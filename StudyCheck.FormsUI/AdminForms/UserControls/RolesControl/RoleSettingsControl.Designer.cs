namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    partial class RoleSettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleSettingsControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblrolAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxRol = new System.Windows.Forms.GroupBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.tbxEkleyen = new System.Windows.Forms.TextBox();
            this.tbxRolAdi = new System.Windows.Forms.TextBox();
            this.tbxRolKayit = new System.Windows.Forms.TextBox();
            this.tbxYetkiId = new System.Windows.Forms.TextBox();
            this.tbxRolGuncelleme = new System.Windows.Forms.TextBox();
            this.tbxRolId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRolSuccess = new System.Windows.Forms.Button();
            this.btnRolCancel = new System.Windows.Forms.Button();
            this.btnRolDuzenle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gbxRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(34, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 2);
            this.panel1.TabIndex = 3;
            // 
            // lblrolAdi
            // 
            this.lblrolAdi.AutoSize = true;
            this.lblrolAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblrolAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblrolAdi.Location = new System.Drawing.Point(128, 19);
            this.lblrolAdi.Name = "lblrolAdi";
            this.lblrolAdi.Size = new System.Drawing.Size(90, 19);
            this.lblrolAdi.TabIndex = 2;
            this.lblrolAdi.Text = "rolAdiLabel";
            this.lblrolAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şu rol için :";
            // 
            // gbxRol
            // 
            this.gbxRol.Controls.Add(this.cbxDurum);
            this.gbxRol.Controls.Add(this.tbxEkleyen);
            this.gbxRol.Controls.Add(this.tbxRolAdi);
            this.gbxRol.Controls.Add(this.tbxRolKayit);
            this.gbxRol.Controls.Add(this.tbxYetkiId);
            this.gbxRol.Controls.Add(this.tbxRolGuncelleme);
            this.gbxRol.Controls.Add(this.tbxRolId);
            this.gbxRol.Controls.Add(this.label5);
            this.gbxRol.Controls.Add(this.label7);
            this.gbxRol.Controls.Add(this.label3);
            this.gbxRol.Controls.Add(this.label8);
            this.gbxRol.Controls.Add(this.label4);
            this.gbxRol.Controls.Add(this.label2);
            this.gbxRol.Controls.Add(this.label6);
            this.gbxRol.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.gbxRol.Location = new System.Drawing.Point(129, 59);
            this.gbxRol.Name = "gbxRol";
            this.gbxRol.Size = new System.Drawing.Size(791, 276);
            this.gbxRol.TabIndex = 5;
            this.gbxRol.TabStop = false;
            this.gbxRol.Text = "Rol Ayarları";
            // 
            // cbxDurum
            // 
            this.cbxDurum.BackColor = System.Drawing.Color.White;
            this.cbxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.cbxDurum.Location = new System.Drawing.Point(110, 199);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(121, 27);
            this.cbxDurum.TabIndex = 7;
            // 
            // tbxEkleyen
            // 
            this.tbxEkleyen.Enabled = false;
            this.tbxEkleyen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkleyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxEkleyen.Location = new System.Drawing.Point(436, 199);
            this.tbxEkleyen.Name = "tbxEkleyen";
            this.tbxEkleyen.Size = new System.Drawing.Size(130, 26);
            this.tbxEkleyen.TabIndex = 6;
            // 
            // tbxRolAdi
            // 
            this.tbxRolAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxRolAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxRolAdi.Location = new System.Drawing.Point(110, 120);
            this.tbxRolAdi.Name = "tbxRolAdi";
            this.tbxRolAdi.Size = new System.Drawing.Size(130, 26);
            this.tbxRolAdi.TabIndex = 6;
            // 
            // tbxRolKayit
            // 
            this.tbxRolKayit.Enabled = false;
            this.tbxRolKayit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxRolKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxRolKayit.Location = new System.Drawing.Point(436, 123);
            this.tbxRolKayit.Name = "tbxRolKayit";
            this.tbxRolKayit.Size = new System.Drawing.Size(156, 26);
            this.tbxRolKayit.TabIndex = 6;
            // 
            // tbxYetkiId
            // 
            this.tbxYetkiId.Enabled = false;
            this.tbxYetkiId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYetkiId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxYetkiId.Location = new System.Drawing.Point(719, 120);
            this.tbxYetkiId.Name = "tbxYetkiId";
            this.tbxYetkiId.Size = new System.Drawing.Size(43, 26);
            this.tbxYetkiId.TabIndex = 6;
            this.tbxYetkiId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxRolGuncelleme
            // 
            this.tbxRolGuncelleme.Enabled = false;
            this.tbxRolGuncelleme.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxRolGuncelleme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxRolGuncelleme.Location = new System.Drawing.Point(436, 46);
            this.tbxRolGuncelleme.Name = "tbxRolGuncelleme";
            this.tbxRolGuncelleme.Size = new System.Drawing.Size(156, 26);
            this.tbxRolGuncelleme.TabIndex = 6;
            // 
            // tbxRolId
            // 
            this.tbxRolId.Enabled = false;
            this.tbxRolId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxRolId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxRolId.Location = new System.Drawing.Point(110, 46);
            this.tbxRolId.Name = "tbxRolId";
            this.tbxRolId.Size = new System.Drawing.Size(43, 26);
            this.tbxRolId.TabIndex = 6;
            this.tbxRolId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label5.Location = new System.Drawing.Point(338, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rolü Ekleyen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label7.Location = new System.Drawing.Point(41, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(38, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rol Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label8.Location = new System.Drawing.Point(657, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Yetki Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(324, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rol Kayıt Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(47, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rol Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label6.Location = new System.Drawing.Point(279, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Son Güncelleme Tarihi";
            // 
            // btnRolSuccess
            // 
            this.btnRolSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnRolSuccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolSuccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnRolSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRolSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnRolSuccess.Image = ((System.Drawing.Image)(resources.GetObject("btnRolSuccess.Image")));
            this.btnRolSuccess.Location = new System.Drawing.Point(247, 341);
            this.btnRolSuccess.Name = "btnRolSuccess";
            this.btnRolSuccess.Size = new System.Drawing.Size(41, 42);
            this.btnRolSuccess.TabIndex = 8;
            this.btnRolSuccess.UseVisualStyleBackColor = false;
            this.btnRolSuccess.Visible = false;
            // 
            // btnRolCancel
            // 
            this.btnRolCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnRolCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnRolCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRolCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnRolCancel.Image = global::StudyCheck.FormsUI.Properties.Resources.cancel_32px;
            this.btnRolCancel.Location = new System.Drawing.Point(294, 341);
            this.btnRolCancel.Name = "btnRolCancel";
            this.btnRolCancel.Size = new System.Drawing.Size(41, 42);
            this.btnRolCancel.TabIndex = 9;
            this.btnRolCancel.UseVisualStyleBackColor = false;
            this.btnRolCancel.Visible = false;
            // 
            // btnRolDuzenle
            // 
            this.btnRolDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnRolDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolDuzenle.FlatAppearance.BorderSize = 0;
            this.btnRolDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRolDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnRolDuzenle.Location = new System.Drawing.Point(129, 341);
            this.btnRolDuzenle.Name = "btnRolDuzenle";
            this.btnRolDuzenle.Size = new System.Drawing.Size(112, 42);
            this.btnRolDuzenle.TabIndex = 10;
            this.btnRolDuzenle.Text = "Hesap Düzenle";
            this.btnRolDuzenle.UseVisualStyleBackColor = false;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnIptal.Location = new System.Drawing.Point(699, 591);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(162, 42);
            this.btnIptal.TabIndex = 11;
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
            this.btnKaydet.Location = new System.Drawing.Point(867, 591);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(162, 42);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // RoleSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnRolSuccess);
            this.Controls.Add(this.btnRolCancel);
            this.Controls.Add(this.btnRolDuzenle);
            this.Controls.Add(this.gbxRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblrolAdi);
            this.Name = "RoleSettingsControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.gbxRol.ResumeLayout(false);
            this.gbxRol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblrolAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRolSuccess;
        private System.Windows.Forms.Button btnRolCancel;
        private System.Windows.Forms.Button btnRolDuzenle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.TextBox tbxRolId;
        public System.Windows.Forms.TextBox tbxRolAdi;
        public System.Windows.Forms.TextBox tbxRolKayit;
        public System.Windows.Forms.TextBox tbxEkleyen;
        public System.Windows.Forms.TextBox tbxRolGuncelleme;
        public System.Windows.Forms.ComboBox cbxDurum;
        public System.Windows.Forms.TextBox tbxYetkiId;
    }
}
