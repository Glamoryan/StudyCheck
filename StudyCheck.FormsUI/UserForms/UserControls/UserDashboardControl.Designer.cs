namespace StudyCheck.FormsUI.UserForms.UserControls
{
    partial class UserDashboardControl
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
            this.userWidgetBilgiler = new StudyCheck.FormsUI.UserForms.UserControls.UserWidgetControl();
            this.SuspendLayout();
            // 
            // userWidgetBilgiler
            // 
            this.userWidgetBilgiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.userWidgetBilgiler.Location = new System.Drawing.Point(12, 15);
            this.userWidgetBilgiler.Name = "userWidgetBilgiler";
            this.userWidgetBilgiler.Size = new System.Drawing.Size(270, 182);
            this.userWidgetBilgiler.TabIndex = 0;
            // 
            // UserDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.userWidgetBilgiler);
            this.Name = "UserDashboardControl";
            this.Size = new System.Drawing.Size(980, 416);
            this.ResumeLayout(false);

        }

        #endregion

        private UserWidgetControl userWidgetBilgiler;
    }
}
