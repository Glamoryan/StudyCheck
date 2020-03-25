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
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
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
            this.pnlDersContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // btnAsagi
            // 
            this.btnAsagi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnAsagi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsagi.FlatAppearance.BorderSize = 0;
            this.btnAsagi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsagi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsagi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.btnAsagi.Image = global::StudyCheck.FormsUI.Properties.Resources.down_arrow_16px;
            this.btnAsagi.Location = new System.Drawing.Point(342, 363);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(200, 30);
            this.btnAsagi.TabIndex = 5;
            this.btnAsagi.UseVisualStyleBackColor = false;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // btnYukari
            // 
            this.btnYukari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnYukari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYukari.FlatAppearance.BorderSize = 0;
            this.btnYukari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYukari.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.btnYukari.Image = global::StudyCheck.FormsUI.Properties.Resources.up_16px;
            this.btnYukari.Location = new System.Drawing.Point(342, 11);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(200, 30);
            this.btnYukari.TabIndex = 5;
            this.btnYukari.UseVisualStyleBackColor = false;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // StudyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnYukari);
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
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnAsagi;
    }
}
