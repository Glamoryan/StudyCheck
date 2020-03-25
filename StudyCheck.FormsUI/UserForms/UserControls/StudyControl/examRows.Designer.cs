namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl
{
    partial class examRows
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
            this.pcbExamIcon = new System.Windows.Forms.PictureBox();
            this.lblSinavAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExamIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbExamIcon
            // 
            this.pcbExamIcon.Image = global::StudyCheck.FormsUI.Properties.Resources.exam_38px;
            this.pcbExamIcon.Location = new System.Drawing.Point(12, 18);
            this.pcbExamIcon.Name = "pcbExamIcon";
            this.pcbExamIcon.Size = new System.Drawing.Size(38, 38);
            this.pcbExamIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbExamIcon.TabIndex = 0;
            this.pcbExamIcon.TabStop = false;
            // 
            // lblSinavAdi
            // 
            this.lblSinavAdi.AutoSize = true;
            this.lblSinavAdi.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblSinavAdi.Location = new System.Drawing.Point(56, 25);
            this.lblSinavAdi.Name = "lblSinavAdi";
            this.lblSinavAdi.Size = new System.Drawing.Size(97, 25);
            this.lblSinavAdi.TabIndex = 1;
            this.lblSinavAdi.Text = "Sınav Adı";
            // 
            // examRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.lblSinavAdi);
            this.Controls.Add(this.pcbExamIcon);
            this.Name = "examRows";
            this.Size = new System.Drawing.Size(200, 78);
            ((System.ComponentModel.ISupportInitialize)(this.pcbExamIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbExamIcon;
        public System.Windows.Forms.Label lblSinavAdi;
    }
}
