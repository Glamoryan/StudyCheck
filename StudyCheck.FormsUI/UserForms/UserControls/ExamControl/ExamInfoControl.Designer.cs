namespace StudyCheck.FormsUI.UserForms.UserControls.ExamControl
{
    partial class ExamInfoControl
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
            this.lblSinavTarih = new System.Windows.Forms.Label();
            this.lblToplamCalisilanSaat = new System.Windows.Forms.Label();
            this.lblSinavAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSinavTarih
            // 
            this.lblSinavTarih.AutoSize = true;
            this.lblSinavTarih.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavTarih.ForeColor = System.Drawing.Color.White;
            this.lblSinavTarih.Location = new System.Drawing.Point(108, 89);
            this.lblSinavTarih.Name = "lblSinavTarih";
            this.lblSinavTarih.Size = new System.Drawing.Size(13, 17);
            this.lblSinavTarih.TabIndex = 17;
            this.lblSinavTarih.Text = "-";
            // 
            // lblToplamCalisilanSaat
            // 
            this.lblToplamCalisilanSaat.AutoSize = true;
            this.lblToplamCalisilanSaat.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamCalisilanSaat.ForeColor = System.Drawing.Color.White;
            this.lblToplamCalisilanSaat.Location = new System.Drawing.Point(227, 51);
            this.lblToplamCalisilanSaat.Name = "lblToplamCalisilanSaat";
            this.lblToplamCalisilanSaat.Size = new System.Drawing.Size(16, 17);
            this.lblToplamCalisilanSaat.TabIndex = 18;
            this.lblToplamCalisilanSaat.Text = "0";
            // 
            // lblSinavAd
            // 
            this.lblSinavAd.AutoSize = true;
            this.lblSinavAd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavAd.ForeColor = System.Drawing.Color.White;
            this.lblSinavAd.Location = new System.Drawing.Point(149, 16);
            this.lblSinavAd.Name = "lblSinavAd";
            this.lblSinavAd.Size = new System.Drawing.Size(32, 17);
            this.lblSinavAd.TabIndex = 19;
            this.lblSinavAd.Text = "Yok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sınav Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sınava Çalışılan Toplam Dakika :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Son Çalışılan Sınav :";
            // 
            // ExamInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lblSinavTarih);
            this.Controls.Add(this.lblToplamCalisilanSaat);
            this.Controls.Add(this.lblSinavAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ExamInfoControl";
            this.Size = new System.Drawing.Size(278, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSinavTarih;
        public System.Windows.Forms.Label lblToplamCalisilanSaat;
        public System.Windows.Forms.Label lblSinavAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
