using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepetierHost.view
{
    public partial class GCodeNotFound : Form
    {
        static GCodeNotFound form = null;

        public static void execute(string file) {
            if(form==null)
                form = new GCodeNotFound();
            form.labelFile.Text = file;
            form.ShowDialog();
        }
        public GCodeNotFound()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
