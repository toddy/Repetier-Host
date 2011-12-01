using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;

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
