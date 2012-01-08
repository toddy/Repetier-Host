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
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(648, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files and directories";
            // 
            // labelOKMasg
            // 
            this.labelOKMasg.AutoSize = true;
            this.labelOKMasg.ForeColor = System.Drawing.Color.Red;
            this.labelOKMasg.Location = new System.Drawing.Point(156, 53);
            this.labelOKMasg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOKMasg.Name = "labelOKMasg";
            this.labelOKMasg.Size = new System.Drawing.Size(91, 17);
            this.labelOKMasg.TabIndex = 5;
            this.labelOKMasg.Text = "workdirstatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 68);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // checkLogfile
            // 
            this.checkLogfile.AutoSize = true;
            this.checkLogfile.Location = new System.Drawing.Point(13, 64);
            this.checkLogfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkLogfile.Name = "checkLogfile";
            this.checkLogfile.Size = new System.Drawing.Size(106, 21);
            this.checkLogfile.TabIndex = 2;
            this.checkLogfile.Text = "Log session";
            this.checkLogfile.UseVisualStyleBackColor = true;
            // 
            // buttonSearchWorkdir
            // 
            this.buttonSearchWorkdir.Location = new System.Drawing.Point(541, 25);
            this.buttonSearchWorkdir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchWorkdir.Name = "buttonSearchWorkdir";
            this.buttonSearchWorkdir.Size = new System.Drawing.Size(85, 28);
            this.buttonSearchWorkdir.TabIndex = 1;
            this.buttonSearchWorkdir.Text = "Browse ...";
            this.buttonSearchWorkdir.UseVisualStyleBackColor = true;
            this.buttonSearchWorkdir.Click += new System.EventHandler(this.buttonSearchWorkdir_Click);
            // 
            // textWorkdir
            // 
            this.textWorkdir.Location = new System.Drawing.Point(124, 25);
            this.textWorkdir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textWorkdir.Name = "textWorkdir";
            this.textWorkdir.Size = new System.Drawing.Size(408, 22);
            this.textWorkdir.TabIndex = 0;
            this.textWorkdir.TextChanged += new System.EventHandler(this.textWorkdir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work directory:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(435, 202);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(543, 202);
            this.buttonAbort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(100, 28);
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
            // GlobalSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(680, 258);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalSettings";
            this.ShowInTaskbar = false;
            this.Text = "Repetier settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlobalSettings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

    }
}