namespace RepetierHost.view
{
    partial class SDCardUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SDCardUpload));
            this.label1 = new System.Windows.Forms.Label();
            this.textFilename = new System.Windows.Forms.TextBox();
            this.radioCurrent = new System.Windows.Forms.RadioButton();
            this.radioExternal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.extFilename = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkAppendPrepend = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkJobFinished = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uploaded filename:";
            // 
            // textFilename
            // 
            this.textFilename.Location = new System.Drawing.Point(156, 12);
            this.textFilename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFilename.Name = "textFilename";
            this.textFilename.Size = new System.Drawing.Size(132, 22);
            this.textFilename.TabIndex = 1;
            this.textFilename.Validating += new System.ComponentModel.CancelEventHandler(this.textFilename_Validating);
            // 
            // radioCurrent
            // 
            this.radioCurrent.AutoSize = true;
            this.radioCurrent.Checked = true;
            this.radioCurrent.Location = new System.Drawing.Point(21, 101);
            this.radioCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioCurrent.Name = "radioCurrent";
            this.radioCurrent.Size = new System.Drawing.Size(176, 21);
            this.radioCurrent.TabIndex = 2;
            this.radioCurrent.TabStop = true;
            this.radioCurrent.Text = "Upload current G-Code";
            this.radioCurrent.UseVisualStyleBackColor = true;
            // 
            // radioExternal
            // 
            this.radioExternal.AutoSize = true;
            this.radioExternal.Location = new System.Drawing.Point(21, 130);
            this.radioExternal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioExternal.Name = "radioExternal";
            this.radioExternal.Size = new System.Drawing.Size(150, 21);
            this.radioExternal.TabIndex = 3;
            this.radioExternal.Text = "Upload external file";
            this.radioExternal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "File:";
            // 
            // extFilename
            // 
            this.extFilename.Location = new System.Drawing.Point(99, 160);
            this.extFilename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.extFilename.Name = "extFilename";
            this.extFilename.Size = new System.Drawing.Size(375, 22);
            this.extFilename.TabIndex = 5;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(483, 154);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(100, 28);
            this.buttonBrowse.TabIndex = 6;
            this.buttonBrowse.Text = "Browse ...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(349, 212);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(483, 212);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "G_Code|*.gcode|All files|*.*";
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.Title = "Select G-Code file for upload";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(540, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 39);
            this.panel1.TabIndex = 9;
            // 
            // checkAppendPrepend
            // 
            this.checkAppendPrepend.AutoSize = true;
            this.checkAppendPrepend.Checked = true;
            this.checkAppendPrepend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAppendPrepend.Location = new System.Drawing.Point(21, 46);
            this.checkAppendPrepend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkAppendPrepend.Name = "checkAppendPrepend";
            this.checkAppendPrepend.Size = new System.Drawing.Size(269, 21);
            this.checkAppendPrepend.TabIndex = 10;
            this.checkAppendPrepend.Text = "Include \"Append\" and \"Prepend\" code";
            this.checkAppendPrepend.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // checkJobFinished
            // 
            this.checkJobFinished.AutoSize = true;
            this.checkJobFinished.Checked = true;
            this.checkJobFinished.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkJobFinished.Location = new System.Drawing.Point(21, 74);
            this.checkJobFinished.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkJobFinished.Name = "checkJobFinished";
            this.checkJobFinished.Size = new System.Drawing.Size(223, 21);
            this.checkJobFinished.TabIndex = 11;
            this.checkJobFinished.Text = "Include job finished commands";
            this.checkJobFinished.UseVisualStyleBackColor = true;
            // 
            // SDCardUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(599, 250);
            this.ControlBox = false;
            this.Controls.Add(this.checkJobFinished);
            this.Controls.Add(this.checkAppendPrepend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.extFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioExternal);
            this.Controls.Add(this.radioCurrent);
            this.Controls.Add(this.textFilename);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SDCardUpload";
            this.Text = "SD-Card upload";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SDCardUpload_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckBox checkAppendPrepend;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.TextBox textFilename;
        public System.Windows.Forms.RadioButton radioCurrent;
        public System.Windows.Forms.RadioButton radioExternal;
        public System.Windows.Forms.TextBox extFilename;
        public System.Windows.Forms.CheckBox checkJobFinished;
    }
}