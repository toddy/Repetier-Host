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
using System.Diagnostics;
using Microsoft.Win32;
using RepetierHost.view.utils;

namespace RepetierHost.view
{
    public partial class Skeinforge : Form
    {
        public RegistryKey repetierKey;
        Process procSkein = null;
        Process procConvert = null;
        string slicefile = null;
        public Skeinforge()
        {
            InitializeComponent();
            RegMemory.RestoreWindowPos("skeinforgeWindow", this);
            repetierKey = Registry.CurrentUser.CreateSubKey("Software\\Repetier");
            regToForm();
        }
        public string wrapQuotes(string text)
        {
            if (text.StartsWith("\"") && text.EndsWith("\"")) return text;
            return "\"" + text.Replace("\"","\\\"") + "\"";
        }
        public void RunSkeinforge()
        {
            if (procSkein != null)
            {
                return;
            }
            procSkein = new Process();
            try
            {
                procSkein.EnableRaisingEvents = true;
                procSkein.Exited += new EventHandler(SkeinExited);
                procSkein.StartInfo.FileName = Main.IsMono ? textPython.Text : wrapQuotes(textPython.Text);
                procSkein.StartInfo.Arguments = wrapQuotes(textSkeinforge.Text);
                procSkein.StartInfo.UseShellExecute = false;
                procSkein.StartInfo.RedirectStandardOutput = true;
                procSkein.OutputDataReceived += new DataReceivedEventHandler(OutputDataHandler);
                procSkein.StartInfo.RedirectStandardError = true;
                procSkein.ErrorDataReceived += new DataReceivedEventHandler(OutputDataHandler);
                procSkein.Start();
                // Start the asynchronous read of the standard output stream.
                procSkein.BeginOutputReadLine();
                procSkein.BeginErrorReadLine();
            }
            catch (Exception e)
            {
                Main.conn.log(e.ToString(), false, 2);
            }
        }
        public void RunSlice(string file)
        {
            if (procConvert != null)
            {
                MessageBox.Show("Last slice job still running. Slicing of new job is canceled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            procConvert = new Process();
            try
            {
                SlicingInfo.Start("Skeinforge");
                SlicingInfo.SetAction("Slicing STL file ...");
                slicefile = file;
                procConvert.EnableRaisingEvents = true;
                procConvert.Exited += new EventHandler(ConversionExited);
                procConvert.StartInfo.FileName = Main.IsMono ? textPython.Text : wrapQuotes(textPython.Text);
                procConvert.StartInfo.Arguments = wrapQuotes(textSkeinforgeCraft.Text) + " " + wrapQuotes(file);
                procConvert.StartInfo.UseShellExecute = false;
                procConvert.StartInfo.RedirectStandardOutput = true;
                procConvert.OutputDataReceived += new DataReceivedEventHandler(OutputDataHandler);
                procConvert.StartInfo.RedirectStandardError = true;
                procConvert.ErrorDataReceived += new DataReceivedEventHandler(OutputDataHandler);
                procConvert.Start();
                // Start the asynchronous read of the standard output stream.
                procConvert.BeginOutputReadLine();
                procConvert.BeginErrorReadLine();
                //Main.main.tab.SelectedTab = Main.main.tabPrint;
            }
            catch (Exception e)
            {
                Main.conn.log(e.ToString(), false, 2);
            }
        }
        public delegate void LoadGCode(String myString);
        private void ConversionExited(object sender, System.EventArgs e)
        {
            SlicingInfo.f.Invoke(SlicingInfo.f.StopInfo);
            LoadGCode lg = Main.main.LoadGCode;
            procConvert.Close();
            procConvert = null;
            string gcodefile = StlToGCode(slicefile);
            Main.main.Invoke(lg,gcodefile);
        }
        private void SkeinExited(object sender, System.EventArgs e)
        {
            procSkein.Close();
            procSkein = null;
        }
        private static void OutputDataHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            // Collect the net view command output.
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                Main.conn.log(outLine.Data, false, 4);
            }
        }

        public string StlToGCode(string stl)
        {
            int p = stl.LastIndexOf('.');
            if (p > 0) stl = stl.Substring(0, p);
            return stl + textPostfix.Text + textExtension.Text;
        }
        private void regToForm()
        {
            textSkeinforge.Text = (string)repetierKey.GetValue("SkeinforgePath", textSkeinforge.Text);
            textSkeinforgeCraft.Text = (string)repetierKey.GetValue("SkeinforgeCraftPath", textSkeinforgeCraft.Text);
            textPython.Text = (string)repetierKey.GetValue("SkeinforgePython", textPython.Text);
            textExtension.Text = (string)repetierKey.GetValue("SkeinforgeExtension", textExtension.Text);
            textPostfix.Text = (string)repetierKey.GetValue("SkeinforgePostfix", textPostfix.Text);
        }
        private void FormToReg()
        {
            repetierKey.SetValue("SkeinforgePath", textSkeinforge.Text);
            repetierKey.SetValue("SkeinforgeCraftPath", textSkeinforgeCraft.Text);
            repetierKey.SetValue("SkeinforgePython", textPython.Text);
            repetierKey.SetValue("SkeinforgeExtension", textExtension.Text);
            repetierKey.SetValue("SkeinforgePostfix", textPostfix.Text);
        }
        private void buttonAbort_Click(object sender, EventArgs e)
        {
            regToForm();
            Hide();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FormToReg();
            Hide();
            Main.slicer.Update();
        }

        private void buttonSerach_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textSkeinforge.Text = openFile.FileName;
            }
        }

        private void buttonSearchCraft_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textSkeinforgeCraft.Text = openFile.FileName;
            }
        }

        private void buttonSerachPy_Click(object sender, EventArgs e)
        {
            if (openPython.ShowDialog() == DialogResult.OK)
                textPython.Text = openPython.FileName;
        }

        private void Skeinforge_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegMemory.StoreWindowPos("skeinforgeWindow", this, false, false);
        }
    }
}
