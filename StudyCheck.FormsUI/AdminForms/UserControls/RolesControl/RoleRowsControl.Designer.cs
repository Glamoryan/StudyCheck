namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    partial class RoleRowsControl
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
            this.lblRolId = new System.Windows.Forms.Label();
            this.lblRolAd = new System.Windows.Forms.Label();
            this.lblRolKayit = new System.Windows.Forms.Label();
            this.lblEkleyen = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRolId
            // 
            this.lblRolId.AutoSize = true;
            this.lblRolId.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRolId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblRolId.Location = new System.Drawing.Point(40, 12);
            this.lblRolId.Name = "lblRolId";
            this.lblRolId.Size = new System.Drawing.Size(42, 17);
            this.lblRolId.TabIndex = 1;
            this.lblRolId.Text = "RolId";
            // 
            // lblRolAd
            // 
            this.lblRolAd.AutoSize = true;
            this.lblRolAd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRolAd.ForeColor = System.Drawing.Color.White;
            this.lblRolAd.Location = new System.Drawing.Point(191, 12);
            this.lblRolAd.Name = "lblRolAd";
            this.lblRolAd.Size = new System.Drawing.Size(46, 17);
            this.lblRolAd.TabIndex = 2;
            this.lblRolAd.Text = "RolAd";
            // 
            // lblRolKayit
            // 
            this.lblRolKayit.AutoSize = true;
            this.lblRolKayit.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRolKayit.ForeColor = System.Drawing.Color.White;
            this.lblRolKayit.Location = new System.Drawing.Point(357, 12);
            this.lblRolKayit.Name = "lblRolKayit";
            this.lblRolKayit.Size = new System.Drawing.Size(62, 17);
            this.lblRolKayit.TabIndex = 2;
            this.lblRolKayit.Text = "RolKayit";
            // 
            // lblEkleyen
            // 
            this.lblEkleyen.AutoSize = true;
            this.lblEkleyen.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkleyen.ForeColor = System.Drawing.Color.White;
            this.lblEkleyen.Location = new System.Drawing.Point(564, 12);
            this.lblEkleyen.Name = "lblEkleyen";
            this.lblEkleyen.Size = new System.Drawing.Size(59, 17);
            this.lblEkleyen.TabIndex = 2;
            this.lblEkleyen.Text = "Ekleyen";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.White;
            this.lblDurum.Location = new System.Drawing.Point(781, 12);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(52, 17);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Durum";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(206)))), ((int)(((byte)(109)))));
            this.btnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Image = global::StudyCheck.FormsUI.Properties.Resources.edit_16px;
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuzenle.Location = new System.Drawing.Point(947, 10);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(40, 23);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.UseVisualStyleBackColor = false;
            // 
            // RoleRowsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblEkleyen);
            this.Controls.Add(this.lblRolKayit);
            this.Controls.Add(this.lblRolAd);
            this.Controls.Add(this.lblRolId);
            this.Name = "RoleRowsControl";
            this.Size = new System.Drawing.Size(1032, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblRolId;
        public System.Windows.Forms.Label lblRolAd;
        public System.Windows.Forms.Label lblRolKayit;
        public System.Windows.Forms.Label lblEkleyen;
        public System.Windows.Forms.Label lblDurum;
        public System.Windows.Forms.Button btnDuzenle;
    }
}
