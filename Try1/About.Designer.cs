namespace Try1
{
    partial class AboutForm
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
            this.aboutGroupBox = new System.Windows.Forms.GroupBox();
            this.GroupNameLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.MyNameLabel = new System.Windows.Forms.Label();
            this.aboutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutGroupBox
            // 
            this.aboutGroupBox.Controls.Add(this.MyNameLabel);
            this.aboutGroupBox.Controls.Add(this.GroupNameLabel);
            this.aboutGroupBox.Controls.Add(this.StudentNameLabel);
            this.aboutGroupBox.Location = new System.Drawing.Point(12, 12);
            this.aboutGroupBox.Name = "aboutGroupBox";
            this.aboutGroupBox.Size = new System.Drawing.Size(333, 362);
            this.aboutGroupBox.TabIndex = 0;
            this.aboutGroupBox.TabStop = false;
            this.aboutGroupBox.Text = "О программе";
            this.aboutGroupBox.Enter += new System.EventHandler(this.aboutGroupBox_Enter);
            // 
            // GroupNameLabel
            // 
            this.GroupNameLabel.AutoSize = true;
            this.GroupNameLabel.Location = new System.Drawing.Point(156, 31);
            this.GroupNameLabel.Name = "GroupNameLabel";
            this.GroupNameLabel.Size = new System.Drawing.Size(129, 13);
            this.GroupNameLabel.TabIndex = 1;
            this.GroupNameLabel.Text = "Cтудент группы ПИ-15-2";
            this.GroupNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(17, 31);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(61, 13);
            this.StudentNameLabel.TabIndex = 0;
            this.StudentNameLabel.Text = "Выполнил:";
            // 
            // MyNameLabel
            // 
            this.MyNameLabel.AutoSize = true;
            this.MyNameLabel.Location = new System.Drawing.Point(156, 54);
            this.MyNameLabel.Name = "MyNameLabel";
            this.MyNameLabel.Size = new System.Drawing.Size(90, 13);
            this.MyNameLabel.TabIndex = 2;
            this.MyNameLabel.Text = "Фундукян Артур";
            this.MyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 386);
            this.Controls.Add(this.aboutGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.aboutGroupBox.ResumeLayout(false);
            this.aboutGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox aboutGroupBox;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label GroupNameLabel;
        private System.Windows.Forms.Label MyNameLabel;
    }
}