using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepetierHost.model;

namespace RepetierHost.view
{
    public partial class Slic3rSetup : Form
    {
        static Slic3rSetup form = null;
        public static void Execute()
        {
            if (form == null)
            {
                form = new Slic3rSetup();
            }
            if (form.Visible)
                form.BringToFront();
            else
                form.Show();
        }
        public Slic3rSetup()
        {
            InitializeComponent();
            LoadData();            
        }
        private void LoadData()
        {
            BasicConfiguration b = BasicConfiguration.basicConf;
            textIni.Text = b.ExternalSlic3rIniFile;
            textPath.Text = b.ExternalSlic3rPath;
            checkBoxUseBundledVersion.Checked = b.InternalSlic3rUseBundledVersion;
        }
        private void buttonBrowseSlic3r_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textPath.Text = openFileDialog.FileName;
        }

        private void buttonBrowseIni_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textIni.Text = openFileDialog.FileName;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            BasicConfiguration b = BasicConfiguration.basicConf;
            b.InternalSlic3rUseBundledVersion = checkBoxUseBundledVersion.Checked;
            b.ExternalSlic3rPath = textPath.Text;
            b.ExternalSlic3rIniFile = textIni.Text;
            Hide();
            Main.slicer.Update();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoadData();
            Hide();
        }
    }
}
