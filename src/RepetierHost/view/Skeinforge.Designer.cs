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
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skeinforge application:";
            // 
            // textSkeinforge
            // 
            this.textSkeinforge.Location = new System.Drawing.Point(180, 16);
            this.textSkeinforge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSkeinforge.Name = "textSkeinforge";
            this.textSkeinforge.Size = new System.Drawing.Size(500, 22);
            this.textSkeinforge.TabIndex = 1;
            // 
            // buttonSerach
            // 
            this.buttonSerach.Location = new System.Drawing.Point(691, 16);
            this.buttonSerach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSerach.Name = "buttonSerach";
            this.buttonSerach.Size = new System.Drawing.Size(100, 28);
            this.buttonSerach.TabIndex = 2;
            this.buttonSerach.Text = "Browse ...";
            this.buttonSerach.UseVisualStyleBackColor = true;
            this.buttonSerach.Click += new System.EventHandler(this.buttonSerach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "GCode extension:";
            // 
            // textExtension
            // 
            this.textExtension.Location = new System.Drawing.Point(180, 80);
            this.textExtension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textExtension.Name = "textExtension";
            this.textExtension.Size = new System.Drawing.Size(132, 22);
            this.textExtension.TabIndex = 4;
            this.textExtension.Text = ".gcode";
            // 
            // textPostfix
            // 
            this.textPostfix.Location = new System.Drawing.Point(180, 113);
            this.textPostfix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPostfix.Name = "textPostfix";
            this.textPostfix.Size = new System.Drawing.Size(132, 22);
            this.textPostfix.TabIndex = 5;
            this.textPostfix.Text = "_export";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filename postfix:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(95, 180);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(631, 178);
            this.buttonAbort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(100, 28);
            this.buttonAbort.TabIndex = 8;
            this.buttonAbort.Text = "Cancel";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // textPython
            // 
            this.textPython.Location = new System.Drawing.Point(180, 146);
            this.textPython.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPython.Name = "textPython";
            this.textPython.Size = new System.Drawing.Size(500, 22);
            this.textPython.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Python interpreter:";
            // 
            // buttonSerachPy
            // 
            this.buttonSerachPy.Location = new System.Drawing.Point(691, 146);
            this.buttonSerachPy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSerachPy.Name = "buttonSerachPy";
            this.buttonSerachPy.Size = new System.Drawing.Size(100, 28);
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
            this.label5.Location = new System.Drawing.Point(17, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Skeinforge craft:";
            // 
            // textSkeinforgeCraft
            // 
            this.textSkeinforgeCraft.Location = new System.Drawing.Point(180, 48);
            this.textSkeinforgeCraft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSkeinforgeCraft.Name = "textSkeinforgeCraft";
            this.textSkeinforgeCraft.Size = new System.Drawing.Size(500, 22);
            this.textSkeinforgeCraft.TabIndex = 1;
            // 
            // buttonSearchCraft
            // 
            this.buttonSearchCraft.Location = new System.Drawing.Point(691, 48);
            this.buttonSearchCraft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearchCraft.Name = "buttonSearchCraft";
            this.buttonSearchCraft.Size = new System.Drawing.Size(100, 28);
            this.buttonSearchCraft.TabIndex = 2;
            this.buttonSearchCraft.Text = "Browse ...";
            this.buttonSearchCraft.UseVisualStyleBackColor = true;
            this.buttonSearchCraft.Click += new System.EventHandler(this.buttonSearchCraft_Click);
            // 
            // Skeinforge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(804, 229);
            this.ControlBox = false;
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
            this.Controls.Add(this.buttonSearchCraft);
            this.Controls.Add(this.buttonSerach);
            this.Controls.Add(this.textSkeinforgeCraft);
            this.Controls.Add(this.textSkeinforge);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}