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
            this.usersColumnControl1 = new StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl.UsersColumnControl();
            this.SuspendLayout();
            // 
            // usersColumnControl1
            // 
            this.usersColumnControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.usersColumnControl1.Location = new System.Drawing.Point(8, 6);
            this.usersColumnControl1.Name = "usersColumnControl1";
            this.usersColumnControl1.Size = new System.Drawing.Size(1032, 46);
            this.usersColumnControl1.TabIndex = 0;
            // 
            // AccountsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.usersColumnControl1);
            this.Name = "AccountsControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.ResumeLayout(false);

        }

        #endregion

        private UsersColumnControl usersColumnControl1;
    }
}
