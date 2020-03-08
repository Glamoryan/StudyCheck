﻿namespace StudyCheck.FormsUI.AdminForms.UserControls.RightsControl
{
    partial class RightControl
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
            this.pnlRightContent = new System.Windows.Forms.Panel();
            this.rightColumnControl1 = new StudyCheck.FormsUI.AdminForms.UserControls.RightsControl.RightColumnControl();
            this.btnYetkiEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlRightContent
            // 
            this.pnlRightContent.Location = new System.Drawing.Point(8, 100);
            this.pnlRightContent.Name = "pnlRightContent";
            this.pnlRightContent.Size = new System.Drawing.Size(1031, 528);
            this.pnlRightContent.TabIndex = 6;
            // 
            // rightColumnControl1
            // 
            this.rightColumnControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.rightColumnControl1.Location = new System.Drawing.Point(8, 48);
            this.rightColumnControl1.Name = "rightColumnControl1";
            this.rightColumnControl1.Size = new System.Drawing.Size(1031, 46);
            this.rightColumnControl1.TabIndex = 5;
            // 
            // btnYetkiEkle
            // 
            this.btnYetkiEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.btnYetkiEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkiEkle.FlatAppearance.BorderSize = 0;
            this.btnYetkiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYetkiEkle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiEkle.ForeColor = System.Drawing.Color.White;
            this.btnYetkiEkle.Image = global::StudyCheck.FormsUI.Properties.Resources.add_16px;
            this.btnYetkiEkle.Location = new System.Drawing.Point(8, 9);
            this.btnYetkiEkle.Name = "btnYetkiEkle";
            this.btnYetkiEkle.Size = new System.Drawing.Size(110, 31);
            this.btnYetkiEkle.TabIndex = 4;
            this.btnYetkiEkle.Text = "Yetki Ekle";
            this.btnYetkiEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYetkiEkle.UseVisualStyleBackColor = false;
            // 
            // RightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.pnlRightContent);
            this.Controls.Add(this.rightColumnControl1);
            this.Controls.Add(this.btnYetkiEkle);
            this.Name = "RightControl";
            this.Size = new System.Drawing.Size(1045, 649);
            this.Load += new System.EventHandler(this.RightControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYetkiEkle;
        private RightColumnControl rightColumnControl1;
        private System.Windows.Forms.Panel pnlRightContent;
    }
}
