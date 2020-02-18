namespace StudyCheck.FormsUI
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbMinimizeButon = new System.Windows.Forms.PictureBox();
            this.pcbCikisButon = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizeButon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCikisButon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMinimizeButon
            // 
            this.pcbMinimizeButon.Image = global::StudyCheck.FormsUI.Properties.Resources.minimize_window_16px;
            this.pcbMinimizeButon.Location = new System.Drawing.Point(12, 12);
            this.pcbMinimizeButon.Name = "pcbMinimizeButon";
            this.pcbMinimizeButon.Size = new System.Drawing.Size(16, 16);
            this.pcbMinimizeButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMinimizeButon.TabIndex = 2;
            this.pcbMinimizeButon.TabStop = false;
            // 
            // pcbCikisButon
            // 
            this.pcbCikisButon.Image = global::StudyCheck.FormsUI.Properties.Resources.icons8_shutdown_16;
            this.pcbCikisButon.Location = new System.Drawing.Point(314, 12);
            this.pcbCikisButon.Name = "pcbCikisButon";
            this.pcbCikisButon.Size = new System.Drawing.Size(16, 16);
            this.pcbCikisButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbCikisButon.TabIndex = 1;
            this.pcbCikisButon.TabStop = false;
            this.pcbCikisButon.Click += new System.EventHandler(this.pcbCikisButon_Click);
            this.pcbCikisButon.MouseEnter += new System.EventHandler(this.pcbCikisButon_MouseEnter);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::StudyCheck.FormsUI.Properties.Resources.school_80px;
            this.pcbLogo.Location = new System.Drawing.Point(0, 44);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(342, 80);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(342, 542);
            this.Controls.Add(this.pcbMinimizeButon);
            this.Controls.Add(this.pcbCikisButon);
            this.Controls.Add(this.pcbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizeButon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCikisButon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.PictureBox pcbCikisButon;
        private System.Windows.Forms.PictureBox pcbMinimizeButon;
    }
}

