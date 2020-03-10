namespace StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl
{
    partial class LessonSettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonSettingsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.gbxDers = new System.Windows.Forms.GroupBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.cbxDersSinav = new System.Windows.Forms.ComboBox();
            this.tbxTarih = new System.Windows.Forms.TextBox();
            this.tbxEkleyen = new System.Windows.Forms.TextBox();
            this.tbxDersAdi = new System.Windows.Forms.TextBox();
            this.tbxDersId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxGuncelleme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxGuncelleyen = new System.Windows.Forms.TextBox();
            this.btnDersDuzenle = new System.Windows.Forms.Button();
            this.btnDersSuccess = new System.Windows.Forms.Button();
            this.btnDersCancel = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gbxDers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şu ders için :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(34, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 2);
            this.panel1.TabIndex = 9;
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblDersAdi.Location = new System.Drawing.Point(139, 18);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(101, 19);
            this.lblDersAdi.TabIndex = 10;
            this.lblDersAdi.Text = "dersAdıLabel";
            this.lblDersAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxDers
            // 
            this.gbxDers.Controls.Add(this.cbxDurum);
            this.gbxDers.Controls.Add(this.cbxDersSinav);
            this.gbxDers.Controls.Add(this.tbxTarih);
            this.gbxDers.Controls.Add(this.tbxEkleyen);
            this.gbxDers.Controls.Add(this.tbxDersAdi);
            this.gbxDers.Controls.Add(this.tbxDersId);
            this.gbxDers.Controls.Add(this.label8);
            this.gbxDers.Controls.Add(this.label6);
            this.gbxDers.Controls.Add(this.label5);
            this.gbxDers.Controls.Add(this.label4);
            this.gbxDers.Controls.Add(this.label3);
            this.gbxDers.Controls.Add(this.label2);
            this.gbxDers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.gbxDers.Location = new System.Drawing.Point(210, 92);
            this.gbxDers.Name = "gbxDers";
            this.gbxDers.Size = new System.Drawing.Size(623, 227);
            this.gbxDers.TabIndex = 11;
            this.gbxDers.TabStop = false;
            this.gbxDers.Text = "Ders Ayarları";
            // 
            // cbxDurum
            // 
            this.cbxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.cbxDurum.Location = new System.Drawing.Point(462, 107);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(121, 27);
            this.cbxDurum.TabIndex = 16;
            // 
            // cbxDersSinav
            // 
            this.cbxDersSinav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDersSinav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxDersSinav.FormattingEnabled = true;
            this.cbxDersSinav.Location = new System.Drawing.Point(462, 165);
            this.cbxDersSinav.Name = "cbxDersSinav";
            this.cbxDersSinav.Size = new System.Drawing.Size(121, 27);
            this.cbxDersSinav.TabIndex = 15;
            // 
            // tbxTarih
            // 
            this.tbxTarih.Enabled = false;
            this.tbxTarih.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxTarih.Location = new System.Drawing.Point(110, 165);
            this.tbxTarih.Name = "tbxTarih";
            this.tbxTarih.Size = new System.Drawing.Size(178, 26);
            this.tbxTarih.TabIndex = 14;
            // 
            // tbxEkleyen
            // 
            this.tbxEkleyen.Enabled = false;
            this.tbxEkleyen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkleyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxEkleyen.Location = new System.Drawing.Point(462, 48);
            this.tbxEkleyen.Name = "tbxEkleyen";
            this.tbxEkleyen.Size = new System.Drawing.Size(130, 26);
            this.tbxEkleyen.TabIndex = 14;
            // 
            // tbxDersAdi
            // 
            this.tbxDersAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDersAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxDersAdi.Location = new System.Drawing.Point(110, 107);
            this.tbxDersAdi.Name = "tbxDersAdi";
            this.tbxDersAdi.Size = new System.Drawing.Size(130, 26);
            this.tbxDersAdi.TabIndex = 14;
            // 
            // tbxDersId
            // 
            this.tbxDersId.Enabled = false;
            this.tbxDersId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDersId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxDersId.Location = new System.Drawing.Point(110, 48);
            this.tbxDersId.Name = "tbxDersId";
            this.tbxDersId.Size = new System.Drawing.Size(43, 26);
            this.tbxDersId.TabIndex = 13;
            this.tbxDersId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label8.Location = new System.Drawing.Point(393, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Durum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label6.Location = new System.Drawing.Point(386, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ekleyen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label5.Location = new System.Drawing.Point(18, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kayıt Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(318, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kayıtlı Olduğu Sınav";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ders Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ders Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label7.Location = new System.Drawing.Point(88, 607);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Son Guncelleme";
            // 
            // tbxGuncelleme
            // 
            this.tbxGuncelleme.Enabled = false;
            this.tbxGuncelleme.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxGuncelleme.Location = new System.Drawing.Point(210, 604);
            this.tbxGuncelleme.Name = "tbxGuncelleme";
            this.tbxGuncelleme.Size = new System.Drawing.Size(178, 26);
            this.tbxGuncelleme.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label9.Location = new System.Drawing.Point(88, 553);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Son Güncelleyen";
            // 
            // tbxGuncelleyen
            // 
            this.tbxGuncelleyen.Enabled = false;
            this.tbxGuncelleyen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxGuncelleyen.Location = new System.Drawing.Point(210, 550);
            this.tbxGuncelleyen.Name = "tbxGuncelleyen";
            this.tbxGuncelleyen.Size = new System.Drawing.Size(130, 26);
            this.tbxGuncelleyen.TabIndex = 14;
            // 
            // btnDersDuzenle
            // 
            this.btnDersDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnDersDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDersDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDersDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnDersDuzenle.Location = new System.Drawing.Point(210, 325);
            this.btnDersDuzenle.Name = "btnDersDuzenle";
            this.btnDersDuzenle.Size = new System.Drawing.Size(112, 42);
            this.btnDersDuzenle.TabIndex = 19;
            this.btnDersDuzenle.Text = "Ders Düzenle";
            this.btnDersDuzenle.UseVisualStyleBackColor = false;
            // 
            // btnDersSuccess
            // 
            this.btnDersSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnDersSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDersSuccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnDersSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnDersSuccess.Image = ((System.Drawing.Image)(resources.GetObject("btnDersSuccess.Image")));
            this.btnDersSuccess.Location = new System.Drawing.Point(328, 325);
            this.btnDersSuccess.Name = "btnDersSuccess";
            this.btnDersSuccess.Size = new System.Drawing.Size(41, 42);
            this.btnDersSuccess.TabIndex = 17;
            this.btnDersSuccess.UseVisualStyleBackColor = false;
            this.btnDersSuccess.Visible = false;
            // 
            // btnDersCancel
            // 
            this.btnDersCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnDersCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDersCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnDersCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnDersCancel.Image = global::StudyCheck.FormsUI.Properties.Resources.cancel_32px;
            this.btnDersCancel.Location = new System.Drawing.Point(375, 325);
            this.btnDersCancel.Name = "btnDersCancel";
            this.btnDersCancel.Size = new System.Drawing.Size(41, 42);
            this.btnDersCancel.TabIndex = 18;
            this.btnDersCancel.UseVisualStyleBackColor = false;
            this.btnDersCancel.Visible = false;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnIptal.Location = new System.Drawing.Point(694, 588);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(162, 42);
            this.btnIptal.TabIndex = 20;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(862, 588);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(162, 42);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // LessonSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDersDuzenle);
            this.Controls.Add(this.btnDersSuccess);
            this.Controls.Add(this.btnDersCancel);
            this.Controls.Add(this.gbxDers);
            this.Controls.Add(this.tbxGuncelleme);
            this.Controls.Add(this.lblDersAdi);
            this.Controls.Add(this.tbxGuncelleyen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Name = "LessonSettingsControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.LessonSettingsControl_Load);
            this.gbxDers.ResumeLayout(false);
            this.gbxDers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.GroupBox gbxDers;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxDersId;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxDersAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbxTarih;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbxEkleyen;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbxGuncelleme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbxGuncelleyen;
        private System.Windows.Forms.Button btnDersDuzenle;
        private System.Windows.Forms.Button btnDersSuccess;
        private System.Windows.Forms.Button btnDersCancel;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.ComboBox cbxDersSinav;
        public System.Windows.Forms.ComboBox cbxDurum;
    }
}
