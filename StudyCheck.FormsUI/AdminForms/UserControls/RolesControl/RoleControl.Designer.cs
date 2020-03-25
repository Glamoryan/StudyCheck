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
            this.lblRols = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rolesColumnControl1 = new StudyCheck.FormsUI.AdminForms.UserControls.RolesControl.RolesColumnControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // lblRols
            // 
            this.lblRols.AutoSize = true;
            this.lblRols.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRols.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(68)))));
            this.lblRols.Location = new System.Drawing.Point(595, 15);
            this.lblRols.Name = "lblRols";
            this.lblRols.Size = new System.Drawing.Size(39, 17);
            this.lblRols.TabIndex = 7;
            this.lblRols.Text = "Full :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(640, 15);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(380, 17);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Sadece sarı renkli yetkiye sahip roller admin panele girebilir";
            // 
            // rolesColumnControl1
            // 
            this.rolesColumnControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.rolesColumnControl1.Location = new System.Drawing.Point(8, 48);
            this.rolesColumnControl1.Name = "rolesColumnControl1";
            this.rolesColumnControl1.Size = new System.Drawing.Size(1031, 46);
            this.rolesColumnControl1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(175, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Turuncu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Renkli roller ana rollerdir";
            // 
            // RoleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRols);
            this.Controls.Add(this.rolesColumnControl1);
            this.Controls.Add(this.pnlRoleContent);
            this.Controls.Add(this.btnRolEkle);
            this.Name = "RoleControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.RoleControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRolEkle;
        private System.Windows.Forms.Panel pnlRoleContent;
        private RolesColumnControl rolesColumnControl1;
        public System.Windows.Forms.Label lblRols;
        public System.Windows.Forms.Label lblDesc;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}
