namespace RepetierHost.view
{
    partial class Skeinforge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skeinforge));
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textSkeinforge = new System.Windows.Forms.TextBox();
            this.buttonSerach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textExtension = new System.Windows.Forms.TextBox();
            this.textPostfix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.textPython = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSerachPy = new System.Windows.Forms.Button();
            this.openPython = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.textSkeinforgeCraft = new System.Windows.Forms.TextBox();
            this.buttonSearchCraft = new System.Windows.Forms.Button();
            this.textWorkingDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowseWorkingDirectory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Filter = "Python|*.py|All files|*.*";
            this.openFile.Title = "Skeinforge application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skeinforge application:";
            // 
            // textSkeinforge
            // 
            this.textSkeinforge.Location = new System.Drawing.Point(144, 13);
            this.textSkeinforge.Name = "textSkeinforge";
            this.textSkeinforge.Size = new System.Drawing.Size(401, 20);
            this.textSkeinforge.TabIndex = 1;
            // 
            // buttonSerach
            // 
            this.buttonSerach.Location = new System.Drawing.Point(553, 13);
            this.buttonSerach.Name = "buttonSerach";
            this.buttonSerach.Size = new System.Drawing.Size(80, 22);
            this.buttonSerach.TabIndex = 2;
            this.buttonSerach.Text = "Browse ...";
            this.buttonSerach.UseVisualStyleBackColor = true;
            this.buttonSerach.Click += new System.EventHandler(this.buttonSerach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GCode extension:";
            // 
            // textExtension
            // 
            this.textExtension.Location = new System.Drawing.Point(144, 90);
            this.textExtension.Name = "textExtension";
            this.textExtension.Size = new System.Drawing.Size(106, 20);
            this.textExtension.TabIndex = 4;
            this.textExtension.Text = ".gcode";
            // 
            // textPostfix
            // 
            this.textPostfix.Location = new System.Drawing.Point(144, 116);
            this.textPostfix.Name = "textPostfix";
            this.textPostfix.Size = new System.Drawing.Size(106, 20);
            this.textPostfix.TabIndex = 5;
            this.textPostfix.Text = "_export";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filename postfix:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(76, 170);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 22);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(505, 168);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(80, 22);
            this.buttonAbort.TabIndex = 8;
            this.buttonAbort.Text = "Cancel";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // textPython
            // 
            this.textPython.Location = new System.Drawing.Point(144, 143);
            this.textPython.Name = "textPython";
            this.textPython.Size = new System.Drawing.Size(401, 20);
            this.textPython.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Python interpreter:";
            // 
            // buttonSerachPy
            // 
            this.buttonSerachPy.Location = new System.Drawing.Point(553, 143);
            this.buttonSerachPy.Name = "buttonSerachPy";
            this.buttonSerachPy.Size = new System.Drawing.Size(80, 22);
            this.buttonSerachPy.TabIndex = 11;
            this.buttonSerachPy.Text = "Browse ...";
            this.buttonSerachPy.UseVisualStyleBackColor = true;
            this.buttonSerachPy.Click += new System.EventHandler(this.buttonSerachPy_Click);
            // 
            // openPython
            // 
            this.openPython.Filter = "All files|*.*";
            this.openPython.Title = "Python interpreter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Skeinforge craft:";
            // 
            // textSkeinforgeCraft
            // 
            this.textSkeinforgeCraft.Location = new System.Drawing.Point(144, 38);
            this.textSkeinforgeCraft.Name = "textSkeinforgeCraft";
            this.textSkeinforgeCraft.Size = new System.Drawing.Size(401, 20);
            this.textSkeinforgeCraft.TabIndex = 1;
            // 
            // buttonSearchCraft
            // 
            this.buttonSearchCraft.Location = new System.Drawing.Point(553, 38);
            this.buttonSearchCraft.Name = "buttonSearchCraft";
            this.buttonSearchCraft.Size = new System.Drawing.Size(80, 22);
            this.buttonSearchCraft.TabIndex = 2;
            this.buttonSearchCraft.Text = "Browse ...";
            this.buttonSearchCraft.UseVisualStyleBackColor = true;
            this.buttonSearchCraft.Click += new System.EventHandler(this.buttonSearchCraft_Click);
            // 
            // textWorkingDirectory
            // 
            this.textWorkingDirectory.Location = new System.Drawing.Point(144, 64);
            this.textWorkingDirectory.Name = "textWorkingDirectory";
            this.textWorkingDirectory.Size = new System.Drawing.Size(401, 20);
            this.textWorkingDirectory.TabIndex = 1;
            // 
            // buttonBrowseWorkingDirectory
            // 
            this.buttonBrowseWorkingDirectory.Location = new System.Drawing.Point(553, 64);
            this.buttonBrowseWorkingDirectory.Name = "buttonBrowseWorkingDirectory";
            this.buttonBrowseWorkingDirectory.Size = new System.Drawing.Size(80, 22);
            this.buttonBrowseWorkingDirectory.TabIndex = 2;
            this.buttonBrowseWorkingDirectory.Text = "Browse ...";
            this.buttonBrowseWorkingDirectory.UseVisualStyleBackColor = true;
            this.buttonBrowseWorkingDirectory.Click += new System.EventHandler(this.buttonBrowseWorkingDirectory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Working directory:";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select working directory";
            // 
            // Skeinforge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(643, 223);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSerachPy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPython);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPostfix);
            this.Controls.Add(this.textExtension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowseWorkingDirectory);
            this.Controls.Add(this.buttonSearchCraft);
            this.Controls.Add(this.buttonSerach);
            this.Controls.Add(this.textWorkingDirectory);
            this.Controls.Add(this.textSkeinforgeCraft);
            this.Controls.Add(this.textSkeinforge);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Skeinforge";
            this.ShowInTaskbar = false;
            this.Text = "Skeinforge settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Skeinforge_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSerach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textExtension;
        private System.Windows.Forms.TextBox textPostfix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSerachPy;
        private System.Windows.Forms.OpenFileDialog openPython;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearchCraft;
        public System.Windows.Forms.TextBox textSkeinforge;
        public System.Windows.Forms.TextBox textPython;
        public System.Windows.Forms.TextBox textSkeinforgeCraft;
        public System.Windows.Forms.TextBox textWorkingDirectory;
        private System.Windows.Forms.Button buttonBrowseWorkingDirectory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}