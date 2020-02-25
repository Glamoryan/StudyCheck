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
            this.lessonWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // examWidget
            // 
            this.examWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.examWidget.Location = new System.Drawing.Point(839, 102);
            this.examWidget.Name = "examWidget";
            this.examWidget.Size = new System.Drawing.Size(185, 155);
            this.examWidget.TabIndex = 3;
            // 
            // adminWidget
            // 
            this.adminWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.adminWidget.Location = new System.Drawing.Point(565, 102);
            this.adminWidget.Name = "adminWidget";
            this.adminWidget.Size = new System.Drawing.Size(185, 155);
            this.adminWidget.TabIndex = 2;
            // 
            // accountWidget
            // 
            this.accountWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.accountWidget.Location = new System.Drawing.Point(293, 102);
            this.accountWidget.Name = "accountWidget";
            this.accountWidget.Size = new System.Drawing.Size(185, 155);
            this.accountWidget.TabIndex = 1;
            // 
            // userWidget
            // 
            this.userWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.userWidget.Location = new System.Drawing.Point(20, 102);
            this.userWidget.Name = "userWidget";
            this.userWidget.Size = new System.Drawing.Size(185, 155);
            this.userWidget.TabIndex = 0;
            // 
            // lessonWidget
            // 
            this.lessonWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lessonWidget.Location = new System.Drawing.Point(20, 321);
            this.lessonWidget.Name = "lessonWidget";
            this.lessonWidget.Size = new System.Drawing.Size(185, 155);
            this.lessonWidget.TabIndex = 4;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblWelcome.Location = new System.Drawing.Point(27, 27);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(86, 21);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(20, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 2);
            this.panel1.TabIndex = 6;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lessonWidget);
            this.Controls.Add(this.examWidget);
            this.Controls.Add(this.adminWidget);
            this.Controls.Add(this.accountWidget);
            this.Controls.Add(this.userWidget);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WidgetsControl userWidget;
        private WidgetsControl accountWidget;
        private WidgetsControl adminWidget;
        private WidgetsControl examWidget;
        private WidgetsControl lessonWidget;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel1;
    }
}
