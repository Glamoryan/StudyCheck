namespace StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl
{
    partial class LessonControl
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
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.lessonColumnControl1 = new StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl.LessonColumnControl();
            this.pnlLessonContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnDersEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDersEkle.FlatAppearance.BorderSize = 0;
            this.btnDersEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersEkle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.ForeColor = System.Drawing.Color.White;
            this.btnDersEkle.Image = global::StudyCheck.FormsUI.Properties.Resources.add_16px;
            this.btnDersEkle.Location = new System.Drawing.Point(8, 9);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(110, 31);
            this.btnDersEkle.TabIndex = 5;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDersEkle.UseVisualStyleBackColor = false;
            // 
            // lessonColumnControl1
            // 
            this.lessonColumnControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.lessonColumnControl1.Location = new System.Drawing.Point(8, 48);
            this.lessonColumnControl1.Name = "lessonColumnControl1";
            this.lessonColumnControl1.Size = new System.Drawing.Size(1031, 46);
            this.lessonColumnControl1.TabIndex = 6;
            // 
            // pnlLessonContent
            // 
            this.pnlLessonContent.Location = new System.Drawing.Point(8, 100);
            this.pnlLessonContent.Name = "pnlLessonContent";
            this.pnlLessonContent.Size = new System.Drawing.Size(1031, 525);
            this.pnlLessonContent.TabIndex = 7;
            // 
            // LessonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.pnlLessonContent);
            this.Controls.Add(this.lessonColumnControl1);
            this.Controls.Add(this.btnDersEkle);
            this.Name = "LessonControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDersEkle;
        private LessonColumnControl lessonColumnControl1;
        private System.Windows.Forms.Panel pnlLessonContent;
    }
}
