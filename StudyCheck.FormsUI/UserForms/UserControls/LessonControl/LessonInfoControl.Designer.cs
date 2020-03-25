namespace StudyCheck.FormsUI.UserForms.UserControls.LessonControl
{
    partial class LessonInfoControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDersAd = new System.Windows.Forms.Label();
            this.lblToplamCalisilanSaat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Son Çalışılan Ders :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Derse Çalışılan Toplam Dakika :";
            // 
            // lblDersAd
            // 
            this.lblDersAd.AutoSize = true;
            this.lblDersAd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersAd.ForeColor = System.Drawing.Color.White;
            this.lblDersAd.Location = new System.Drawing.Point(144, 19);
            this.lblDersAd.Name = "lblDersAd";
            this.lblDersAd.Size = new System.Drawing.Size(32, 17);
            this.lblDersAd.TabIndex = 20;
            this.lblDersAd.Text = "Yok";
            // 
            // lblToplamCalisilanSaat
            // 
            this.lblToplamCalisilanSaat.AutoSize = true;
            this.lblToplamCalisilanSaat.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamCalisilanSaat.ForeColor = System.Drawing.Color.White;
            this.lblToplamCalisilanSaat.Location = new System.Drawing.Point(222, 52);
            this.lblToplamCalisilanSaat.Name = "lblToplamCalisilanSaat";
            this.lblToplamCalisilanSaat.Size = new System.Drawing.Size(16, 17);
            this.lblToplamCalisilanSaat.TabIndex = 20;
            this.lblToplamCalisilanSaat.Text = "0";
            // 
            // LessonInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lblToplamCalisilanSaat);
            this.Controls.Add(this.lblDersAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "LessonInfoControl";
            this.Size = new System.Drawing.Size(278, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblDersAd;
        public System.Windows.Forms.Label lblToplamCalisilanSaat;
    }
}
