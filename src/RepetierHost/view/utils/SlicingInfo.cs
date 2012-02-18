using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepetierHost.view.utils
{
    public partial class SlicingInfo : Form
    {
        public static SlicingInfo f = null;
        public static void Start(string slicerName) {
            if (f == null)
                f = new SlicingInfo();
            f.labelSlicer.Text = slicerName;
            f.ResetTimer();
            if(f.Visible==false)
                f.Show(Main.main);
            f.timer.Start();
        }
        public static void Stop()
        {
            if (f != null)
            {
                f.timer.Stop();
                f.Hide();
            }
        }
        public MethodInvoker StopInfo = delegate
        {
            SlicingInfo.Stop();
        };
        public MethodInvoker PostprocInfo = delegate
        {
            SetAction("Postprocessing...");
        };
        public static void SetAction(string action)
        {
            f.labelAction.Text = action;
        }
        int min = 0;
        int sec = 0;
        public SlicingInfo()
        {
            InitializeComponent();
        }
        private void ResetTimer() {
            min = sec = 0;
            labelDuration.Text = "0:00";
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            sec++;
            if(sec>=60) {
                sec = 0;
                min++;
            }
            labelDuration.Text = min.ToString() + ":" + sec.ToString("00");
        }
    }
}
