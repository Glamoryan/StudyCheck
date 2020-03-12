namespace StudyCheck.FormsUI.AdminForms.UserControls.ExamControl
{
    partial class SinavEkleControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxSinav = new System.Windows.Forms.GroupBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.mtbxSinavTarihi = new System.Windows.Forms.MaskedTextBox();
            this.tbxSinavAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSinavEkle = new System.Windows.Forms.Button();
            this.gbxSinav.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sınav Ekle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(34, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 2);
            this.panel1.TabIndex = 22;
            // 
            // gbxSinav
            // 
            this.gbxSinav.Controls.Add(this.cbxDurum);
            this.gbxSinav.Controls.Add(this.mtbxSinavTarihi);
            this.gbxSinav.Controls.Add(this.tbxSinavAdi);
            this.gbxSinav.Controls.Add(this.label4);
            this.gbxSinav.Controls.Add(this.label3);
            this.gbxSinav.Controls.Add(this.label2);
            this.gbxSinav.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSinav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.gbxSinav.Location = new System.Drawing.Point(219, 154);
            this.gbxSinav.Name = "gbxSinav";
            this.gbxSinav.Size = new System.Drawing.Size(597, 200);
            this.gbxSinav.TabIndex = 23;
            this.gbxSinav.TabStop = false;
            this.gbxSinav.Text = "Sınav Bilgileri";
            // 
            // cbxDurum
            // 
            this.cbxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.cbxDurum.Location = new System.Drawing.Point(132, 127);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(121, 27);
            this.cbxDurum.TabIndex = 27;
            // 
            // mtbxSinavTarihi
            // 
            this.mtbxSinavTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.mtbxSinavTarihi.Location = new System.Drawing.Point(443, 67);
            this.mtbxSinavTarihi.Mask = "00/00/0000";
            this.mtbxSinavTarihi.Name = "mtbxSinavTarihi";
            this.mtbxSinavTarihi.Size = new System.Drawing.Size(99, 27);
            this.mtbxSinavTarihi.TabIndex = 26;
            this.mtbxSinavTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // tbxSinavAdi
            // 
            this.tbxSinavAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxSinavAdi.Location = new System.Drawing.Point(132, 67);
            this.tbxSinavAdi.Name = "tbxSinavAdi";
            this.tbxSinavAdi.Size = new System.Drawing.Size(143, 27);
            this.tbxSinavAdi.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(64, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(344, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sınav Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sınav Adı";
            // 
            // btnSinavEkle
            // 
            this.btnSinavEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnSinavEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinavEkle.FlatAppearance.BorderSize = 0;
            this.btnSinavEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavEkle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavEkle.ForeColor = System.Drawing.Color.White;
            this.btnSinavEkle.Location = new System.Drawing.Point(219, 360);
            this.btnSinavEkle.Name = "btnSinavEkle";
            this.btnSinavEkle.Size = new System.Drawing.Size(127, 53);
            this.btnSinavEkle.TabIndex = 24;
            this.btnSinavEkle.Text = "Sınav Ekle";
            this.btnSinavEkle.UseVisualStyleBackColor = false;
            this.btnSinavEkle.Click += new System.EventHandler(this.btnSinavEkle_Click);
            // 
            // SinavEkleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnSinavEkle);
            this.Controls.Add(this.gbxSinav);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SinavEkleControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.SinavEkleControl_Load);
            this.gbxSinav.ResumeLayout(false);
            this.gbxSinav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxSinav;
        private System.Windows.Forms.TextBox tbxSinavAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox mtbxSinavTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.Button btnSinavEkle;
    }
}
