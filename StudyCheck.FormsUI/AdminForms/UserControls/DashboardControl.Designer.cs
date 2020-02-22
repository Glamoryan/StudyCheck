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
            this.widgetsControl1 = new StudyCheck.FormsUI.AdminForms.UserControls.WidgetsControl();
            this.SuspendLayout();
            // 
            // widgetsControl1
            // 
            this.widgetsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.widgetsControl1.Location = new System.Drawing.Point(26, 22);
            this.widgetsControl1.Name = "widgetsControl1";
            this.widgetsControl1.Size = new System.Drawing.Size(185, 155);
            this.widgetsControl1.TabIndex = 0;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.widgetsControl1);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.ResumeLayout(false);

        }

        #endregion

        private WidgetsControl widgetsControl1;
    }
}
