using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace RepetierHost.view.utils
{
    public class Slicer
    {
        public enum SlicerID  {Slic3r,Skeinforge};
        private SlicerID _ActiveSlicer = SlicerID.Slic3r;
        bool _hasSlic3r = false;
        bool _hasSkeinforge = false;
        private Skeinforge skein = null;

        public Slicer()
        {
            skein = Main.main.skeinforge;
            _ActiveSlicer = (Slicer.SlicerID)(int)Main.main.repetierKey.GetValue("ActiveSlicer", (int)ActiveSlicer);
            Update();
        }
        public bool hasSlic3r
        {
            get
            {
                return _hasSlic3r;
            }
        }
        public bool hasSkeinforge
        {
            get
            {
                return _hasSkeinforge;
            }
        }
        public string wrapQuotes(string text)
        {
            if (text.StartsWith("\"") && text.EndsWith("\"")) return text;
            return "\"" + text.Replace("\"", "\\\"") + "\"";
        }
        public delegate void LoadGCode(String myString);
        string postprocessFile = null;
        Process postproc=null;
        public void Postprocess(string file)
        {
            string dir = Main.globalSettings.Workdir;
            if (Main.conn.runFilterEverySlice == false || postproc != null || dir.Length==0)
            {
                SlicingInfo.f.Invoke(SlicingInfo.f.StopInfo);
                LoadGCode lg = Main.main.LoadGCode;
                Main.main.Invoke(lg, file);
                return; // Nothing to do
            }
            SlicingInfo.f.Invoke(SlicingInfo.f.PostprocInfo);
            // Copy file to work dir
            postprocessFile = file;
            string tmpfile = dir + Path.DirectorySeparatorChar + "filter.gcode";
            File.Copy(file, tmpfile,true);
            // run filter
            string full = Main.conn.filterCommand;
            int p = full.IndexOf(' ');
            if (p < 0) return;
            string cmd = full.Substring(0, p);
            string args = full.Substring(p + 1);
            args = args.Replace("#in", wrapQuotes(tmpfile));
            args = args.Replace("#out", wrapQuotes(file));
            Main.conn.log(cmd + " " + args, false, 3);
            postproc = new Process();
            postproc.EnableRaisingEvents = true;
            postproc.Exited += new EventHandler(PostprocessExited);
            postproc.StartInfo.FileName = Main.IsMono ? cmd : wrapQuotes(cmd);
            postproc.StartInfo.Arguments = args;
            postproc.StartInfo.UseShellExecute = false;
            postproc.StartInfo.RedirectStandardOutput = true;
            postproc.OutputDataReceived += new DataReceivedEventHandler(OutputDataHandler);
            postproc.StartInfo.RedirectStandardError = true;
            postproc.ErrorDataReceived += new DataReceivedEventHandler(OutputDataHandler);
            try
            {
                postproc.Start();
            }
            catch (Exception e)
            {
                postproc = null;
                SlicingInfo.f.Invoke(SlicingInfo.f.StopInfo);
                MessageBox.Show("Error starting postprocessor:" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Start the asynchronous read of the standard output stream.
            postproc.BeginOutputReadLine();
            postproc.BeginErrorReadLine();


        }
        private void PostprocessExited(object sender, System.EventArgs e)
        {
            postproc.Close();
            postproc = null;
            SlicingInfo.f.Invoke(SlicingInfo.f.StopInfo);
            LoadGCode lg = Main.main.LoadGCode;
            Main.main.Invoke(lg, postprocessFile);

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

        public SlicerID ActiveSlicer {
            get {return _ActiveSlicer;}
            set {
                if(value!=_ActiveSlicer) {
                    _ActiveSlicer = value;
                    Main.main.repetierKey.SetValue("ActiveSlicer", (int)_ActiveSlicer);
                }
                Main.main.slic3rToolStripMenuItem.Checked = _ActiveSlicer == SlicerID.Slic3r;
                Main.main.skeinforgeToolStripMenuItem1.Checked = _ActiveSlicer == SlicerID.Skeinforge;
            }
        }
        public void Update()
        {
            string basedir = (string)Main.main.repetierKey.GetValue("installPath","");
            _hasSlic3r = false;
            if(basedir.Length>0) {
                string exname = "slic3r.exe";
                if (Environment.OSVersion.Platform == PlatformID.Unix)
                    exname = "bin" + Path.DirectorySeparatorChar + "slic3r";
                if(Main.IsMac) 
                    exname = "MacOS"+Path.DirectorySeparatorChar+"slic3r";
                _hasSlic3r = File.Exists(basedir+Path.DirectorySeparatorChar+"Slic3r"+Path.DirectorySeparatorChar+exname);
            }
            _hasSkeinforge = false;
            if(skein.textPython.Text.Length>0 && skein.textSkeinforge.Text.Length>0 && 
                skein.textSkeinforgeCraft.Text.Length>0) {
                _hasSkeinforge = File.Exists(skein.textPython.Text) && File.Exists(skein.textSkeinforge.Text) &&
                    File.Exists(skein.textSkeinforgeCraft.Text);
            }
            Main.main.slic3rToolStripMenuItem.Enabled = _hasSlic3r;
            Main.main.skeinforgeToolStripMenuItem1.Enabled = _hasSkeinforge;
            Main.main.skeinforgeConfigurationToolStripMenuItem.Enabled = _hasSkeinforge;
            // Check if active slicer is possible
            if (ActiveSlicer == SlicerID.Slic3r && !_hasSlic3r && _hasSkeinforge)
            {
                ActiveSlicer = SlicerID.Skeinforge;
            }
            else if (ActiveSlicer == SlicerID.Skeinforge && !_hasSkeinforge && _hasSlic3r)
                ActiveSlicer = SlicerID.Slic3r;
            else ActiveSlicer = _ActiveSlicer;
        }
        /// <summary>
        /// Convert STL in GCode and load into editor
        /// </summary>
        /// <param name="file"></param>
        public void RunSlice(string file)
        {
            switch (_ActiveSlicer)
            {
                case SlicerID.Slic3r:
                    Main.slic3r.RunSlice(file, Main.printerSettings.PrintAreaWidth / 2, Main.printerSettings.PrintAreaDepth / 2);
                    break;
                case SlicerID.Skeinforge:
                    skein.RunSlice(file);
                    break;
            }
        }
    }
}
