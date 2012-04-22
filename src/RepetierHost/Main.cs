/*
   Copyright 2011 repetier repetierdev@googlemail.com

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using RepetierHost.model;
using RepetierHost.view;
using RepetierHost.view.utils;
using Microsoft.Win32;
using System.Threading;
using System.Diagnostics;

namespace RepetierHost
{
    public delegate void executeHostCommandDelegate(GCode code);

    public partial class Main : Form
    {
        public static PrinterConnection conn;
        public static Main main;
        public static FormPrinterSettings printerSettings;
        public static ThreeDSettings threeDSettings;
        public static GlobalSettings globalSettings;
        public Skeinforge skeinforge = null;
        public EEPROMRepetier eepromSettings = null;
        public EEPROMMarlin eepromSettingsm = null;
        public LogView logView = null;
        public PrintPanel printPanel = null;
        public RegistryKey repetierKey;
        public ThreeDControl threedview = null;
        public ThreeDView jobPreview = null;
        public ThreeDView printPreview = null;
        public GCodeVisual jobVisual = new GCodeVisual();
        public GCodeVisual printVisual = null;
        public static GCodeGenerator generator = null;
        public string basicTitle = "";
        public volatile GCodeVisual newVisual = null;
        public volatile bool jobPreviewThreadFinished = true;
        public volatile Thread previewThread = null;
        public RegMemory.FilesHistory fileHistory = new RegMemory.FilesHistory("fileHistory", 8);
        public static bool IsMono = Type.GetType("Mono.Runtime") != null;
        public static Slicer slicer = null;
        public static Slic3r slic3r = null;
        public static bool IsMac = false;
        public int refreshCounter = 0;
        public executeHostCommandDelegate executeHostCall;
        bool recalcJobPreview = false;
        List<GCodeShort> previewArray;
        public TemperatureHistory history = null;
        public TemperatureView tempView = null;
        public class JobUpdater
        {
            GCodeVisual visual = null;
            // This method will be called when the thread is started.
            public void DoWork()
            {
                RepetierEditor ed = Main.main.editor;
                
                Stopwatch sw = new Stopwatch();
                sw.Start();
                visual = new GCodeVisual();
                switch (ed.ShowMode)
                {
                    case 0:
                        visual.minLayer = 0;
                        visual.maxLayer = 999999;
                        break;
                    case 1:
                        visual.minLayer = visual.maxLayer = ed.ShowMinLayer;
                        break;
                    case 2:
                        visual.minLayer = ed.ShowMinLayer;
                        visual.maxLayer = ed.ShowMaxLayer;
                        break;
                }
                visual.parseGCodeShortArray(Main.main.previewArray, true);
                Main.main.previewArray = null;
                visual.Reduce();
                //visual.stats();
                Main.main.newVisual = visual;
                Main.main.jobPreviewThreadFinished = true;
                Main.main.previewThread = null;
                sw.Stop();
                //Main.conn.log("Update time:" + sw.ElapsedMilliseconds, false, 3);
            }
        }
        //From Managed.Windows.Forms/XplatUI
        static bool IsRunningOnMac()
        {
            IntPtr buf = IntPtr.Zero;
            try
            {
                buf = System.Runtime.InteropServices.Marshal.AllocHGlobal(8192);
                // This is a hacktastic way of getting sysname from uname ()
                if (uname(buf) == 0)
                {
                    string os = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(buf);
                    if (os == "Darwin")
                        return true;
                }
            }
            catch
            {
            }
            finally
            {
                if (buf != IntPtr.Zero)
                    System.Runtime.InteropServices.Marshal.FreeHGlobal(buf);
            }
            return false;
        }

        [System.Runtime.InteropServices.DllImport("libc")]
        static extern int uname(IntPtr buf);
        public Main()
        {
            executeHostCall = new executeHostCommandDelegate(this.executeHostCommand);
            repetierKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Repetier");
            repetierKey.SetValue("installPath", Application.StartupPath);
            if (Path.DirectorySeparatorChar != '\\' && IsRunningOnMac())
                IsMac = true;
            /*String[] parms = Environment.GetCommandLineArgs();
            string lastcom = "";
            foreach (string s in parms)
            {
                if (lastcom == "-home")
                {
                    repetierKey.SetValue("installPath",s);
                    lastcom = "";
                    continue;
                }
                if (s == "-macosx") IsMac = true;
                lastcom = s;
            }*/
            main = this;
            generator = new GCodeGenerator();
            globalSettings = new GlobalSettings();
            conn = new PrinterConnection();
            printerSettings = new FormPrinterSettings();
            conn.analyzer.start();
            threeDSettings = new ThreeDSettings();
            InitializeComponent();
            updateShowFilament();
            RegMemory.RestoreWindowPos("mainWindow", this);
            if (WindowState == FormWindowState.Maximized)
                Application.DoEvents();
            splitLog.SplitterDistance = RegMemory.GetInt("logSplitterDistance", splitLog.SplitterDistance);
            splitInfoEdit.SplitterDistance = RegMemory.GetInt("infoEditSplitterDistance", Width-470);
            if (IsMono)
            {
                if (!IsMac)
                {
                    foreach (ToolStripItem m in menu.Items)
                    {
                        m.Text = m.Text.Replace("&", null);
                    }
                }
                if (IsMac)
                {
                    /*Application.Events.Quit += delegate (object sender, ApplicationEventArgs e) {
                        Application.Quit ();
                        e.Handled = true;
                    };
 
                    ApplicationEvents.Reopen += delegate (object sender, ApplicationEventArgs e) {
                        WindowState = FormWindowState.Normal;
                        e.Handled = true;
                    };*/

                    MinimumSize = new Size(500, 640);
                    tab.MinimumSize = new Size(500, 500);
                    splitLog.Panel1MinSize = 520;
                    splitLog.Panel2MinSize = 100;
                    splitLog.IsSplitterFixed = true;
                    //splitContainerPrinterGraphic.SplitterDistance -= 52;
                    splitLog.SplitterDistance = splitLog.Height - 100;
                }
            }
            toolShowLog.Checked = RegMemory.GetBool("logShow", true);
            conn.eventConnectionChange += OnPrinterConnectionChange;
            conn.eventPrinterAction += OnPrinterAction;
            conn.eventJobProgress += OnJobProgress;
            printPanel = new PrintPanel();
            printPanel.Dock = DockStyle.Fill;
            tabPrint.Controls.Add(printPanel);
            printerSettings.formToCon();
            logView = new LogView();
            logView.Dock = DockStyle.Fill;
            splitLog.Panel2.Controls.Add(logView);
            skeinforge = new Skeinforge();
            PrinterChanged(printerSettings.currentPrinterKey, true);
            printerSettings.eventPrinterChanged += PrinterChanged;
            // GCode print preview
            threedview = new ThreeDControl();
            threedview.Dock = DockStyle.Fill;
            tabPage3DView.Controls.Add(threedview);

            printPreview = new ThreeDView();
           // printPreview.Dock = DockStyle.Fill;
          //  splitContainerPrinterGraphic.Panel2.Controls.Add(printPreview);
            printPreview.SetEditor(false);
            printPreview.autoupdateable = true;
            printVisual = new GCodeVisual(conn.analyzer);
            printVisual.liveView = true;
            printPreview.models.AddLast(printVisual);
            basicTitle = Text;
            jobPreview = new ThreeDView();
         //   jobPreview.Dock = DockStyle.Fill;
         //   splitJob.Panel2.Controls.Add(jobPreview);
            jobPreview.SetEditor(false);
            jobPreview.models.AddLast(jobVisual);
            editor.contentChangedEvent += JobPreview;
            editor.commands = new Commands();
            editor.commands.Read("default", "en");
            UpdateHistory();
            UpdateConnections();
            Main.slic3r = new Slic3r();
            slicer = new Slicer();
            toolShowLog_CheckedChanged(null, null);
            updateShowFilament();
            assign3DView();
            history = new TemperatureHistory();
            tempView = new TemperatureView();
            tempView.Dock = DockStyle.Fill;
            tabPageTemp.Controls.Add(tempView);
        }

        public void UpdateConnections()
        {
            toolConnect.DropDownItems.Clear();
            foreach (string s in printerSettings.printerKey.GetSubKeyNames())
            {
                toolConnect.DropDownItems.Add(s, null, ConnectHandler);
            }
            foreach (ToolStripItem it in toolConnect.DropDownItems)
                it.Enabled = !conn.connected;
        }
        public void UpdateHistory()
        {
            bool delFlag = false;
            LinkedList<ToolStripItem> delArray = new LinkedList<ToolStripItem>();
            int pos = 0;
            foreach (ToolStripItem c in fileToolStripMenuItem.DropDownItems)
            {
                if (c == toolStripEndHistory) break;
                if (!delFlag) pos++;
                if (c == toolStripStartHistory)
                {
                    delFlag = true;
                    continue;
                }
                if (delFlag)
                    delArray.AddLast(c);
            }
            foreach (ToolStripItem i in delArray)
                fileToolStripMenuItem.DropDownItems.Remove(i);
            toolLoad.DropDownItems.Clear();
            foreach (RegMemory.HistoryFile f in fileHistory.list)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(); // You would obviously calculate this value at runtime
                item = new ToolStripMenuItem();
                item.Name = "file" + pos;
                item.Tag = f;
                item.Text = f.ToString();
                item.Click += new EventHandler(HistoryHandler);
                fileToolStripMenuItem.DropDownItems.Insert(pos++, item);
                item = new ToolStripMenuItem();
                item.Name = "filet" + pos;
                item.Tag = f;
                item.Text = f.ToString();
                item.Click += new EventHandler(HistoryHandler);
                toolLoad.DropDownItems.Add(item);
            }
        }

        private void HistoryHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            RegMemory.HistoryFile f = (RegMemory.HistoryFile)clickedItem.Tag;
            LoadGCodeOrSTL(f.file);
            // Take some action based on the data in clickedItem
        }
        private void ConnectHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            printerSettings.load(clickedItem.Text);
            printerSettings.formToCon();
            conn.open();
        }
        public void PrinterChanged(RegistryKey pkey, bool printerChanged)
        {
            if (printerChanged)
            {
                editor.UpdatePrependAppend();
            }
        }
        public string Title
        {
            set { Text = basicTitle + " - " + value; }
            get { return Text; }
        }
        private void FormToFront(Form f)
        {
            // Make this form the active form and make it TopMost
            //f.ShowInTaskbar = false;
            /*f.TopMost = true;
            f.Focus();*/
            f.BringToFront();
            // f.TopMost = false;
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnPrinterConnectionChange(string msg)
        {
            toolConnection.Text = msg;
            if (conn.connected)
            {
                toolConnect.Image = imageList.Images[0];
                toolConnect.ToolTipText = "Disconnect printer";
                toolConnect.Text = "Disconnect";
                foreach (ToolStripItem it in toolConnect.DropDownItems)
                    it.Enabled = false;
                //eeprom.Enabled = true;
                toolStripEmergencyButton.Enabled = true;
            }
            else
            {
                toolConnect.Image = imageList.Images[1];
                toolConnect.ToolTipText = "Connect printer";
                toolConnect.Text = "Connect";
                eeprom.Enabled = false;
                continuousMonitoringMenuItem.Enabled = false;
                if (eepromSettings != null && eepromSettings.Visible)
                {
                    eepromSettings.Close();
                    eepromSettings.Dispose();
                    eepromSettings = null;
                }
                if (eepromSettingsm != null && eepromSettingsm.Visible)
                {
                    eepromSettingsm.Close();
                    eepromSettingsm.Dispose();
                    eepromSettingsm = null;
                }
                foreach (ToolStripItem it in toolConnect.DropDownItems)
                    it.Enabled = true;
                toolStripEmergencyButton.Enabled = false;
                SDCard.Disconnected();
            }
        }
        private void OnPrinterAction(string msg)
        {
            toolAction.Text = msg;
        }
        private void OnJobProgress(float per)
        {
            toolProgress.Value = (int)per;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn.isRepetier)
            {
                if (eepromSettings != null)
                {
                    if (eepromSettings.Visible)
                    {
                        eepromSettings.BringToFront();
                        return;
                    }
                    else
                    {
                        eepromSettings.Dispose();
                        eepromSettings = null;
                    }
                }
                if (eepromSettings == null)
                    eepromSettings = new EEPROMRepetier();
                eepromSettings.Show2();
            }
            if (conn.isMarlin)
            {
                if (eepromSettingsm != null)
                {
                    if (eepromSettingsm.Visible)
                    {
                        eepromSettingsm.BringToFront();
                        return;
                    }
                    else
                    {
                        eepromSettingsm.Dispose();
                        eepromSettingsm = null;
                    }
                }
                if (eepromSettingsm == null)
                    eepromSettingsm = new EEPROMMarlin();
                eepromSettingsm.Show2();
            }
        }



        private void toolGCodeLoad_Click(object sender, EventArgs e)
        {
            if (openGCode.ShowDialog() == DialogResult.OK)
            {
                LoadGCodeOrSTL(openGCode.FileName);
            }
        }
        public void LoadGCodeOrSTL(string file)
        {
            if (!File.Exists(file)) return;
            FileInfo f = new FileInfo(file);
            Title = f.Name;
            fileHistory.Save(file);
            UpdateHistory();
            if (file.ToLower().EndsWith(".stl"))
            {
                if (MessageBox.Show("Do you want to slice the STL-File? No adds it to the object grid.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    slicer.RunSlice(file); // Slice it and load
                }
                else
                {
                    stlComposer1.openAndAddObject(file);
                }
            }
            else
            {
                editor.setContent(0, System.IO.File.ReadAllText(file));
                tab.SelectTab(tabGCode);
                editor.selectContent(0);
            }
        }
        public void LoadGCode(string file)
        {
            try
            {
                editor.setContent(0, System.IO.File.ReadAllText(file));
                tab.SelectTab(tabGCode);
                editor.selectContent(0);
                fileHistory.Save(file);
                UpdateHistory();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadGCodeText(string text)
        {
            try
            {
                editor.setContent(0, text);
                tab.SelectTab(tabGCode);
                editor.selectContent(0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public MethodInvoker StartJob = delegate
        {
            Main.main.toolPrintJob_Click(null, null);
        };
        private void toolPrintJob_Click(object sender, EventArgs e)
        {
            Printjob job = conn.job;
            if (job.dataComplete)
            {
                conn.pause("Press OK to continue.\n\nYou can add pauses in your code with\n@pause Some text like this");
            }
            else
            {
                tab.SelectedTab = tabPrint;
                toolRunJob.Image = imageList.Images[3];
                job.BeginJob();
                job.PushGCodeShortArray(editor.getContentArray(1));
                job.PushGCodeShortArray(editor.getContentArray(0));
                job.PushGCodeShortArray(editor.getContentArray(2));
                job.EndJob();
            }
        }



        private void toolKillJob_Click(object sender, EventArgs e)
        {
            conn.job.KillJob();
        }

        private void printerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerSettings.Show(this);
            FormToFront(printerSettings);
        }

        private void skeinforgeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skeinforge.Show();
            skeinforge.BringToFront();
        }

        private void skeinforgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skeinforge.RunSkeinforge();
        }

        private void threeDSettingsMenu_Click(object sender, EventArgs e)
        {
            threeDSettings.Show();
            threeDSettings.BringToFront();
        }
        private PrinterInfo printerInfo = null;
        private void printerInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printerInfo == null)
                printerInfo = new PrinterInfo();
            printerInfo.Show();
            printerInfo.BringToFront();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.close();
            RegMemory.StoreWindowPos("mainWindow", this, true, true);
            RegMemory.SetInt("logSplitterDistance", splitLog.SplitterDistance);
            RegMemory.SetInt("infoEditSplitterDistance", splitInfoEdit.SplitterDistance);

            RegMemory.SetBool("logShow", toolShowLog.Checked);

            if (previewThread != null)
                previewThread.Join();
            conn.Destroy();
        }

        private void repetierSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalSettings.Show(this);
            globalSettings.BringToFront();
        }
        public About about = null;
        private void aboutRepetierHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (about == null) about = new About();
            about.Show(this);
            about.BringToFront();
        }

        private void jobStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobStatus.ShowStatus();
        }
        public void openLink(string link)
        {
            try
            {
                System.Diagnostics.Process.Start(link);
            }
            catch
            (
            System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        private void repetierHostHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("https://github.com/repetier/Repetier-Host");
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("https://github.com/repetier/Repetier-Host/wiki");
        }
        public MethodInvoker FirmwareDetected = delegate
        {
            if (conn.isRepetier)
            {
                Main.main.continuousMonitoringMenuItem.Enabled = true;
            }
        };
        public MethodInvoker UpdateJobButtons = delegate
        {
            if (conn.job.mode != 1)
            {
                Main.main.toolKillJob.Enabled = false;
                Main.main.toolRunJob.Enabled = conn.connected;
                Main.main.toolRunJob.ToolTipText = "Run job";
                Main.main.toolRunJob.Text = "Run job";
                Main.main.toolRunJob.Image = Main.main.imageList.Images[2];
            }
            else
            {                
                Main.main.toolRunJob.Enabled = true;
                Main.main.toolKillJob.Enabled = true;
                Main.main.toolRunJob.Image = Main.main.imageList.Images[3];
                Main.main.toolRunJob.ToolTipText = "Pause job";
                Main.main.toolRunJob.Text = "Pause job";
                Main.main.printVisual.Clear();
            }
        };
        public MethodInvoker UpdateEEPROM = delegate
        {
            if (conn.isMarlin || conn.isRepetier) // Activate special menus and function
            {
                main.eeprom.Enabled = true;
            }
            else main.eeprom.Enabled = false;

        };
        /*  private void toolStripSaveGCode_Click(object sender, EventArgs e)
          {
              if (saveJobDialog.ShowDialog() == DialogResult.OK)
              {
                  System.IO.File.WriteAllText(saveJobDialog.FileName, textGCode.Text, Encoding.Default);
              }
          }

          private void toolStripSavePrepend_Click(object sender, EventArgs e)
          {
              printerSettings.currentPrinterKey.SetValue("gcodePrepend", textGCodePrepend.Text);
          }

          private void toolStripSaveAppend_Click(object sender, EventArgs e)
          {
              printerSettings.currentPrinterKey.SetValue("gcodeAppend", textGCodeAppend.Text);
          }*/
        private void JobPreview()
        {
            if (editor.autopreview == false) return;
            /*       if (splitJob.Panel2Collapsed)
                   {
                       splitJob.Panel2Collapsed = false;
                       splitJob.SplitterDistance = 300;
                       jobPreview = new ThreeDControl();
                       jobPreview.Dock = DockStyle.Fill;
                       splitJob.Panel2.Controls.Add(jobPreview);
                       jobPreview.SetEditor(false);
                       jobPreview.models.AddLast(jobVisual);
                       //jobPreview.SetObjectSelected(false);
                   }*/
            /* Read the initial time. */
            recalcJobPreview = true;
            /*DateTime startTime = DateTime.Now;
            jobVisual.ParseText(editor.getContent(1), true);
            jobVisual.ParseText(editor.getContent(0), false);
            jobVisual.ParseText(editor.getContent(2), false);
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;
            Main.conn.log(duration.ToString(), false, 3);
            jobPreview.UpdateChanges();*/
        }
        public void Update3D()
        {
            if(threedview!=null)
                threedview.UpdateChanges();
        }

        private void testCaseGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestGenerator.Execute();
        }

        private void internalSlicingParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlicingParameter.Execute();
        }

        private void toolStripSDCard_Click(object sender, EventArgs e)
        {
            SDCard.Execute();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (newVisual != null)
            {
                jobPreview.models.RemoveLast();
                jobVisual.Clear();
                jobVisual = newVisual;
                jobPreview.models.AddLast(jobVisual);
                threedview.UpdateChanges();
                newVisual = null;
                editor.toolUpdating.Text = "";
                editor.UpdateLayerInfo();
                editor.MaxLayer = editor.getContentArray(0).Last<GCodeShort>().layer;
            }
            if (recalcJobPreview && jobPreviewThreadFinished)
            {
                previewArray = new List<GCodeShort>();
                previewArray.AddRange(((RepetierEditor.Content)editor.toolFile.Items[1]).textArray);
                previewArray.AddRange(((RepetierEditor.Content)editor.toolFile.Items[0]).textArray);
                previewArray.AddRange(((RepetierEditor.Content)editor.toolFile.Items[2]).textArray);
                recalcJobPreview = false;
                jobPreviewThreadFinished = false;
                JobUpdater workerObject = new JobUpdater();
                editor.toolUpdating.Text = "Updating ...";
                previewThread = new Thread(workerObject.DoWork);
                previewThread.Start();

            }
            if (refreshCounter > 0)
            {
                if (--refreshCounter == 0)
                {
                    Invalidate();
                }
            }
        }

        private void toolConnect_Click(object sender, EventArgs e)
        {
            if (conn.connected)
            {
                conn.close();
            }
            else
            {
                conn.open();
            }
        }

        private void toolShowLog_Click(object sender, EventArgs e)
        {
            toolShowLog.Checked = !toolShowLog.Checked;
        }

        private void toolShowLog_CheckedChanged(object sender, EventArgs e)
        {
            if (toolShowLog.Checked)
            {
                toolShowLog.ToolTipText = "Hide log";
                toolShowLog.Text = "Hide Log";
                splitLog.Panel2Collapsed = false;
            }
            else
            {
                toolShowLog.ToolTipText = "Show logs";
                toolShowLog.Text = "Show Log";
                splitLog.Panel2Collapsed = true;
            }
        }

        private void repRapWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("http://www.reprap.org");
        }

        private void repRapForumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("http://forum.reprap.org");
        }

        private void slic3rHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("http://www.slic3r.org");

        }

        private void skeinforgeHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("http://fabmetheus.crsndoo.com/");

        }

        private void thingiverseNewestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("http://www.thingiverse.com/newest");

        }

        private void thingiversePopularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("http://www.thingiverse.com/popular");

        }

        private void slic3rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slicer.ActiveSlicer = Slicer.SlicerID.Slic3r;
        }

        private void skeinforgeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            slicer.ActiveSlicer = Slicer.SlicerID.Skeinforge;
        }

        private void slic3rConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slic3r.Show();
            slic3r.BringToFront();
        }
        public void assign3DView()
        {
            if (tab == null) return;
            switch (tab.SelectedIndex)
            {
                case 0:
                    threedview.SetView(stlComposer1.cont);
                    break;
                case 1:
                    threedview.SetView(jobPreview);
                    break;
                case 2:
                    threedview.SetView(printPreview);
                    break;
            }
        }
        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("index changed " + Environment.OSVersion.Platform + " Mac=" + PlatformID.MacOSX);
            //if (Environment.OSVersion.Platform == PlatformID.MacOSX )
            if (IsMac)
            {
                // In MacOSX the OpenGL windows shine through the
                // tabs, so we need to disable all GL windows except the active.
                if (tab.SelectedTab != tabModel)
                {
                    if (tabModel.Controls.Contains(stlComposer1))
                    {
                        tabModel.Controls.Remove(stlComposer1);
                    }
                }
                if (tab.SelectedTab == tabModel)
                {
                    if (!tabModel.Controls.Contains(stlComposer1))
                        tabModel.Controls.Add(stlComposer1);
                }
                refreshCounter = 6;
            }
            assign3DView();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (IsMac)
            {
                if (Height < 740) Height = 740;
                refreshCounter = 8;
                Application.DoEvents();
                /*             Invalidate();
                             Application.DoEvents();
                             tab.SelectedTab.Invalidate();*/
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            if (!globalSettings.WorkdirOK())
                globalSettings.Show();

        }
        public void executeHostCommand(GCode code)
        {
            string com = code.getHostCommand();
            string param = code.getHostParameter();
            if (com.Equals("@info"))
            {
                conn.log(param, false, 3);
            }
            else if (com.Equals("@pause"))
            {
                conn.pause(param);
            }
        }
        public void updateShowFilament()
        {
            if (threeDSettings.checkDisableFilamentVisualization.Checked)
            {
                toolShowFilament.Image = imageList.Images[5];
                toolShowFilament.ToolTipText = "Filament visualization disabled";
                toolShowFilament.Text = "Show Filament";
            }
            else
            {
                toolShowFilament.Image = imageList.Images[4];
                toolShowFilament.ToolTipText = "Filament visualization enabled";
                toolShowFilament.Text = "Hide Filament";
            }
        }
        private void toolShowFilament_Click(object sender, EventArgs e)
        {
            threeDSettings.checkDisableFilamentVisualization.Checked = !threeDSettings.checkDisableFilamentVisualization.Checked;
            // updateShowFilament();
        }

        private void toolStripEmergencyButton_Click(object sender, EventArgs e)
        {
            if (!conn.connected) return;
            conn.injectManualCommandFirst("M112");
            conn.job.KillJob();
            conn.log("Send emergency stop to printer. You may need to reset the printer for a restart!", false, 3);
            while (conn.hasInjectedMCommand(112))
            {
                Application.DoEvents();
            }
            conn.close();
        }

        private void killSlicingProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skeinforge.KillSlice();
            slic3r.KillSlice();
            SlicingInfo.Stop();
        }

        private void externalSlic3rSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Slic3rSetup.Execute();
        }

        private void externalSlic3rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slicer.ActiveSlicer = Slicer.SlicerID.Slic3rExternal;
        }

        private void externalSlic3rConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slic3r.RunExternalConfig();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            stlComposer1.recheckChangedFiles();
        }
        public void selectTimePeriod(object sender, EventArgs e)
        {
            history.CurrentPos = (int)((ToolStripMenuItem)sender).Tag;
        }
        public void selectAverage(object sender, EventArgs e)
        {
            history.AvgPeriod = int.Parse(((ToolStripMenuItem)sender).Tag.ToString());
        }
        public void selectZoom(object sender, EventArgs e)
        {
            history.CurrentZoomLevel = int.Parse(((ToolStripMenuItem)sender).Tag.ToString());
        }

        private void showExtruderTemperaturesMenuItem_Click(object sender, EventArgs e)
        {
            history.ShowExtruder = !history.ShowExtruder;
        }

        private void showHeatedBedTemperaturesMenuItem_Click(object sender, EventArgs e)
        {
            history.ShowBed = !history.ShowBed;
        }

        private void showTargetTemperaturesMenuItem_Click(object sender, EventArgs e)
        {
            history.ShowTarget = !history.ShowTarget;
        }

        private void showAverageTemperaturesMenuItem_Click(object sender, EventArgs e)
        {
            history.ShowAverage = !history.ShowAverage;
        }

        private void showHeaterPowerMenuItem_Click(object sender, EventArgs e)
        {
            history.ShowOutput = !history.ShowOutput;
        }

        private void autoscrollTemperatureViewMenuItem_Click(object sender, EventArgs e)
        {
            history.Autoscroll = !history.Autoscroll;
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.injectManualCommand("M203 S255");
        }

        private void extruder1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.injectManualCommand("M203 S0");
        }

        private void extruder2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.injectManualCommand("M203 S1");
        }

        private void heatedBedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.injectManualCommand("M203 S100");
        }
    }
}
