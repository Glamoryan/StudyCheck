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
            // LessonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnDersEkle);
            this.Name = "LessonControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDersEkle;
    }
}
