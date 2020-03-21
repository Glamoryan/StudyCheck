namespace StudyCheck.FormsUI.UserForms
{
    partial class frmUserPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbMinimize = new System.Windows.Forms.PictureBox();
            this.pcbExit = new System.Windows.Forms.PictureBox();
            this.pcbSignout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.pnlUserContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSignout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Controls.Add(this.pcbMinimize);
            this.panel1.Controls.Add(this.pcbExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 42);
            this.panel1.TabIndex = 0;
            // 
            // pcbMinimize
            // 
            this.pcbMinimize.Image = global::StudyCheck.FormsUI.Properties.Resources.minimize_window_16px;
            this.pcbMinimize.Location = new System.Drawing.Point(935, 13);
            this.pcbMinimize.Name = "pcbMinimize";
            this.pcbMinimize.Size = new System.Drawing.Size(16, 16);
            this.pcbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMinimize.TabIndex = 1;
            this.pcbMinimize.TabStop = false;
            // 
            // pcbExit
            // 
            this.pcbExit.Image = global::StudyCheck.FormsUI.Properties.Resources.icons8_shutdown_16;
            this.pcbExit.Location = new System.Drawing.Point(962, 13);
            this.pcbExit.Name = "pcbExit";
            this.pcbExit.Size = new System.Drawing.Size(16, 16);
            this.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbExit.TabIndex = 1;
            this.pcbExit.TabStop = false;
            // 
            // pcbSignout
            // 
            this.pcbSignout.Image = global::StudyCheck.FormsUI.Properties.Resources.exit_sign_32px;
            this.pcbSignout.Location = new System.Drawing.Point(16, 471);
            this.pcbSignout.Name = "pcbSignout";
            this.pcbSignout.Size = new System.Drawing.Size(32, 32);
            this.pcbSignout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbSignout.TabIndex = 1;
            this.pcbSignout.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çıkış Yap";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblTarih.Location = new System.Drawing.Point(12, 13);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(39, 19);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "tarih";
            // 
            // pnlUserContent
            // 
            this.pnlUserContent.Location = new System.Drawing.Point(5, 49);
            this.pnlUserContent.Name = "pnlUserContent";
            this.pnlUserContent.Size = new System.Drawing.Size(980, 416);
            this.pnlUserContent.TabIndex = 3;
            // 
            // frmUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(990, 510);
            this.Controls.Add(this.pnlUserContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcbSignout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserPanel";
            this.Text = "frmUserPanel";
            this.Load += new System.EventHandler(this.frmUserPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSignout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbExit;
        private System.Windows.Forms.PictureBox pcbMinimize;
        private System.Windows.Forms.PictureBox pcbSignout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Panel pnlUserContent;
    }
}