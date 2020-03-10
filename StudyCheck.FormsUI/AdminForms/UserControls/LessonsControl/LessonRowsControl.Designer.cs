namespace StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl
{
    partial class LessonRowsControl
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
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lblDersId = new System.Windows.Forms.Label();
            this.lblDersAd = new System.Windows.Forms.Label();
            this.lblSinavi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblEkleyen = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(206)))), ((int)(((byte)(109)))));
            this.btnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Image = global::StudyCheck.FormsUI.Properties.Resources.edit_16px;
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuzenle.Location = new System.Drawing.Point(966, 10);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(40, 23);
            this.btnDuzenle.TabIndex = 5;
            this.btnDuzenle.UseVisualStyleBackColor = false;
            // 
            // lblDersId
            // 
            this.lblDersId.AutoSize = true;
            this.lblDersId.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblDersId.Location = new System.Drawing.Point(23, 12);
            this.lblDersId.Name = "lblDersId";
            this.lblDersId.Size = new System.Drawing.Size(50, 17);
            this.lblDersId.TabIndex = 6;
            this.lblDersId.Text = "DersId";
            // 
            // lblDersAd
            // 
            this.lblDersAd.AutoSize = true;
            this.lblDersAd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersAd.ForeColor = System.Drawing.Color.White;
            this.lblDersAd.Location = new System.Drawing.Point(138, 12);
            this.lblDersAd.Name = "lblDersAd";
            this.lblDersAd.Size = new System.Drawing.Size(54, 17);
            this.lblDersAd.TabIndex = 7;
            this.lblDersAd.Text = "DersAd";
            // 
            // lblSinavi
            // 
            this.lblSinavi.AutoSize = true;
            this.lblSinavi.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavi.ForeColor = System.Drawing.Color.White;
            this.lblSinavi.Location = new System.Drawing.Point(285, 12);
            this.lblSinavi.Name = "lblSinavi";
            this.lblSinavi.Size = new System.Drawing.Size(75, 17);
            this.lblSinavi.TabIndex = 7;
            this.lblSinavi.Text = "DersSınavı";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(482, 12);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(74, 17);
            this.lblTarih.TabIndex = 7;
            this.lblTarih.Text = "KayıtTarih";
            // 
            // lblEkleyen
            // 
            this.lblEkleyen.AutoSize = true;
            this.lblEkleyen.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkleyen.ForeColor = System.Drawing.Color.White;
            this.lblEkleyen.Location = new System.Drawing.Point(677, 12);
            this.lblEkleyen.Name = "lblEkleyen";
            this.lblEkleyen.Size = new System.Drawing.Size(88, 17);
            this.lblEkleyen.TabIndex = 7;
            this.lblEkleyen.Text = "DersEkleyen";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.White;
            this.lblDurum.Location = new System.Drawing.Point(847, 12);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(52, 17);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "Durum";
            // 
            // LessonRowsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblEkleyen);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSinavi);
            this.Controls.Add(this.lblDersAd);
            this.Controls.Add(this.lblDersId);
            this.Controls.Add(this.btnDuzenle);
            this.Name = "LessonRowsControl";
            this.Size = new System.Drawing.Size(1032, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnDuzenle;
        public System.Windows.Forms.Label lblDersId;
        public System.Windows.Forms.Label lblDersAd;
        public System.Windows.Forms.Label lblSinavi;
        public System.Windows.Forms.Label lblTarih;
        public System.Windows.Forms.Label lblEkleyen;
        public System.Windows.Forms.Label lblDurum;
    }
}
