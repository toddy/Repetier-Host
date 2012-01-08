namespace RepetierHost.view
{
    partial class TestGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestGenerator));
            this.label1 = new System.Windows.Forms.Label();
            this.comboTestCase = new System.Windows.Forms.ComboBox();
            this.buttonCreateTestCase = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP3 = new System.Windows.Forms.Label();
            this.textP1 = new System.Windows.Forms.TextBox();
            this.textP2 = new System.Windows.Forms.TextBox();
            this.textP3 = new System.Windows.Forms.TextBox();
            this.labelU1 = new System.Windows.Forms.Label();
            this.labelU2 = new System.Windows.Forms.Label();
            this.labelU3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelP4 = new System.Windows.Forms.Label();
            this.textP4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelU4 = new System.Windows.Forms.Label();
            this.labelU5 = new System.Windows.Forms.Label();
            this.textP5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test case:";
            // 
            // comboTestCase
            // 
            this.comboTestCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTestCase.FormattingEnabled = true;
            this.comboTestCase.Items.AddRange(new object[] {
            "Advance calibration Test 1",
            "Advance calibration Test 2"});
            this.comboTestCase.Location = new System.Drawing.Point(124, 16);
            this.comboTestCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTestCase.Name = "comboTestCase";
            this.comboTestCase.Size = new System.Drawing.Size(259, 24);
            this.comboTestCase.TabIndex = 1;
            this.comboTestCase.SelectedIndexChanged += new System.EventHandler(this.comboTestCase_SelectedIndexChanged);
            // 
            // buttonCreateTestCase
            // 
            this.buttonCreateTestCase.Location = new System.Drawing.Point(76, 215);
            this.buttonCreateTestCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateTestCase.Name = "buttonCreateTestCase";
            this.buttonCreateTestCase.Size = new System.Drawing.Size(165, 28);
            this.buttonCreateTestCase.TabIndex = 2;
            this.buttonCreateTestCase.Text = "Create test case";
            this.buttonCreateTestCase.UseVisualStyleBackColor = true;
            this.buttonCreateTestCase.Click += new System.EventHandler(this.buttonCreateTestCase_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(284, 215);
            this.buttonAbort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(100, 28);
            this.buttonAbort.TabIndex = 3;
            this.buttonAbort.Text = "Cancel";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Location = new System.Drawing.Point(17, 55);
            this.labelP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(80, 17);
            this.labelP1.TabIndex = 4;
            this.labelP1.Text = "Low speed:";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Location = new System.Drawing.Point(17, 87);
            this.labelP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(84, 17);
            this.labelP2.TabIndex = 5;
            this.labelP2.Text = "High speed:";
            // 
            // labelP3
            // 
            this.labelP3.AutoSize = true;
            this.labelP3.Location = new System.Drawing.Point(17, 119);
            this.labelP3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP3.Name = "labelP3";
            this.labelP3.Size = new System.Drawing.Size(90, 17);
            this.labelP3.TabIndex = 6;
            this.labelP3.Text = "Acceleration:";
            // 
            // textP1
            // 
            this.textP1.Location = new System.Drawing.Point(124, 52);
            this.textP1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textP1.Name = "textP1";
            this.textP1.Size = new System.Drawing.Size(132, 22);
            this.textP1.TabIndex = 7;
            this.textP1.Text = "10";
            this.textP1.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textP2
            // 
            this.textP2.Location = new System.Drawing.Point(124, 84);
            this.textP2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textP2.Name = "textP2";
            this.textP2.Size = new System.Drawing.Size(132, 22);
            this.textP2.TabIndex = 8;
            this.textP2.Text = "80";
            this.textP2.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // textP3
            // 
            this.textP3.Location = new System.Drawing.Point(124, 116);
            this.textP3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textP3.Name = "textP3";
            this.textP3.Size = new System.Drawing.Size(132, 22);
            this.textP3.TabIndex = 9;
            this.textP3.Text = "1000";
            this.textP3.Validating += new System.ComponentModel.CancelEventHandler(this.float_Validating);
            // 
            // labelU1
            // 
            this.labelU1.AutoSize = true;
            this.labelU1.Location = new System.Drawing.Point(299, 60);
            this.labelU1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelU1.Name = "labelU1";
            this.labelU1.Size = new System.Drawing.Size(49, 17);
            this.labelU1.TabIndex = 10;
            this.labelU1.Text = "[mm/s]";
            // 
            // labelU2
            // 
            this.labelU2.AutoSize = true;
            this.labelU2.Location = new System.Drawing.Point(299, 87);
            this.labelU2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelU2.Name = "labelU2";
            this.labelU2.Size = new System.Drawing.Size(49, 17);
            this.labelU2.TabIndex = 11;
            this.labelU2.Text = "[mm/s]";
            // 
            // labelU3
            // 
            this.labelU3.AutoSize = true;
            this.labelU3.Location = new System.Drawing.Point(299, 118);
            this.labelU3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelU3.Name = "labelU3";
            this.labelU3.Size = new System.Drawing.Size(54, 17);
            this.labelU3.TabIndex = 12;
            this.labelU3.Text = "[mm/s²]";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelP4
            // 
            this.labelP4.AutoSize = true;
            this.labelP4.Location = new System.Drawing.Point(17, 146);
            this.labelP4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP4.Name = "labelP4";
            this.labelP4.Size = new System.Drawing.Size(68, 17);
            this.labelP4.TabIndex = 13;
            this.labelP4.Text = "Length 1:";
            // 
            // textP4
            // 
            this.textP4.Location = new System.Drawing.Point(124, 143);
            this.textP4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textP4.Name = "textP4";
            this.textP4.Size = new System.Drawing.Size(132, 22);
            this.textP4.TabIndex = 14;
            this.textP4.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Length 2:";
            // 
            // labelU4
            // 
            this.labelU4.AutoSize = true;
            this.labelU4.Location = new System.Drawing.Point(299, 146);
            this.labelU4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelU4.Name = "labelU4";
            this.labelU4.Size = new System.Drawing.Size(38, 17);
            this.labelU4.TabIndex = 16;
            this.labelU4.Text = "[mm]";
            // 
            // labelU5
            // 
            this.labelU5.AutoSize = true;
            this.labelU5.Location = new System.Drawing.Point(299, 180);
            this.labelU5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelU5.Name = "labelU5";
            this.labelU5.Size = new System.Drawing.Size(38, 17);
            this.labelU5.TabIndex = 17;
            this.labelU5.Text = "[mm]";
            // 
            // textP5
            // 
            this.textP5.Location = new System.Drawing.Point(124, 176);
            this.textP5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textP5.Name = "textP5";
            this.textP5.Size = new System.Drawing.Size(132, 22);
            this.textP5.TabIndex = 18;
            this.textP5.Text = "80";
            // 
            // TestGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(413, 260);
            this.ControlBox = false;
            this.Controls.Add(this.textP5);
            this.Controls.Add(this.labelU5);
            this.Controls.Add(this.labelU4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textP4);
            this.Controls.Add(this.labelP4);
            this.Controls.Add(this.labelU3);
            this.Controls.Add(this.labelU2);
            this.Controls.Add(this.labelU1);
            this.Controls.Add(this.textP3);
            this.Controls.Add(this.textP2);
            this.Controls.Add(this.textP1);
            this.Controls.Add(this.labelP3);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonCreateTestCase);
            this.Controls.Add(this.comboTestCase);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestGenerator";
            this.Text = "Test generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestGenerator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTestCase;
        private System.Windows.Forms.Button buttonCreateTestCase;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelP3;
        private System.Windows.Forms.TextBox textP1;
        private System.Windows.Forms.TextBox textP2;
        private System.Windows.Forms.TextBox textP3;
        private System.Windows.Forms.Label labelU1;
        private System.Windows.Forms.Label labelU2;
        private System.Windows.Forms.Label labelU3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textP4;
        private System.Windows.Forms.Label labelP4;
        private System.Windows.Forms.TextBox textP5;
        private System.Windows.Forms.Label labelU5;
        private System.Windows.Forms.Label labelU4;
        private System.Windows.Forms.Label label2;
    }
}