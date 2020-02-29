using StudyCheck.Entites.AccountManagement;
using StudyCheck.Entites.Concrete;
using System.Collections.Generic;

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    partial class UserSettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingsControl));
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUyeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUyeAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUyeSoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxUye = new System.Windows.Forms.GroupBox();
            this.gbxHesap = new System.Windows.Forms.GroupBox();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.cbxTema = new System.Windows.Forms.ComboBox();
            this.cbxSifreGoster = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxKullaniciMail = new System.Windows.Forms.TextBox();
            this.tbxKayitTarihi = new System.Windows.Forms.TextBox();
            this.tbxKullaniciSifre = new System.Windows.Forms.TextBox();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxGuncellemeTarihi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.btnUyeDuzenle = new System.Windows.Forms.Button();
            this.btnHesapDuzenle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnHesapSuccess = new System.Windows.Forms.Button();
            this.btnHesapCancel = new System.Windows.Forms.Button();
            this.btnUyeCancel = new System.Windows.Forms.Button();
            this.btnUyeSuccess = new System.Windows.Forms.Button();
            this.lblUyeDId = new System.Windows.Forms.Label();
            this.gbxUye.SuspendLayout();
            this.gbxHesap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(160, 18);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(127, 19);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "kullaniciAdiLabel";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şu kullanıcı için :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(34, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 2);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(43, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Üye Id";
            // 
            // tbxUyeId
            // 
            this.tbxUyeId.Enabled = false;
            this.tbxUyeId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUyeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxUyeId.Location = new System.Drawing.Point(109, 51);
            this.tbxUyeId.Name = "tbxUyeId";
            this.tbxUyeId.Size = new System.Drawing.Size(46, 27);
            this.tbxUyeId.TabIndex = 3;
            this.tbxUyeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Üye Adı";
            // 
            // tbxUyeAdi
            // 
            this.tbxUyeAdi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUyeAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxUyeAdi.Location = new System.Drawing.Point(109, 122);
            this.tbxUyeAdi.Name = "tbxUyeAdi";
            this.tbxUyeAdi.Size = new System.Drawing.Size(148, 27);
            this.tbxUyeAdi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(13, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Üye Soyadı";
            // 
            // tbxUyeSoyadi
            // 
            this.tbxUyeSoyadi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUyeSoyadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxUyeSoyadi.Location = new System.Drawing.Point(109, 189);
            this.tbxUyeSoyadi.Name = "tbxUyeSoyadi";
            this.tbxUyeSoyadi.Size = new System.Drawing.Size(148, 27);
            this.tbxUyeSoyadi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label5.Location = new System.Drawing.Point(26, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // gbxUye
            // 
            this.gbxUye.Controls.Add(this.tbxUyeId);
            this.gbxUye.Controls.Add(this.tbxUyeSoyadi);
            this.gbxUye.Controls.Add(this.label2);
            this.gbxUye.Controls.Add(this.tbxUyeAdi);
            this.gbxUye.Controls.Add(this.label3);
            this.gbxUye.Controls.Add(this.label4);
            this.gbxUye.Enabled = false;
            this.gbxUye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxUye.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.gbxUye.Location = new System.Drawing.Point(743, 71);
            this.gbxUye.Name = "gbxUye";
            this.gbxUye.Size = new System.Drawing.Size(290, 254);
            this.gbxUye.TabIndex = 5;
            this.gbxUye.TabStop = false;
            this.gbxUye.Text = "Üye Ayarları";
            // 
            // gbxHesap
            // 
            this.gbxHesap.Controls.Add(this.cbxRol);
            this.gbxHesap.Controls.Add(this.cbxTema);
            this.gbxHesap.Controls.Add(this.cbxSifreGoster);
            this.gbxHesap.Controls.Add(this.label12);
            this.gbxHesap.Controls.Add(this.label11);
            this.gbxHesap.Controls.Add(this.label8);
            this.gbxHesap.Controls.Add(this.label7);
            this.gbxHesap.Controls.Add(this.label6);
            this.gbxHesap.Controls.Add(this.cbxDurum);
            this.gbxHesap.Controls.Add(this.label5);
            this.gbxHesap.Controls.Add(this.tbxKullaniciMail);
            this.gbxHesap.Controls.Add(this.tbxKayitTarihi);
            this.gbxHesap.Controls.Add(this.tbxKullaniciSifre);
            this.gbxHesap.Controls.Add(this.tbxKullaniciAdi);
            this.gbxHesap.Controls.Add(this.label10);
            this.gbxHesap.Enabled = false;
            this.gbxHesap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxHesap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.gbxHesap.Location = new System.Drawing.Point(34, 71);
            this.gbxHesap.Name = "gbxHesap";
            this.gbxHesap.Size = new System.Drawing.Size(703, 302);
            this.gbxHesap.TabIndex = 6;
            this.gbxHesap.TabStop = false;
            this.gbxHesap.Text = "Hesap Ayarları";
            // 
            // cbxRol
            // 
            this.cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Items.AddRange(new object[] {
            "Seçiniz...",
            "Admin",
            "Kullanıcı"});
            this.cbxRol.Location = new System.Drawing.Point(501, 189);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(121, 27);
            this.cbxRol.TabIndex = 8;
            // 
            // cbxTema
            // 
            this.cbxTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxTema.FormattingEnabled = true;
            this.cbxTema.Items.AddRange(new object[] {
            "Seçiniz...",
            "Default",
            "Dark"});
            this.cbxTema.Location = new System.Drawing.Point(501, 122);
            this.cbxTema.Name = "cbxTema";
            this.cbxTema.Size = new System.Drawing.Size(121, 27);
            this.cbxTema.TabIndex = 7;
            // 
            // cbxSifreGoster
            // 
            this.cbxSifreGoster.AutoSize = true;
            this.cbxSifreGoster.Location = new System.Drawing.Point(515, 81);
            this.cbxSifreGoster.Name = "cbxSifreGoster";
            this.cbxSifreGoster.Size = new System.Drawing.Size(115, 23);
            this.cbxSifreGoster.TabIndex = 5;
            this.cbxSifreGoster.Text = "Şifreyi Göster";
            this.cbxSifreGoster.UseVisualStyleBackColor = true;
            this.cbxSifreGoster.CheckedChanged += new System.EventHandler(this.cbxSifreGoster_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label12.Location = new System.Drawing.Point(443, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Rol";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label11.Location = new System.Drawing.Point(443, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tema";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label8.Location = new System.Drawing.Point(34, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kayıt Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label7.Location = new System.Drawing.Point(18, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kullanıcı Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label6.Location = new System.Drawing.Point(387, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kullanıcı Şifresi";
            // 
            // tbxKullaniciMail
            // 
            this.tbxKullaniciMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKullaniciMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxKullaniciMail.Location = new System.Drawing.Point(132, 119);
            this.tbxKullaniciMail.Name = "tbxKullaniciMail";
            this.tbxKullaniciMail.Size = new System.Drawing.Size(224, 27);
            this.tbxKullaniciMail.TabIndex = 4;
            // 
            // tbxKayitTarihi
            // 
            this.tbxKayitTarihi.Enabled = false;
            this.tbxKayitTarihi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKayitTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxKayitTarihi.Location = new System.Drawing.Point(132, 189);
            this.tbxKayitTarihi.Name = "tbxKayitTarihi";
            this.tbxKayitTarihi.Size = new System.Drawing.Size(148, 27);
            this.tbxKayitTarihi.TabIndex = 4;
            // 
            // tbxKullaniciSifre
            // 
            this.tbxKullaniciSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKullaniciSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxKullaniciSifre.Location = new System.Drawing.Point(501, 48);
            this.tbxKullaniciSifre.Name = "tbxKullaniciSifre";
            this.tbxKullaniciSifre.PasswordChar = '*';
            this.tbxKullaniciSifre.Size = new System.Drawing.Size(148, 27);
            this.tbxKullaniciSifre.TabIndex = 4;
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(132, 47);
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(148, 27);
            this.tbxKullaniciAdi.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label9.Location = new System.Drawing.Point(30, 603);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Son Güncelleme";
            // 
            // tbxGuncellemeTarihi
            // 
            this.tbxGuncellemeTarihi.Enabled = false;
            this.tbxGuncellemeTarihi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncellemeTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxGuncellemeTarihi.Location = new System.Drawing.Point(151, 599);
            this.tbxGuncellemeTarihi.Name = "tbxGuncellemeTarihi";
            this.tbxGuncellemeTarihi.Size = new System.Drawing.Size(148, 27);
            this.tbxGuncellemeTarihi.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label10.Location = new System.Drawing.Point(57, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Durum";
            // 
            // cbxDurum
            // 
            this.cbxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.cbxDurum.Location = new System.Drawing.Point(132, 245);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(121, 27);
            this.cbxDurum.TabIndex = 6;
            // 
            // btnUyeDuzenle
            // 
            this.btnUyeDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnUyeDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeDuzenle.FlatAppearance.BorderSize = 0;
            this.btnUyeDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnUyeDuzenle.Location = new System.Drawing.Point(743, 331);
            this.btnUyeDuzenle.Name = "btnUyeDuzenle";
            this.btnUyeDuzenle.Size = new System.Drawing.Size(108, 42);
            this.btnUyeDuzenle.TabIndex = 7;
            this.btnUyeDuzenle.Text = "Üye Düzenle";
            this.btnUyeDuzenle.UseVisualStyleBackColor = false;
            this.btnUyeDuzenle.Click += new System.EventHandler(this.btnUyeDuzenle_Click);
            // 
            // btnHesapDuzenle
            // 
            this.btnHesapDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnHesapDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapDuzenle.FlatAppearance.BorderSize = 0;
            this.btnHesapDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnHesapDuzenle.Location = new System.Drawing.Point(34, 379);
            this.btnHesapDuzenle.Name = "btnHesapDuzenle";
            this.btnHesapDuzenle.Size = new System.Drawing.Size(112, 42);
            this.btnHesapDuzenle.TabIndex = 7;
            this.btnHesapDuzenle.Text = "Hesap Düzenle";
            this.btnHesapDuzenle.UseVisualStyleBackColor = false;
            this.btnHesapDuzenle.Click += new System.EventHandler(this.btnHesapDuzenle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(871, 592);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(162, 42);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnIptal.Location = new System.Drawing.Point(703, 592);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(162, 42);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnHesapSuccess
            // 
            this.btnHesapSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnHesapSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapSuccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnHesapSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnHesapSuccess.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapSuccess.Image")));
            this.btnHesapSuccess.Location = new System.Drawing.Point(152, 379);
            this.btnHesapSuccess.Name = "btnHesapSuccess";
            this.btnHesapSuccess.Size = new System.Drawing.Size(41, 42);
            this.btnHesapSuccess.TabIndex = 7;
            this.btnHesapSuccess.UseVisualStyleBackColor = false;
            this.btnHesapSuccess.Visible = false;
            this.btnHesapSuccess.Click += new System.EventHandler(this.btnHesapSuccess_Click);
            // 
            // btnHesapCancel
            // 
            this.btnHesapCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnHesapCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnHesapCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnHesapCancel.Image = global::StudyCheck.FormsUI.Properties.Resources.cancel_32px;
            this.btnHesapCancel.Location = new System.Drawing.Point(198, 379);
            this.btnHesapCancel.Name = "btnHesapCancel";
            this.btnHesapCancel.Size = new System.Drawing.Size(41, 42);
            this.btnHesapCancel.TabIndex = 7;
            this.btnHesapCancel.UseVisualStyleBackColor = false;
            this.btnHesapCancel.Visible = false;
            this.btnHesapCancel.Click += new System.EventHandler(this.btnHesapCancel_Click);
            // 
            // btnUyeCancel
            // 
            this.btnUyeCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnUyeCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnUyeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnUyeCancel.Image = global::StudyCheck.FormsUI.Properties.Resources.cancel_32px;
            this.btnUyeCancel.Location = new System.Drawing.Point(904, 331);
            this.btnUyeCancel.Name = "btnUyeCancel";
            this.btnUyeCancel.Size = new System.Drawing.Size(41, 42);
            this.btnUyeCancel.TabIndex = 7;
            this.btnUyeCancel.UseVisualStyleBackColor = false;
            this.btnUyeCancel.Visible = false;
            this.btnUyeCancel.Click += new System.EventHandler(this.btnUyeCancel_Click);
            // 
            // btnUyeSuccess
            // 
            this.btnUyeSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnUyeSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeSuccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnUyeSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnUyeSuccess.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeSuccess.Image")));
            this.btnUyeSuccess.Location = new System.Drawing.Point(857, 331);
            this.btnUyeSuccess.Name = "btnUyeSuccess";
            this.btnUyeSuccess.Size = new System.Drawing.Size(41, 42);
            this.btnUyeSuccess.TabIndex = 7;
            this.btnUyeSuccess.UseVisualStyleBackColor = false;
            this.btnUyeSuccess.Visible = false;
            this.btnUyeSuccess.Click += new System.EventHandler(this.btnUyeSuccess_Click);
            // 
            // lblUyeDId
            // 
            this.lblUyeDId.AutoSize = true;
            this.lblUyeDId.Location = new System.Drawing.Point(444, 23);
            this.lblUyeDId.Name = "lblUyeDId";
            this.lblUyeDId.Size = new System.Drawing.Size(41, 13);
            this.lblUyeDId.TabIndex = 8;
            this.lblUyeDId.Text = "label13";
            this.lblUyeDId.Visible = false;
            // 
            // UserSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.lblUyeDId);
            this.Controls.Add(this.btnUyeSuccess);
            this.Controls.Add(this.btnHesapSuccess);
            this.Controls.Add(this.btnHesapCancel);
            this.Controls.Add(this.btnUyeCancel);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnHesapDuzenle);
            this.Controls.Add(this.btnUyeDuzenle);
            this.Controls.Add(this.gbxHesap);
            this.Controls.Add(this.gbxUye);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.tbxGuncellemeTarihi);
            this.Name = "UserSettingsControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.UserSettingsControl_Load);
            this.gbxUye.ResumeLayout(false);
            this.gbxUye.PerformLayout();
            this.gbxHesap.ResumeLayout(false);
            this.gbxHesap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxUye;
        private System.Windows.Forms.GroupBox gbxHesap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxSifreGoster;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUyeDuzenle;
        private System.Windows.Forms.Button btnHesapDuzenle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        public System.Windows.Forms.Label lblKullaniciAdi;
        public System.Windows.Forms.TextBox tbxUyeId;
        public System.Windows.Forms.TextBox tbxUyeAdi;
        public System.Windows.Forms.TextBox tbxUyeSoyadi;
        public System.Windows.Forms.TextBox tbxKullaniciAdi;
        public System.Windows.Forms.TextBox tbxKullaniciSifre;
        public System.Windows.Forms.TextBox tbxKullaniciMail;
        public System.Windows.Forms.TextBox tbxKayitTarihi;
        public System.Windows.Forms.TextBox tbxGuncellemeTarihi;
        public System.Windows.Forms.ComboBox cbxDurum;
        public System.Windows.Forms.ComboBox cbxTema;
        public System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.Button btnUyeCancel;
        private System.Windows.Forms.Button btnHesapCancel;
        private System.Windows.Forms.Button btnHesapSuccess;
        private System.Windows.Forms.Button btnUyeSuccess;
        public System.Windows.Forms.Label lblUyeDId;
    }
}
