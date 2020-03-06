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
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.themeWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.lessonWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.examWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.adminWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.accountWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.rolWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblDashboard.Location = new System.Drawing.Point(27, 27);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(86, 21);
            this.lblDashboard.TabIndex = 5;
            this.lblDashboard.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(20, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 2);
            this.panel1.TabIndex = 6;
            // 
            // themeWidget
            // 
            this.themeWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.themeWidget.Location = new System.Drawing.Point(829, 102);
            this.themeWidget.Name = "themeWidget";
            this.themeWidget.Size = new System.Drawing.Size(185, 155);
            this.themeWidget.TabIndex = 7;
            // 
            // lessonWidget
            // 
            this.lessonWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lessonWidget.Location = new System.Drawing.Point(20, 321);
            this.lessonWidget.Name = "lessonWidget";
            this.lessonWidget.Size = new System.Drawing.Size(185, 155);
            this.lessonWidget.TabIndex = 4;
            // 
            // examWidget
            // 
            this.examWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.examWidget.Location = new System.Drawing.Point(566, 102);
            this.examWidget.Name = "examWidget";
            this.examWidget.Size = new System.Drawing.Size(185, 155);
            this.examWidget.TabIndex = 3;
            // 
            // adminWidget
            // 
            this.adminWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.adminWidget.Location = new System.Drawing.Point(292, 102);
            this.adminWidget.Name = "adminWidget";
            this.adminWidget.Size = new System.Drawing.Size(185, 155);
            this.adminWidget.TabIndex = 2;
            // 
            // accountWidget
            // 
            this.accountWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.accountWidget.Location = new System.Drawing.Point(20, 102);
            this.accountWidget.Name = "accountWidget";
            this.accountWidget.Size = new System.Drawing.Size(185, 155);
            this.accountWidget.TabIndex = 1;
            // 
            // rolWidget
            // 
            this.rolWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.rolWidget.Location = new System.Drawing.Point(292, 321);
            this.rolWidget.Name = "rolWidget";
            this.rolWidget.Size = new System.Drawing.Size(185, 155);
            this.rolWidget.TabIndex = 8;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.rolWidget);
            this.Controls.Add(this.themeWidget);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.lessonWidget);
            this.Controls.Add(this.examWidget);
            this.Controls.Add(this.adminWidget);
            this.Controls.Add(this.accountWidget);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WidgetsControl accountWidget;
        private WidgetsControl adminWidget;
        private WidgetsControl examWidget;
        private WidgetsControl lessonWidget;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panel1;
        private WidgetsControl themeWidget;
        private WidgetsControl rolWidget;
    }
}
