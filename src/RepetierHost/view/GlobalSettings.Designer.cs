namespace RepetierHost.view
{
    partial class GlobalSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOKMasg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkLogfile = new System.Windows.Forms.CheckBox();
            this.buttonSearchWorkdir = new System.Windows.Forms.Button();
            this.textWorkdir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkDisableQualityReduction = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelOKMasg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkLogfile);
            this.groupBox1.Controls.Add(this.buttonSearchWorkdir);
            this.groupBox1.Controls.Add(this.textWorkdir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files and directories";
            // 
            // labelOKMasg
            // 
            this.labelOKMasg.AutoSize = true;
            this.labelOKMasg.ForeColor = System.Drawing.Color.Red;
            this.labelOKMasg.Location = new System.Drawing.Point(125, 42);
            this.labelOKMasg.Name = "labelOKMasg";
            this.labelOKMasg.Size = new System.Drawing.Size(69, 13);
            this.labelOKMasg.TabIndex = 5;
            this.labelOKMasg.Text = "workdirstatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // checkLogfile
            // 
            this.checkLogfile.AutoSize = true;
            this.checkLogfile.Location = new System.Drawing.Point(10, 51);
            this.checkLogfile.Name = "checkLogfile";
            this.checkLogfile.Size = new System.Drawing.Size(82, 17);
            this.checkLogfile.TabIndex = 2;
            this.checkLogfile.Text = "Log session";
            this.checkLogfile.UseVisualStyleBackColor = true;
            // 
            // buttonSearchWorkdir
            // 
            this.buttonSearchWorkdir.Location = new System.Drawing.Point(433, 20);
            this.buttonSearchWorkdir.Name = "buttonSearchWorkdir";
            this.buttonSearchWorkdir.Size = new System.Drawing.Size(68, 22);
            this.buttonSearchWorkdir.TabIndex = 1;
            this.buttonSearchWorkdir.Text = "Browse ...";
            this.buttonSearchWorkdir.UseVisualStyleBackColor = true;
            this.buttonSearchWorkdir.Click += new System.EventHandler(this.buttonSearchWorkdir_Click);
            // 
            // textWorkdir
            // 
            this.textWorkdir.Location = new System.Drawing.Point(99, 20);
            this.textWorkdir.Name = "textWorkdir";
            this.textWorkdir.Size = new System.Drawing.Size(327, 20);
            this.textWorkdir.TabIndex = 0;
            this.textWorkdir.TextChanged += new System.EventHandler(this.textWorkdir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work directory:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(365, 235);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 22);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(451, 235);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(80, 22);
            this.buttonAbort.TabIndex = 1;
            this.buttonAbort.Text = "Cancel";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Select working directory";
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDisableQualityReduction);
            this.groupBox2.Location = new System.Drawing.Point(13, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Behaviour";
            // 
            // checkDisableQualityReduction
            // 
            this.checkDisableQualityReduction.AutoSize = true;
            this.checkDisableQualityReduction.Location = new System.Drawing.Point(13, 20);
            this.checkDisableQualityReduction.Name = "checkDisableQualityReduction";
            this.checkDisableQualityReduction.Size = new System.Drawing.Size(196, 17);
            this.checkDisableQualityReduction.TabIndex = 0;
            this.checkDisableQualityReduction.Text = "Disable quality reduction during print";
            this.checkDisableQualityReduction.UseVisualStyleBackColor = true;
            // 
            // GlobalSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(544, 283);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalSettings";
            this.ShowInTaskbar = false;
            this.Text = "Repetier settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlobalSettings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkLogfile;
        private System.Windows.Forms.Button buttonSearchWorkdir;
        private System.Windows.Forms.TextBox textWorkdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label labelOKMasg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkDisableQualityReduction;

    }
}