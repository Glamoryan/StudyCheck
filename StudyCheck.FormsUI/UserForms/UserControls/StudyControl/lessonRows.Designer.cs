namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl
{
    partial class lessonRows
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
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.pcbLessonIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLessonIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblDersAdi.Location = new System.Drawing.Point(56, 25);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(90, 25);
            this.lblDersAdi.TabIndex = 3;
            this.lblDersAdi.Text = "Ders Adı";
            // 
            // pcbLessonIcon
            // 
            this.pcbLessonIcon.Image = global::StudyCheck.FormsUI.Properties.Resources.test_passed_38px;
            this.pcbLessonIcon.Location = new System.Drawing.Point(12, 18);
            this.pcbLessonIcon.Name = "pcbLessonIcon";
            this.pcbLessonIcon.Size = new System.Drawing.Size(38, 38);
            this.pcbLessonIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbLessonIcon.TabIndex = 2;
            this.pcbLessonIcon.TabStop = false;
            // 
            // lessonRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.lblDersAdi);
            this.Controls.Add(this.pcbLessonIcon);
            this.Name = "lessonRows";
            this.Size = new System.Drawing.Size(200, 78);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLessonIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.PictureBox pcbLessonIcon;
    }
}
