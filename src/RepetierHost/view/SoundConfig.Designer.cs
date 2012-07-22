namespace RepetierHost.view
{
    partial class SoundConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPlaySoundCommand = new System.Windows.Forms.Button();
            this.buttonPlayError = new System.Windows.Forms.Button();
            this.buttonPlayPrintPaused = new System.Windows.Forms.Button();
            this.buttonPlayPrintFinished = new System.Windows.Forms.Button();
            this.buttonBrowseSoundCommand = new System.Windows.Forms.Button();
            this.buttonBrowseError = new System.Windows.Forms.Button();
            this.buttonBrowsePrintPaused = new System.Windows.Forms.Button();
            this.buttonBrowsePrintFinsihed = new System.Windows.Forms.Button();
            this.labelSoundCommand = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelPrintPaused = new System.Windows.Forms.Label();
            this.labelPrintFinished = new System.Windows.Forms.Label();
            this.checkSoundCommand = new System.Windows.Forms.CheckBox();
            this.checkError = new System.Windows.Forms.CheckBox();
            this.checkPrintPaused = new System.Windows.Forms.CheckBox();
            this.checkPrintFinished = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPlaySoundCommand);
            this.groupBox1.Controls.Add(this.buttonPlayError);
            this.groupBox1.Controls.Add(this.buttonPlayPrintPaused);
            this.groupBox1.Controls.Add(this.buttonPlayPrintFinished);
            this.groupBox1.Controls.Add(this.buttonBrowseSoundCommand);
            this.groupBox1.Controls.Add(this.buttonBrowseError);
            this.groupBox1.Controls.Add(this.buttonBrowsePrintPaused);
            this.groupBox1.Controls.Add(this.buttonBrowsePrintFinsihed);
            this.groupBox1.Controls.Add(this.labelSoundCommand);
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.labelPrintPaused);
            this.groupBox1.Controls.Add(this.labelPrintFinished);
            this.groupBox1.Controls.Add(this.checkSoundCommand);
            this.groupBox1.Controls.Add(this.checkError);
            this.groupBox1.Controls.Add(this.checkPrintPaused);
            this.groupBox1.Controls.Add(this.checkPrintFinished);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sounds";
            // 
            // buttonPlaySoundCommand
            // 
            this.buttonPlaySoundCommand.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlaySoundCommand.Image")));
            this.buttonPlaySoundCommand.Location = new System.Drawing.Point(505, 140);
            this.buttonPlaySoundCommand.Name = "buttonPlaySoundCommand";
            this.buttonPlaySoundCommand.Size = new System.Drawing.Size(69, 23);
            this.buttonPlaySoundCommand.TabIndex = 3;
            this.buttonPlaySoundCommand.UseVisualStyleBackColor = true;
            this.buttonPlaySoundCommand.Click += new System.EventHandler(this.buttonPlaySoundCommand_Click);
            // 
            // buttonPlayError
            // 
            this.buttonPlayError.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlayError.Image")));
            this.buttonPlayError.Location = new System.Drawing.Point(505, 100);
            this.buttonPlayError.Name = "buttonPlayError";
            this.buttonPlayError.Size = new System.Drawing.Size(69, 23);
            this.buttonPlayError.TabIndex = 3;
            this.buttonPlayError.UseVisualStyleBackColor = true;
            this.buttonPlayError.Click += new System.EventHandler(this.buttonPlayError_Click);
            // 
            // buttonPlayPrintPaused
            // 
            this.buttonPlayPrintPaused.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlayPrintPaused.Image")));
            this.buttonPlayPrintPaused.Location = new System.Drawing.Point(506, 60);
            this.buttonPlayPrintPaused.Name = "buttonPlayPrintPaused";
            this.buttonPlayPrintPaused.Size = new System.Drawing.Size(69, 23);
            this.buttonPlayPrintPaused.TabIndex = 3;
            this.buttonPlayPrintPaused.UseVisualStyleBackColor = true;
            this.buttonPlayPrintPaused.Click += new System.EventHandler(this.buttonPlayPrintPaused_Click);
            // 
            // buttonPlayPrintFinished
            // 
            this.buttonPlayPrintFinished.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlayPrintFinished.Image")));
            this.buttonPlayPrintFinished.Location = new System.Drawing.Point(506, 20);
            this.buttonPlayPrintFinished.Name = "buttonPlayPrintFinished";
            this.buttonPlayPrintFinished.Size = new System.Drawing.Size(69, 23);
            this.buttonPlayPrintFinished.TabIndex = 3;
            this.buttonPlayPrintFinished.UseVisualStyleBackColor = true;
            this.buttonPlayPrintFinished.Click += new System.EventHandler(this.buttonPlayPrintFinished_Click);
            // 
            // buttonBrowseSoundCommand
            // 
            this.buttonBrowseSoundCommand.Location = new System.Drawing.Point(423, 140);
            this.buttonBrowseSoundCommand.Name = "buttonBrowseSoundCommand";
            this.buttonBrowseSoundCommand.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSoundCommand.TabIndex = 2;
            this.buttonBrowseSoundCommand.Text = "Browse";
            this.buttonBrowseSoundCommand.UseVisualStyleBackColor = true;
            this.buttonBrowseSoundCommand.Click += new System.EventHandler(this.buttonBrowseSoundCommand_Click);
            // 
            // buttonBrowseError
            // 
            this.buttonBrowseError.Location = new System.Drawing.Point(423, 100);
            this.buttonBrowseError.Name = "buttonBrowseError";
            this.buttonBrowseError.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseError.TabIndex = 2;
            this.buttonBrowseError.Text = "Browse";
            this.buttonBrowseError.UseVisualStyleBackColor = true;
            this.buttonBrowseError.Click += new System.EventHandler(this.buttonBrowseError_Click);
            // 
            // buttonBrowsePrintPaused
            // 
            this.buttonBrowsePrintPaused.Location = new System.Drawing.Point(424, 60);
            this.buttonBrowsePrintPaused.Name = "buttonBrowsePrintPaused";
            this.buttonBrowsePrintPaused.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowsePrintPaused.TabIndex = 2;
            this.buttonBrowsePrintPaused.Text = "Browse";
            this.buttonBrowsePrintPaused.UseVisualStyleBackColor = true;
            this.buttonBrowsePrintPaused.Click += new System.EventHandler(this.buttonBrowsePrintPaused_Click);
            // 
            // buttonBrowsePrintFinsihed
            // 
            this.buttonBrowsePrintFinsihed.Location = new System.Drawing.Point(424, 20);
            this.buttonBrowsePrintFinsihed.Name = "buttonBrowsePrintFinsihed";
            this.buttonBrowsePrintFinsihed.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowsePrintFinsihed.TabIndex = 2;
            this.buttonBrowsePrintFinsihed.Text = "Browse";
            this.buttonBrowsePrintFinsihed.UseVisualStyleBackColor = true;
            this.buttonBrowsePrintFinsihed.Click += new System.EventHandler(this.buttonBrowsePrintFinsihed_Click);
            // 
            // labelSoundCommand
            // 
            this.labelSoundCommand.AutoSize = true;
            this.labelSoundCommand.Location = new System.Drawing.Point(27, 164);
            this.labelSoundCommand.Name = "labelSoundCommand";
            this.labelSoundCommand.Size = new System.Drawing.Size(26, 13);
            this.labelSoundCommand.TabIndex = 1;
            this.labelSoundCommand.Text = "File:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(27, 124);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(26, 13);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "File:";
            // 
            // labelPrintPaused
            // 
            this.labelPrintPaused.AutoSize = true;
            this.labelPrintPaused.Location = new System.Drawing.Point(28, 84);
            this.labelPrintPaused.Name = "labelPrintPaused";
            this.labelPrintPaused.Size = new System.Drawing.Size(26, 13);
            this.labelPrintPaused.TabIndex = 1;
            this.labelPrintPaused.Text = "File:";
            // 
            // labelPrintFinished
            // 
            this.labelPrintFinished.AutoSize = true;
            this.labelPrintFinished.Location = new System.Drawing.Point(28, 44);
            this.labelPrintFinished.Name = "labelPrintFinished";
            this.labelPrintFinished.Size = new System.Drawing.Size(26, 13);
            this.labelPrintFinished.TabIndex = 1;
            this.labelPrintFinished.Text = "File:";
            // 
            // checkSoundCommand
            // 
            this.checkSoundCommand.AutoSize = true;
            this.checkSoundCommand.Location = new System.Drawing.Point(6, 140);
            this.checkSoundCommand.Name = "checkSoundCommand";
            this.checkSoundCommand.Size = new System.Drawing.Size(115, 17);
            this.checkSoundCommand.TabIndex = 0;
            this.checkSoundCommand.Text = "@sound command";
            this.checkSoundCommand.UseVisualStyleBackColor = true;
            // 
            // checkError
            // 
            this.checkError.AutoSize = true;
            this.checkError.Location = new System.Drawing.Point(6, 100);
            this.checkError.Name = "checkError";
            this.checkError.Size = new System.Drawing.Size(48, 17);
            this.checkError.TabIndex = 0;
            this.checkError.Text = "Error";
            this.checkError.UseVisualStyleBackColor = true;
            // 
            // checkPrintPaused
            // 
            this.checkPrintPaused.AutoSize = true;
            this.checkPrintPaused.Location = new System.Drawing.Point(7, 60);
            this.checkPrintPaused.Name = "checkPrintPaused";
            this.checkPrintPaused.Size = new System.Drawing.Size(99, 17);
            this.checkPrintPaused.TabIndex = 0;
            this.checkPrintPaused.Text = "Printjob paused";
            this.checkPrintPaused.UseVisualStyleBackColor = true;
            // 
            // checkPrintFinished
            // 
            this.checkPrintFinished.AutoSize = true;
            this.checkPrintFinished.Location = new System.Drawing.Point(7, 20);
            this.checkPrintFinished.Name = "checkPrintFinished";
            this.checkPrintFinished.Size = new System.Drawing.Size(100, 17);
            this.checkPrintFinished.TabIndex = 0;
            this.checkPrintFinished.Text = "Printjob finished";
            this.checkPrintFinished.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(511, 219);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "wav";
            this.openFile.Filter = "WAV File|*.wav";
            this.openFile.Title = "Select WAV file to play";
            // 
            // SoundConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(605, 272);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoundConfig";
            this.Text = "Sound configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPlaySoundCommand;
        private System.Windows.Forms.Button buttonPlayError;
        private System.Windows.Forms.Button buttonPlayPrintPaused;
        private System.Windows.Forms.Button buttonPlayPrintFinished;
        private System.Windows.Forms.Button buttonBrowseSoundCommand;
        private System.Windows.Forms.Button buttonBrowseError;
        private System.Windows.Forms.Button buttonBrowsePrintPaused;
        private System.Windows.Forms.Button buttonBrowsePrintFinsihed;
        private System.Windows.Forms.Label labelSoundCommand;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelPrintPaused;
        private System.Windows.Forms.Label labelPrintFinished;
        private System.Windows.Forms.CheckBox checkSoundCommand;
        private System.Windows.Forms.CheckBox checkError;
        private System.Windows.Forms.CheckBox checkPrintPaused;
        private System.Windows.Forms.CheckBox checkPrintFinished;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}