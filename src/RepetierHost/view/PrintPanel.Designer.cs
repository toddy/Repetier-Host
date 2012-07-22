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
            this.buttonJobStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textGCode = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.buttonHomeX = new System.Windows.Forms.Button();
            this.buttonXM100 = new System.Windows.Forms.Button();
            this.buttonXM10 = new System.Windows.Forms.Button();
            this.buttonXM1 = new System.Windows.Forms.Button();
            this.buttonXM01 = new System.Windows.Forms.Button();
            this.buttonXP01 = new System.Windows.Forms.Button();
            this.buttonXP1 = new System.Windows.Forms.Button();
            this.buttonXP10 = new System.Windows.Forms.Button();
            this.buttonXP100 = new System.Windows.Forms.Button();
            this.buttonYP100 = new System.Windows.Forms.Button();
            this.buttonYP10 = new System.Windows.Forms.Button();
            this.buttonYP1 = new System.Windows.Forms.Button();
            this.buttonYP01 = new System.Windows.Forms.Button();
            this.buttonYM01 = new System.Windows.Forms.Button();
            this.buttonYM1 = new System.Windows.Forms.Button();
            this.buttonYM10 = new System.Windows.Forms.Button();
            this.buttonYM100 = new System.Windows.Forms.Button();
            this.buttonHomeY = new System.Windows.Forms.Button();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonZP100 = new System.Windows.Forms.Button();
            this.buttonZP10 = new System.Windows.Forms.Button();
            this.buttonZP1 = new System.Windows.Forms.Button();
            this.buttonZP01 = new System.Windows.Forms.Button();
            this.buttonZM01 = new System.Windows.Forms.Button();
            this.buttonZM1 = new System.Windows.Forms.Button();
            this.buttonZM10 = new System.Windows.Forms.Button();
            this.buttonZM100 = new System.Windows.Forms.Button();
            this.buttonHomeZ = new System.Windows.Forms.Button();
            this.labelZ = new System.Windows.Forms.Label();
            this.buttonHomeAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownExtruder = new System.Windows.Forms.NumericUpDown();
            this.textRetractAmount = new System.Windows.Forms.TextBox();
            this.textExtrudeAmount = new System.Windows.Forms.TextBox();
            this.textExtrudeSpeed = new System.Windows.Forms.TextBox();
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
            this.labelVoltage = new System.Windows.Forms.Label();
            this.trackFanVoltage = new System.Windows.Forms.TrackBar();
            this.switchFanOn = new RepetierHost.view.SwitchButton();
            this.buttonGoDisposeArea = new System.Windows.Forms.Button();
            this.buttonSimulateOK = new System.Windows.Forms.Button();
            this.buttonStopMotor = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sliderSpeed = new MB.Controls.ColorSlider();
            this.switchDryRun = new RepetierHost.view.SwitchButton();
            this.switchErrors = new RepetierHost.view.SwitchButton();
            this.switchInfo = new RepetierHost.view.SwitchButton();
            this.switchEcho = new RepetierHost.view.SwitchButton();
            this.switchPower = new RepetierHost.view.SwitchButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtruder)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrintBed)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackFanVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonJobStatus
            // 
            this.buttonJobStatus.Location = new System.Drawing.Point(324, 58);
            this.buttonJobStatus.Name = "buttonJobStatus";
            this.buttonJobStatus.Size = new System.Drawing.Size(100, 23);
            this.buttonJobStatus.TabIndex = 3;
            this.buttonJobStatus.Text = "Job status";
            this.buttonJobStatus.UseVisualStyleBackColor = true;
            this.buttonJobStatus.Click += new System.EventHandler(this.buttonJobStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "GCode:";
            // 
            // textGCode
            // 
            this.textGCode.Location = new System.Drawing.Point(54, 118);
            this.textGCode.Name = "textGCode";
            this.textGCode.Size = new System.Drawing.Size(305, 20);
            this.textGCode.TabIndex = 8;
            this.textGCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textGCode_KeyDown);
            this.textGCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textGCode_KeyPress);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(365, 118);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(59, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.ForeColor = System.Drawing.Color.Red;
            this.labelX.Location = new System.Drawing.Point(4, 152);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(35, 13);
            this.labelX.TabIndex = 10;
            this.labelX.Text = "X=0.0";
            // 
            // buttonHomeX
            // 
            this.buttonHomeX.FlatAppearance.BorderSize = 0;
            this.buttonHomeX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomeX.Location = new System.Drawing.Point(63, 147);
            this.buttonHomeX.Name = "buttonHomeX";
            this.buttonHomeX.Size = new System.Drawing.Size(45, 23);
            this.buttonHomeX.TabIndex = 10;
            this.buttonHomeX.Text = "Home";
            this.buttonHomeX.UseVisualStyleBackColor = true;
            this.buttonHomeX.Click += new System.EventHandler(this.buttonHomeX_Click);
            // 
            // buttonXM100
            // 
            this.buttonXM100.Location = new System.Drawing.Point(114, 147);
            this.buttonXM100.Name = "buttonXM100";
            this.buttonXM100.Size = new System.Drawing.Size(36, 23);
            this.buttonXM100.TabIndex = 11;
            this.buttonXM100.Text = "-100";
            this.buttonXM100.UseVisualStyleBackColor = true;
            this.buttonXM100.Click += new System.EventHandler(this.buttonXM100_Click);
            // 
            // buttonXM10
            // 
            this.buttonXM10.Location = new System.Drawing.Point(156, 147);
            this.buttonXM10.Name = "buttonXM10";
            this.buttonXM10.Size = new System.Drawing.Size(30, 23);
            this.buttonXM10.TabIndex = 12;
            this.buttonXM10.Text = "-10";
            this.buttonXM10.UseVisualStyleBackColor = true;
            this.buttonXM10.Click += new System.EventHandler(this.buttonXM10_Click);
            // 
            // buttonXM1
            // 
            this.buttonXM1.Location = new System.Drawing.Point(192, 147);
            this.buttonXM1.Name = "buttonXM1";
            this.buttonXM1.Size = new System.Drawing.Size(24, 23);
            this.buttonXM1.TabIndex = 13;
            this.buttonXM1.Text = "-1";
            this.buttonXM1.UseVisualStyleBackColor = true;
            this.buttonXM1.Click += new System.EventHandler(this.buttonXM1_Click);
            // 
            // buttonXM01
            // 
            this.buttonXM01.Location = new System.Drawing.Point(222, 147);
            this.buttonXM01.Name = "buttonXM01";
            this.buttonXM01.Size = new System.Drawing.Size(36, 23);
            this.buttonXM01.TabIndex = 14;
            this.buttonXM01.Text = "-0.1";
            this.buttonXM01.UseVisualStyleBackColor = true;
            this.buttonXM01.Click += new System.EventHandler(this.buttonXM01_Click);
            // 
            // buttonXP01
            // 
            this.buttonXP01.Location = new System.Drawing.Point(264, 147);
            this.buttonXP01.Name = "buttonXP01";
            this.buttonXP01.Size = new System.Drawing.Size(36, 23);
            this.buttonXP01.TabIndex = 15;
            this.buttonXP01.Text = "+0.1";
            this.buttonXP01.UseVisualStyleBackColor = true;
            this.buttonXP01.Click += new System.EventHandler(this.buttonXP01_Click);
            // 
            // buttonXP1
            // 
            this.buttonXP1.Location = new System.Drawing.Point(306, 147);
            this.buttonXP1.Name = "buttonXP1";
            this.buttonXP1.Size = new System.Drawing.Size(28, 23);
            this.buttonXP1.TabIndex = 16;
            this.buttonXP1.Text = "+1";
            this.buttonXP1.UseVisualStyleBackColor = true;
            this.buttonXP1.Click += new System.EventHandler(this.buttonXP1_Click);
            // 
            // buttonXP10
            // 
            this.buttonXP10.Location = new System.Drawing.Point(340, 147);
            this.buttonXP10.Name = "buttonXP10";
            this.buttonXP10.Size = new System.Drawing.Size(36, 23);
            this.buttonXP10.TabIndex = 17;
            this.buttonXP10.Text = "+10";
            this.buttonXP10.UseVisualStyleBackColor = true;
            this.buttonXP10.Click += new System.EventHandler(this.buttonXP10_Click);
            // 
            // buttonXP100
            // 
            this.buttonXP100.Location = new System.Drawing.Point(382, 147);
            this.buttonXP100.Name = "buttonXP100";
            this.buttonXP100.Size = new System.Drawing.Size(43, 23);
            this.buttonXP100.TabIndex = 18;
            this.buttonXP100.Text = "+100";
            this.buttonXP100.UseVisualStyleBackColor = true;
            this.buttonXP100.Click += new System.EventHandler(this.buttonXP100_Click);
            // 
            // buttonYP100
            // 
            this.buttonYP100.Location = new System.Drawing.Point(382, 176);
            this.buttonYP100.Name = "buttonYP100";
            this.buttonYP100.Size = new System.Drawing.Size(43, 23);
            this.buttonYP100.TabIndex = 27;
            this.buttonYP100.Text = "+100";
            this.buttonYP100.UseVisualStyleBackColor = true;
            this.buttonYP100.Click += new System.EventHandler(this.buttonYP100_Click);
            // 
            // buttonYP10
            // 
            this.buttonYP10.Location = new System.Drawing.Point(340, 176);
            this.buttonYP10.Name = "buttonYP10";
            this.buttonYP10.Size = new System.Drawing.Size(36, 23);
            this.buttonYP10.TabIndex = 26;
            this.buttonYP10.Text = "+10";
            this.buttonYP10.UseVisualStyleBackColor = true;
            this.buttonYP10.Click += new System.EventHandler(this.buttonYP10_Click);
            // 
            // buttonYP1
            // 
            this.buttonYP1.Location = new System.Drawing.Point(306, 176);
            this.buttonYP1.Name = "buttonYP1";
            this.buttonYP1.Size = new System.Drawing.Size(28, 23);
            this.buttonYP1.TabIndex = 25;
            this.buttonYP1.Text = "+1";
            this.buttonYP1.UseVisualStyleBackColor = true;
            this.buttonYP1.Click += new System.EventHandler(this.buttonYP1_Click);
            // 
            // buttonYP01
            // 
            this.buttonYP01.Location = new System.Drawing.Point(264, 176);
            this.buttonYP01.Name = "buttonYP01";
            this.buttonYP01.Size = new System.Drawing.Size(36, 23);
            this.buttonYP01.TabIndex = 24;
            this.buttonYP01.Text = "+0.1";
            this.buttonYP01.UseVisualStyleBackColor = true;
            this.buttonYP01.Click += new System.EventHandler(this.buttonYP01_Click);
            // 
            // buttonYM01
            // 
            this.buttonYM01.Location = new System.Drawing.Point(222, 176);
            this.buttonYM01.Name = "buttonYM01";
            this.buttonYM01.Size = new System.Drawing.Size(36, 23);
            this.buttonYM01.TabIndex = 23;
            this.buttonYM01.Text = "-0.1";
            this.buttonYM01.UseVisualStyleBackColor = true;
            this.buttonYM01.Click += new System.EventHandler(this.buttonYM01_Click);
            // 
            // buttonYM1
            // 
            this.buttonYM1.Location = new System.Drawing.Point(192, 176);
            this.buttonYM1.Name = "buttonYM1";
            this.buttonYM1.Size = new System.Drawing.Size(24, 23);
            this.buttonYM1.TabIndex = 22;
            this.buttonYM1.Text = "-1";
            this.buttonYM1.UseVisualStyleBackColor = true;
            this.buttonYM1.Click += new System.EventHandler(this.buttonYM1_Click);
            // 
            // buttonYM10
            // 
            this.buttonYM10.Location = new System.Drawing.Point(156, 176);
            this.buttonYM10.Name = "buttonYM10";
            this.buttonYM10.Size = new System.Drawing.Size(30, 23);
            this.buttonYM10.TabIndex = 21;
            this.buttonYM10.Text = "-10";
            this.buttonYM10.UseVisualStyleBackColor = true;
            this.buttonYM10.Click += new System.EventHandler(this.buttonYM10_Click);
            // 
            // buttonYM100
            // 
            this.buttonYM100.Location = new System.Drawing.Point(114, 176);
            this.buttonYM100.Name = "buttonYM100";
            this.buttonYM100.Size = new System.Drawing.Size(36, 23);
            this.buttonYM100.TabIndex = 20;
            this.buttonYM100.Text = "-100";
            this.buttonYM100.UseVisualStyleBackColor = true;
            this.buttonYM100.Click += new System.EventHandler(this.buttonYM100_Click);
            // 
            // buttonHomeY
            // 
            this.buttonHomeY.Location = new System.Drawing.Point(63, 176);
            this.buttonHomeY.Name = "buttonHomeY";
            this.buttonHomeY.Size = new System.Drawing.Size(45, 23);
            this.buttonHomeY.TabIndex = 19;
            this.buttonHomeY.Text = "Home";
            this.buttonHomeY.UseVisualStyleBackColor = true;
            this.buttonHomeY.Click += new System.EventHandler(this.buttonHomeY_Click);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.ForeColor = System.Drawing.Color.Red;
            this.labelY.Location = new System.Drawing.Point(4, 181);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(35, 13);
            this.labelY.TabIndex = 20;
            this.labelY.Text = "Y=0.0";
            // 
            // buttonZP100
            // 
            this.buttonZP100.Location = new System.Drawing.Point(382, 205);
            this.buttonZP100.Name = "buttonZP100";
            this.buttonZP100.Size = new System.Drawing.Size(43, 23);
            this.buttonZP100.TabIndex = 36;
            this.buttonZP100.Text = "+100";
            this.buttonZP100.UseVisualStyleBackColor = true;
            this.buttonZP100.Click += new System.EventHandler(this.buttonZP100_Click);
            // 
            // buttonZP10
            // 
            this.buttonZP10.Location = new System.Drawing.Point(340, 205);
            this.buttonZP10.Name = "buttonZP10";
            this.buttonZP10.Size = new System.Drawing.Size(36, 23);
            this.buttonZP10.TabIndex = 35;
            this.buttonZP10.Text = "+10";
            this.buttonZP10.UseVisualStyleBackColor = true;
            this.buttonZP10.Click += new System.EventHandler(this.buttonZP10_Click);
            // 
            // buttonZP1
            // 
            this.buttonZP1.Location = new System.Drawing.Point(306, 205);
            this.buttonZP1.Name = "buttonZP1";
            this.buttonZP1.Size = new System.Drawing.Size(28, 23);
            this.buttonZP1.TabIndex = 34;
            this.buttonZP1.Text = "+1";
            this.buttonZP1.UseVisualStyleBackColor = true;
            this.buttonZP1.Click += new System.EventHandler(this.buttonZP1_Click);
            // 
            // buttonZP01
            // 
            this.buttonZP01.Location = new System.Drawing.Point(264, 205);
            this.buttonZP01.Name = "buttonZP01";
            this.buttonZP01.Size = new System.Drawing.Size(36, 23);
            this.buttonZP01.TabIndex = 33;
            this.buttonZP01.Text = "+0.1";
            this.buttonZP01.UseVisualStyleBackColor = true;
            this.buttonZP01.Click += new System.EventHandler(this.buttonZP01_Click);
            // 
            // buttonZM01
            // 
            this.buttonZM01.Location = new System.Drawing.Point(222, 205);
            this.buttonZM01.Name = "buttonZM01";
            this.buttonZM01.Size = new System.Drawing.Size(36, 23);
            this.buttonZM01.TabIndex = 32;
            this.buttonZM01.Text = "-0.1";
            this.buttonZM01.UseVisualStyleBackColor = true;
            this.buttonZM01.Click += new System.EventHandler(this.buttonZM01_Click);
            // 
            // buttonZM1
            // 
            this.buttonZM1.Location = new System.Drawing.Point(192, 205);
            this.buttonZM1.Name = "buttonZM1";
            this.buttonZM1.Size = new System.Drawing.Size(24, 23);
            this.buttonZM1.TabIndex = 31;
            this.buttonZM1.Text = "-1";
            this.buttonZM1.UseVisualStyleBackColor = true;
            this.buttonZM1.Click += new System.EventHandler(this.buttonZM1_Click);
            // 
            // buttonZM10
            // 
            this.buttonZM10.Location = new System.Drawing.Point(156, 205);
            this.buttonZM10.Name = "buttonZM10";
            this.buttonZM10.Size = new System.Drawing.Size(30, 23);
            this.buttonZM10.TabIndex = 30;
            this.buttonZM10.Text = "-10";
            this.buttonZM10.UseVisualStyleBackColor = true;
            this.buttonZM10.Click += new System.EventHandler(this.buttonZM10_Click);
            // 
            // buttonZM100
            // 
            this.buttonZM100.Location = new System.Drawing.Point(114, 205);
            this.buttonZM100.Name = "buttonZM100";
            this.buttonZM100.Size = new System.Drawing.Size(36, 23);
            this.buttonZM100.TabIndex = 29;
            this.buttonZM100.Text = "-100";
            this.buttonZM100.UseVisualStyleBackColor = true;
            this.buttonZM100.Click += new System.EventHandler(this.buttonZM100_Click);
            // 
            // buttonHomeZ
            // 
            this.buttonHomeZ.Location = new System.Drawing.Point(63, 205);
            this.buttonHomeZ.Name = "buttonHomeZ";
            this.buttonHomeZ.Size = new System.Drawing.Size(45, 23);
            this.buttonHomeZ.TabIndex = 28;
            this.buttonHomeZ.Text = "Home";
            this.buttonHomeZ.UseVisualStyleBackColor = true;
            this.buttonHomeZ.Click += new System.EventHandler(this.buttonHomeZ_Click);
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.ForeColor = System.Drawing.Color.Red;
            this.labelZ.Location = new System.Drawing.Point(4, 210);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(35, 13);
            this.labelZ.TabIndex = 30;
            this.labelZ.Text = "Z=0.0";
            // 
            // buttonHomeAll
            // 
            this.buttonHomeAll.Location = new System.Drawing.Point(7, 234);
            this.buttonHomeAll.Name = "buttonHomeAll";
            this.buttonHomeAll.Size = new System.Drawing.Size(75, 23);
            this.buttonHomeAll.TabIndex = 37;
            this.buttonHomeAll.Text = "Home all";
            this.buttonHomeAll.UseVisualStyleBackColor = true;
            this.buttonHomeAll.Click += new System.EventHandler(this.buttonHomeAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownExtruder);
            this.groupBox1.Controls.Add(this.textRetractAmount);
            this.groupBox1.Controls.Add(this.textExtrudeAmount);
            this.groupBox1.Controls.Add(this.textExtrudeSpeed);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonRetract);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonExtrude);
            this.groupBox1.Controls.Add(this.labelExtruderTemp);
            this.groupBox1.Controls.Add(this.switchExtruderHeatOn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 99);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extruder";
            // 
            // numericUpDownExtruder
            // 
            this.numericUpDownExtruder.Location = new System.Drawing.Point(227, 23);
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
            // textRetractAmount
            // 
            this.textRetractAmount.Location = new System.Drawing.Point(261, 66);
            this.textRetractAmount.Name = "textRetractAmount";
            this.textRetractAmount.Size = new System.Drawing.Size(66, 20);
            this.textRetractAmount.TabIndex = 13;
            this.textRetractAmount.Text = "3";
            this.textRetractAmount.TextChanged += new System.EventHandler(this.textRetractAmount_TextChanged);
            this.textRetractAmount.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // textExtrudeAmount
            // 
            this.textExtrudeAmount.Location = new System.Drawing.Point(104, 66);
            this.textExtrudeAmount.Name = "textExtrudeAmount";
            this.textExtrudeAmount.Size = new System.Drawing.Size(66, 20);
            this.textExtrudeAmount.TabIndex = 13;
            this.textExtrudeAmount.Text = "10";
            this.textExtrudeAmount.TextChanged += new System.EventHandler(this.textExtrudeAmount_TextChanged);
            this.textExtrudeAmount.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // textExtrudeSpeed
            // 
            this.textExtrudeSpeed.Location = new System.Drawing.Point(15, 66);
            this.textExtrudeSpeed.Name = "textExtrudeSpeed";
            this.textExtrudeSpeed.Size = new System.Drawing.Size(66, 20);
            this.textExtrudeSpeed.TabIndex = 13;
            this.textExtrudeSpeed.Text = "10";
            this.textExtrudeSpeed.TextChanged += new System.EventHandler(this.textExtrudeSpeed_TextChanged);
            this.textExtrudeSpeed.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Retract [mm]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Extrude [mm]";
            // 
            // buttonRetract
            // 
            this.buttonRetract.Location = new System.Drawing.Point(336, 66);
            this.buttonRetract.Name = "buttonRetract";
            this.buttonRetract.Size = new System.Drawing.Size(75, 23);
            this.buttonRetract.TabIndex = 6;
            this.buttonRetract.Text = "Retract";
            this.buttonRetract.UseVisualStyleBackColor = true;
            this.buttonRetract.Click += new System.EventHandler(this.buttonRetract_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Speed [mm/min]";
            // 
            // buttonExtrude
            // 
            this.buttonExtrude.Location = new System.Drawing.Point(178, 64);
            this.buttonExtrude.Name = "buttonExtrude";
            this.buttonExtrude.Size = new System.Drawing.Size(74, 23);
            this.buttonExtrude.TabIndex = 6;
            this.buttonExtrude.Text = "Extrude";
            this.buttonExtrude.UseVisualStyleBackColor = true;
            this.buttonExtrude.Click += new System.EventHandler(this.buttonExtrude_Click);
            // 
            // labelExtruderTemp
            // 
            this.labelExtruderTemp.AutoSize = true;
            this.labelExtruderTemp.Location = new System.Drawing.Point(185, 26);
            this.labelExtruderTemp.Name = "labelExtruderTemp";
            this.labelExtruderTemp.Size = new System.Drawing.Size(36, 13);
            this.labelExtruderTemp.TabIndex = 2;
            this.labelExtruderTemp.Text = "200°C";
            // 
            // switchExtruderHeatOn
            // 
            this.switchExtruderHeatOn.Location = new System.Drawing.Point(7, 20);
            this.switchExtruderHeatOn.Name = "switchExtruderHeatOn";
            this.switchExtruderHeatOn.On = false;
            this.switchExtruderHeatOn.Size = new System.Drawing.Size(100, 23);
            this.switchExtruderHeatOn.TabIndex = 0;
            this.switchExtruderHeatOn.TextOff = "Heat on";
            this.switchExtruderHeatOn.TextOn = "Heat on";
            this.switchExtruderHeatOn.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchExtruderHeatOn_Change);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericPrintBed);
            this.groupBox2.Controls.Add(this.labelPrintbedTemp);
            this.groupBox2.Controls.Add(this.switchBedHeat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(8, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 55);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printbed";
            // 
            // numericPrintBed
            // 
            this.numericPrintBed.Location = new System.Drawing.Point(226, 22);
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
            this.labelPrintbedTemp.Location = new System.Drawing.Point(184, 25);
            this.labelPrintbedTemp.Name = "labelPrintbedTemp";
            this.labelPrintbedTemp.Size = new System.Drawing.Size(36, 13);
            this.labelPrintbedTemp.TabIndex = 7;
            this.labelPrintbedTemp.Text = "200°C";
            // 
            // switchBedHeat
            // 
            this.switchBedHeat.Location = new System.Drawing.Point(6, 19);
            this.switchBedHeat.Name = "switchBedHeat";
            this.switchBedHeat.On = false;
            this.switchBedHeat.Size = new System.Drawing.Size(100, 23);
            this.switchBedHeat.TabIndex = 0;
            this.switchBedHeat.TextOff = "Heat on";
            this.switchBedHeat.TextOn = "Heat on";
            this.switchBedHeat.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchBedHeat_Change);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Temperature";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelVoltage);
            this.groupBox3.Controls.Add(this.trackFanVoltage);
            this.groupBox3.Controls.Add(this.switchFanOn);
            this.groupBox3.Location = new System.Drawing.Point(10, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 62);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fan";
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = true;
            this.labelVoltage.Location = new System.Drawing.Point(109, 19);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(39, 13);
            this.labelVoltage.TabIndex = 2;
            this.labelVoltage.Text = "Output";
            // 
            // trackFanVoltage
            // 
            this.trackFanVoltage.BackColor = System.Drawing.SystemColors.Control;
            this.trackFanVoltage.LargeChange = 11;
            this.trackFanVoltage.Location = new System.Drawing.Point(185, 11);
            this.trackFanVoltage.Maximum = 255;
            this.trackFanVoltage.Name = "trackFanVoltage";
            this.trackFanVoltage.Size = new System.Drawing.Size(225, 45);
            this.trackFanVoltage.TabIndex = 1;
            this.trackFanVoltage.TickFrequency = 21;
            this.trackFanVoltage.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackFanVoltage.Value = 106;
            this.trackFanVoltage.ValueChanged += new System.EventHandler(this.trackFanVoltage_ValueChanged);
            // 
            // switchFanOn
            // 
            this.switchFanOn.Location = new System.Drawing.Point(6, 19);
            this.switchFanOn.Name = "switchFanOn";
            this.switchFanOn.On = false;
            this.switchFanOn.Size = new System.Drawing.Size(97, 23);
            this.switchFanOn.TabIndex = 0;
            this.switchFanOn.TextOff = "Fan on";
            this.switchFanOn.TextOn = "Fan on";
            this.switchFanOn.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchFanOn_Change);
            // 
            // buttonGoDisposeArea
            // 
            this.buttonGoDisposeArea.Location = new System.Drawing.Point(88, 234);
            this.buttonGoDisposeArea.Name = "buttonGoDisposeArea";
            this.buttonGoDisposeArea.Size = new System.Drawing.Size(84, 23);
            this.buttonGoDisposeArea.TabIndex = 38;
            this.buttonGoDisposeArea.Text = "Go dump area";
            this.buttonGoDisposeArea.UseVisualStyleBackColor = true;
            this.buttonGoDisposeArea.Click += new System.EventHandler(this.buttonGoDisposeArea_Click);
            // 
            // buttonSimulateOK
            // 
            this.buttonSimulateOK.Location = new System.Drawing.Point(217, 58);
            this.buttonSimulateOK.Name = "buttonSimulateOK";
            this.buttonSimulateOK.Size = new System.Drawing.Size(100, 23);
            this.buttonSimulateOK.TabIndex = 2;
            this.buttonSimulateOK.Text = "Simulate OK";
            this.buttonSimulateOK.UseVisualStyleBackColor = true;
            this.buttonSimulateOK.Click += new System.EventHandler(this.buttonSimulateOK_Click);
            // 
            // buttonStopMotor
            // 
            this.buttonStopMotor.Location = new System.Drawing.Point(179, 235);
            this.buttonStopMotor.Name = "buttonStopMotor";
            this.buttonStopMotor.Size = new System.Drawing.Size(75, 23);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Speed Multiply:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(135, 271);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(15, 13);
            this.labelSpeed.TabIndex = 47;
            this.labelSpeed.Text = "%";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(88, 269);
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
            // sliderSpeed
            // 
            this.sliderSpeed.BackColor = System.Drawing.Color.Transparent;
            this.sliderSpeed.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.sliderSpeed.LargeChange = ((uint)(5u));
            this.sliderSpeed.Location = new System.Drawing.Point(140, 264);
            this.sliderSpeed.Maximum = 300;
            this.sliderSpeed.Minimum = 25;
            this.sliderSpeed.Name = "sliderSpeed";
            this.sliderSpeed.Size = new System.Drawing.Size(278, 30);
            this.sliderSpeed.SmallChange = ((uint)(1u));
            this.sliderSpeed.TabIndex = 45;
            this.sliderSpeed.Text = "sliderSpeed";
            this.sliderSpeed.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.sliderSpeed.Value = 100;
            this.sliderSpeed.ValueChanged += new System.EventHandler(this.sliderSpeed_ValueChanged);
            // 
            // switchDryRun
            // 
            this.switchDryRun.Location = new System.Drawing.Point(324, 89);
            this.switchDryRun.Name = "switchDryRun";
            this.switchDryRun.On = false;
            this.switchDryRun.Size = new System.Drawing.Size(100, 23);
            this.switchDryRun.TabIndex = 7;
            this.switchDryRun.TextOff = "Dry run";
            this.switchDryRun.TextOn = "Dry run";
            this.switchDryRun.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchDryRun_Change);
            // 
            // switchErrors
            // 
            this.switchErrors.Location = new System.Drawing.Point(217, 89);
            this.switchErrors.Name = "switchErrors";
            this.switchErrors.On = true;
            this.switchErrors.Size = new System.Drawing.Size(100, 23);
            this.switchErrors.TabIndex = 6;
            this.switchErrors.TextOff = "Errors";
            this.switchErrors.TextOn = "Errors";
            this.switchErrors.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchErrors_Change);
            // 
            // switchInfo
            // 
            this.switchInfo.Location = new System.Drawing.Point(110, 88);
            this.switchInfo.Name = "switchInfo";
            this.switchInfo.On = true;
            this.switchInfo.Size = new System.Drawing.Size(100, 23);
            this.switchInfo.TabIndex = 5;
            this.switchInfo.TextOff = "Info";
            this.switchInfo.TextOn = "Info";
            this.switchInfo.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchInfo_Change);
            // 
            // switchEcho
            // 
            this.switchEcho.Location = new System.Drawing.Point(4, 88);
            this.switchEcho.Name = "switchEcho";
            this.switchEcho.On = false;
            this.switchEcho.Size = new System.Drawing.Size(100, 23);
            this.switchEcho.TabIndex = 4;
            this.switchEcho.TextOff = "Echo";
            this.switchEcho.TextOn = "Echo";
            this.switchEcho.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchEcho_Change);
            // 
            // switchPower
            // 
            this.switchPower.Location = new System.Drawing.Point(110, 58);
            this.switchPower.Name = "switchPower";
            this.switchPower.On = false;
            this.switchPower.Size = new System.Drawing.Size(100, 23);
            this.switchPower.TabIndex = 1;
            this.switchPower.TextOff = "Power on";
            this.switchPower.TextOn = "Power off";
            this.switchPower.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchPower_Change);
            // 
            // PrintPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sliderSpeed);
            this.Controls.Add(this.buttonStopMotor);
            this.Controls.Add(this.buttonSimulateOK);
            this.Controls.Add(this.buttonGoDisposeArea);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHomeAll);
            this.Controls.Add(this.buttonZP100);
            this.Controls.Add(this.buttonZP10);
            this.Controls.Add(this.buttonZP1);
            this.Controls.Add(this.buttonZP01);
            this.Controls.Add(this.buttonZM01);
            this.Controls.Add(this.buttonZM1);
            this.Controls.Add(this.buttonZM10);
            this.Controls.Add(this.buttonZM100);
            this.Controls.Add(this.buttonHomeZ);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.buttonYP100);
            this.Controls.Add(this.buttonYP10);
            this.Controls.Add(this.buttonYP1);
            this.Controls.Add(this.buttonYP01);
            this.Controls.Add(this.buttonYM01);
            this.Controls.Add(this.buttonYM1);
            this.Controls.Add(this.buttonYM10);
            this.Controls.Add(this.buttonYM100);
            this.Controls.Add(this.buttonHomeY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.buttonXP100);
            this.Controls.Add(this.buttonXP10);
            this.Controls.Add(this.buttonXP1);
            this.Controls.Add(this.buttonXP01);
            this.Controls.Add(this.buttonXM01);
            this.Controls.Add(this.buttonXM1);
            this.Controls.Add(this.buttonXM10);
            this.Controls.Add(this.buttonXM100);
            this.Controls.Add(this.buttonHomeX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textGCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchDryRun);
            this.Controls.Add(this.switchErrors);
            this.Controls.Add(this.switchInfo);
            this.Controls.Add(this.switchEcho);
            this.Controls.Add(this.buttonJobStatus);
            this.Controls.Add(this.switchPower);
            this.Name = "PrintPanel";
            this.Size = new System.Drawing.Size(430, 549);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtruder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrintBed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackFanVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SwitchButton switchPower;
        private System.Windows.Forms.Button buttonJobStatus;
        private SwitchButton switchEcho;
        private SwitchButton switchInfo;
        private SwitchButton switchErrors;
        private SwitchButton switchDryRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGCode;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button buttonHomeX;
        private System.Windows.Forms.Button buttonXM100;
        private System.Windows.Forms.Button buttonXM10;
        private System.Windows.Forms.Button buttonXM1;
        private System.Windows.Forms.Button buttonXM01;
        private System.Windows.Forms.Button buttonXP01;
        private System.Windows.Forms.Button buttonXP1;
        private System.Windows.Forms.Button buttonXP10;
        private System.Windows.Forms.Button buttonXP100;
        private System.Windows.Forms.Button buttonYP100;
        private System.Windows.Forms.Button buttonYP10;
        private System.Windows.Forms.Button buttonYP1;
        private System.Windows.Forms.Button buttonYP01;
        private System.Windows.Forms.Button buttonYM01;
        private System.Windows.Forms.Button buttonYM1;
        private System.Windows.Forms.Button buttonYM10;
        private System.Windows.Forms.Button buttonYM100;
        private System.Windows.Forms.Button buttonHomeY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button buttonZP100;
        private System.Windows.Forms.Button buttonZP10;
        private System.Windows.Forms.Button buttonZP1;
        private System.Windows.Forms.Button buttonZP01;
        private System.Windows.Forms.Button buttonZM01;
        private System.Windows.Forms.Button buttonZM1;
        private System.Windows.Forms.Button buttonZM10;
        private System.Windows.Forms.Button buttonZM100;
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
        private System.Windows.Forms.TrackBar trackFanVoltage;
        private SwitchButton switchFanOn;
        private System.Windows.Forms.Button buttonGoDisposeArea;
        private System.Windows.Forms.Button buttonSimulateOK;
        private System.Windows.Forms.Button buttonStopMotor;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textRetractAmount;
        private System.Windows.Forms.TextBox textExtrudeAmount;
        private System.Windows.Forms.TextBox textExtrudeSpeed;
        private System.Windows.Forms.Button buttonRetract;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label3;
        private MB.Controls.ColorSlider sliderSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        public System.Windows.Forms.NumericUpDown numericUpDownExtruder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NumericUpDown numericPrintBed;
    }
}
