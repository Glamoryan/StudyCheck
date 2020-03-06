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
            this.btnRolEkle.Location = new System.Drawing.Point(13, 12);
            this.btnRolEkle.Name = "btnRolEkle";
            this.btnRolEkle.Size = new System.Drawing.Size(110, 31);
            this.btnRolEkle.TabIndex = 3;
            this.btnRolEkle.Text = "Rol Ekle";
            this.btnRolEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolEkle.UseVisualStyleBackColor = false;
            // 
            // RoleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnRolEkle);
            this.Name = "RoleControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRolEkle;
    }
}
