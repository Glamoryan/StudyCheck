﻿namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl
{
    partial class StudyPanel
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
            this.pnlExamInfo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlExamInfo
            // 
            this.pnlExamInfo.Location = new System.Drawing.Point(21, 47);
            this.pnlExamInfo.Name = "pnlExamInfo";
            this.pnlExamInfo.Size = new System.Drawing.Size(295, 162);
            this.pnlExamInfo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(21, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 142);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(342, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 310);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(570, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 310);
            this.panel4.TabIndex = 1;
            // 
            // StudyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlExamInfo);
            this.Name = "StudyPanel";
            this.Size = new System.Drawing.Size(980, 416);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExamInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}