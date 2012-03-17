namespace RepetierHost.view
{
    partial class EEPROMMarlin
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EEPROMMarlin));
            this.label1 = new System.Windows.Forms.Label();
            this.xstepsbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ystepsbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zstepsbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.estepsbox = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.xfeedbox = new System.Windows.Forms.TextBox();
            this.yfeedbox = new System.Windows.Forms.TextBox();
            this.zfeedbox = new System.Windows.Forms.TextBox();
            this.efeedbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.maccxbox = new System.Windows.Forms.TextBox();
            this.maccybox = new System.Windows.Forms.TextBox();
            this.macczbox = new System.Windows.Forms.TextBox();
            this.maccebox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mzjerkbox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.maxxyjerkbox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.minsegtbox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.mintfeedbox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.minfeedbox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ppidbox = new System.Windows.Forms.TextBox();
            this.ipidbox = new System.Windows.Forms.TextBox();
            this.dpidbox = new System.Windows.Forms.TextBox();
            this.accbox = new System.Windows.Forms.TextBox();
            this.lable17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.raccbox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steps per mm:";
            // 
            // xstepsbox
            // 
            this.xstepsbox.Location = new System.Drawing.Point(207, 6);
            this.xstepsbox.Name = "xstepsbox";
            this.xstepsbox.Size = new System.Drawing.Size(63, 20);
            this.xstepsbox.TabIndex = 1;
            this.xstepsbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // ystepsbox
            // 
            this.ystepsbox.Location = new System.Drawing.Point(299, 6);
            this.ystepsbox.Name = "ystepsbox";
            this.ystepsbox.Size = new System.Drawing.Size(63, 20);
            this.ystepsbox.TabIndex = 4;
            this.ystepsbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z:";
            // 
            // zstepsbox
            // 
            this.zstepsbox.Location = new System.Drawing.Point(391, 6);
            this.zstepsbox.Name = "zstepsbox";
            this.zstepsbox.Size = new System.Drawing.Size(63, 20);
            this.zstepsbox.TabIndex = 6;
            this.zstepsbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "E:";
            // 
            // estepsbox
            // 
            this.estepsbox.Location = new System.Drawing.Point(483, 6);
            this.estepsbox.Name = "estepsbox";
            this.estepsbox.Size = new System.Drawing.Size(63, 20);
            this.estepsbox.TabIndex = 8;
            this.estepsbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(15, 356);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(95, 22);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Reload Config";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(372, 357);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 22);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save to EEPROM";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(116, 355);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(141, 23);
            this.buttonRestore.TabIndex = 11;
            this.buttonRestore.Text = "Restore factory settings";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(496, 356);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(95, 23);
            this.buttonAbort.TabIndex = 12;
            this.buttonAbort.Text = "Cancel";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Maximum feedrates [mm/s]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Z:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "E:";
            // 
            // xfeedbox
            // 
            this.xfeedbox.Location = new System.Drawing.Point(207, 32);
            this.xfeedbox.Name = "xfeedbox";
            this.xfeedbox.Size = new System.Drawing.Size(63, 20);
            this.xfeedbox.TabIndex = 18;
            this.xfeedbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // yfeedbox
            // 
            this.yfeedbox.Location = new System.Drawing.Point(299, 32);
            this.yfeedbox.Name = "yfeedbox";
            this.yfeedbox.Size = new System.Drawing.Size(63, 20);
            this.yfeedbox.TabIndex = 19;
            this.yfeedbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // zfeedbox
            // 
            this.zfeedbox.Location = new System.Drawing.Point(391, 32);
            this.zfeedbox.Name = "zfeedbox";
            this.zfeedbox.Size = new System.Drawing.Size(63, 20);
            this.zfeedbox.TabIndex = 20;
            this.zfeedbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // efeedbox
            // 
            this.efeedbox.Location = new System.Drawing.Point(483, 32);
            this.efeedbox.Name = "efeedbox";
            this.efeedbox.Size = new System.Drawing.Size(63, 20);
            this.efeedbox.TabIndex = 21;
            this.efeedbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Maximum Acceleration [mm/s²]:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "X:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(276, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Y:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(368, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Z:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(460, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "E:";
            // 
            // maccxbox
            // 
            this.maccxbox.Location = new System.Drawing.Point(207, 58);
            this.maccxbox.Name = "maccxbox";
            this.maccxbox.Size = new System.Drawing.Size(63, 20);
            this.maccxbox.TabIndex = 27;
            this.maccxbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // maccybox
            // 
            this.maccybox.Location = new System.Drawing.Point(299, 58);
            this.maccybox.Name = "maccybox";
            this.maccybox.Size = new System.Drawing.Size(63, 20);
            this.maccybox.TabIndex = 28;
            this.maccybox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // macczbox
            // 
            this.macczbox.Location = new System.Drawing.Point(391, 58);
            this.macczbox.Name = "macczbox";
            this.macczbox.Size = new System.Drawing.Size(63, 20);
            this.macczbox.TabIndex = 29;
            this.macczbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // maccebox
            // 
            this.maccebox.Location = new System.Drawing.Point(483, 58);
            this.maccebox.Name = "maccebox";
            this.maccebox.Size = new System.Drawing.Size(63, 20);
            this.maccebox.TabIndex = 30;
            this.maccebox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.mzjerkbox);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.maxxyjerkbox);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.minsegtbox);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.mintfeedbox);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.minfeedbox);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(15, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 168);
            this.panel2.TabIndex = 36;
            // 
            // mzjerkbox
            // 
            this.mzjerkbox.Location = new System.Drawing.Point(20, 118);
            this.mzjerkbox.Name = "mzjerkbox";
            this.mzjerkbox.Size = new System.Drawing.Size(63, 20);
            this.mzjerkbox.TabIndex = 44;
            this.mzjerkbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 91);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Maximum Z jerk [mm/s]";
            // 
            // maxxyjerkbox
            // 
            this.maxxyjerkbox.Location = new System.Drawing.Point(438, 56);
            this.maxxyjerkbox.Name = "maxxyjerkbox";
            this.maxxyjerkbox.Size = new System.Drawing.Size(63, 20);
            this.maxxyjerkbox.TabIndex = 42;
            this.maxxyjerkbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(420, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Maximum X-Y jerk [mm/s]";
            // 
            // minsegtbox
            // 
            this.minsegtbox.Location = new System.Drawing.Point(285, 56);
            this.minsegtbox.Name = "minsegtbox";
            this.minsegtbox.Size = new System.Drawing.Size(63, 20);
            this.minsegtbox.TabIndex = 40;
            this.minsegtbox.Validating += new System.ComponentModel.CancelEventHandler(this.int_Validating);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(267, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(135, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Minimum segment time [ms]";
            // 
            // mintfeedbox
            // 
            this.mintfeedbox.Location = new System.Drawing.Point(149, 56);
            this.mintfeedbox.Name = "mintfeedbox";
            this.mintfeedbox.Size = new System.Drawing.Size(63, 20);
            this.mintfeedbox.TabIndex = 38;
            this.mintfeedbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(131, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Min travel feedrate [mm/s]";
            // 
            // minfeedbox
            // 
            this.minfeedbox.Location = new System.Drawing.Point(23, 56);
            this.minfeedbox.Name = "minfeedbox";
            this.minfeedbox.Size = new System.Drawing.Size(63, 20);
            this.minfeedbox.TabIndex = 36;
            this.minfeedbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Min feedrate [mm/s]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Advanced variables:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 137);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 37;
            this.label24.Text = "PID settings:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(184, 137);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "P:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(276, 137);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "I:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(364, 137);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(18, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "D:";
            // 
            // ppidbox
            // 
            this.ppidbox.Location = new System.Drawing.Point(207, 136);
            this.ppidbox.Name = "ppidbox";
            this.ppidbox.Size = new System.Drawing.Size(63, 20);
            this.ppidbox.TabIndex = 50;
            this.ppidbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // ipidbox
            // 
            this.ipidbox.Location = new System.Drawing.Point(295, 134);
            this.ipidbox.Name = "ipidbox";
            this.ipidbox.Size = new System.Drawing.Size(63, 20);
            this.ipidbox.TabIndex = 51;
            this.ipidbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // dpidbox
            // 
            this.dpidbox.Location = new System.Drawing.Point(388, 134);
            this.dpidbox.Name = "dpidbox";
            this.dpidbox.Size = new System.Drawing.Size(63, 20);
            this.dpidbox.TabIndex = 52;
            this.dpidbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // accbox
            // 
            this.accbox.Location = new System.Drawing.Point(207, 84);
            this.accbox.Name = "accbox";
            this.accbox.Size = new System.Drawing.Size(63, 20);
            this.accbox.TabIndex = 32;
            this.accbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // lable17
            // 
            this.lable17.AutoSize = true;
            this.lable17.Location = new System.Drawing.Point(12, 113);
            this.lable17.Name = "lable17";
            this.lable17.Size = new System.Drawing.Size(107, 13);
            this.lable17.TabIndex = 33;
            this.lable17.Text = "Retract Acceleration:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Acceleration:";
            // 
            // raccbox
            // 
            this.raccbox.Location = new System.Drawing.Point(207, 110);
            this.raccbox.Name = "raccbox";
            this.raccbox.Size = new System.Drawing.Size(63, 20);
            this.raccbox.TabIndex = 34;
            this.raccbox.Validating += new System.ComponentModel.CancelEventHandler(this.floatPos_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EEPROMMarlin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(615, 408);
            this.ControlBox = false;
            this.Controls.Add(this.raccbox);
            this.Controls.Add(this.dpidbox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ipidbox);
            this.Controls.Add(this.lable17);
            this.Controls.Add(this.ppidbox);
            this.Controls.Add(this.accbox);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.maccebox);
            this.Controls.Add(this.macczbox);
            this.Controls.Add(this.maccybox);
            this.Controls.Add(this.maccxbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.efeedbox);
            this.Controls.Add(this.zfeedbox);
            this.Controls.Add(this.yfeedbox);
            this.Controls.Add(this.xfeedbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.estepsbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zstepsbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ystepsbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xstepsbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EEPROMMarlin";
            this.Text = "Marlin Firmware EEPROM settings";
            this.Activated += new System.EventHandler(this.EEPROMMarlin_Activated);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xstepsbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ystepsbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zstepsbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox estepsbox;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox xfeedbox;
        private System.Windows.Forms.TextBox yfeedbox;
        private System.Windows.Forms.TextBox zfeedbox;
        private System.Windows.Forms.TextBox efeedbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox maccxbox;
        private System.Windows.Forms.TextBox maccybox;
        private System.Windows.Forms.TextBox macczbox;
        private System.Windows.Forms.TextBox maccebox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox minfeedbox;
        private System.Windows.Forms.TextBox mintfeedbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox minsegtbox;
        private System.Windows.Forms.TextBox maxxyjerkbox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox mzjerkbox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox ppidbox;
        private System.Windows.Forms.TextBox ipidbox;
        private System.Windows.Forms.TextBox dpidbox;
        private System.Windows.Forms.TextBox accbox;
        private System.Windows.Forms.Label lable17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox raccbox;
        private System.Windows.Forms.ErrorProvider errorProvider;
       
    }
}