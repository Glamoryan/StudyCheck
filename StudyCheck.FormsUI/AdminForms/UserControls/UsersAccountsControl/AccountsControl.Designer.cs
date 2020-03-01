namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    partial class AccountsControl
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
            this.pnlUserContent = new System.Windows.Forms.Panel();
            this.usersColumnControl1 = new StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl.UsersColumnControl();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlUserContent
            // 
            this.pnlUserContent.Location = new System.Drawing.Point(8, 100);
            this.pnlUserContent.Name = "pnlUserContent";
            this.pnlUserContent.Size = new System.Drawing.Size(1032, 535);
            this.pnlUserContent.TabIndex = 1;
            // 
            // usersColumnControl1
            // 
            this.usersColumnControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.usersColumnControl1.Location = new System.Drawing.Point(8, 48);
            this.usersColumnControl1.Name = "usersColumnControl1";
            this.usersColumnControl1.Size = new System.Drawing.Size(1032, 46);
            this.usersColumnControl1.TabIndex = 0;
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnKullaniciEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciEkle.FlatAppearance.BorderSize = 0;
            this.btnKullaniciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciEkle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciEkle.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciEkle.Image = global::StudyCheck.FormsUI.Properties.Resources.add_16px;
            this.btnKullaniciEkle.Location = new System.Drawing.Point(8, 9);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(110, 31);
            this.btnKullaniciEkle.TabIndex = 2;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKullaniciEkle.UseVisualStyleBackColor = false;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // AccountsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnKullaniciEkle);
            this.Controls.Add(this.pnlUserContent);
            this.Controls.Add(this.usersColumnControl1);
            this.Name = "AccountsControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.AccountsControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UsersColumnControl usersColumnControl1;
        private System.Windows.Forms.Panel pnlUserContent;
        private System.Windows.Forms.Button btnKullaniciEkle;
    }
}
