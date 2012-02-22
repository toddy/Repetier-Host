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
using System.IO;
using Microsoft.Win32;
using RepetierHost.view.utils;

namespace RepetierHost.view
{
    public partial class GlobalSettings : Form
    {
        RegistryKey repetierKey;

        public GlobalSettings()
        {
            InitializeComponent();
            RegMemory.RestoreWindowPos("globalSettingsWindow", this);
            repetierKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Repetier");
            RegToForm();
        }
        public bool WorkdirOK()
        {
            string wd = Workdir;
            if (wd.Length == 0 || !Directory.Exists(wd))
            {
                labelOKMasg.Text = "Existing work directory required!";
                return false;
            }
            labelOKMasg.Text = "";
            return true;
        }
        public void FormToReg()
        {
            repetierKey.SetValue("workdir", Workdir);
            repetierKey.SetValue("logEnabled", LogEnabled ? 1 : 0);
        }
        public void RegToForm()
        {
            Workdir = (string)repetierKey.GetValue("workdir", Workdir);
            checkLogfile.Checked = 1== (int) repetierKey.GetValue("logEnabled", LogEnabled ? 1 : 0);
        }
        public string Workdir
        {
            get { return textWorkdir.Text; }
            set { textWorkdir.Text = value; }
        }
        public Boolean LogEnabled
        {
            get { return checkLogfile.Checked; }
        }
        private void buttonAbort_Click(object sender, EventArgs e)
        {
            RegToForm();
            if(WorkdirOK())
                Hide();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FormToReg();
            if(WorkdirOK())
                Hide();
        }

        private void buttonSearchWorkdir_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                textWorkdir.Text = folderBrowser.SelectedPath;
            }
        }

        private void GlobalSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegMemory.StoreWindowPos("globalSettingsWindow", this, false, false);
        }

        private void textWorkdir_TextChanged(object sender, EventArgs e)
        {
            WorkdirOK();
        }
    }
}
