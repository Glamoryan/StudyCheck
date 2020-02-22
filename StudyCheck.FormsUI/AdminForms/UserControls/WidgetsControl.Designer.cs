namespace StudyCheck.FormsUI.AdminForms.UserControls
{
    partial class WidgetsControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbWidgetIcon = new System.Windows.Forms.PictureBox();
            this.lblWidgetTitle = new System.Windows.Forms.Label();
            this.lblWidgetValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWidgetIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 3);
            this.panel1.TabIndex = 0;
            // 
            // pcbWidgetIcon
            // 
            this.pcbWidgetIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.pcbWidgetIcon.Image = global::StudyCheck.FormsUI.Properties.Resources.icons8_user_account_32;
            this.pcbWidgetIcon.Location = new System.Drawing.Point(0, 0);
            this.pcbWidgetIcon.Name = "pcbWidgetIcon";
            this.pcbWidgetIcon.Size = new System.Drawing.Size(67, 74);
            this.pcbWidgetIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbWidgetIcon.TabIndex = 1;
            this.pcbWidgetIcon.TabStop = false;
            // 
            // lblWidgetTitle
            // 
            this.lblWidgetTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWidgetTitle.AutoSize = true;
            this.lblWidgetTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWidgetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.lblWidgetTitle.Location = new System.Drawing.Point(76, 29);
            this.lblWidgetTitle.Name = "lblWidgetTitle";
            this.lblWidgetTitle.Size = new System.Drawing.Size(98, 19);
            this.lblWidgetTitle.TabIndex = 2;
            this.lblWidgetTitle.Text = "Kullanıcılar";
            this.lblWidgetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWidgetValue
            // 
            this.lblWidgetValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.lblWidgetValue.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWidgetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblWidgetValue.Location = new System.Drawing.Point(15, 91);
            this.lblWidgetValue.Name = "lblWidgetValue";
            this.lblWidgetValue.Size = new System.Drawing.Size(155, 52);
            this.lblWidgetValue.TabIndex = 3;
            this.lblWidgetValue.Text = "25";
            this.lblWidgetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WidgetsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.lblWidgetValue);
            this.Controls.Add(this.lblWidgetTitle);
            this.Controls.Add(this.pcbWidgetIcon);
            this.Controls.Add(this.panel1);
            this.Name = "WidgetsControl";
            this.Size = new System.Drawing.Size(185, 155);
            ((System.ComponentModel.ISupportInitialize)(this.pcbWidgetIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbWidgetIcon;
        private System.Windows.Forms.Label lblWidgetTitle;
        private System.Windows.Forms.Label lblWidgetValue;
    }
}
