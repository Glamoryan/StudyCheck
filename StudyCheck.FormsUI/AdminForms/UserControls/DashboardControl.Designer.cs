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
            this.userWidget = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.widgetsControl1 = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.SuspendLayout();
            // 
            // userWidget
            // 
            this.userWidget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.userWidget.Location = new System.Drawing.Point(26, 22);
            this.userWidget.Name = "userWidget";
            this.userWidget.Size = new System.Drawing.Size(185, 155);
            this.userWidget.TabIndex = 0;
            // 
            // widgetsControl1
            // 
            this.widgetsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.widgetsControl1.Location = new System.Drawing.Point(253, 22);
            this.widgetsControl1.Name = "widgetsControl1";
            this.widgetsControl1.Size = new System.Drawing.Size(185, 155);
            this.widgetsControl1.TabIndex = 1;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.widgetsControl1);
            this.Controls.Add(this.userWidget);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.DashboardControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WidgetsControl userWidget;
        private WidgetsControl widgetsControl1;
    }
}
