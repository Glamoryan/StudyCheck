namespace StudyCheck.FormsUI.AdminForms.UserControls.RightsControl
{
    partial class RightSettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RightSettingsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYetkiAdi = new System.Windows.Forms.Label();
            this.gbxYetki = new System.Windows.Forms.GroupBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.tbxKayitTarih = new System.Windows.Forms.TextBox();
            this.tbxEkleyen = new System.Windows.Forms.TextBox();
            this.tbxYetkiAdi = new System.Windows.Forms.TextBox();
            this.tbxYetkiId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxGuncelleyen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxGuncellemeTarih = new System.Windows.Forms.TextBox();
            this.btnYetkiDuzenle = new System.Windows.Forms.Button();
            this.btnYetkiSuccess = new System.Windows.Forms.Button();
            this.btnYetkiCancel = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gbxYetki.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şu yetki için :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(34, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 2);
            this.panel1.TabIndex = 6;
            // 
            // lblYetkiAdi
            // 
            this.lblYetkiAdi.AutoSize = true;
            this.lblYetkiAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblYetkiAdi.Location = new System.Drawing.Point(141, 19);
            this.lblYetkiAdi.Name = "lblYetkiAdi";
            this.lblYetkiAdi.Size = new System.Drawing.Size(103, 19);
            this.lblYetkiAdi.TabIndex = 5;
            this.lblYetkiAdi.Text = "yetkiAdiLabel";
            this.lblYetkiAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxYetki
            // 
            this.gbxYetki.Controls.Add(this.cbxDurum);
            this.gbxYetki.Controls.Add(this.tbxKayitTarih);
            this.gbxYetki.Controls.Add(this.tbxEkleyen);
            this.gbxYetki.Controls.Add(this.tbxYetkiAdi);
            this.gbxYetki.Controls.Add(this.tbxYetkiId);
            this.gbxYetki.Controls.Add(this.label5);
            this.gbxYetki.Controls.Add(this.label4);
            this.gbxYetki.Controls.Add(this.label6);
            this.gbxYetki.Controls.Add(this.label3);
            this.gbxYetki.Controls.Add(this.label2);
            this.gbxYetki.Enabled = false;
            this.gbxYetki.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxYetki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.gbxYetki.Location = new System.Drawing.Point(195, 79);
            this.gbxYetki.Name = "gbxYetki";
            this.gbxYetki.Size = new System.Drawing.Size(617, 248);
            this.gbxYetki.TabIndex = 8;
            this.gbxYetki.TabStop = false;
            this.gbxYetki.Text = "Yetki Ayarları";
            // 
            // cbxDurum
            // 
            this.cbxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.cbxDurum.Location = new System.Drawing.Point(436, 109);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(121, 27);
            this.cbxDurum.TabIndex = 9;
            // 
            // tbxKayitTarih
            // 
            this.tbxKayitTarih.Enabled = false;
            this.tbxKayitTarih.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKayitTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxKayitTarih.Location = new System.Drawing.Point(153, 178);
            this.tbxKayitTarih.Name = "tbxKayitTarih";
            this.tbxKayitTarih.Size = new System.Drawing.Size(168, 26);
            this.tbxKayitTarih.TabIndex = 9;
            // 
            // tbxEkleyen
            // 
            this.tbxEkleyen.Enabled = false;
            this.tbxEkleyen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkleyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxEkleyen.Location = new System.Drawing.Point(436, 51);
            this.tbxEkleyen.Name = "tbxEkleyen";
            this.tbxEkleyen.Size = new System.Drawing.Size(130, 26);
            this.tbxEkleyen.TabIndex = 9;
            // 
            // tbxYetkiAdi
            // 
            this.tbxYetkiAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYetkiAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxYetkiAdi.Location = new System.Drawing.Point(153, 114);
            this.tbxYetkiAdi.Name = "tbxYetkiAdi";
            this.tbxYetkiAdi.Size = new System.Drawing.Size(130, 26);
            this.tbxYetkiAdi.TabIndex = 9;
            // 
            // tbxYetkiId
            // 
            this.tbxYetkiId.Enabled = false;
            this.tbxYetkiId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYetkiId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxYetkiId.Location = new System.Drawing.Point(153, 51);
            this.tbxYetkiId.Name = "tbxYetkiId";
            this.tbxYetkiId.Size = new System.Drawing.Size(43, 26);
            this.tbxYetkiId.TabIndex = 7;
            this.tbxYetkiId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label5.Location = new System.Drawing.Point(31, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yetki Kayıt Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(371, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ekleyen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label6.Location = new System.Drawing.Point(378, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(81, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yetki Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(81, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yetki Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label7.Location = new System.Drawing.Point(74, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Son Güncelleyen";
            // 
            // tbxGuncelleyen
            // 
            this.tbxGuncelleyen.Enabled = false;
            this.tbxGuncelleyen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxGuncelleyen.Location = new System.Drawing.Point(197, 549);
            this.tbxGuncelleyen.Name = "tbxGuncelleyen";
            this.tbxGuncelleyen.Size = new System.Drawing.Size(130, 26);
            this.tbxGuncelleyen.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label8.Location = new System.Drawing.Point(38, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Son Güncelleme Tarihi";
            // 
            // tbxGuncellemeTarih
            // 
            this.tbxGuncellemeTarih.Enabled = false;
            this.tbxGuncellemeTarih.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncellemeTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxGuncellemeTarih.Location = new System.Drawing.Point(197, 598);
            this.tbxGuncellemeTarih.Name = "tbxGuncellemeTarih";
            this.tbxGuncellemeTarih.Size = new System.Drawing.Size(168, 26);
            this.tbxGuncellemeTarih.TabIndex = 9;
            // 
            // btnYetkiDuzenle
            // 
            this.btnYetkiDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnYetkiDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkiDuzenle.FlatAppearance.BorderSize = 0;
            this.btnYetkiDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYetkiDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnYetkiDuzenle.Location = new System.Drawing.Point(195, 333);
            this.btnYetkiDuzenle.Name = "btnYetkiDuzenle";
            this.btnYetkiDuzenle.Size = new System.Drawing.Size(112, 42);
            this.btnYetkiDuzenle.TabIndex = 16;
            this.btnYetkiDuzenle.Text = "Yetki Düzenle";
            this.btnYetkiDuzenle.UseVisualStyleBackColor = false;
            this.btnYetkiDuzenle.Click += new System.EventHandler(this.btnYetkiDuzenle_Click);
            // 
            // btnYetkiSuccess
            // 
            this.btnYetkiSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnYetkiSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkiSuccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnYetkiSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYetkiSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnYetkiSuccess.Image = ((System.Drawing.Image)(resources.GetObject("btnYetkiSuccess.Image")));
            this.btnYetkiSuccess.Location = new System.Drawing.Point(313, 333);
            this.btnYetkiSuccess.Name = "btnYetkiSuccess";
            this.btnYetkiSuccess.Size = new System.Drawing.Size(41, 42);
            this.btnYetkiSuccess.TabIndex = 14;
            this.btnYetkiSuccess.UseVisualStyleBackColor = false;
            this.btnYetkiSuccess.Visible = false;
            this.btnYetkiSuccess.Click += new System.EventHandler(this.btnYetkiSuccess_Click);
            // 
            // btnYetkiCancel
            // 
            this.btnYetkiCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnYetkiCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkiCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnYetkiCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYetkiCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnYetkiCancel.Image = global::StudyCheck.FormsUI.Properties.Resources.cancel_32px;
            this.btnYetkiCancel.Location = new System.Drawing.Point(360, 333);
            this.btnYetkiCancel.Name = "btnYetkiCancel";
            this.btnYetkiCancel.Size = new System.Drawing.Size(41, 42);
            this.btnYetkiCancel.TabIndex = 15;
            this.btnYetkiCancel.UseVisualStyleBackColor = false;
            this.btnYetkiCancel.Visible = false;
            this.btnYetkiCancel.Click += new System.EventHandler(this.btnYetkiCancel_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnIptal.Location = new System.Drawing.Point(695, 578);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(162, 42);
            this.btnIptal.TabIndex = 17;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(863, 578);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(162, 42);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // RightSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYetkiDuzenle);
            this.Controls.Add(this.btnYetkiSuccess);
            this.Controls.Add(this.btnYetkiCancel);
            this.Controls.Add(this.gbxYetki);
            this.Controls.Add(this.tbxGuncellemeTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxGuncelleyen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblYetkiAdi);
            this.Controls.Add(this.label7);
            this.Name = "RightSettingsControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.RightSettingsControl_Load);
            this.gbxYetki.ResumeLayout(false);
            this.gbxYetki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblYetkiAdi;
        private System.Windows.Forms.GroupBox gbxYetki;
        public System.Windows.Forms.TextBox tbxYetkiId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxYetkiAdi;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbxEkleyen;
        public System.Windows.Forms.TextBox tbxKayitTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbxGuncelleyen;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbxGuncellemeTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnYetkiDuzenle;
        private System.Windows.Forms.Button btnYetkiSuccess;
        private System.Windows.Forms.Button btnYetkiCancel;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.ComboBox cbxDurum;
    }
}
