namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    partial class RoleControl
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
            this.btnRolEkle = new System.Windows.Forms.Button();
            this.pnlRoleContent = new System.Windows.Forms.Panel();
            this.rolesColumnControl1 = new StudyCheck.FormsUI.AdminForms.UserControls.RolesControl.RolesColumnControl();
            this.SuspendLayout();
            // 
            // btnRolEkle
            // 
            this.btnRolEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnRolEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolEkle.FlatAppearance.BorderSize = 0;
            this.btnRolEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolEkle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRolEkle.ForeColor = System.Drawing.Color.White;
            this.btnRolEkle.Image = global::StudyCheck.FormsUI.Properties.Resources.add_16px;
            this.btnRolEkle.Location = new System.Drawing.Point(8, 9);
            this.btnRolEkle.Name = "btnRolEkle";
            this.btnRolEkle.Size = new System.Drawing.Size(110, 31);
            this.btnRolEkle.TabIndex = 3;
            this.btnRolEkle.Text = "Rol Ekle";
            this.btnRolEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolEkle.UseVisualStyleBackColor = false;
            this.btnRolEkle.Click += new System.EventHandler(this.btnRolEkle_Click);
            // 
            // pnlRoleContent
            // 
            this.pnlRoleContent.Location = new System.Drawing.Point(8, 100);
            this.pnlRoleContent.Name = "pnlRoleContent";
            this.pnlRoleContent.Size = new System.Drawing.Size(1031, 525);
            this.pnlRoleContent.TabIndex = 5;
            // 
            // rolesColumnControl1
            // 
            this.rolesColumnControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.rolesColumnControl1.Location = new System.Drawing.Point(8, 48);
            this.rolesColumnControl1.Name = "rolesColumnControl1";
            this.rolesColumnControl1.Size = new System.Drawing.Size(1031, 46);
            this.rolesColumnControl1.TabIndex = 6;
            // 
            // RoleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.rolesColumnControl1);
            this.Controls.Add(this.pnlRoleContent);
            this.Controls.Add(this.btnRolEkle);
            this.Name = "RoleControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.RoleControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRolEkle;
        private System.Windows.Forms.Panel pnlRoleContent;
        private RolesColumnControl rolesColumnControl1;
    }
}
