namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    partial class RolEkleControl
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
            this.gbxRol = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRolAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxYetki = new System.Windows.Forms.ComboBox();
            this.btnRolEkle = new System.Windows.Forms.Button();
            this.gbxRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rol Ekle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(34, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 2);
            this.panel1.TabIndex = 15;
            // 
            // gbxRol
            // 
            this.gbxRol.Controls.Add(this.cbxYetki);
            this.gbxRol.Controls.Add(this.cbxDurum);
            this.gbxRol.Controls.Add(this.tbxRolAdi);
            this.gbxRol.Controls.Add(this.label4);
            this.gbxRol.Controls.Add(this.label3);
            this.gbxRol.Controls.Add(this.label2);
            this.gbxRol.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.gbxRol.Location = new System.Drawing.Point(233, 140);
            this.gbxRol.Name = "gbxRol";
            this.gbxRol.Size = new System.Drawing.Size(548, 171);
            this.gbxRol.TabIndex = 17;
            this.gbxRol.TabStop = false;
            this.gbxRol.Text = "Rol Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rol Adı";
            // 
            // tbxRolAdi
            // 
            this.tbxRolAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.tbxRolAdi.Location = new System.Drawing.Point(129, 54);
            this.tbxRolAdi.Name = "tbxRolAdi";
            this.tbxRolAdi.Size = new System.Drawing.Size(143, 26);
            this.tbxRolAdi.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(325, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Durum";
            // 
            // cbxDurum
            // 
            this.cbxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Pasif",
            "Aktif"});
            this.cbxDurum.Location = new System.Drawing.Point(383, 54);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(121, 27);
            this.cbxDurum.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(43, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rol Yetkisi";
            // 
            // cbxYetki
            // 
            this.cbxYetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYetki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxYetki.FormattingEnabled = true;
            this.cbxYetki.Location = new System.Drawing.Point(129, 110);
            this.cbxYetki.Name = "cbxYetki";
            this.cbxYetki.Size = new System.Drawing.Size(121, 27);
            this.cbxYetki.TabIndex = 20;
            // 
            // btnRolEkle
            // 
            this.btnRolEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnRolEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolEkle.FlatAppearance.BorderSize = 0;
            this.btnRolEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolEkle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRolEkle.ForeColor = System.Drawing.Color.White;
            this.btnRolEkle.Location = new System.Drawing.Point(233, 317);
            this.btnRolEkle.Name = "btnRolEkle";
            this.btnRolEkle.Size = new System.Drawing.Size(127, 53);
            this.btnRolEkle.TabIndex = 18;
            this.btnRolEkle.Text = "Rol Ekle";
            this.btnRolEkle.UseVisualStyleBackColor = false;
            // 
            // RolEkleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnRolEkle);
            this.Controls.Add(this.gbxRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RolEkleControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.gbxRol.ResumeLayout(false);
            this.gbxRol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRolAdi;
        private System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxYetki;
        private System.Windows.Forms.Button btnRolEkle;
    }
}
