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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.textSlic3rConfigDir = new System.Windows.Forms.TextBox();
            this.buttonBrowseConfigDir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textExecutable = new System.Windows.Forms.TextBox();
            this.buttonBrowseExecutable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonBrowseExecutable);
            this.groupBox1.Controls.Add(this.buttonBrowseConfigDir);
            this.groupBox1.Controls.Add(this.textExecutable);
            this.groupBox1.Controls.Add(this.textSlic3rConfigDir);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slic3r setup";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(226, 284);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(343, 284);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Slic3r setup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Slic3r configuration directory";
            // 
            // textSlic3rConfigDir
            // 
            this.textSlic3rConfigDir.Location = new System.Drawing.Point(9, 42);
            this.textSlic3rConfigDir.Name = "textSlic3rConfigDir";
            this.textSlic3rConfigDir.Size = new System.Drawing.Size(315, 20);
            this.textSlic3rConfigDir.TabIndex = 0;
            // 
            // buttonBrowseConfigDir
            // 
            this.buttonBrowseConfigDir.Location = new System.Drawing.Point(330, 39);
            this.buttonBrowseConfigDir.Name = "buttonBrowseConfigDir";
            this.buttonBrowseConfigDir.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseConfigDir.TabIndex = 1;
            this.buttonBrowseConfigDir.Text = "Browse";
            this.buttonBrowseConfigDir.UseVisualStyleBackColor = true;
            this.buttonBrowseConfigDir.Click += new System.EventHandler(this.buttonBrowseConfigDir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Leave blank to use guessed location.";
            // 
            // textExecutable
            // 
            this.textExecutable.Location = new System.Drawing.Point(6, 104);
            this.textExecutable.Name = "textExecutable";
            this.textExecutable.Size = new System.Drawing.Size(315, 20);
            this.textExecutable.TabIndex = 2;
            // 
            // buttonBrowseExecutable
            // 
            this.buttonBrowseExecutable.Location = new System.Drawing.Point(327, 101);
            this.buttonBrowseExecutable.Name = "buttonBrowseExecutable";
            this.buttonBrowseExecutable.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseExecutable.TabIndex = 3;
            this.buttonBrowseExecutable.Text = "Browse";
            this.buttonBrowseExecutable.UseVisualStyleBackColor = true;
            this.buttonBrowseExecutable.Click += new System.EventHandler(this.buttonBrowseExecutable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slic3r executable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Leave blank to use the bundled version.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 52);
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Slic3rSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(461, 342);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Slic3rSetup";
            this.Text = "Slic3r Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBrowseConfigDir;
        private System.Windows.Forms.TextBox textSlic3rConfigDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowseExecutable;
        private System.Windows.Forms.TextBox textExecutable;
    }
}