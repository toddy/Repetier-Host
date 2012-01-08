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
        private FormTempMonitor tempMonitor = null;
        public Skeinforge skeinforge = null;
        public EEPROMRepetier eepromSettings = null;
        public LogView logView = null;
        public PrintPanel printPanel = null;
        public RegistryKey repetierKey;
        public ThreeDControl jobPreview = null;
        public ThreeDControl printPreview = null;
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
        public class JobUpdater
        {
            GCodeVisual visual = null;
            // This method will be called when the thread is started.
            public void DoWork()
            {
                RepetierEditor ed = Main.main.editor;
                string text = ed.getContent(1) + ed.getContent(0) + ed.getContent(2);
                visual = new GCodeVisual();
                visual.ParseText(text, true);
                visual.Reduce();
                //visual.stats();
                Main.main.newVisual = visual;
                Main.main.jobPreviewThreadFinished = true;
                Main.main.previewThread = null;
            }
        }
		//From Managed.Windows.Forms/XplatUI
	static bool IsRunningOnMac ()
	{
		IntPtr buf = IntPtr.Zero;
		try {
			buf = System.Runtime.InteropServices.Marshal.AllocHGlobal (8192);
			// This is a hacktastic way of getting sysname from uname ()
			if (uname (buf) == 0) {
				string os = System.Runtime.InteropServices.Marshal.PtrToStringAnsi (buf);
				if (os == "Darwin")
					return true;
			}
		} catch {
		} finally {
			if (buf != IntPtr.Zero)
				System.Runtime.InteropServices.Marshal.FreeHGlobal (buf);
		}
		return false;
	}
 
	[System.Runtime.InteropServices.DllImport ("libc")]
	static extern int uname (IntPtr buf);
        public Main()
        {
            executeHostCall = new executeHostCommandDelegate(this.executeHostCommand);
            repetierKey = Registry.CurrentUser.CreateSubKey("Software\\Repetier");
			repetierKey.SetValue("installPath",Application.StartupPath);
			if(Path.DirectorySeparatorChar != '\\' && IsRunningOnMac())
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
            threeDSettings = new ThreeDSettings();
            InitializeComponent();
            RegMemory.RestoreWindowPos("mainWindow", this);
            if (WindowState == FormWindowState.Maximized)
                Application.DoEvents();
            splitLog.SplitterDistance = RegMemory.GetInt("logSplitterDistance", splitLog.SplitterDistance);
            if (IsMono)
            {
                if (!IsMac)
                {
                    splitContainerPrinterGraphic.SplitterDistance += 52;
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
 
					MinimumSize = new Size(500,640);
                    tab.MinimumSize = new Size(500,500);
                    splitLog.Panel1MinSize = 520;
					splitLog.Panel2MinSize = 100;
                    splitLog.IsSplitterFixed = true;
                    splitJob.IsSplitterFixed = true;
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
            splitContainerPrinterGraphic.Panel1.Controls.Add(printPanel);
            printerSettings.formToCon();
            logView = new LogView();
            logView.Dock = DockStyle.Fill;
            splitLog.Panel2.Controls.Add(logView);
            skeinforge = new Skeinforge();
            PrinterChanged(printerSettings.currentPrinterKey,true);
            printerSettings.eventPrinterChanged += PrinterChanged;
            // GCode print preview
            printPreview = new ThreeDControl();
            printPreview.Dock = DockStyle.Fill;
            splitContainerPrinterGraphic.Panel2.Controls.Add(printPreview);
            printPreview.SetEditor(false);
            printPreview.AutoUpdateable = true;
            printVisual = new GCodeVisual(conn.analyzer);
            printVisual.liveView = true;
            printPreview.models.AddLast(printVisual);
            basicTitle = Text;
            jobPreview = new ThreeDControl();
            jobPreview.Dock = DockStyle.Fill;
            splitJob.Panel2.Controls.Add(jobPreview);
            jobPreview.SetEditor(false);
            jobPreview.models.AddLast(jobVisual);
            editor.contentChangedEvent += JobPreview;
            editor.commands = new Commands();
            editor.commands.Read("default", "en");
            UpdateHistory();
            UpdateConnections();
            Main.slic3r = new Slic3r();
            slicer = new Slicer();
            if(IsMac) {
                 tabGCode.Controls.Remove(splitJob);
                 tabPrint.Controls.Remove(splitContainerPrinterGraphic);
            }
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
            foreach(ToolStripItem c in fileToolStripMenuItem.DropDownItems) {
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
            foreach(RegMemory.HistoryFile f in fileHistory.list) {
                ToolStripMenuItem item = new ToolStripMenuItem(); // You would obviously calculate this value at runtime
                item = new ToolStripMenuItem();
                item.Name = "file" +pos;
                item.Tag = f;
                item.Text = f.ToString();
                item.Click += new EventHandler(HistoryHandler);
                fileToolStripMenuItem.DropDownItems.Insert(pos++,item);
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
        private void OnPrinterConnectionChange(string msg) {
            toolConnection.Text = msg;
            if (conn.connected)
            {
                toolConnect.Image = imageList.Images[0];
                toolConnect.ToolTipText = "Disconnect printer";
                foreach (ToolStripItem it in toolConnect.DropDownItems)
                    it.Enabled = false;
            }
            else
            {
                toolConnect.Image = imageList.Images[1];
                toolConnect.ToolTipText = "Connect printer";
                foreach (ToolStripItem it in toolConnect.DropDownItems)
                    it.Enabled = true;
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
            if (eepromSettings == null)
                eepromSettings = new EEPROMRepetier();
            eepromSettings.Show2();
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
            if (file.EndsWith(".stl"))
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
                editor.setContent(0,System.IO.File.ReadAllText(file));
                tab.SelectTab(tabGCode);
                editor.selectContent(0);
                fileHistory.Save(file);
                UpdateHistory();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadGCodeText(string text)
        {
            try
            {
                editor.setContent(0,text);
                tab.SelectTab(tabGCode);
                editor.selectContent(0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolPrintJob_Click(object sender, EventArgs e)
        {
            Printjob job = conn.job;
            if (job.dataComplete)
            {
                conn.pause("Press OK to continue.\n\nYou can add pauses in your code with\n@pause Some text like this");
            }
            else
            {
                toolRunJob.Image = imageList.Images[3];
                job.BeginJob();
                job.PushData(editor.getContent(1));
                job.PushData(editor.getContent(0));
                job.PushData(editor.getContent(2));
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

        private void temperatureMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tempMonitor == null)
                tempMonitor = new FormTempMonitor();
            tempMonitor.Show();
            tempMonitor.BringToFront();
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
            RegMemory.StoreWindowPos("mainWindow",this, true, true);
            RegMemory.SetInt("logSplitterDistance", splitLog.SplitterDistance);
            RegMemory.SetBool("logShow", toolShowLog.Checked);

            if(previewThread!=null)
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

        public MethodInvoker UpdateJobButtons = delegate
        {
            if (conn.job.mode != 1)
            {
                Main.main.toolKillJob.Enabled = false;
                Main.main.toolRunJob.Enabled = conn.connected;
                Main.main.toolRunJob.ToolTipText = "Run job";
                Main.main.toolRunJob.Image = Main.main.imageList.Images[2];
            }
            else
            {
                Main.main.toolRunJob.Enabled = true;
                Main.main.toolKillJob.Enabled = true;
                Main.main.toolRunJob.Image = Main.main.imageList.Images[3];
                Main.main.toolRunJob.ToolTipText = "Pause job";
                Main.main.printVisual.Clear();
            }
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
        bool recalcJobPreview = false;
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
            if (tab == null) return;
            switch (tab.SelectedIndex)
            {
                case 2:
                    printPreview.UpdateChanges();
                    break;
                case 1:
                    if (jobPreview != null)
                        jobPreview.UpdateChanges();
                    break;
                case 0:
                    stlComposer1.Update3D();
                    break;
            }
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
                jobPreview.UpdateChanges();
                newVisual = null;
                editor.toolUpdating.Text = "";
            }
            if (recalcJobPreview && jobPreviewThreadFinished)
            {
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
                toolShowLog.ToolTipText = "Hide logs";
                splitLog.Panel2Collapsed = false;
            }
            else
            {
                toolShowLog.ToolTipText = "Show logs";
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

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("index changed " + Environment.OSVersion.Platform + " Mac=" + PlatformID.MacOSX);
            //if (Environment.OSVersion.Platform == PlatformID.MacOSX )
            if(IsMac)
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
                if (tab.SelectedTab != tabGCode)
                {
                    if (tabGCode.Controls.Contains(splitJob))
                    {
                        tabGCode.Controls.Remove(splitJob);
                    }
                }
                if (tab.SelectedTab != tabPrint)
                {
                    if (tabPrint.Controls.Contains(splitContainerPrinterGraphic))
                    {
                        tabPrint.Controls.Remove(splitContainerPrinterGraphic);
                    }
                }
                if (tab.SelectedTab == tabModel)
                {
                    if (!tabModel.Controls.Contains(stlComposer1))
                        tabModel.Controls.Add(stlComposer1);
                }
                if (tab.SelectedTab == tabGCode)
                {
                    if (!tabGCode.Controls.Contains(splitJob))
                        tabGCode.Controls.Add(splitJob);
                    splitJob.Dock = DockStyle.Fill;
                }
                if (tab.SelectedTab == tabPrint)
                {
                    if (!tabPrint.Controls.Contains(splitContainerPrinterGraphic))
                        tabPrint.Controls.Add(splitContainerPrinterGraphic);
                }
                
                stlComposer1.cont.MakeVisible(tab.SelectedIndex == 0);
                jobPreview.MakeVisible(tab.SelectedIndex == 1);
                printPreview.MakeVisible(tab.SelectedIndex == 2);
                //Invalidate();
                refreshCounter = 3;
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (IsMac)
            {
                if (Height < 740) Height = 740;
                refreshCounter = 4;
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

    }
}
