namespace StudyCheck.FormsUI.AdminForms.UserControls.ExamControl
{
    partial class ExamSettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamSettingsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSinavAdi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxSinav = new System.Windows.Forms.GroupBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.mtbxSinavTarihi = new System.Windows.Forms.MaskedTextBox();
            this.tbxSinavAd = new System.Windows.Forms.TextBox();
            this.tbxEkleyen = new System.Windows.Forms.TextBox();
            this.tbxKayitTarihi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSinavId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSinavDuzenle = new System.Windows.Forms.Button();
            this.btnSinavSuccess = new System.Windows.Forms.Button();
            this.btnSinavCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxGuncelleme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxGuncelleyen = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gbxSinav.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Şu sınav için :";
            // 
            // lblSinavAdi
            // 
            this.lblSinavAdi.AutoSize = true;
            this.lblSinavAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblSinavAdi.Location = new System.Drawing.Point(144, 18);
            this.lblSinavAdi.Name = "lblSinavAdi";
            this.lblSinavAdi.Size = new System.Drawing.Size(106, 19);
            this.lblSinavAdi.TabIndex = 11;
            this.lblSinavAdi.Text = "sınavAdıLabel";
            this.lblSinavAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(34, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 2);
            this.panel1.TabIndex = 12;
            // 
            // gbxSinav
            // 
            this.gbxSinav.Controls.Add(this.cbxDurum);
            this.gbxSinav.Controls.Add(this.mtbxSinavTarihi);
            this.gbxSinav.Controls.Add(this.tbxSinavAd);
            this.gbxSinav.Controls.Add(this.tbxEkleyen);
            this.gbxSinav.Controls.Add(this.tbxKayitTarihi);
            this.gbxSinav.Controls.Add(this.label6);
            this.gbxSinav.Controls.Add(this.label5);
            this.gbxSinav.Controls.Add(this.label4);
            this.gbxSinav.Controls.Add(this.label9);
            this.gbxSinav.Controls.Add(this.label3);
            this.gbxSinav.Controls.Add(this.tbxSinavId);
            this.gbxSinav.Controls.Add(this.label2);
            this.gbxSinav.Enabled = false;
            this.gbxSinav.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSinav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.gbxSinav.Location = new System.Drawing.Point(238, 113);
            this.gbxSinav.Name = "gbxSinav";
            this.gbxSinav.Size = new System.Drawing.Size(586, 252);
            this.gbxSinav.TabIndex = 13;
            this.gbxSinav.TabStop = false;
            this.gbxSinav.Text = "Sınav Ayarları";
            // 
            // cbxDurum
            // 
            this.cbxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.cbxDurum.Location = new System.Drawing.Point(388, 115);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(121, 27);
            this.cbxDurum.TabIndex = 28;
            // 
            // mtbxSinavTarihi
            // 
            this.mtbxSinavTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.mtbxSinavTarihi.Location = new System.Drawing.Point(131, 169);
            this.mtbxSinavTarihi.Mask = "00/00/0000";
            this.mtbxSinavTarihi.Name = "mtbxSinavTarihi";
            this.mtbxSinavTarihi.Size = new System.Drawing.Size(99, 27);
            this.mtbxSinavTarihi.TabIndex = 27;
            this.mtbxSinavTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // tbxSinavAd
            // 
            this.tbxSinavAd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSinavAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxSinavAd.Location = new System.Drawing.Point(131, 115);
            this.tbxSinavAd.Name = "tbxSinavAd";
            this.tbxSinavAd.Size = new System.Drawing.Size(130, 26);
            this.tbxSinavAd.TabIndex = 17;
            // 
            // tbxEkleyen
            // 
            this.tbxEkleyen.Enabled = false;
            this.tbxEkleyen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkleyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxEkleyen.Location = new System.Drawing.Point(388, 61);
            this.tbxEkleyen.Name = "tbxEkleyen";
            this.tbxEkleyen.Size = new System.Drawing.Size(130, 26);
            this.tbxEkleyen.TabIndex = 17;
            // 
            // tbxKayitTarihi
            // 
            this.tbxKayitTarihi.Enabled = false;
            this.tbxKayitTarihi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKayitTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxKayitTarihi.Location = new System.Drawing.Point(388, 169);
            this.tbxKayitTarihi.Name = "tbxKayitTarihi";
            this.tbxKayitTarihi.Size = new System.Drawing.Size(153, 26);
            this.tbxKayitTarihi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label6.Location = new System.Drawing.Point(314, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ekleyen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label5.Location = new System.Drawing.Point(269, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Eklenme Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(33, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sınav Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label9.Location = new System.Drawing.Point(321, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(46, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sınav Adı";
            // 
            // tbxSinavId
            // 
            this.tbxSinavId.Enabled = false;
            this.tbxSinavId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSinavId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxSinavId.Location = new System.Drawing.Point(131, 61);
            this.tbxSinavId.Name = "tbxSinavId";
            this.tbxSinavId.Size = new System.Drawing.Size(43, 26);
            this.tbxSinavId.TabIndex = 15;
            this.tbxSinavId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(55, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sınav Id";
            // 
            // btnSinavDuzenle
            // 
            this.btnSinavDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnSinavDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinavDuzenle.FlatAppearance.BorderSize = 0;
            this.btnSinavDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnSinavDuzenle.Location = new System.Drawing.Point(238, 371);
            this.btnSinavDuzenle.Name = "btnSinavDuzenle";
            this.btnSinavDuzenle.Size = new System.Drawing.Size(112, 42);
            this.btnSinavDuzenle.TabIndex = 22;
            this.btnSinavDuzenle.Text = "Sınav Düzenle";
            this.btnSinavDuzenle.UseVisualStyleBackColor = false;
            this.btnSinavDuzenle.Click += new System.EventHandler(this.btnSinavDuzenle_Click);
            // 
            // btnSinavSuccess
            // 
            this.btnSinavSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnSinavSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinavSuccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnSinavSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnSinavSuccess.Image = ((System.Drawing.Image)(resources.GetObject("btnSinavSuccess.Image")));
            this.btnSinavSuccess.Location = new System.Drawing.Point(356, 371);
            this.btnSinavSuccess.Name = "btnSinavSuccess";
            this.btnSinavSuccess.Size = new System.Drawing.Size(41, 42);
            this.btnSinavSuccess.TabIndex = 20;
            this.btnSinavSuccess.UseVisualStyleBackColor = false;
            this.btnSinavSuccess.Visible = false;
            this.btnSinavSuccess.Click += new System.EventHandler(this.btnSinavSuccess_Click);
            // 
            // btnSinavCancel
            // 
            this.btnSinavCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnSinavCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinavCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnSinavCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnSinavCancel.Image = global::StudyCheck.FormsUI.Properties.Resources.cancel_32px;
            this.btnSinavCancel.Location = new System.Drawing.Point(403, 371);
            this.btnSinavCancel.Name = "btnSinavCancel";
            this.btnSinavCancel.Size = new System.Drawing.Size(41, 42);
            this.btnSinavCancel.TabIndex = 21;
            this.btnSinavCancel.UseVisualStyleBackColor = false;
            this.btnSinavCancel.Visible = false;
            this.btnSinavCancel.Click += new System.EventHandler(this.btnSinavCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label7.Location = new System.Drawing.Point(119, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Son Guncelleme";
            // 
            // tbxGuncelleme
            // 
            this.tbxGuncelleme.Enabled = false;
            this.tbxGuncelleme.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxGuncelleme.Location = new System.Drawing.Point(238, 601);
            this.tbxGuncelleme.Name = "tbxGuncelleme";
            this.tbxGuncelleme.Size = new System.Drawing.Size(153, 26);
            this.tbxGuncelleme.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label8.Location = new System.Drawing.Point(119, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Son Guncelleyen";
            // 
            // tbxGuncelleyen
            // 
            this.tbxGuncelleyen.Enabled = false;
            this.tbxGuncelleyen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxGuncelleyen.Location = new System.Drawing.Point(238, 550);
            this.tbxGuncelleyen.Name = "tbxGuncelleyen";
            this.tbxGuncelleyen.Size = new System.Drawing.Size(153, 26);
            this.tbxGuncelleyen.TabIndex = 17;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnIptal.Location = new System.Drawing.Point(697, 591);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(162, 42);
            this.btnIptal.TabIndex = 23;
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
            this.btnKaydet.Location = new System.Drawing.Point(865, 591);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(162, 42);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ExamSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSinavDuzenle);
            this.Controls.Add(this.btnSinavSuccess);
            this.Controls.Add(this.btnSinavCancel);
            this.Controls.Add(this.tbxGuncelleyen);
            this.Controls.Add(this.tbxGuncelleme);
            this.Controls.Add(this.gbxSinav);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSinavAdi);
            this.Controls.Add(this.label1);
            this.Name = "ExamSettingsControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.ExamSettingsControl_Load);
            this.gbxSinav.ResumeLayout(false);
            this.gbxSinav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblSinavAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxSinav;
        public System.Windows.Forms.TextBox tbxSinavId;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxKayitTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSinavDuzenle;
        private System.Windows.Forms.Button btnSinavSuccess;
        private System.Windows.Forms.Button btnSinavCancel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox mtbxSinavTarihi;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbxSinavAd;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbxEkleyen;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbxGuncelleme;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbxGuncelleyen;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
    }
}
