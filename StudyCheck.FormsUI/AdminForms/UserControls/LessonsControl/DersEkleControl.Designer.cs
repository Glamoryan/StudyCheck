namespace StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl
{
    partial class DersEkleControl
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
            this.gbxDers = new System.Windows.Forms.GroupBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.cbxDersSinav = new System.Windows.Forms.ComboBox();
            this.tbxDersAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.gbxDers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ders Ekle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(34, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 2);
            this.panel1.TabIndex = 19;
            // 
            // gbxDers
            // 
            this.gbxDers.Controls.Add(this.cbxDurum);
            this.gbxDers.Controls.Add(this.cbxDersSinav);
            this.gbxDers.Controls.Add(this.tbxDersAdi);
            this.gbxDers.Controls.Add(this.label4);
            this.gbxDers.Controls.Add(this.label3);
            this.gbxDers.Controls.Add(this.label2);
            this.gbxDers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.gbxDers.Location = new System.Drawing.Point(241, 160);
            this.gbxDers.Name = "gbxDers";
            this.gbxDers.Size = new System.Drawing.Size(558, 195);
            this.gbxDers.TabIndex = 21;
            this.gbxDers.TabStop = false;
            this.gbxDers.Text = "Ders Bilgileri";
            // 
            // cbxDurum
            // 
            this.cbxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.cbxDurum.Location = new System.Drawing.Point(132, 124);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(121, 27);
            this.cbxDurum.TabIndex = 25;
            // 
            // cbxDersSinav
            // 
            this.cbxDersSinav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDersSinav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxDersSinav.FormattingEnabled = true;
            this.cbxDersSinav.Location = new System.Drawing.Point(402, 57);
            this.cbxDersSinav.Name = "cbxDersSinav";
            this.cbxDersSinav.Size = new System.Drawing.Size(121, 27);
            this.cbxDersSinav.TabIndex = 24;
            // 
            // tbxDersAdi
            // 
            this.tbxDersAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxDersAdi.Location = new System.Drawing.Point(132, 57);
            this.tbxDersAdi.Name = "tbxDersAdi";
            this.tbxDersAdi.Size = new System.Drawing.Size(143, 27);
            this.tbxDersAdi.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(73, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(303, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hangi Sınava";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(61, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ders Adı";
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnDersEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDersEkle.FlatAppearance.BorderSize = 0;
            this.btnDersEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersEkle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.ForeColor = System.Drawing.Color.White;
            this.btnDersEkle.Location = new System.Drawing.Point(241, 361);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(127, 53);
            this.btnDersEkle.TabIndex = 22;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // DersEkleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.gbxDers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DersEkleControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.DersEkleControl_Load);
            this.gbxDers.ResumeLayout(false);
            this.gbxDers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxDers;
        private System.Windows.Forms.TextBox tbxDersAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDersSinav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.Button btnDersEkle;
    }
}
