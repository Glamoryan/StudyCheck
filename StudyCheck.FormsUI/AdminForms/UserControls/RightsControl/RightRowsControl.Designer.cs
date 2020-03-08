namespace StudyCheck.FormsUI.AdminForms.UserControls.RightsControl
{
    partial class RightRowsControl
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
            this.lblYetkiId = new System.Windows.Forms.Label();
            this.lblYetkiAd = new System.Windows.Forms.Label();
            this.lblEkleyen = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
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
            this.btnDuzenle.Location = new System.Drawing.Point(953, 10);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(40, 23);
            this.btnDuzenle.TabIndex = 4;
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lblYetkiId
            // 
            this.lblYetkiId.AutoSize = true;
            this.lblYetkiId.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblYetkiId.Location = new System.Drawing.Point(50, 12);
            this.lblYetkiId.Name = "lblYetkiId";
            this.lblYetkiId.Size = new System.Drawing.Size(53, 17);
            this.lblYetkiId.TabIndex = 5;
            this.lblYetkiId.Text = "YetkiId";
            // 
            // lblYetkiAd
            // 
            this.lblYetkiAd.AutoSize = true;
            this.lblYetkiAd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiAd.ForeColor = System.Drawing.Color.White;
            this.lblYetkiAd.Location = new System.Drawing.Point(199, 12);
            this.lblYetkiAd.Name = "lblYetkiAd";
            this.lblYetkiAd.Size = new System.Drawing.Size(57, 17);
            this.lblYetkiAd.TabIndex = 6;
            this.lblYetkiAd.Text = "YetkiAd";
            // 
            // lblEkleyen
            // 
            this.lblEkleyen.AutoSize = true;
            this.lblEkleyen.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkleyen.ForeColor = System.Drawing.Color.White;
            this.lblEkleyen.Location = new System.Drawing.Point(403, 12);
            this.lblEkleyen.Name = "lblEkleyen";
            this.lblEkleyen.Size = new System.Drawing.Size(59, 17);
            this.lblEkleyen.TabIndex = 6;
            this.lblEkleyen.Text = "Ekleyen";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(597, 12);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(78, 17);
            this.lblTarih.TabIndex = 6;
            this.lblTarih.Text = "KayıtTarihi";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.White;
            this.lblDurum.Location = new System.Drawing.Point(808, 12);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(52, 17);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "Durum";
            // 
            // RightRowsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblEkleyen);
            this.Controls.Add(this.lblYetkiAd);
            this.Controls.Add(this.lblYetkiId);
            this.Controls.Add(this.btnDuzenle);
            this.Name = "RightRowsControl";
            this.Size = new System.Drawing.Size(1032, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnDuzenle;
        public System.Windows.Forms.Label lblYetkiId;
        public System.Windows.Forms.Label lblYetkiAd;
        public System.Windows.Forms.Label lblEkleyen;
        public System.Windows.Forms.Label lblTarih;
        public System.Windows.Forms.Label lblDurum;
    }
}
