namespace RepetierHost.view
{
    partial class ThreeDSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThreeDSettings));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textHotFilamentLength = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printerBase = new System.Windows.Forms.Panel();
            this.hotFilament = new System.Windows.Forms.Panel();
            this.filament = new System.Windows.Forms.Panel();
            this.selectedFaces = new System.Windows.Forms.Panel();
            this.edges = new System.Windows.Forms.Panel();
            this.faces = new System.Windows.Forms.Panel();
            this.background = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboDrawMethod = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkDisableFilamentVisualization = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textDiameter = new System.Windows.Forms.TextBox();
            this.radioDiameter = new System.Windows.Forms.RadioButton();
            this.radioHeight = new System.Windows.Forms.RadioButton();
            this.textWidthOverThickness = new System.Windows.Forms.TextBox();
            this.textLayerHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboFilamentVisualization = new System.Windows.Forms.ComboBox();
            this.showPrintbed = new System.Windows.Forms.CheckBox();
            this.showEdges = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enableLight4 = new System.Windows.Forms.CheckBox();
            this.enableLight3 = new System.Windows.Forms.CheckBox();
            this.enableLight2 = new System.Windows.Forms.CheckBox();
            this.enableLight1 = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxColors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.label14);
            this.groupBoxColors.Controls.Add(this.label13);
            this.groupBoxColors.Controls.Add(this.textHotFilamentLength);
            this.groupBoxColors.Controls.Add(this.label12);
            this.groupBoxColors.Controls.Add(this.label5);
            this.groupBoxColors.Controls.Add(this.printerBase);
            this.groupBoxColors.Controls.Add(this.hotFilament);
            this.groupBoxColors.Controls.Add(this.filament);
            this.groupBoxColors.Controls.Add(this.selectedFaces);
            this.groupBoxColors.Controls.Add(this.edges);
            this.groupBoxColors.Controls.Add(this.faces);
            this.groupBoxColors.Controls.Add(this.background);
            this.groupBoxColors.Controls.Add(this.label4);
            this.groupBoxColors.Controls.Add(this.label6);
            this.groupBoxColors.Controls.Add(this.label3);
            this.groupBoxColors.Controls.Add(this.label2);
            this.groupBoxColors.Controls.Add(this.label1);
            this.groupBoxColors.Location = new System.Drawing.Point(14, 7);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(551, 137);
            this.groupBoxColors.TabIndex = 0;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Colors";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Hot filament:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "[mm]";
            // 
            // textHotFilamentLength
            // 
            this.textHotFilamentLength.Location = new System.Drawing.Point(118, 103);
            this.textHotFilamentLength.Name = "textHotFilamentLength";
            this.textHotFilamentLength.Size = new System.Drawing.Size(81, 20);
            this.textHotFilamentLength.TabIndex = 7;
            this.textHotFilamentLength.Text = "1000";
            this.textHotFilamentLength.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Hot filament length:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Printer base:";
            // 
            // printerBase
            // 
            this.printerBase.BackColor = System.Drawing.Color.White;
            this.printerBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printerBase.Location = new System.Drawing.Point(364, 20);
            this.printerBase.Name = "printerBase";
            this.printerBase.Size = new System.Drawing.Size(111, 22);
            this.printerBase.TabIndex = 4;
            this.printerBase.Click += new System.EventHandler(this.printerBase_Click);
            // 
            // hotFilament
            // 
            this.hotFilament.BackColor = System.Drawing.Color.Red;
            this.hotFilament.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotFilament.Location = new System.Drawing.Point(364, 102);
            this.hotFilament.Name = "hotFilament";
            this.hotFilament.Size = new System.Drawing.Size(111, 22);
            this.hotFilament.TabIndex = 4;
            this.hotFilament.Click += new System.EventHandler(this.hotFilament_Click);
            // 
            // filament
            // 
            this.filament.BackColor = System.Drawing.Color.Blue;
            this.filament.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filament.Location = new System.Drawing.Point(364, 75);
            this.filament.Name = "filament";
            this.filament.Size = new System.Drawing.Size(111, 22);
            this.filament.TabIndex = 4;
            this.filament.Click += new System.EventHandler(this.filament_Click);
            // 
            // selectedFaces
            // 
            this.selectedFaces.BackColor = System.Drawing.Color.Fuchsia;
            this.selectedFaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedFaces.Location = new System.Drawing.Point(118, 75);
            this.selectedFaces.Name = "selectedFaces";
            this.selectedFaces.Size = new System.Drawing.Size(111, 22);
            this.selectedFaces.TabIndex = 4;
            this.selectedFaces.Click += new System.EventHandler(this.selectedFaces_Click);
            // 
            // edges
            // 
            this.edges.BackColor = System.Drawing.Color.RosyBrown;
            this.edges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edges.Location = new System.Drawing.Point(364, 47);
            this.edges.Name = "edges";
            this.edges.Size = new System.Drawing.Size(111, 22);
            this.edges.TabIndex = 4;
            this.edges.Click += new System.EventHandler(this.edges_Click);
            // 
            // faces
            // 
            this.faces.BackColor = System.Drawing.Color.Red;
            this.faces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.faces.Location = new System.Drawing.Point(118, 47);
            this.faces.Name = "faces";
            this.faces.Size = new System.Drawing.Size(111, 22);
            this.faces.TabIndex = 4;
            this.faces.Click += new System.EventHandler(this.faces_Click);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.background.Location = new System.Drawing.Point(118, 20);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(111, 22);
            this.background.TabIndex = 4;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filament:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Edges:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selected faces:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faces:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(468, 394);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 22);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboDrawMethod);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.checkDisableFilamentVisualization);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textDiameter);
            this.groupBox1.Controls.Add(this.radioDiameter);
            this.groupBox1.Controls.Add(this.radioHeight);
            this.groupBox1.Controls.Add(this.textWidthOverThickness);
            this.groupBox1.Controls.Add(this.textLayerHeight);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboFilamentVisualization);
            this.groupBox1.Controls.Add(this.showPrintbed);
            this.groupBox1.Controls.Add(this.showEdges);
            this.groupBox1.Location = new System.Drawing.Point(14, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualization";
            // 
            // comboDrawMethod
            // 
            this.comboDrawMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDrawMethod.FormattingEnabled = true;
            this.comboDrawMethod.Items.AddRange(new object[] {
            "Autodetect best",
            "VBOs (fastest)",
            "Arrays (medium)",
            "Immediate (slow)"});
            this.comboDrawMethod.Location = new System.Drawing.Point(92, 88);
            this.comboDrawMethod.Name = "comboDrawMethod";
            this.comboDrawMethod.Size = new System.Drawing.Size(144, 21);
            this.comboDrawMethod.TabIndex = 16;
            this.comboDrawMethod.SelectedIndexChanged += new System.EventHandler(this.comboDrawMethod_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Draw method:";
            // 
            // checkDisableFilamentVisualization
            // 
            this.checkDisableFilamentVisualization.AutoSize = true;
            this.checkDisableFilamentVisualization.Location = new System.Drawing.Point(14, 67);
            this.checkDisableFilamentVisualization.Name = "checkDisableFilamentVisualization";
            this.checkDisableFilamentVisualization.Size = new System.Drawing.Size(160, 17);
            this.checkDisableFilamentVisualization.TabIndex = 14;
            this.checkDisableFilamentVisualization.Text = "Disable filament visualization";
            this.checkDisableFilamentVisualization.UseVisualStyleBackColor = true;
            this.checkDisableFilamentVisualization.CheckedChanged += new System.EventHandler(this.checkDisableFilamentVisualization_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(461, 39);
            this.label11.TabIndex = 13;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "[mm]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "[mm]";
            // 
            // textDiameter
            // 
            this.textDiameter.Location = new System.Drawing.Point(375, 101);
            this.textDiameter.Name = "textDiameter";
            this.textDiameter.Size = new System.Drawing.Size(106, 20);
            this.textDiameter.TabIndex = 11;
            this.textDiameter.Text = "2.87";
            this.textDiameter.TextChanged += new System.EventHandler(this.textLayerHeight_TextChanged);
            this.textDiameter.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // radioDiameter
            // 
            this.radioDiameter.AutoSize = true;
            this.radioDiameter.Location = new System.Drawing.Point(256, 99);
            this.radioDiameter.Name = "radioDiameter";
            this.radioDiameter.Size = new System.Drawing.Size(110, 17);
            this.radioDiameter.TabIndex = 10;
            this.radioDiameter.Text = "Filament diameter:";
            this.radioDiameter.UseVisualStyleBackColor = true;
            // 
            // radioHeight
            // 
            this.radioHeight.AutoSize = true;
            this.radioHeight.Checked = true;
            this.radioHeight.Location = new System.Drawing.Point(256, 77);
            this.radioHeight.Name = "radioHeight";
            this.radioHeight.Size = new System.Drawing.Size(86, 17);
            this.radioHeight.TabIndex = 9;
            this.radioHeight.TabStop = true;
            this.radioHeight.Text = "Layer height:";
            this.radioHeight.UseVisualStyleBackColor = true;
            this.radioHeight.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // textWidthOverThickness
            // 
            this.textWidthOverThickness.Location = new System.Drawing.Point(375, 48);
            this.textWidthOverThickness.Name = "textWidthOverThickness";
            this.textWidthOverThickness.Size = new System.Drawing.Size(106, 20);
            this.textWidthOverThickness.TabIndex = 7;
            this.textWidthOverThickness.Text = "1.8";
            this.textWidthOverThickness.TextChanged += new System.EventHandler(this.textLayerHeight_TextChanged);
            this.textWidthOverThickness.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textLayerHeight
            // 
            this.textLayerHeight.Location = new System.Drawing.Point(375, 74);
            this.textLayerHeight.Name = "textLayerHeight";
            this.textLayerHeight.Size = new System.Drawing.Size(106, 20);
            this.textLayerHeight.TabIndex = 6;
            this.textLayerHeight.Text = "0.38";
            this.textLayerHeight.TextChanged += new System.EventHandler(this.textLayerHeight_TextChanged);
            this.textLayerHeight.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Width over thickness:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Filament visualization:";
            // 
            // comboFilamentVisualization
            // 
            this.comboFilamentVisualization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilamentVisualization.FormattingEnabled = true;
            this.comboFilamentVisualization.Items.AddRange(new object[] {
            "Simple",
            "Medium",
            "Fine",
            "Ultra fine"});
            this.comboFilamentVisualization.Location = new System.Drawing.Point(375, 20);
            this.comboFilamentVisualization.Name = "comboFilamentVisualization";
            this.comboFilamentVisualization.Size = new System.Drawing.Size(129, 21);
            this.comboFilamentVisualization.TabIndex = 2;
            this.comboFilamentVisualization.SelectedIndexChanged += new System.EventHandler(this.comboFilamentVisualization_SelectedIndexChanged);
            // 
            // showPrintbed
            // 
            this.showPrintbed.AutoSize = true;
            this.showPrintbed.Checked = true;
            this.showPrintbed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPrintbed.Location = new System.Drawing.Point(14, 43);
            this.showPrintbed.Name = "showPrintbed";
            this.showPrintbed.Size = new System.Drawing.Size(94, 17);
            this.showPrintbed.TabIndex = 1;
            this.showPrintbed.Text = "Show printbed";
            this.showPrintbed.UseVisualStyleBackColor = true;
            this.showPrintbed.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // showEdges
            // 
            this.showEdges.AutoSize = true;
            this.showEdges.Location = new System.Drawing.Point(14, 20);
            this.showEdges.Name = "showEdges";
            this.showEdges.Size = new System.Drawing.Size(85, 17);
            this.showEdges.TabIndex = 0;
            this.showEdges.Text = "Show edges";
            this.showEdges.UseVisualStyleBackColor = true;
            this.showEdges.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enableLight4);
            this.groupBox2.Controls.Add(this.enableLight3);
            this.groupBox2.Controls.Add(this.enableLight2);
            this.groupBox2.Controls.Add(this.enableLight1);
            this.groupBox2.Location = new System.Drawing.Point(13, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lightning";
            // 
            // enableLight4
            // 
            this.enableLight4.AutoSize = true;
            this.enableLight4.Location = new System.Drawing.Point(326, 20);
            this.enableLight4.Name = "enableLight4";
            this.enableLight4.Size = new System.Drawing.Size(90, 17);
            this.enableLight4.TabIndex = 3;
            this.enableLight4.Text = "Enable light 4";
            this.enableLight4.UseVisualStyleBackColor = true;
            this.enableLight4.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // enableLight3
            // 
            this.enableLight3.AutoSize = true;
            this.enableLight3.Location = new System.Drawing.Point(222, 20);
            this.enableLight3.Name = "enableLight3";
            this.enableLight3.Size = new System.Drawing.Size(90, 17);
            this.enableLight3.TabIndex = 2;
            this.enableLight3.Text = "Enable light 3";
            this.enableLight3.UseVisualStyleBackColor = true;
            this.enableLight3.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // enableLight2
            // 
            this.enableLight2.AutoSize = true;
            this.enableLight2.Checked = true;
            this.enableLight2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableLight2.Location = new System.Drawing.Point(118, 20);
            this.enableLight2.Name = "enableLight2";
            this.enableLight2.Size = new System.Drawing.Size(90, 17);
            this.enableLight2.TabIndex = 1;
            this.enableLight2.Text = "Enable light 2";
            this.enableLight2.UseVisualStyleBackColor = true;
            this.enableLight2.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // enableLight1
            // 
            this.enableLight1.AutoSize = true;
            this.enableLight1.Checked = true;
            this.enableLight1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableLight1.Location = new System.Drawing.Point(14, 20);
            this.enableLight1.Name = "enableLight1";
            this.enableLight1.Size = new System.Drawing.Size(90, 17);
            this.enableLight1.TabIndex = 0;
            this.enableLight1.Text = "Enable light 1";
            this.enableLight1.UseVisualStyleBackColor = true;
            this.enableLight1.CheckedChanged += new System.EventHandler(this.showEdges_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ThreeDSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(578, 456);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThreeDSettings";
            this.Opacity = 0.85;
            this.Text = "3D settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThreeDSettings_FormClosing);
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel faces;
        public System.Windows.Forms.Panel background;
        public System.Windows.Forms.Panel selectedFaces;
        public System.Windows.Forms.Panel filament;
        public System.Windows.Forms.Panel printerBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox showPrintbed;
        public System.Windows.Forms.CheckBox showEdges;
        public System.Windows.Forms.CheckBox enableLight4;
        public System.Windows.Forms.CheckBox enableLight3;
        public System.Windows.Forms.CheckBox enableLight2;
        public System.Windows.Forms.CheckBox enableLight1;
        public System.Windows.Forms.Panel edges;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textWidthOverThickness;
        private System.Windows.Forms.TextBox textLayerHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboFilamentVisualization;
        private System.Windows.Forms.TextBox textDiameter;
        private System.Windows.Forms.RadioButton radioDiameter;
        private System.Windows.Forms.RadioButton radioHeight;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textHotFilamentLength;
        public System.Windows.Forms.Panel hotFilament;
        public System.Windows.Forms.CheckBox checkDisableFilamentVisualization;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox comboDrawMethod;
    }
}