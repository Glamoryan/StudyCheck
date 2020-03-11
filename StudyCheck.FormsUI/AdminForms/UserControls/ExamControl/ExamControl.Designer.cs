namespace StudyCheck.FormsUI.AdminForms.UserControls.ExamControl
{
    partial class ExamControl
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
            this.btnSinavEkle = new System.Windows.Forms.Button();
            this.examColumnControl1 = new StudyCheck.FormsUI.AdminForms.UserControls.ExamControl.ExamColumnControl();
            this.pnlExamContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSinavEkle
            // 
            this.btnSinavEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnSinavEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinavEkle.FlatAppearance.BorderSize = 0;
            this.btnSinavEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavEkle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavEkle.ForeColor = System.Drawing.Color.White;
            this.btnSinavEkle.Image = global::StudyCheck.FormsUI.Properties.Resources.add_16px;
            this.btnSinavEkle.Location = new System.Drawing.Point(8, 9);
            this.btnSinavEkle.Name = "btnSinavEkle";
            this.btnSinavEkle.Size = new System.Drawing.Size(110, 31);
            this.btnSinavEkle.TabIndex = 6;
            this.btnSinavEkle.Text = "Sınav Ekle";
            this.btnSinavEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSinavEkle.UseVisualStyleBackColor = false;
            this.btnSinavEkle.Click += new System.EventHandler(this.btnSinavEkle_Click);
            // 
            // examColumnControl1
            // 
            this.examColumnControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.examColumnControl1.Location = new System.Drawing.Point(8, 48);
            this.examColumnControl1.Name = "examColumnControl1";
            this.examColumnControl1.Size = new System.Drawing.Size(1031, 46);
            this.examColumnControl1.TabIndex = 7;
            // 
            // pnlExamContent
            // 
            this.pnlExamContent.Location = new System.Drawing.Point(8, 101);
            this.pnlExamContent.Name = "pnlExamContent";
            this.pnlExamContent.Size = new System.Drawing.Size(1031, 518);
            this.pnlExamContent.TabIndex = 8;
            // 
            // ExamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.pnlExamContent);
            this.Controls.Add(this.examColumnControl1);
            this.Controls.Add(this.btnSinavEkle);
            this.Name = "ExamControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.ExamControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinavEkle;
        private ExamColumnControl examColumnControl1;
        private System.Windows.Forms.Panel pnlExamContent;
    }
}
