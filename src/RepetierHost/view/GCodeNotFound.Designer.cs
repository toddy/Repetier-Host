namespace RepetierHost.view
{
    partial class GCodeNotFound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCodeNotFound));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(28, 167);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(353, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expected filename and location:";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(16, 131);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(132, 13);
            this.labelFile.TabIndex = 3;
            this.labelFile.Text = "filename and directory";
            // 
            // GCodeNotFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 215);
            this.ControlBox = false;
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GCodeNotFound";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Generated G-code not found";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFile;
    }
}