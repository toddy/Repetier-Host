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
using Microsoft.Win32;
using System.Globalization;
using RepetierHost.model;
using RepetierHost.view.utils;

namespace RepetierHost.view
{
    public partial class ThreeDSettings : Form
    {
        RegistryKey repetierKey;
        RegistryKey threedKey;
        public bool useVBOs = false;
        public int drawMethod = 0; // 0 = elements, 1 = drawElements, 2 = VBO
        public float openGLVersion = 1.0f; // Version for feature detection
        public ThreeDSettings()
        {
            InitializeComponent();
            RegMemory.RestoreWindowPos("threeDSettingsWindow", this);
            if (Main.IsMono)
                buttonOK.Location = new Point(buttonOK.Location.X,buttonOK.Location.Y-10);
            comboDrawMethod.SelectedIndex = 0;
            repetierKey = Registry.CurrentUser.CreateSubKey("Software\\Repetier");
            threedKey = repetierKey.CreateSubKey("3D");
            if (comboFilamentVisualization.SelectedIndex < 0) comboFilamentVisualization.SelectedIndex = 1;
            RegistryToForm();
        }
        public int filamentVisualization
        {
            get {return comboFilamentVisualization.SelectedIndex;}
        }
        public float layerHeight
        {
            get { float h; float.TryParse(textLayerHeight.Text, NumberStyles.Float, GCode.format, out h); if (h < 0.05) h = 0.05f; return h; }
        }
        public float filamentDiameter
        {
            get { float h; float.TryParse(textDiameter.Text, NumberStyles.Float, GCode.format, out h); if (h < 0.05) h = 0.05f; return h; }
        }
        public float widthOverHeight
        {
            get { float h; float.TryParse(textWidthOverThickness.Text, NumberStyles.Float, GCode.format, out h); if (h < 0.05) h = 0.05f; return h; }
        }
        public float hotFilamentLength
        {
            get { float h; float.TryParse(textHotFilamentLength.Text, NumberStyles.Float, GCode.format, out h); if (h < 0) h = 0; return h; }
        }
        public bool useLayerHeight
        {
            get { return radioHeight.Checked; }
        }
        private void FormToRegistry()
        {
            try
            {
                threedKey.SetValue("backgroundColor", background.BackColor.ToArgb());
                threedKey.SetValue("facesColor", faces.BackColor.ToArgb());
                threedKey.SetValue("edgesColor", edges.BackColor.ToArgb());
                threedKey.SetValue("selectedFacesColor", selectedFaces.BackColor.ToArgb());
                threedKey.SetValue("printerBaseColor", printerBase.BackColor.ToArgb());
                threedKey.SetValue("filamenColor", filament.BackColor.ToArgb());
                threedKey.SetValue("hotFilamentColor", hotFilament.BackColor.ToArgb());
                threedKey.SetValue("showEdges", showEdges.Checked ? 1 : 0);
                threedKey.SetValue("showPrintbed", showPrintbed.Checked ? 1 : 0);
                threedKey.SetValue("disableFilamentVisualization", checkDisableFilamentVisualization.Checked ? 1 : 0);
                // threedKey.SetValue("useVBOs", useVBOs ? 1 : 0);
                threedKey.SetValue("drawMethod", comboDrawMethod.SelectedIndex);
                threedKey.SetValue("layerHeight", textLayerHeight.Text);
                threedKey.SetValue("filamentDiameter", textDiameter.Text);
                threedKey.SetValue("useLayerHeight", radioHeight.Checked ? 1 : 0);
                threedKey.SetValue("widthOverHeight", textWidthOverThickness.Text);
                threedKey.SetValue("hotFilamentLength", textHotFilamentLength.Text);
                threedKey.SetValue("filamentVisualization", comboFilamentVisualization.SelectedIndex);
            }
            catch { }
        }
        private void RegistryToForm()
        {
            try
            {
                background.BackColor = Color.FromArgb((int)threedKey.GetValue("backgroundColor",background.BackColor.ToArgb()));
                faces.BackColor = Color.FromArgb((int)threedKey.GetValue("facesColor", faces.BackColor.ToArgb()));
                edges.BackColor = Color.FromArgb((int)threedKey.GetValue("edgesColor", faces.BackColor.ToArgb()));
                selectedFaces.BackColor = Color.FromArgb((int)threedKey.GetValue("selectedFacesColor", selectedFaces.BackColor.ToArgb()));
                printerBase.BackColor = Color.FromArgb((int)threedKey.GetValue("printerBaseColor", printerBase.BackColor.ToArgb()));
                filament.BackColor = Color.FromArgb((int)threedKey.GetValue("filamenColor", filament.BackColor.ToArgb()));
                hotFilament.BackColor = Color.FromArgb((int)threedKey.GetValue("hotFilamentColor", hotFilament.BackColor.ToArgb()));
                showEdges.Checked = 0 != (int)threedKey.GetValue("showEdges", showEdges.Checked ? 1 : 0);
                showPrintbed.Checked = 0 != (int)threedKey.GetValue("showPrintbed", showPrintbed.Checked ? 1 : 0);
                checkDisableFilamentVisualization.Checked = 0 != (int)threedKey.GetValue("disableFilamentVisualization", checkDisableFilamentVisualization.Checked ? 1 : 0);
                // useVBOs = 0 != (int)threedKey.GetValue("useVBOs", useVBOs.Checked ? 1 : 0);
                comboDrawMethod.SelectedIndex = (int)threedKey.GetValue("drawMethod", 0);
                textLayerHeight.Text = (string)threedKey.GetValue("layerHeight", textLayerHeight.Text);
                textDiameter.Text = (string)threedKey.GetValue("filamentDiameter", textDiameter.Text);
                radioHeight.Checked = 0 != (int)threedKey.GetValue("useLayerHeight", radioHeight.Checked ? 1 : 0);
                radioDiameter.Checked = !radioHeight.Checked;
                textWidthOverThickness.Text = (string)threedKey.GetValue("widthOverHeight", textWidthOverThickness.Text);
                textHotFilamentLength.Text = (string)threedKey.GetValue("hotFilamentLength", textHotFilamentLength.Text);
                comboFilamentVisualization.SelectedIndex = (int)threedKey.GetValue("filamentVisualization", comboFilamentVisualization.SelectedIndex);
            }
            catch { }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            FormToRegistry();
            Hide();
        }

        private void background_Click(object sender, EventArgs e)
        {
            colorDialog.Color = background.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                background.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void faces_Click(object sender, EventArgs e)
        {
            colorDialog.Color = faces.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                faces.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }
        private void edges_Click(object sender, EventArgs e)
        {
            colorDialog.Color = edges.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                edges.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void selectedFaces_Click(object sender, EventArgs e)
        {
            colorDialog.Color = selectedFaces.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFaces.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void filament_Click(object sender, EventArgs e)
        {
            colorDialog.Color = filament.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                filament.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void printerBase_Click(object sender, EventArgs e)
        {
            colorDialog.Color = printerBase.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                printerBase.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void comboFilamentVisualization_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.main.Update3D();
        }

        private void textLayerHeight_TextChanged(object sender, EventArgs e)
        {
            Main.main.Update3D();
        }

        private void showEdges_CheckedChanged(object sender, EventArgs e)
        {
            Main.main.Update3D();
        }
        private void float_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = (TextBox)sender;
            try
            {
                float.Parse(box.Text);
                errorProvider.SetError(box, "");
            }
            catch
            {
                errorProvider.SetError(box, "Not a number.");
            }
        }

        private void ThreeDSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegMemory.StoreWindowPos("threeDSettingsWindow", this, false, false);
        }

        private void hotFilament_Click(object sender, EventArgs e)
        {
            colorDialog.Color = hotFilament.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                hotFilament.BackColor = colorDialog.Color;
                Main.main.Update3D();
            }
        }

        private void checkDisableFilamentVisualization_CheckedChanged(object sender, EventArgs e)
        {
            Main.main.updateShowFilament();
            Main.main.Update3D();
        }

        private void comboDrawMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Main.main.Update3D();
        }
    }
}
