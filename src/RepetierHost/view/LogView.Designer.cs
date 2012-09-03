namespace RepetierHost.view
{
    partial class LogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.labelShowInLog = new System.Windows.Forms.Label();
            this.listLog = new RepetierHost.view.LogBox();
            this.switchAutoscroll = new RepetierHost.view.SwitchButton();
            this.switchACK = new RepetierHost.view.SwitchButton();
            this.switchErrors = new RepetierHost.view.SwitchButton();
            this.switchWarnings = new RepetierHost.view.SwitchButton();
            this.switchInfo = new RepetierHost.view.SwitchButton();
            this.switchCommandsSend = new RepetierHost.view.SwitchButton();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonCopy);
            this.panelButtons.Controls.Add(this.buttonClearLog);
            this.panelButtons.Controls.Add(this.switchAutoscroll);
            this.panelButtons.Controls.Add(this.switchACK);
            this.panelButtons.Controls.Add(this.switchErrors);
            this.panelButtons.Controls.Add(this.switchWarnings);
            this.panelButtons.Controls.Add(this.switchInfo);
            this.panelButtons.Controls.Add(this.switchCommandsSend);
            this.panelButtons.Controls.Add(this.labelShowInLog);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(947, 25);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonCopy
            // 
            this.buttonCopy.FlatAppearance.BorderSize = 0;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopy.Image")));
            this.buttonCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCopy.Location = new System.Drawing.Point(684, 1);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(71, 23);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.toolCopy_Click);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.FlatAppearance.BorderSize = 0;
            this.buttonClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearLog.Image = ((System.Drawing.Image)(resources.GetObject("buttonClearLog.Image")));
            this.buttonClearLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClearLog.Location = new System.Drawing.Point(585, 1);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(91, 23);
            this.buttonClearLog.TabIndex = 3;
            this.buttonClearLog.Text = "Clear log";
            this.buttonClearLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.toolClear_Click);
            // 
            // labelShowInLog
            // 
            this.labelShowInLog.AutoSize = true;
            this.labelShowInLog.Location = new System.Drawing.Point(4, 5);
            this.labelShowInLog.Name = "labelShowInLog";
            this.labelShowInLog.Size = new System.Drawing.Size(62, 13);
            this.labelShowInLog.TabIndex = 0;
            this.labelShowInLog.Text = "Show in log";
            // 
            // listLog
            // 
            this.listLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLog.Location = new System.Drawing.Point(0, 25);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(947, 376);
            this.listLog.TabIndex = 1;
            // 
            // switchAutoscroll
            // 
            this.switchAutoscroll.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchAutoscroll.ButtonFlatBorderSize = 0;
            this.switchAutoscroll.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchAutoscroll.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switchAutoscroll.Location = new System.Drawing.Point(498, 1);
            this.switchAutoscroll.Name = "switchAutoscroll";
            this.switchAutoscroll.On = true;
            this.switchAutoscroll.Size = new System.Drawing.Size(88, 23);
            this.switchAutoscroll.TabIndex = 2;
            this.switchAutoscroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.switchAutoscroll.TextOff = "Auto Scroll";
            this.switchAutoscroll.TextOn = "Auto Scroll";
            this.switchAutoscroll.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchAutoscroll_OnChange);
            // 
            // switchACK
            // 
            this.switchACK.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchACK.ButtonFlatBorderSize = 0;
            this.switchACK.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchACK.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switchACK.Location = new System.Drawing.Point(409, 1);
            this.switchACK.Name = "switchACK";
            this.switchACK.On = false;
            this.switchACK.Size = new System.Drawing.Size(86, 23);
            this.switchACK.TabIndex = 1;
            this.switchACK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.switchACK.TextOff = "ACK";
            this.switchACK.TextOn = "ACK";
            this.switchACK.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchACK_OnChange);
            // 
            // switchErrors
            // 
            this.switchErrors.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchErrors.ButtonFlatBorderSize = 0;
            this.switchErrors.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchErrors.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switchErrors.Location = new System.Drawing.Point(344, 1);
            this.switchErrors.Name = "switchErrors";
            this.switchErrors.On = true;
            this.switchErrors.Size = new System.Drawing.Size(62, 23);
            this.switchErrors.TabIndex = 1;
            this.switchErrors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.switchErrors.TextOff = "Errors";
            this.switchErrors.TextOn = "Errors";
            this.switchErrors.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchErrors_OnChange);
            // 
            // switchWarnings
            // 
            this.switchWarnings.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchWarnings.ButtonFlatBorderSize = 0;
            this.switchWarnings.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchWarnings.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switchWarnings.Location = new System.Drawing.Point(238, 1);
            this.switchWarnings.Name = "switchWarnings";
            this.switchWarnings.On = true;
            this.switchWarnings.Size = new System.Drawing.Size(100, 23);
            this.switchWarnings.TabIndex = 1;
            this.switchWarnings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.switchWarnings.TextOff = "Warnings";
            this.switchWarnings.TextOn = "Warnings";
            this.switchWarnings.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchWarnings_OnChange);
            // 
            // switchInfo
            // 
            this.switchInfo.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchInfo.ButtonFlatBorderSize = 0;
            this.switchInfo.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchInfo.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switchInfo.Location = new System.Drawing.Point(159, 1);
            this.switchInfo.Name = "switchInfo";
            this.switchInfo.On = true;
            this.switchInfo.Size = new System.Drawing.Size(73, 23);
            this.switchInfo.TabIndex = 1;
            this.switchInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.switchInfo.TextOff = "Info";
            this.switchInfo.TextOn = "Info";
            this.switchInfo.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchInfo_OnChange);
            // 
            // switchCommandsSend
            // 
            this.switchCommandsSend.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchCommandsSend.ButtonFlatBorderSize = 0;
            this.switchCommandsSend.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchCommandsSend.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switchCommandsSend.Location = new System.Drawing.Point(83, 1);
            this.switchCommandsSend.Name = "switchCommandsSend";
            this.switchCommandsSend.On = false;
            this.switchCommandsSend.Size = new System.Drawing.Size(86, 23);
            this.switchCommandsSend.TabIndex = 1;
            this.switchCommandsSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.switchCommandsSend.TextOff = "Commands";
            this.switchCommandsSend.TextOn = "Commands";
            this.switchCommandsSend.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchCommandsSend_OnChange);
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.panelButtons);
            this.Name = "LogView";
            this.Size = new System.Drawing.Size(947, 401);
            this.Load += new System.EventHandler(this.LogView_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LogBox listLog;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label labelShowInLog;
        public SwitchButton switchACK;
        public SwitchButton switchErrors;
        public SwitchButton switchWarnings;
        public SwitchButton switchInfo;
        public SwitchButton switchCommandsSend;
        public SwitchButton switchAutoscroll;
        public System.Windows.Forms.Button buttonCopy;
        public System.Windows.Forms.Button buttonClearLog;
    }
}
