using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Globalization;
using RepetierHost.view.utils;
using RepetierHost.model;

namespace RepetierHost.view
{
    public partial class Slic3r : Form
    {
        RegistryKey rconfigs;
        RegistryKey rcon;
        string config="";
        Process procConvert = null;
        string slicefile = null;

        public Slic3r()
        {
            InitializeComponent();
            if (Main.IsMono)
                panelCloseButtons.Location = new Point(panelCloseButtons.Location.X, panelCloseButtons.Location.Y - 14);
            comboFillPattern.SelectedIndex = 0;
            comboSolidFillPattern.SelectedIndex = 0;
            RegMemory.RestoreWindowPos("slic3rWindow", this);
            rconfigs = Main.main.repetierKey.CreateSubKey("slic3r");
            foreach (string s in rconfigs.GetSubKeyNames())
                comboConfig.Items.Add(s);
            config = (string)rconfigs.GetValue("currentConfig", "default");
            if (comboConfig.Items.Count == 0)
            {
                comboConfig.Items.Add("default");
                comboConfig.SelectedIndex = 0;
            }
            else
            {
                for (int i = 0; i < comboConfig.Items.Count; i++)
                {
                    if (comboConfig.Items[i].ToString() == config)
                    {
                        comboConfig.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
        private void loadConfig(string name)
        {
            if (name != config)
            {
                rconfigs.SetValue("currentConfig", name);
                config = name;
            }
            comboConfig.Text = config;
            rcon = rconfigs.CreateSubKey(config);
            RegistryKey c = rcon;
            textNozzleDiameter.Text = (string)c.GetValue("NozzleDiameter", textNozzleDiameter.Text);
            textZOffset.Text = (string)c.GetValue("ZOffset", textZOffset.Text);
            checkRelativeE.Checked  = ((int)c.GetValue("UseRelativeE", checkRelativeE.Checked ? 1 : 0))==1;
            checkNoExtrusion.Checked = ((int)c.GetValue("NoExtrusion", checkNoExtrusion.Checked ? 1 : 0))==1;
            textDiameter.Text = (string)c.GetValue("FilamentDiameter", textDiameter.Text);
            textPackingDensity.Text = (string)c.GetValue("PackingDensity", textPackingDensity.Text);
            textTemperature.Text = (string)c.GetValue("Temperature", textTemperature.Text);
            textPrintFeedrate.Text = (string)c.GetValue("PrintFeedrate", textPrintFeedrate.Text);
            textTravelFeedrate.Text = (string)c.GetValue("TravelFeedrate", textTravelFeedrate.Text);
            textPerimeterFeedrate.Text = (string)c.GetValue("PerimeterFeedrate", textPerimeterFeedrate.Text);
            textBottomLayerRatio.Text = (string)c.GetValue("BottomLayerRatio", textBottomLayerRatio.Text);
            textLayerHeight.Text = (string)c.GetValue("LayerHeight", textLayerHeight.Text);
            textInfillEvery.Text = (string)c.GetValue("InfillEvery", textInfillEvery.Text);
            textPerimeters.Text = (string)c.GetValue("Perimeters", textPerimeters.Text);
            textSolidLayers.Text = (string)c.GetValue("SolidLayers", textSolidLayers.Text);
            textFillDensity.Text = (string)c.GetValue("FillDensity", textFillDensity.Text);
            textFillAngle.Text = (string)c.GetValue("FillAngle", textFillAngle.Text);
            comboFillPattern.Text = (string)c.GetValue("FillPattern", comboFillPattern.Text);
            comboSolidFillPattern.Text = (string)c.GetValue("SolidFillPattern", comboSolidFillPattern.Text);
            textRetLength.Text = (string)c.GetValue("RetLength", textRetLength.Text);
            textRetExtraDistance.Text = (string)c.GetValue("RetExtraDistance", textRetExtraDistance.Text);
            textRetLift.Text = (string)c.GetValue("RetLift", textRetLift.Text);
            textRetMinTravel.Text = (string)c.GetValue("RetMinTravel", textRetMinTravel.Text);
            textRetSpeed.Text = (string)c.GetValue("RetSpeed", textRetSpeed.Text);
            textSkirtLoops.Text = (string)c.GetValue("SkirtLoops", textSkirtLoops.Text);
            textSkirtHeight.Text = (string)c.GetValue("SkirtHeight", textSkirtHeight.Text);
            textSkirtDistance.Text = (string)c.GetValue("SkirtDistance", textSkirtDistance.Text);
            textExtrusionWidthRatio.Text = (string)c.GetValue("ExtrusionWidthRatio", textExtrusionWidthRatio.Text);

        }
        private void saveConfig(string name)
        {
            RegistryKey c = rconfigs.CreateSubKey(name);
            c.SetValue("NozzleDiameter", textNozzleDiameter.Text);
            c.SetValue("ZOffset", textZOffset.Text);
            c.SetValue("UseRelativeE", checkRelativeE.Checked ? 1 : 0);
            c.SetValue("NoExtrusion", checkNoExtrusion.Checked ? 1 : 0);
            c.SetValue("FilamentDiameter", textDiameter.Text);
            c.SetValue("PackingDensity", textPackingDensity.Text);
            c.SetValue("Temperature", textTemperature.Text);
            c.SetValue("PrintFeedrate", textPrintFeedrate.Text);
            c.SetValue("TravelFeedrate", textTravelFeedrate.Text);
            c.SetValue("PerimeterFeedrate", textPerimeterFeedrate.Text);
            c.SetValue("BottomLayerRatio", textBottomLayerRatio.Text);
            c.SetValue("LayerHeight", textLayerHeight.Text);
            c.SetValue("InfillEvery", textInfillEvery.Text);
            c.SetValue("Perimeters", textPerimeters.Text);
            c.SetValue("SolidLayers", textSolidLayers.Text);
            c.SetValue("FillDensity", textFillDensity.Text);
            c.SetValue("FillAngle", textFillAngle.Text);
            c.SetValue("FillPattern", comboFillPattern.Text);
            c.SetValue("SolidFillPattern", comboSolidFillPattern.Text);
            c.SetValue("RetLength", textRetLength.Text);
            c.SetValue("RetExtraDistance", textRetExtraDistance.Text);
            c.SetValue("RetLift", textRetLift.Text);
            c.SetValue("RetMinTravel", textRetMinTravel.Text);
            c.SetValue("RetSpeed", textRetSpeed.Text);
            c.SetValue("SkirtLoops", textSkirtLoops.Text);
            c.SetValue("SkirtHeight", textSkirtHeight.Text);
            c.SetValue("SkirtDistance", textSkirtDistance.Text);
            c.SetValue("ExtrusionWidthRatio", textExtrusionWidthRatio.Text);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            saveConfig(config);
            Hide();
        }

        private void Slic3r_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegMemory.StoreWindowPos("slic3rWindow", this, false, false);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            saveConfig(config);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            loadConfig(config);
            Hide();
        }

        private void buttonNewConfig_Click(object sender, EventArgs e)
        {
            string name = StringInput.GetString("Create new config", "Name of the new configuration");
            comboConfig.Items.Add(name);
            comboConfig.SelectedIndex = comboConfig.Items.Count - 1;
        }
        private void float_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = (TextBox)sender;
            try
            {
                float f = float.Parse(box.Text);
                if(f>=0) 
                    errorProvider.SetError(box, "");
                else
                    errorProvider.SetError(box, "No negative values allowed.");
            }
            catch
            {
                errorProvider.SetError(box, "Not a number.");
            }
        }
        private void int_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = (TextBox)sender;
            try
            {
                int i = int.Parse(box.Text);
                if (i >= 0)
                    errorProvider.SetError(box, "");
                else
                    errorProvider.SetError(box, "No negative values allowed.");
            }
            catch
            {
                errorProvider.SetError(box, "Not an integer.");
            }
        }
        public string wrapQuotes(string text)
        {
            if (text.StartsWith("\"") && text.EndsWith("\"")) return text;
            return "\"" + text.Replace("\"", "\\\"") + "\"";
        }
        public void RunSlice(string file,float centerx,float centery)
        {
            if (procConvert != null)
            {
                MessageBox.Show("Last slice job still running. Slicing of new job is canceled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SlicingInfo.Start("Slic3r");
            SlicingInfo.SetAction("Analyzing STL file ...");
            try
            {
                STL stl = new STL();
                stl.Load(file);
                stl.UpdateBoundingBox();
                if (stl.xMin > 0 && stl.yMin > 0 && stl.xMax < Main.printerSettings.PrintAreaWidth && stl.yMax < Main.printerSettings.PrintAreaDepth)
                {
                    // User assigned valid position, so we use this
                    centerx = stl.xMin + (stl.xMax - stl.xMin) / 2;
                    centery = stl.yMin + (stl.yMax - stl.yMin) / 2;
                }
                stl.Clear();
            }
            catch (Exception e)
            {
                Main.conn.log(e.ToString(), false, 2);
                SlicingInfo.Stop();
                return;
            }
            SlicingInfo.SetAction("Slicing STL file ...");
            procConvert = new Process();
            try
            {
            string basedir = (string)Main.main.repetierKey.GetValue("installPath","");
            string exname = "slic3r.exe";
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                    exname = "bin"+Path.DirectorySeparatorChar+"slic3r";
            if (Main.IsMac)
                exname = "MacOS" + Path.DirectorySeparatorChar + "slic3r";
            string exe = basedir + Path.DirectorySeparatorChar + "Slic3r" + Path.DirectorySeparatorChar + exname;
                slicefile = file;
                procConvert.EnableRaisingEvents = true;
                procConvert.Exited += new EventHandler(ConversionExited);
                procConvert.StartInfo.FileName = Main.IsMono ? exe : wrapQuotes(exe);
                StringBuilder sb = new StringBuilder();
                sb.Append("--nozzle-diameter ");
                sb.Append(textNozzleDiameter.Text);
                sb.Append(" ");
                if (checkNoExtrusion.Checked)
                    sb.Append("--no-extrusion ");
                if (checkRelativeE.Checked)
                    sb.Append("--use-relative-e-distances ");
                sb.Append("--z-offset ");
                sb.Append(textZOffset.Text);
                sb.Append(" --filament-diameter ");
                sb.Append(textDiameter.Text);
                sb.Append(" --extrusion-multiplier ");
                sb.Append(textPackingDensity.Text);
                sb.Append(" --temperature ");
                sb.Append(textTemperature.Text);
                sb.Append(" --print-feed-rate ");
                sb.Append(textPrintFeedrate.Text);
                sb.Append(" --travel-feed-rate ");
                sb.Append(textTravelFeedrate.Text);
                sb.Append(" --perimeter-feed-rate ");
                sb.Append(textPerimeterFeedrate.Text);
                sb.Append(" --bottom-layer-speed-ratio ");
                sb.Append(textBottomLayerRatio.Text);
                sb.Append(" --layer-height ");
                sb.Append(textLayerHeight.Text);
                sb.Append(" --infill-every-layers ");
                sb.Append(textInfillEvery.Text);
                sb.Append(" --perimeters ");
                sb.Append(textPerimeters.Text);
                sb.Append(" --solid-layers ");
                sb.Append(textSolidLayers.Text);
                sb.Append(" --fill-density ");
                sb.Append(textFillDensity.Text);
                sb.Append(" --fill-angle ");
                sb.Append(textFillAngle.Text);
                sb.Append(" --fill-pattern ");
                sb.Append(comboFillPattern.Text);
                sb.Append(" --solid-fill-pattern ");
                sb.Append(comboSolidFillPattern.Text);
                sb.Append(" --retract-length ");
                sb.Append(textRetLength.Text);
                sb.Append(" --retract-speed ");
                sb.Append(textRetSpeed.Text);
                sb.Append(" --retract-restart-extra ");
                sb.Append(textRetExtraDistance.Text);
                sb.Append(" --retract-before-travel ");
                sb.Append(textRetMinTravel.Text);
                sb.Append(" --retract-lift ");
                sb.Append(textRetLift.Text);
                sb.Append(" --skirts ");
                sb.Append(textSkirtLoops.Text);
                sb.Append(" --skirt-distance ");
                sb.Append(textSkirtDistance.Text);
                sb.Append(" --skirt-height ");
                sb.Append(textSkirtHeight.Text);
                sb.Append(" --extrusion-width-ratio ");
                sb.Append(textExtrusionWidthRatio.Text);
                sb.Append(" --print-center ");
                sb.Append(centerx.ToString("0",GCode.format));
                sb.Append(",");
                sb.Append(centery.ToString("0", GCode.format));
                sb.Append(" --start-gcode ");
                sb.Append(wrapQuotes(basedir+Path.DirectorySeparatorChar+"empty.txt"));
                sb.Append(" --end-gcode ");
                sb.Append(wrapQuotes(basedir+Path.DirectorySeparatorChar+"empty.txt"));
                sb.Append(" ");
                sb.Append(wrapQuotes(file));
                procConvert.StartInfo.Arguments = sb.ToString();
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
        public string StlToGCode(string stl)
        {
            int p = stl.LastIndexOf('.');
            if (p > 0) stl = stl.Substring(0, p);
            return stl + ".gcode";
        }
        public delegate void LoadGCode(String myString);
        private void ConversionExited(object sender, System.EventArgs e)
        {
            
            SlicingInfo.f.Invoke(SlicingInfo.f.StopInfo);
            LoadGCode lg = Main.main.LoadGCode;
            procConvert.Close();
            procConvert = null;
            string gcodefile = StlToGCode(slicefile);
            Main.main.Invoke(lg, gcodefile);
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

        private void buttonDeleteConfig_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete config " + config, "Security question", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string oc = config;
                comboConfig.Items.Remove(comboConfig.SelectedItem);
                rconfigs.DeleteSubKeyTree(config);
                if (comboConfig.Items.Count == 0)
                {
                    comboConfig.Items.Add("default");
                    comboConfig.SelectedIndex = 0;
                }
                else comboConfig.SelectedIndex = 0;
            }
        }

        private void comboConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadConfig(comboConfig.Text);
        }
    }
}
