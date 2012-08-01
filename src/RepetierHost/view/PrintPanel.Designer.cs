namespace RepetierHost.view
{
    partial class PrintPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.textGCode = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.buttonHomeX = new System.Windows.Forms.Button();
            this.buttonHomeY = new System.Windows.Forms.Button();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonHomeZ = new System.Windows.Forms.Button();
            this.labelZ = new System.Windows.Forms.Label();
            this.buttonHomeAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRetractAmount = new System.Windows.Forms.NumericUpDown();
            this.textExtrudeAmount = new System.Windows.Forms.NumericUpDown();
            this.textExtrudeSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExtruder = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRetract = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExtrude = new System.Windows.Forms.Button();
            this.labelExtruderTemp = new System.Windows.Forms.Label();
            this.switchExtruderHeatOn = new RepetierHost.view.SwitchButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericPrintBed = new System.Windows.Forms.NumericUpDown();
            this.labelPrintbedTemp = new System.Windows.Forms.Label();
            this.switchBedHeat = new RepetierHost.view.SwitchButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackFanVoltage = new MB.Controls.ColorSlider();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.switchFanOn = new RepetierHost.view.SwitchButton();
            this.buttonGoDisposeArea = new System.Windows.Forms.Button();
            this.buttonSimulateOK = new System.Windows.Forms.Button();
            this.buttonStopMotor = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMoveDist = new System.Windows.Forms.Label();
            this.labelZDiff = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.switchEcho = new RepetierHost.view.SwitchButton();
            this.switchInfo = new RepetierHost.view.SwitchButton();
            this.switchErrors = new RepetierHost.view.SwitchButton();
            this.switchDryRun = new RepetierHost.view.SwitchButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sliderSpeed = new MB.Controls.ColorSlider();
            this.arrowButtonXPlus = new RepetierHost.view.utils.ArrowButton();
            this.arrowButtonXMinus = new RepetierHost.view.utils.ArrowButton();
            this.arrowButtonZPlus = new RepetierHost.view.utils.ArrowButton();
            this.arrowButtonZMinus = new RepetierHost.view.utils.ArrowButton();
            this.arrowButtonYPlus = new RepetierHost.view.utils.ArrowButton();
            this.arrowButtonYMinus = new RepetierHost.view.utils.ArrowButton();
            this.switchPower = new RepetierHost.view.SwitchButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRetractAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textExtrudeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textExtrudeSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtruder)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrintBed)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "G-Code:";
            // 
            // textGCode
            // 
            this.textGCode.Location = new System.Drawing.Point(54, 56);
            this.textGCode.Name = "textGCode";
            this.textGCode.Size = new System.Drawing.Size(276, 20);
            this.textGCode.TabIndex = 8;
            this.textGCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textGCode_KeyDown);
            this.textGCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textGCode_KeyPress);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(336, 56);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(83, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.Red;
            this.labelX.Location = new System.Drawing.Point(208, 162);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(45, 17);
            this.labelX.TabIndex = 10;
            this.labelX.Text = "X=0.0";
            // 
            // buttonHomeX
            // 
            this.buttonHomeX.FlatAppearance.BorderSize = 0;
            this.buttonHomeX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomeX.Image = ((System.Drawing.Image)(resources.GetObject("buttonHomeX.Image")));
            this.buttonHomeX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHomeX.Location = new System.Drawing.Point(31, 103);
            this.buttonHomeX.Name = "buttonHomeX";
            this.buttonHomeX.Size = new System.Drawing.Size(60, 41);
            this.buttonHomeX.TabIndex = 10;
            this.buttonHomeX.Text = "X";
            this.buttonHomeX.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonHomeX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHomeX.UseVisualStyleBackColor = true;
            this.buttonHomeX.Click += new System.EventHandler(this.buttonHomeX_Click);
            // 
            // buttonHomeY
            // 
            this.buttonHomeY.FlatAppearance.BorderSize = 0;
            this.buttonHomeY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomeY.Image = ((System.Drawing.Image)(resources.GetObject("buttonHomeY.Image")));
            this.buttonHomeY.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHomeY.Location = new System.Drawing.Point(227, 103);
            this.buttonHomeY.Name = "buttonHomeY";
            this.buttonHomeY.Size = new System.Drawing.Size(60, 41);
            this.buttonHomeY.TabIndex = 19;
            this.buttonHomeY.Text = "Y";
            this.buttonHomeY.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonHomeY.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonHomeY.UseVisualStyleBackColor = true;
            this.buttonHomeY.Click += new System.EventHandler(this.buttonHomeY_Click);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.ForeColor = System.Drawing.Color.Red;
            this.labelY.Location = new System.Drawing.Point(142, 83);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(45, 17);
            this.labelY.TabIndex = 20;
            this.labelY.Text = "Y=0.0";
            // 
            // buttonHomeZ
            // 
            this.buttonHomeZ.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHomeZ.FlatAppearance.BorderSize = 0;
            this.buttonHomeZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomeZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomeZ.Image = ((System.Drawing.Image)(resources.GetObject("buttonHomeZ.Image")));
            this.buttonHomeZ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHomeZ.Location = new System.Drawing.Point(225, 276);
            this.buttonHomeZ.Name = "buttonHomeZ";
            this.buttonHomeZ.Size = new System.Drawing.Size(60, 41);
            this.buttonHomeZ.TabIndex = 28;
            this.buttonHomeZ.Text = "Z";
            this.buttonHomeZ.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonHomeZ.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonHomeZ.UseVisualStyleBackColor = false;
            this.buttonHomeZ.Click += new System.EventHandler(this.buttonHomeZ_Click);
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ.ForeColor = System.Drawing.Color.Red;
            this.labelZ.Location = new System.Drawing.Point(329, 83);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(45, 17);
            this.labelZ.TabIndex = 30;
            this.labelZ.Text = "Z=0.0";
            // 
            // buttonHomeAll
            // 
            this.buttonHomeAll.FlatAppearance.BorderSize = 0;
            this.buttonHomeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomeAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonHomeAll.Image")));
            this.buttonHomeAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHomeAll.Location = new System.Drawing.Point(31, 275);
            this.buttonHomeAll.Name = "buttonHomeAll";
            this.buttonHomeAll.Size = new System.Drawing.Size(60, 41);
            this.buttonHomeAll.TabIndex = 37;
            this.buttonHomeAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHomeAll.UseVisualStyleBackColor = true;
            this.buttonHomeAll.Click += new System.EventHandler(this.buttonHomeAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRetractAmount);
            this.groupBox1.Controls.Add(this.textExtrudeAmount);
            this.groupBox1.Controls.Add(this.textExtrudeSpeed);
            this.groupBox1.Controls.Add(this.numericUpDownExtruder);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonRetract);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonExtrude);
            this.groupBox1.Controls.Add(this.labelExtruderTemp);
            this.groupBox1.Controls.Add(this.switchExtruderHeatOn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 171);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extruder";
            // 
            // textRetractAmount
            // 
            this.textRetractAmount.Location = new System.Drawing.Point(99, 138);
            this.textRetractAmount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.textRetractAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textRetractAmount.Name = "textRetractAmount";
            this.textRetractAmount.Size = new System.Drawing.Size(53, 20);
            this.textRetractAmount.TabIndex = 15;
            this.textRetractAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textRetractAmount.ValueChanged += new System.EventHandler(this.textRetractAmount_TextChanged);
            // 
            // textExtrudeAmount
            // 
            this.textExtrudeAmount.Location = new System.Drawing.Point(99, 111);
            this.textExtrudeAmount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.textExtrudeAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textExtrudeAmount.Name = "textExtrudeAmount";
            this.textExtrudeAmount.Size = new System.Drawing.Size(53, 20);
            this.textExtrudeAmount.TabIndex = 15;
            this.textExtrudeAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textExtrudeAmount.ValueChanged += new System.EventHandler(this.textExtrudeAmount_TextChanged);
            // 
            // textExtrudeSpeed
            // 
            this.textExtrudeSpeed.Location = new System.Drawing.Point(100, 85);
            this.textExtrudeSpeed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.textExtrudeSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textExtrudeSpeed.Name = "textExtrudeSpeed";
            this.textExtrudeSpeed.Size = new System.Drawing.Size(53, 20);
            this.textExtrudeSpeed.TabIndex = 15;
            this.textExtrudeSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textExtrudeSpeed.ValueChanged += new System.EventHandler(this.textExtrudeSpeed_TextChanged);
            // 
            // numericUpDownExtruder
            // 
            this.numericUpDownExtruder.Location = new System.Drawing.Point(99, 49);
            this.numericUpDownExtruder.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownExtruder.Name = "numericUpDownExtruder";
            this.numericUpDownExtruder.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownExtruder.TabIndex = 14;
            this.numericUpDownExtruder.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownExtruder.ValueChanged += new System.EventHandler(this.numericUpDownExtruder_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Retract [mm]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Extrude [mm]";
            // 
            // buttonRetract
            // 
            this.buttonRetract.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetract.Image")));
            this.buttonRetract.Location = new System.Drawing.Point(159, 137);
            this.buttonRetract.Name = "buttonRetract";
            this.buttonRetract.Size = new System.Drawing.Size(50, 23);
            this.buttonRetract.TabIndex = 6;
            this.buttonRetract.UseVisualStyleBackColor = true;
            this.buttonRetract.Click += new System.EventHandler(this.buttonRetract_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Speed [mm/min]";
            // 
            // buttonExtrude
            // 
            this.buttonExtrude.Image = ((System.Drawing.Image)(resources.GetObject("buttonExtrude.Image")));
            this.buttonExtrude.Location = new System.Drawing.Point(161, 108);
            this.buttonExtrude.Name = "buttonExtrude";
            this.buttonExtrude.Size = new System.Drawing.Size(48, 23);
            this.buttonExtrude.TabIndex = 6;
            this.buttonExtrude.UseVisualStyleBackColor = true;
            this.buttonExtrude.Click += new System.EventHandler(this.buttonExtrude_Click);
            // 
            // labelExtruderTemp
            // 
            this.labelExtruderTemp.AutoSize = true;
            this.labelExtruderTemp.Location = new System.Drawing.Point(51, 51);
            this.labelExtruderTemp.Name = "labelExtruderTemp";
            this.labelExtruderTemp.Size = new System.Drawing.Size(44, 13);
            this.labelExtruderTemp.TabIndex = 2;
            this.labelExtruderTemp.Text = "200°C /";
            // 
            // switchExtruderHeatOn
            // 
            this.switchExtruderHeatOn.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchExtruderHeatOn.ButtonFlatBorderSize = 1;
            this.switchExtruderHeatOn.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.switchExtruderHeatOn.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switchExtruderHeatOn.Location = new System.Drawing.Point(7, 20);
            this.switchExtruderHeatOn.Name = "switchExtruderHeatOn";
            this.switchExtruderHeatOn.On = false;
            this.switchExtruderHeatOn.Size = new System.Drawing.Size(100, 23);
            this.switchExtruderHeatOn.TabIndex = 0;
            this.switchExtruderHeatOn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchExtruderHeatOn.TextOff = "  Heat extruder ";
            this.switchExtruderHeatOn.TextOn = "  Heat extruder ";
            this.switchExtruderHeatOn.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchExtruderHeatOn_Change);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temp.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericPrintBed);
            this.groupBox2.Controls.Add(this.labelPrintbedTemp);
            this.groupBox2.Controls.Add(this.switchBedHeat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(227, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 79);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printbed";
            // 
            // numericPrintBed
            // 
            this.numericPrintBed.Location = new System.Drawing.Point(96, 49);
            this.numericPrintBed.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericPrintBed.Name = "numericPrintBed";
            this.numericPrintBed.Size = new System.Drawing.Size(54, 20);
            this.numericPrintBed.TabIndex = 8;
            this.numericPrintBed.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.numericPrintBed.ValueChanged += new System.EventHandler(this.numericPrintBed_ValueChanged);
            // 
            // labelPrintbedTemp
            // 
            this.labelPrintbedTemp.AutoSize = true;
            this.labelPrintbedTemp.Location = new System.Drawing.Point(49, 52);
            this.labelPrintbedTemp.Name = "labelPrintbedTemp";
            this.labelPrintbedTemp.Size = new System.Drawing.Size(44, 13);
            this.labelPrintbedTemp.TabIndex = 7;
            this.labelPrintbedTemp.Text = "200°C /";
            // 
            // switchBedHeat
            // 
            this.switchBedHeat.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchBedHeat.ButtonFlatBorderSize = 1;
            this.switchBedHeat.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.switchBedHeat.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switchBedHeat.Location = new System.Drawing.Point(6, 19);
            this.switchBedHeat.Name = "switchBedHeat";
            this.switchBedHeat.On = false;
            this.switchBedHeat.Size = new System.Drawing.Size(100, 23);
            this.switchBedHeat.TabIndex = 0;
            this.switchBedHeat.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchBedHeat.TextOff = "Heat printbed ";
            this.switchBedHeat.TextOn = "Heat printbed ";
            this.switchBedHeat.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchBedHeat_Change);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Temp.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackFanVoltage);
            this.groupBox3.Controls.Add(this.labelVoltage);
            this.groupBox3.Controls.Add(this.switchFanOn);
            this.groupBox3.Location = new System.Drawing.Point(227, 507);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 87);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fan";
            // 
            // trackFanVoltage
            // 
            this.trackFanVoltage.BackColor = System.Drawing.Color.Transparent;
            this.trackFanVoltage.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.trackFanVoltage.BarOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.trackFanVoltage.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.trackFanVoltage.LargeChange = ((uint)(5u));
            this.trackFanVoltage.Location = new System.Drawing.Point(9, 48);
            this.trackFanVoltage.Maximum = 255;
            this.trackFanVoltage.Name = "trackFanVoltage";
            this.trackFanVoltage.Size = new System.Drawing.Size(182, 30);
            this.trackFanVoltage.SmallChange = ((uint)(1u));
            this.trackFanVoltage.TabIndex = 3;
            this.trackFanVoltage.Text = "trackFanVoltage";
            this.trackFanVoltage.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.trackFanVoltage.Value = 128;
            this.trackFanVoltage.ValueChanged += new System.EventHandler(this.trackFanVoltage_ValueChanged);
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = true;
            this.labelVoltage.Location = new System.Drawing.Point(111, 24);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(39, 13);
            this.labelVoltage.TabIndex = 2;
            this.labelVoltage.Text = "Output";
            // 
            // switchFanOn
            // 
            this.switchFanOn.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchFanOn.ButtonFlatBorderSize = 1;
            this.switchFanOn.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.switchFanOn.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switchFanOn.Location = new System.Drawing.Point(6, 19);
            this.switchFanOn.Name = "switchFanOn";
            this.switchFanOn.On = false;
            this.switchFanOn.Size = new System.Drawing.Size(97, 23);
            this.switchFanOn.TabIndex = 0;
            this.switchFanOn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchFanOn.TextOff = "Fan";
            this.switchFanOn.TextOn = "Fan";
            this.switchFanOn.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchFanOn_Change);
            // 
            // buttonGoDisposeArea
            // 
            this.buttonGoDisposeArea.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonGoDisposeArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoDisposeArea.Location = new System.Drawing.Point(335, 330);
            this.buttonGoDisposeArea.Name = "buttonGoDisposeArea";
            this.buttonGoDisposeArea.Size = new System.Drawing.Size(84, 23);
            this.buttonGoDisposeArea.TabIndex = 38;
            this.buttonGoDisposeArea.Text = "Park";
            this.buttonGoDisposeArea.UseVisualStyleBackColor = true;
            this.buttonGoDisposeArea.Click += new System.EventHandler(this.buttonGoDisposeArea_Click);
            // 
            // buttonSimulateOK
            // 
            this.buttonSimulateOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSimulateOK.Location = new System.Drawing.Point(372, 19);
            this.buttonSimulateOK.Name = "buttonSimulateOK";
            this.buttonSimulateOK.Size = new System.Drawing.Size(33, 23);
            this.buttonSimulateOK.TabIndex = 2;
            this.buttonSimulateOK.Text = "OK";
            this.buttonSimulateOK.UseVisualStyleBackColor = true;
            this.buttonSimulateOK.Click += new System.EventHandler(this.buttonSimulateOK_Click);
            // 
            // buttonStopMotor
            // 
            this.buttonStopMotor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonStopMotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopMotor.Location = new System.Drawing.Point(246, 330);
            this.buttonStopMotor.Name = "buttonStopMotor";
            this.buttonStopMotor.Size = new System.Drawing.Size(84, 23);
            this.buttonStopMotor.TabIndex = 44;
            this.buttonStopMotor.Text = "Stop motor";
            this.buttonStopMotor.UseVisualStyleBackColor = true;
            this.buttonStopMotor.Click += new System.EventHandler(this.buttonStopMotor_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(142, 292);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(15, 13);
            this.labelSpeed.TabIndex = 47;
            this.labelSpeed.Text = "%";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(359, 20);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownSpeed.TabIndex = 48;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.sliderSpeed_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 32);
            this.panel1.TabIndex = 49;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(46, 10);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(166, 23);
            this.labelStatus.TabIndex = 50;
            this.labelStatus.Text = "Disconnected";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelStatus);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 49);
            this.panel2.TabIndex = 51;
            // 
            // labelMoveDist
            // 
            this.labelMoveDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoveDist.Location = new System.Drawing.Point(133, 199);
            this.labelMoveDist.Name = "labelMoveDist";
            this.labelMoveDist.Size = new System.Drawing.Size(69, 16);
            this.labelMoveDist.TabIndex = 53;
            this.labelMoveDist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZDiff
            // 
            this.labelZDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZDiff.Location = new System.Drawing.Point(325, 199);
            this.labelZDiff.Name = "labelZDiff";
            this.labelZDiff.Size = new System.Drawing.Size(64, 16);
            this.labelZDiff.TabIndex = 53;
            this.labelZDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.switchEcho);
            this.groupBox4.Controls.Add(this.switchInfo);
            this.groupBox4.Controls.Add(this.switchErrors);
            this.groupBox4.Controls.Add(this.switchDryRun);
            this.groupBox4.Controls.Add(this.buttonSimulateOK);
            this.groupBox4.Location = new System.Drawing.Point(8, 600);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 50);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Debug options";
            // 
            // switchEcho
            // 
            this.switchEcho.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchEcho.ButtonFlatBorderSize = 1;
            this.switchEcho.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.switchEcho.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchEcho.Location = new System.Drawing.Point(9, 19);
            this.switchEcho.Name = "switchEcho";
            this.switchEcho.On = false;
            this.switchEcho.Size = new System.Drawing.Size(84, 23);
            this.switchEcho.TabIndex = 4;
            this.switchEcho.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchEcho.TextOff = "Echo";
            this.switchEcho.TextOn = "Echo";
            this.switchEcho.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchEcho_Change);
            // 
            // switchInfo
            // 
            this.switchInfo.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchInfo.ButtonFlatBorderSize = 1;
            this.switchInfo.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.switchInfo.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchInfo.Location = new System.Drawing.Point(99, 19);
            this.switchInfo.Name = "switchInfo";
            this.switchInfo.On = true;
            this.switchInfo.Size = new System.Drawing.Size(84, 23);
            this.switchInfo.TabIndex = 5;
            this.switchInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchInfo.TextOff = "Info";
            this.switchInfo.TextOn = "Info";
            this.switchInfo.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchInfo_Change);
            // 
            // switchErrors
            // 
            this.switchErrors.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchErrors.ButtonFlatBorderSize = 1;
            this.switchErrors.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.switchErrors.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchErrors.Location = new System.Drawing.Point(190, 19);
            this.switchErrors.Name = "switchErrors";
            this.switchErrors.On = true;
            this.switchErrors.Size = new System.Drawing.Size(84, 23);
            this.switchErrors.TabIndex = 6;
            this.switchErrors.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchErrors.TextOff = "Errors";
            this.switchErrors.TextOn = "Errors";
            this.switchErrors.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchErrors_Change);
            // 
            // switchDryRun
            // 
            this.switchDryRun.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchDryRun.ButtonFlatBorderSize = 1;
            this.switchDryRun.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.switchDryRun.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchDryRun.Location = new System.Drawing.Point(280, 19);
            this.switchDryRun.Name = "switchDryRun";
            this.switchDryRun.On = false;
            this.switchDryRun.Size = new System.Drawing.Size(84, 23);
            this.switchDryRun.TabIndex = 7;
            this.switchDryRun.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchDryRun.TextOff = "Dry run";
            this.switchDryRun.TextOn = "Dry run";
            this.switchDryRun.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchDryRun_Change);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDownSpeed);
            this.groupBox5.Controls.Add(this.sliderSpeed);
            this.groupBox5.Location = new System.Drawing.Point(8, 362);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(416, 55);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Speed Multiply";
            // 
            // sliderSpeed
            // 
            this.sliderSpeed.BackColor = System.Drawing.Color.Transparent;
            this.sliderSpeed.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.sliderSpeed.BarOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.sliderSpeed.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.sliderSpeed.LargeChange = ((uint)(5u));
            this.sliderSpeed.Location = new System.Drawing.Point(7, 15);
            this.sliderSpeed.Maximum = 300;
            this.sliderSpeed.Minimum = 25;
            this.sliderSpeed.Name = "sliderSpeed";
            this.sliderSpeed.Size = new System.Drawing.Size(346, 31);
            this.sliderSpeed.SmallChange = ((uint)(1u));
            this.sliderSpeed.TabIndex = 45;
            this.sliderSpeed.Text = "sliderSpeed";
            this.sliderSpeed.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.sliderSpeed.Value = 100;
            this.sliderSpeed.ValueChanged += new System.EventHandler(this.sliderSpeed_ValueChanged);
            // 
            // arrowButtonXPlus
            // 
            this.arrowButtonXPlus.ArrowBaseHeight = 0.6F;
            this.arrowButtonXPlus.ArrowHeadWidth = 25;
            this.arrowButtonXPlus.Clicked = false;
            this.arrowButtonXPlus.GradientEndColor = System.Drawing.Color.BurlyWood;
            this.arrowButtonXPlus.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButtonXPlus.HighGradientEndColor = System.Drawing.Color.Sienna;
            this.arrowButtonXPlus.HighGradientStartColor = System.Drawing.Color.LightGray;
            this.arrowButtonXPlus.Location = new System.Drawing.Point(205, 182);
            this.arrowButtonXPlus.Name = "arrowButtonXPlus";
            this.arrowButtonXPlus.PossibleValues = "0.1;1;10;100";
            this.arrowButtonXPlus.Rotation = 0;
            this.arrowButtonXPlus.Size = new System.Drawing.Size(80, 50);
            this.arrowButtonXPlus.TabIndex = 52;
            this.arrowButtonXPlus.Text = "arrowButton1";
            this.arrowButtonXPlus.Title = "+X";
            this.arrowButtonXPlus.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.arrowButtonXPlus.UseVisualStyleBackColor = true;
            this.arrowButtonXPlus.Click += new System.EventHandler(this.arrowButtonXPlus_Click);
            this.arrowButtonXPlus.arrowValueChanged += new RepetierHost.view.utils.ArrowValueChanged(this.XY_arrowValueChanged);
            // 
            // arrowButtonXMinus
            // 
            this.arrowButtonXMinus.ArrowBaseHeight = 0.6F;
            this.arrowButtonXMinus.ArrowHeadWidth = 25;
            this.arrowButtonXMinus.Clicked = false;
            this.arrowButtonXMinus.GradientEndColor = System.Drawing.Color.BurlyWood;
            this.arrowButtonXMinus.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButtonXMinus.HighGradientEndColor = System.Drawing.Color.Sienna;
            this.arrowButtonXMinus.HighGradientStartColor = System.Drawing.Color.LightGray;
            this.arrowButtonXMinus.Location = new System.Drawing.Point(50, 182);
            this.arrowButtonXMinus.Name = "arrowButtonXMinus";
            this.arrowButtonXMinus.PossibleValues = "0.1;1;10;100";
            this.arrowButtonXMinus.Rotation = 180;
            this.arrowButtonXMinus.Size = new System.Drawing.Size(80, 50);
            this.arrowButtonXMinus.TabIndex = 52;
            this.arrowButtonXMinus.Text = "arrowButton1";
            this.arrowButtonXMinus.Title = "-X";
            this.arrowButtonXMinus.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.arrowButtonXMinus.UseVisualStyleBackColor = true;
            this.arrowButtonXMinus.Click += new System.EventHandler(this.arrowButtonXMinus_Click);
            this.arrowButtonXMinus.arrowValueChanged += new RepetierHost.view.utils.ArrowValueChanged(this.XY_arrowValueChanged);
            // 
            // arrowButtonZPlus
            // 
            this.arrowButtonZPlus.ArrowBaseHeight = 0.6F;
            this.arrowButtonZPlus.ArrowHeadWidth = 25;
            this.arrowButtonZPlus.Clicked = false;
            this.arrowButtonZPlus.GradientEndColor = System.Drawing.Color.MediumAquamarine;
            this.arrowButtonZPlus.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButtonZPlus.HighGradientEndColor = System.Drawing.Color.Green;
            this.arrowButtonZPlus.HighGradientStartColor = System.Drawing.Color.LightGray;
            this.arrowButtonZPlus.Location = new System.Drawing.Point(332, 103);
            this.arrowButtonZPlus.Name = "arrowButtonZPlus";
            this.arrowButtonZPlus.PossibleValues = "0.1;1;10";
            this.arrowButtonZPlus.Rotation = 270;
            this.arrowButtonZPlus.Size = new System.Drawing.Size(50, 80);
            this.arrowButtonZPlus.TabIndex = 52;
            this.arrowButtonZPlus.Text = "arrowButton1";
            this.arrowButtonZPlus.Title = "+Z";
            this.arrowButtonZPlus.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.arrowButtonZPlus.UseVisualStyleBackColor = true;
            this.arrowButtonZPlus.Click += new System.EventHandler(this.arrowButtonZPlus_Click);
            this.arrowButtonZPlus.arrowValueChanged += new RepetierHost.view.utils.ArrowValueChanged(this.Z_arrowValueChanged);
            // 
            // arrowButtonZMinus
            // 
            this.arrowButtonZMinus.ArrowBaseHeight = 0.6F;
            this.arrowButtonZMinus.ArrowHeadWidth = 25;
            this.arrowButtonZMinus.Clicked = false;
            this.arrowButtonZMinus.GradientEndColor = System.Drawing.Color.MediumAquamarine;
            this.arrowButtonZMinus.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButtonZMinus.HighGradientEndColor = System.Drawing.Color.Green;
            this.arrowButtonZMinus.HighGradientStartColor = System.Drawing.Color.LightGray;
            this.arrowButtonZMinus.Location = new System.Drawing.Point(332, 237);
            this.arrowButtonZMinus.Name = "arrowButtonZMinus";
            this.arrowButtonZMinus.PossibleValues = "0.1;1;10";
            this.arrowButtonZMinus.Rotation = 90;
            this.arrowButtonZMinus.Size = new System.Drawing.Size(50, 80);
            this.arrowButtonZMinus.TabIndex = 52;
            this.arrowButtonZMinus.Text = "arrowButton1";
            this.arrowButtonZMinus.Title = "-Z";
            this.arrowButtonZMinus.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.arrowButtonZMinus.UseVisualStyleBackColor = true;
            this.arrowButtonZMinus.Click += new System.EventHandler(this.arrowButtonZMinus_Click);
            this.arrowButtonZMinus.arrowValueChanged += new RepetierHost.view.utils.ArrowValueChanged(this.Z_arrowValueChanged);
            // 
            // arrowButtonYPlus
            // 
            this.arrowButtonYPlus.ArrowBaseHeight = 0.6F;
            this.arrowButtonYPlus.ArrowHeadWidth = 25;
            this.arrowButtonYPlus.Clicked = false;
            this.arrowButtonYPlus.GradientEndColor = System.Drawing.Color.SkyBlue;
            this.arrowButtonYPlus.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButtonYPlus.HighGradientEndColor = System.Drawing.Color.RoyalBlue;
            this.arrowButtonYPlus.HighGradientStartColor = System.Drawing.Color.LightGray;
            this.arrowButtonYPlus.Location = new System.Drawing.Point(145, 103);
            this.arrowButtonYPlus.Name = "arrowButtonYPlus";
            this.arrowButtonYPlus.PossibleValues = "0.1;1;10;100";
            this.arrowButtonYPlus.Rotation = 270;
            this.arrowButtonYPlus.Size = new System.Drawing.Size(50, 80);
            this.arrowButtonYPlus.TabIndex = 52;
            this.arrowButtonYPlus.Text = "arrowButton1";
            this.arrowButtonYPlus.Title = "+Y";
            this.arrowButtonYPlus.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.arrowButtonYPlus.UseVisualStyleBackColor = true;
            this.arrowButtonYPlus.Click += new System.EventHandler(this.arrowButtonYPlus_Click);
            this.arrowButtonYPlus.arrowValueChanged += new RepetierHost.view.utils.ArrowValueChanged(this.XY_arrowValueChanged);
            // 
            // arrowButtonYMinus
            // 
            this.arrowButtonYMinus.ArrowBaseHeight = 0.6F;
            this.arrowButtonYMinus.ArrowHeadWidth = 25;
            this.arrowButtonYMinus.Clicked = false;
            this.arrowButtonYMinus.GradientEndColor = System.Drawing.Color.SkyBlue;
            this.arrowButtonYMinus.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.arrowButtonYMinus.HighGradientEndColor = System.Drawing.Color.RoyalBlue;
            this.arrowButtonYMinus.HighGradientStartColor = System.Drawing.Color.LightGray;
            this.arrowButtonYMinus.Location = new System.Drawing.Point(145, 237);
            this.arrowButtonYMinus.Name = "arrowButtonYMinus";
            this.arrowButtonYMinus.PossibleValues = "0.1;1;10;100";
            this.arrowButtonYMinus.Rotation = 90;
            this.arrowButtonYMinus.Size = new System.Drawing.Size(50, 80);
            this.arrowButtonYMinus.TabIndex = 52;
            this.arrowButtonYMinus.Text = "arrowButton1";
            this.arrowButtonYMinus.Title = "-Y";
            this.arrowButtonYMinus.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.arrowButtonYMinus.UseVisualStyleBackColor = true;
            this.arrowButtonYMinus.Click += new System.EventHandler(this.arrowButtonYMinus_Click);
            this.arrowButtonYMinus.arrowValueChanged += new RepetierHost.view.utils.ArrowValueChanged(this.XY_arrowValueChanged);
            // 
            // switchPower
            // 
            this.switchPower.ButtonFlatBorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.switchPower.ButtonFlatBorderSize = 1;
            this.switchPower.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchPower.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchPower.Location = new System.Drawing.Point(8, 330);
            this.switchPower.Name = "switchPower";
            this.switchPower.On = false;
            this.switchPower.Size = new System.Drawing.Size(83, 23);
            this.switchPower.TabIndex = 1;
            this.switchPower.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchPower.TextOff = "  Power";
            this.switchPower.TextOn = "  Power";
            this.switchPower.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchPower_Change);
            // 
            // PrintPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.labelZDiff);
            this.Controls.Add(this.labelMoveDist);
            this.Controls.Add(this.arrowButtonXPlus);
            this.Controls.Add(this.arrowButtonXMinus);
            this.Controls.Add(this.arrowButtonZPlus);
            this.Controls.Add(this.arrowButtonZMinus);
            this.Controls.Add(this.arrowButtonYPlus);
            this.Controls.Add(this.arrowButtonYMinus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.buttonStopMotor);
            this.Controls.Add(this.buttonGoDisposeArea);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHomeAll);
            this.Controls.Add(this.buttonHomeZ);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.buttonHomeY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.buttonHomeX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textGCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchPower);
            this.Name = "PrintPanel";
            this.Size = new System.Drawing.Size(430, 658);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRetractAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textExtrudeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textExtrudeSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtruder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrintBed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SwitchButton switchPower;
        private SwitchButton switchEcho;
        private SwitchButton switchInfo;
        private SwitchButton switchErrors;
        private SwitchButton switchDryRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGCode;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button buttonHomeX;
        private System.Windows.Forms.Button buttonHomeY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button buttonHomeZ;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Button buttonHomeAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelExtruderTemp;
        private SwitchButton switchExtruderHeatOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExtrude;
        private System.Windows.Forms.Label labelPrintbedTemp;
        private SwitchButton switchBedHeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelVoltage;
        private SwitchButton switchFanOn;
        private System.Windows.Forms.Button buttonGoDisposeArea;
        private System.Windows.Forms.Button buttonSimulateOK;
        private System.Windows.Forms.Button buttonStopMotor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRetract;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelSpeed;
        private MB.Controls.ColorSlider sliderSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        public System.Windows.Forms.NumericUpDown numericUpDownExtruder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NumericUpDown numericPrintBed;
        public MB.Controls.ColorSlider trackFanVoltage;
        private RepetierHost.view.utils.ArrowButton arrowButtonYMinus;
        private RepetierHost.view.utils.ArrowButton arrowButtonXPlus;
        private RepetierHost.view.utils.ArrowButton arrowButtonXMinus;
        private RepetierHost.view.utils.ArrowButton arrowButtonYPlus;
        private System.Windows.Forms.Label labelMoveDist;
        private RepetierHost.view.utils.ArrowButton arrowButtonZPlus;
        private RepetierHost.view.utils.ArrowButton arrowButtonZMinus;
        private System.Windows.Forms.Label labelZDiff;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown textExtrudeSpeed;
        private System.Windows.Forms.NumericUpDown textExtrudeAmount;
        private System.Windows.Forms.NumericUpDown textRetractAmount;
    }
}
