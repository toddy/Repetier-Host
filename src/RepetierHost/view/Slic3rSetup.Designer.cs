namespace RepetierHost.view
{
    partial class Slic3rSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slic3rSetup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxUseBundledVersion = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBrowseIni = new System.Windows.Forms.Button();
            this.buttonBrowseSlic3r = new System.Windows.Forms.Button();
            this.textIni = new System.Windows.Forms.TextBox();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxUseBundledVersion);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Internal Slic3r configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // checkBoxUseBundledVersion
            // 
            this.checkBoxUseBundledVersion.AutoSize = true;
            this.checkBoxUseBundledVersion.Location = new System.Drawing.Point(7, 20);
            this.checkBoxUseBundledVersion.Name = "checkBoxUseBundledVersion";
            this.checkBoxUseBundledVersion.Size = new System.Drawing.Size(161, 17);
            this.checkBoxUseBundledVersion.TabIndex = 0;
            this.checkBoxUseBundledVersion.Text = "Use bundeled Slic3r version.";
            this.checkBoxUseBundledVersion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonBrowseIni);
            this.groupBox2.Controls.Add(this.buttonBrowseSlic3r);
            this.groupBox2.Controls.Add(this.textIni);
            this.groupBox2.Controls.Add(this.textPath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External Slic3r";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Leave blank to use internal Slic3r with ini file.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 52);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // buttonBrowseIni
            // 
            this.buttonBrowseIni.Location = new System.Drawing.Point(331, 93);
            this.buttonBrowseIni.Name = "buttonBrowseIni";
            this.buttonBrowseIni.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseIni.TabIndex = 5;
            this.buttonBrowseIni.Text = "Browse";
            this.buttonBrowseIni.UseVisualStyleBackColor = true;
            this.buttonBrowseIni.Click += new System.EventHandler(this.buttonBrowseIni_Click);
            // 
            // buttonBrowseSlic3r
            // 
            this.buttonBrowseSlic3r.Location = new System.Drawing.Point(331, 30);
            this.buttonBrowseSlic3r.Name = "buttonBrowseSlic3r";
            this.buttonBrowseSlic3r.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSlic3r.TabIndex = 4;
            this.buttonBrowseSlic3r.Text = "Browse";
            this.buttonBrowseSlic3r.UseVisualStyleBackColor = true;
            this.buttonBrowseSlic3r.Click += new System.EventHandler(this.buttonBrowseSlic3r_Click);
            // 
            // textIni
            // 
            this.textIni.Location = new System.Drawing.Point(10, 96);
            this.textIni.Name = "textIni";
            this.textIni.Size = new System.Drawing.Size(315, 20);
            this.textIni.TabIndex = 3;
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(10, 33);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(315, 20);
            this.textPath.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Slic3r ini file to use";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Slic3r executable";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(227, 362);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(344, 362);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Slic3r setup";
            // 
            // Slic3rSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(461, 413);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Slic3rSetup";
            this.Text = "Slic3r Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxUseBundledVersion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textIni;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBrowseIni;
        private System.Windows.Forms.Button buttonBrowseSlic3r;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label5;
    }
}