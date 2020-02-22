namespace StudyCheck.FormsUI.AdminForms.UserControls
{
    partial class DashboardControl
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
            this.examWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.adminWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.accountWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.userWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.SuspendLayout();
            // 
            // examWidget
            // 
            this.examWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.examWidget.Location = new System.Drawing.Point(839, 22);
            this.examWidget.Name = "examWidget";
            this.examWidget.Size = new System.Drawing.Size(185, 155);
            this.examWidget.TabIndex = 3;
            // 
            // adminWidget
            // 
            this.adminWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.adminWidget.Location = new System.Drawing.Point(565, 22);
            this.adminWidget.Name = "adminWidget";
            this.adminWidget.Size = new System.Drawing.Size(185, 155);
            this.adminWidget.TabIndex = 2;
            // 
            // accountWidget
            // 
            this.accountWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.accountWidget.Location = new System.Drawing.Point(293, 22);
            this.accountWidget.Name = "accountWidget";
            this.accountWidget.Size = new System.Drawing.Size(185, 155);
            this.accountWidget.TabIndex = 1;
            // 
            // userWidget
            // 
            this.userWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.userWidget.Location = new System.Drawing.Point(20, 22);
            this.userWidget.Name = "userWidget";
            this.userWidget.Size = new System.Drawing.Size(185, 155);
            this.userWidget.TabIndex = 0;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.examWidget);
            this.Controls.Add(this.adminWidget);
            this.Controls.Add(this.accountWidget);
            this.Controls.Add(this.userWidget);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WidgetsControl userWidget;
        private WidgetsControl accountWidget;
        private WidgetsControl adminWidget;
        private WidgetsControl examWidget;
    }
}
