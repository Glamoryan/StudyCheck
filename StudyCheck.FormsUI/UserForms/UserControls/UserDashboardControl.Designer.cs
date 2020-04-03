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
            this.btnStartWExam = new System.Windows.Forms.Button();
            this.btnStartWLesson = new System.Windows.Forms.Button();
            this.btnStartNew = new System.Windows.Forms.Button();
            this.userWidgetSonDers = new StudyCheck.FormsUI.UserForms.UserControls.LessonControl.LessonInfoControl();
            this.userWidgetSonSinav = new StudyCheck.FormsUI.UserForms.UserControls.ExamControl.ExamInfoControl();
            this.userWidgetBilgiler = new StudyCheck.FormsUI.UserForms.UserControls.UserWidgetControl();
            this.userWidgetAccountInfo = new StudyCheck.FormsUI.UserForms.UserControls.UserDetailControl.UserInfoControl();
            this.SuspendLayout();
            // 
            // btnStartWExam
            // 
            this.btnStartWExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(204)))));
            this.btnStartWExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartWExam.FlatAppearance.BorderSize = 0;
            this.btnStartWExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartWExam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartWExam.ForeColor = System.Drawing.Color.White;
            this.btnStartWExam.Location = new System.Drawing.Point(228, 342);
            this.btnStartWExam.Name = "btnStartWExam";
            this.btnStartWExam.Size = new System.Drawing.Size(180, 45);
            this.btnStartWExam.TabIndex = 3;
            this.btnStartWExam.Text = "Son Sınavdan Devam Et";
            this.btnStartWExam.UseVisualStyleBackColor = false;
            this.btnStartWExam.Click += new System.EventHandler(this.btnStartWExam_Click);
            // 
            // btnStartWLesson
            // 
            this.btnStartWLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(191)))), ((int)(((byte)(115)))));
            this.btnStartWLesson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartWLesson.FlatAppearance.BorderSize = 0;
            this.btnStartWLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartWLesson.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartWLesson.ForeColor = System.Drawing.Color.White;
            this.btnStartWLesson.Image = global::StudyCheck.FormsUI.Properties.Resources.resume_button_16px;
            this.btnStartWLesson.Location = new System.Drawing.Point(420, 342);
            this.btnStartWLesson.Name = "btnStartWLesson";
            this.btnStartWLesson.Size = new System.Drawing.Size(187, 45);
            this.btnStartWLesson.TabIndex = 3;
            this.btnStartWLesson.Text = "Son Dersten Devam Et";
            this.btnStartWLesson.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStartWLesson.UseVisualStyleBackColor = false;
            this.btnStartWLesson.Click += new System.EventHandler(this.btnStartWLesson_Click);
            // 
            // btnStartNew
            // 
            this.btnStartNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnStartNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartNew.FlatAppearance.BorderSize = 0;
            this.btnStartNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartNew.ForeColor = System.Drawing.Color.White;
            this.btnStartNew.Image = global::StudyCheck.FormsUI.Properties.Resources.add_16px;
            this.btnStartNew.Location = new System.Drawing.Point(31, 342);
            this.btnStartNew.Name = "btnStartNew";
            this.btnStartNew.Size = new System.Drawing.Size(186, 45);
            this.btnStartNew.TabIndex = 3;
            this.btnStartNew.Text = "Yeni Çalışma Başlat";
            this.btnStartNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartNew.UseVisualStyleBackColor = false;
            this.btnStartNew.Click += new System.EventHandler(this.btnStartNew_Click);
            // 
            // userWidgetSonDers
            // 
            this.userWidgetSonDers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.userWidgetSonDers.Location = new System.Drawing.Point(324, 182);
            this.userWidgetSonDers.Name = "userWidgetSonDers";
            this.userWidgetSonDers.Size = new System.Drawing.Size(297, 119);
            this.userWidgetSonDers.TabIndex = 10;
            // 
            // userWidgetSonSinav
            // 
            this.userWidgetSonSinav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.userWidgetSonSinav.Location = new System.Drawing.Point(324, 37);
            this.userWidgetSonSinav.Name = "userWidgetSonSinav";
            this.userWidgetSonSinav.Size = new System.Drawing.Size(297, 127);
            this.userWidgetSonSinav.TabIndex = 9;
            // 
            // userWidgetBilgiler
            // 
            this.userWidgetBilgiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.userWidgetBilgiler.Location = new System.Drawing.Point(31, 37);
            this.userWidgetBilgiler.Name = "userWidgetBilgiler";
            this.userWidgetBilgiler.Size = new System.Drawing.Size(265, 264);
            this.userWidgetBilgiler.TabIndex = 8;
            // 
            // userWidgetAccountInfo
            // 
            this.userWidgetAccountInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.userWidgetAccountInfo.Location = new System.Drawing.Point(669, 76);
            this.userWidgetAccountInfo.Name = "userWidgetAccountInfo";
            this.userWidgetAccountInfo.Size = new System.Drawing.Size(288, 193);
            this.userWidgetAccountInfo.TabIndex = 4;
            // 
            // UserDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.userWidgetSonDers);
            this.Controls.Add(this.userWidgetSonSinav);
            this.Controls.Add(this.userWidgetBilgiler);
            this.Controls.Add(this.userWidgetAccountInfo);
            this.Controls.Add(this.btnStartWLesson);
            this.Controls.Add(this.btnStartWExam);
            this.Controls.Add(this.btnStartNew);
            this.Name = "UserDashboardControl";
            this.Size = new System.Drawing.Size(980, 416);
            this.Load += new System.EventHandler(this.UserDashboardControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStartNew;
        private System.Windows.Forms.Button btnStartWExam;
        private System.Windows.Forms.Button btnStartWLesson;
        private UserDetailControl.UserInfoControl userWidgetAccountInfo;
        private UserWidgetControl userWidgetBilgiler;
        private ExamControl.ExamInfoControl userWidgetSonSinav;
        private LessonControl.LessonInfoControl userWidgetSonDers;
    }
}
