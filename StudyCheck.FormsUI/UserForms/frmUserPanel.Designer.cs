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
            this.pnlDragDrop = new System.Windows.Forms.Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.pcbMinimize = new System.Windows.Forms.PictureBox();
            this.pcbExit = new System.Windows.Forms.PictureBox();
            this.pcbSignout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUserContent = new System.Windows.Forms.Panel();
            this.pcbRefresh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDragDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSignout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDragDrop
            // 
            this.pnlDragDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnlDragDrop.Controls.Add(this.label2);
            this.pnlDragDrop.Controls.Add(this.lblTarih);
            this.pnlDragDrop.Controls.Add(this.pcbMinimize);
            this.pnlDragDrop.Controls.Add(this.pcbExit);
            this.pnlDragDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragDrop.Location = new System.Drawing.Point(0, 0);
            this.pnlDragDrop.Name = "pnlDragDrop";
            this.pnlDragDrop.Size = new System.Drawing.Size(990, 42);
            this.pnlDragDrop.TabIndex = 0;
            this.pnlDragDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragDrop_MouseDown);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblTarih.Location = new System.Drawing.Point(158, 13);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(39, 19);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "tarih";
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
            this.pcbMinimize.Click += new System.EventHandler(this.pcbMinimize_Click);
            this.pcbMinimize.MouseEnter += new System.EventHandler(this.pcbMinimize_MouseEnter);
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
            this.pcbExit.Click += new System.EventHandler(this.pcbExit_Click);
            this.pcbExit.MouseEnter += new System.EventHandler(this.pcbExit_MouseEnter);
            // 
            // pcbSignout
            // 
            this.pcbSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSignout.Image = global::StudyCheck.FormsUI.Properties.Resources.exit_sign_32px;
            this.pcbSignout.Location = new System.Drawing.Point(16, 472);
            this.pcbSignout.Name = "pcbSignout";
            this.pcbSignout.Size = new System.Drawing.Size(32, 32);
            this.pcbSignout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbSignout.TabIndex = 1;
            this.pcbSignout.TabStop = false;
            this.pcbSignout.Click += new System.EventHandler(this.pcbSignout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çıkış Yap";
            // 
            // pnlUserContent
            // 
            this.pnlUserContent.Location = new System.Drawing.Point(5, 49);
            this.pnlUserContent.Name = "pnlUserContent";
            this.pnlUserContent.Size = new System.Drawing.Size(980, 416);
            this.pnlUserContent.TabIndex = 3;
            // 
            // pcbRefresh
            // 
            this.pcbRefresh.Image = global::StudyCheck.FormsUI.Properties.Resources.refresh_32px;
            this.pcbRefresh.Location = new System.Drawing.Point(946, 471);
            this.pcbRefresh.Name = "pcbRefresh";
            this.pcbRefresh.Size = new System.Drawing.Size(32, 32);
            this.pcbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbRefresh.TabIndex = 4;
            this.pcbRefresh.TabStop = false;
            this.pcbRefresh.Click += new System.EventHandler(this.pcbRefresh_Click);
            this.pcbRefresh.MouseEnter += new System.EventHandler(this.pcbRefresh_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "StudyCheck";
            // 
            // frmUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(990, 510);
            this.Controls.Add(this.pcbRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbSignout);
            this.Controls.Add(this.pnlUserContent);
            this.Controls.Add(this.pnlDragDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserPanel";
            this.Load += new System.EventHandler(this.frmUserPanel_Load);
            this.pnlDragDrop.ResumeLayout(false);
            this.pnlDragDrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSignout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDragDrop;
        private System.Windows.Forms.PictureBox pcbExit;
        private System.Windows.Forms.PictureBox pcbMinimize;
        private System.Windows.Forms.PictureBox pcbSignout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Panel pnlUserContent;
        private System.Windows.Forms.PictureBox pcbRefresh;
        private System.Windows.Forms.Label label2;
    }
}