using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepetierHost.model;
using RepetierHost;

namespace RepetierHost.view.utils
{
    public partial class PauseInfo : Form
    {
        private static PauseInfo form=null;
        public static void ShowPause(string info) {
            if (form == null)
            {
                form = new PauseInfo();
            }
            form.labelInfo.Text = info;
            if (form.Visible == false)
                form.Show();
        }
        public PauseInfo()
        {
            InitializeComponent();
        }

        private void buttonContinuePrinting_Click(object sender, EventArgs e)
        {
            Hide();
            Main.conn.paused = false;
        }
    }
}
