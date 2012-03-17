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
using System.Windows.Forms;
using RepetierHost.model;
using RepetierHost.view.utils;

namespace RepetierHost.view
{
    public delegate void OnResponse(string response);
    public partial class SDCard : Form
    {
        static SDCard f = null;
        bool mounted = true;
        bool printing = false;
        bool printPaused = false;
        bool uploading = false;
        bool readFilenames = false;
        bool updateFilenames = false;
        bool startPrint = false;
        int printWait = 0;
        int waitDelete = 0;
        private event OnResponse ana;
        public static void Execute() {
            if (f == null)
            {
                f = new SDCard();
                Main.conn.eventResponse += f.analyzeEvent;
            }
            f.RefreshFilenames();
            f.Show();            
        }
        public static void Disconnected()
        {
            if (f == null) return;
            if (f.Visible)
                f.Hide();
        }
        public SDCard()
        {
            ana += analyzer;
            InitializeComponent();
            RegMemory.RestoreWindowPos("sdcardWindow",this);
        }
        public void RefreshFilenames()
        {
            updateFilenames = false;
            Main.conn.injectManualCommand("M20");
        }
        private void analyzeEvent(string res)
        {
            try
            {
                this.Invoke(ana, res); //new object[] {res});
            }
            catch { }
        }
        private string reduceSpace(string a)
        {
            StringBuilder b = new StringBuilder();
            char lastc = 'X';
            foreach (char c in a)
            {
                if (c != lastc || c != ' ')
                    b.Append(c);
                lastc = c;
            }
            return b.ToString();
        }
        private void analyzer(string res)
        {
            if (readFilenames)
            {
                if(res.StartsWith("End file list")) {
                    readFilenames = false;
                    return;
                }
                string[] parts = reduceSpace(res.ToLower()).Trim().Split(' ');
                files.Items.Add(new ListViewItem(parts));
                return;
            }
            if(res.StartsWith("Begin file list")) {
                readFilenames = true;
                files.Items.Clear();
                return;
            }
            // Printing done?
            if (res.IndexOf("Not SD printing") != -1 || res.IndexOf("Done printing file")!=-1)
            {
                printing = false;
                toolStatus.Text = "Print finished";
                progress.Value = 200;
            }
            else if (res.IndexOf("SD printing byte ") != -1) // Print status update
            {
                string s = res.Substring(res.IndexOf("SD printing byte ") + 17);
                string[] s2 = s.Split('/');
                if (s2.Length == 2)
                {
                    long a, b;
                    long.TryParse(s2[0], out a);
                    long.TryParse(s2[1], out b);
                    progress.Value = (int)(200 * a / b);
                }
            }
            else if (res.IndexOf("SD init fail") != -1 || res.IndexOf("volume.init failed") != -1 ||
                res.IndexOf("openRoot failed")!=-1) // mount failed
            {
                mounted = false;
            }
            else if (res.IndexOf("error writing to file") != -1) // write error
            {
                Main.conn.job.KillJob();
            }
            else if (res.IndexOf("Done saving file") != -1) // save finished
            {
                uploading = false;
                progress.Value = 200;
                toolStatus.Text = "Upload finished.";
                updateFilenames = true;
            }
            else if (res.IndexOf("File selected") != -1)
            {
                toolStatus.Text = "SD printing ...";
                progress.Value = 0;
                printing = true;
                printPaused = false;
                startPrint = true;
            }
            else if (uploading && res.StartsWith("open failed, File"))
            {
                Main.conn.job.KillJob();
                Main.conn.analyzer.uploading = false;
                toolStatus.Text = "Upload failed.";
            }
            else if (res.StartsWith("File deleted"))
            {
                waitDelete = 0;
                toolStatus.Text = "File deleted";
                updateFilenames = true;
            }
            else if (res.StartsWith("Deletion failed"))
            {
                waitDelete = 0;
                toolStatus.Text = "Delete failed";
            }
        }
        private void updateButtons()
        {
            if (!Main.conn.connected)
            {
                toolAddFile.Enabled = false;
                toolDelFile.Enabled = false;
                toolUnmount.Enabled = false;
                toolMount.Enabled = false;
                toolStartPrint.Enabled = false;
                toolStopPrint.Enabled = false;
                return;
            }
            if (uploading || printing || Main.conn.job.hasData())
            {
                toolAddFile.Enabled = false;
                toolDelFile.Enabled = false;
                toolUnmount.Enabled = false;
                toolMount.Enabled = false;
                toolStartPrint.Enabled = false;
                toolStopPrint.Enabled = mounted;
            }
            else
            {
                toolStopPrint.Enabled = printPaused && mounted;
                toolAddFile.Enabled = mounted;
                bool fc = files.SelectedIndices.Count > 0;
                toolStartPrint.Enabled = (fc || printPaused) && mounted;
                toolDelFile.Enabled = fc && mounted;
                toolMount.Enabled = true;
                toolUnmount.Enabled = true;
            }

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void toolAddFile_Click(object sender, EventArgs e)
        {
            Printjob job = Main.conn.job;
            if (job.hasData())
            {
                updateButtons();
                return;
            }
            SDCardUpload f = SDCardUpload.Execute();
            if (f.exit)
            {
                toolStatus.Text = "Uploading file ...";
                progress.Value = 0;
                job.BeginJob();
                job.exclusive = true;
                job.PushData("M28 " + f.textFilename.Text);
                if(f.checkAppendPrepend.Checked)
                    job.PushGCodeShortArray(Main.main.editor.getContentArray(1));
                if (f.radioCurrent.Checked)
                {
                    job.PushGCodeShortArray(Main.main.editor.getContentArray(0));
                }
                else
                {
                    try
                    {
                        job.PushData(System.IO.File.ReadAllText(f.extFilename.Text));
                    }
                    catch (Exception ex)
                    {
                        job.exclusive = false;
                        job.BeginJob();
                        job.EndJob();
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (f.checkAppendPrepend.Checked)
                    job.PushGCodeShortArray(Main.main.editor.getContentArray(2));
                if (f.checkJobFinished.Checked)
                {
                    PrinterConnection con = Main.conn;
                    if (con.afterJobDisableExtruder)
                    {
                        job.PushData("M104 S0");
                    }
                    if (con.afterJobDisablePrintbed)
                        job.PushData("M140 S0");
                    if (con.afterJobGoDispose)
                    {
                        job.PushData("G90");
                        job.PushData("G1 X" + con.disposeX.ToString(GCode.format) + " Y" + con.disposeY.ToString(GCode.format) + " F" + con.travelFeedRate.ToString(GCode.format));
                    }
                }
                job.PushData("M29");
                job.EndJob();
                uploading = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (printing && printWait == 0)
            {
                printWait = 2;
                if(!Main.conn.hasInjectedMCommand(27))
                    Main.conn.injectManualCommand("M27");
            }
            if (printWait <= 0) printWait = 2;
            if (uploading)
            {
                progress.Value = (int)(Main.conn.job.PercentDone * 2);
            }
            printWait--;
            if (updateFilenames) RefreshFilenames();
            if (startPrint)
            {
                startPrint = false;
                Main.conn.injectManualCommand("M24");
            }
            if (waitDelete > 0)
            {
                if (--waitDelete == 0)
                {
                    MessageBox.Show("Your firmware doesn't implement file delete or has an unknown implementation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            updateButtons();
        }

        private void toolStopPrint_Click(object sender, EventArgs e)
        {
            if (printPaused)
            {
                printPaused = false;
                toolStatus.Text = "Print aborted";
                return;
            }
            Main.conn.injectManualCommand("M25");
            printPaused = true;
            printing = false;
            toolStatus.Text = "Print paused";
        }

        private void toolStartPrint_Click(object sender, EventArgs e)
        {
            if (printPaused)
            {
                toolStatus.Text = "SD printing ...";
                printing = true;
                printPaused = false;
                Main.conn.injectManualCommand("M24");
                return;
            }
            foreach(ListViewItem v in files.SelectedItems) {
                string name = v.Text;
                Main.conn.injectManualCommand("M23 "+name);
                break;
            }
        }

        private void files_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateButtons();
        }

        private void toolMount_Click(object sender, EventArgs e)
        {
            Main.conn.injectManualCommand("M21");
            mounted = true;
            RefreshFilenames();
        }

        private void toolUnmount_Click(object sender, EventArgs e)
        {
            Main.conn.injectManualCommand("M22");
            mounted = false;
            MessageBox.Show("You can remove the sd card.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (files.SelectedItems.Count == 0) return;
            string fname = files.SelectedItems[0].Text;
            if (MessageBox.Show("Really delete "+fname,"Security question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                waitDelete = 6;
                Main.conn.injectManualCommand("M30 " + fname);
            }
        }

        private void SDCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegMemory.StoreWindowPos("sdcardWindow", this, false, false);
        }
    }
}
