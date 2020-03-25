namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl
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
            this.pnlLessonInfo = new System.Windows.Forms.Panel();
            this.pnlSinavContent = new System.Windows.Forms.Panel();
            this.pnlDersContent = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlExamInfo
            // 
            this.pnlExamInfo.Location = new System.Drawing.Point(21, 47);
            this.pnlExamInfo.Name = "pnlExamInfo";
            this.pnlExamInfo.Size = new System.Drawing.Size(295, 162);
            this.pnlExamInfo.TabIndex = 0;
            // 
            // pnlLessonInfo
            // 
            this.pnlLessonInfo.Location = new System.Drawing.Point(21, 226);
            this.pnlLessonInfo.Name = "pnlLessonInfo";
            this.pnlLessonInfo.Size = new System.Drawing.Size(295, 131);
            this.pnlLessonInfo.TabIndex = 0;
            // 
            // pnlSinavContent
            // 
            this.pnlSinavContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSinavContent.Location = new System.Drawing.Point(342, 47);
            this.pnlSinavContent.Name = "pnlSinavContent";
            this.pnlSinavContent.Size = new System.Drawing.Size(200, 310);
            this.pnlSinavContent.TabIndex = 1;
            // 
            // pnlDersContent
            // 
            this.pnlDersContent.Location = new System.Drawing.Point(570, 47);
            this.pnlDersContent.Name = "pnlDersContent";
            this.pnlDersContent.Size = new System.Drawing.Size(200, 310);
            this.pnlDersContent.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(798, 317);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // StudyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlDersContent);
            this.Controls.Add(this.pnlSinavContent);
            this.Controls.Add(this.pnlLessonInfo);
            this.Controls.Add(this.pnlExamInfo);
            this.Name = "StudyPanel";
            this.Size = new System.Drawing.Size(980, 416);
            this.Load += new System.EventHandler(this.StudyPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExamInfo;
        private System.Windows.Forms.Panel pnlLessonInfo;
        private System.Windows.Forms.Panel pnlSinavContent;
        private System.Windows.Forms.Panel pnlDersContent;
        private System.Windows.Forms.Button btnStart;
    }
}
