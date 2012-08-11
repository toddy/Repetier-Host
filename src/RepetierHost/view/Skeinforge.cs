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
using System.Diagnostics;
using Microsoft.Win32;
using RepetierHost.view.utils;
using RepetierHost.model;

namespace RepetierHost.view
{
    public partial class Skeinforge : Form
    {
        public RegistryKey repetierKey;
        Process procSkein = null;
        Process procConvert = null;
        string slicefile = null;
        SkeinConfig profileConfig = null;
        SkeinConfig exportConfig = null;
        SkeinConfig extrusionConfig = null;

        public Skeinforge()
        {
            InitializeComponent();
            RegMemory.RestoreWindowPos("skeinforgeWindow", this);
            repetierKey = Custom.BaseKey; // Registry.CurrentUser.CreateSubKey("SOFTWARE\\Repetier");
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
                procSkein.StartInfo.WorkingDirectory = textWorkingDirectory.Text;
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
        public void KillSlice()
        {
            if (procConvert != null)
            {
                procConvert.Kill();
                procConvert = null;
                Main.conn.log("Skeinforge slicing process killed on user request.", false, 2);
            }
        }
        public string PyPy
        {
            get
            {
                if (textPypy.Text.Length > 1) return textPypy.Text;
                return textPython.Text;
            }
        }
        public void RunSlice(string file,string profile)
        {
            if (procConvert != null)
            {
                MessageBox.Show("Last slice job still running. Slicing of new job is canceled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            profileConfig = new SkeinConfig(BasicConfiguration.basicConf.SkeinforgeProfileDir + Path.DirectorySeparatorChar + "skeinforge_profile.csv");
            extrusionConfig = new SkeinConfig(BasicConfiguration.basicConf.SkeinforgeProfileDir+Path.DirectorySeparatorChar+"extrusion.csv");
            exportConfig = new SkeinConfig(BasicConfiguration.basicConf.SkeinforgeProfileDir + Path.DirectorySeparatorChar + "extrusion" +
                Path.DirectorySeparatorChar + profile + Path.DirectorySeparatorChar + "export.csv");
            // Set profile to extrusion
            /* cutting	False
extrusion	True
milling	False
winding	False
*/
            profileConfig.setValue("cutting", "False");
            profileConfig.setValue("milling", "False");
            profileConfig.setValue("extrusion", "True");
            profileConfig.setValue("winding", "False");
            profileConfig.writeModified();
            // Set used profile
            extrusionConfig.setValue("Profile Selection:", profile);
            extrusionConfig.writeModified();
            // Set export to correct values
            exportConfig.setValue("Activate Export", "True");
            exportConfig.setValue("Add Profile Extension", "False");
            exportConfig.setValue("Add Timestamp Extension", "False");
            exportConfig.writeModified();
            string target = StlToGCode(file);
            if (File.Exists(target))
                File.Delete(target);
            procConvert = new Process();
            try
            {
                SlicingInfo.Start("Skeinforge");
                SlicingInfo.SetAction("Slicing STL file ...");
                slicefile = file;
                procConvert.EnableRaisingEvents = true;
                procConvert.Exited += new EventHandler(ConversionExited);
                
                procConvert.StartInfo.FileName = Main.IsMono ? PyPy : wrapQuotes(PyPy);
                procConvert.StartInfo.Arguments = wrapQuotes(textSkeinforgeCraft.Text) + " " + wrapQuotes(file);
                procConvert.StartInfo.UseShellExecute = false;
                procConvert.StartInfo.WorkingDirectory = textWorkingDirectory.Text;
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
            if (procConvert == null) return;
            try {
            procConvert.Close();
            procConvert = null;
            string gcodefile = StlToGCode(slicefile);
            Main.slicer.Postprocess(gcodefile);
            } catch {}
        }
        private void SkeinExited(object sender, System.EventArgs e)
        {
            procSkein.Close();
            procSkein = null;
            Main.main.Invoke(Main.main.slicerPanel.UpdateSelectionInvoker);
        }
        private static void OutputDataHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            // Collect the net view command output.
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                string[] lines = outLine.Data.Split((char)0x0d);
                foreach(string l in lines)
                    Main.conn.log("<Skeinforge> "+l, false, 4);
            }
        }

        public string StlToGCode(string stl)
        {
            int p = stl.LastIndexOf('.');
            if (p > 0) stl = stl.Substring(0, p);
            string extension = exportConfig.getValue("File Extension:");
            string export = exportConfig.getValue("Add Export Suffix");
            if (export == null || export != "True") export = ""; else export = "_export";
            return stl + export + "."+extension;
        }
        private void regToForm()
        {

            textSkeinforge.Text = (string)repetierKey.GetValue("SkeinforgePath", textSkeinforge.Text);
            textSkeinforgeCraft.Text = (string)repetierKey.GetValue("SkeinforgeCraftPath", textSkeinforgeCraft.Text);
            textPython.Text = (string)repetierKey.GetValue("SkeinforgePython", textPython.Text);
            textPypy.Text = (string)repetierKey.GetValue("SkeinforgePypy", textPypy.Text);
            //textExtension.Text = (string)repetierKey.GetValue("SkeinforgeExtension", textExtension.Text);
            //textPostfix.Text = (string)repetierKey.GetValue("SkeinforgePostfix", textPostfix.Text);
            textWorkingDirectory.Text = (string)repetierKey.GetValue("SkeinforgeWorkdir", textWorkingDirectory.Text);
            textProfilesDir.Text = BasicConfiguration.basicConf.SkeinforgeProfileDir;
        }
        private void FormToReg()
        {
            BasicConfiguration.basicConf.SkeinforgeProfileDir = textProfilesDir.Text;
            repetierKey.SetValue("SkeinforgePath", textSkeinforge.Text);
            repetierKey.SetValue("SkeinforgeCraftPath", textSkeinforgeCraft.Text);
            repetierKey.SetValue("SkeinforgePython", textPython.Text);
            repetierKey.SetValue("SkeinforgePypy", textPypy.Text);
            //repetierKey.SetValue("SkeinforgeExtension", textExtension.Text);
            //repetierKey.SetValue("SkeinforgePostfix", textPostfix.Text);
            repetierKey.SetValue("SkeinforgeWorkdir", textWorkingDirectory.Text);
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
            Main.main.slicerPanel.UpdateSelection();
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

        private void buttonBrowseWorkingDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textWorkingDirectory.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textWorkingDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBrowseProfilesDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textProfilesDir.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textProfilesDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBrosePyPy_Click(object sender, EventArgs e)
        {
            if (openPython.ShowDialog() == DialogResult.OK)
                textPypy.Text = openPython.FileName;
        }
    }
}
