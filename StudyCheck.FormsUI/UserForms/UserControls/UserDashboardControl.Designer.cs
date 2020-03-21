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
            this.userWidgetSonSinav = new StudyCheck.FormsUI.UserForms.UserControls.ExamControl.ExamInfoControl();
            this.userWidgetSonDers = new StudyCheck.FormsUI.UserForms.UserControls.LessonControl.LessonInfoControl();
            this.SuspendLayout();
            // 
            // userWidgetBilgiler
            // 
            this.userWidgetBilgiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.userWidgetBilgiler.Location = new System.Drawing.Point(31, 37);
            this.userWidgetBilgiler.Name = "userWidgetBilgiler";
            this.userWidgetBilgiler.Size = new System.Drawing.Size(270, 264);
            this.userWidgetBilgiler.TabIndex = 0;
            // 
            // userWidgetSonSinav
            // 
            this.userWidgetSonSinav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.userWidgetSonSinav.Location = new System.Drawing.Point(324, 37);
            this.userWidgetSonSinav.Name = "userWidgetSonSinav";
            this.userWidgetSonSinav.Size = new System.Drawing.Size(278, 127);
            this.userWidgetSonSinav.TabIndex = 1;
            // 
            // userWidgetSonDers
            // 
            this.userWidgetSonDers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.userWidgetSonDers.Location = new System.Drawing.Point(324, 209);
            this.userWidgetSonDers.Name = "userWidgetSonDers";
            this.userWidgetSonDers.Size = new System.Drawing.Size(278, 92);
            this.userWidgetSonDers.TabIndex = 2;
            // 
            // UserDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.userWidgetSonDers);
            this.Controls.Add(this.userWidgetSonSinav);
            this.Controls.Add(this.userWidgetBilgiler);
            this.Name = "UserDashboardControl";
            this.Size = new System.Drawing.Size(980, 416);
            this.ResumeLayout(false);

        }

        #endregion

        private UserWidgetControl userWidgetBilgiler;
        private ExamControl.ExamInfoControl userWidgetSonSinav;
        private LessonControl.LessonInfoControl userWidgetSonDers;
    }
}
