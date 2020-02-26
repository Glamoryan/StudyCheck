namespace StudyCheck.FormsUI.UserControls.ExamSettings
{
    partial class ExamSettingsGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.examColumnsPanel = new System.Windows.Forms.Panel();
            this.examsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exam Settings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examColumnsPanel
            // 
            this.examColumnsPanel.Location = new System.Drawing.Point(6, 149);
            this.examColumnsPanel.Name = "examColumnsPanel";
            this.examColumnsPanel.Size = new System.Drawing.Size(1012, 38);
            this.examColumnsPanel.TabIndex = 10;
            // 
            // examsPanel
            // 
            this.examsPanel.Location = new System.Drawing.Point(6, 189);
            this.examsPanel.Name = "examsPanel";
            this.examsPanel.Size = new System.Drawing.Size(1012, 458);
            this.examsPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 72);
            this.panel1.TabIndex = 8;
            // 
            // ExamSettingsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.examColumnsPanel);
            this.Controls.Add(this.examsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "ExamSettingsGrid";
            this.Size = new System.Drawing.Size(1025, 654);
            this.Load += new System.EventHandler(this.ExamSettingsGrid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel examColumnsPanel;
        private System.Windows.Forms.Panel examsPanel;
        private System.Windows.Forms.Panel panel1;
    }
}
