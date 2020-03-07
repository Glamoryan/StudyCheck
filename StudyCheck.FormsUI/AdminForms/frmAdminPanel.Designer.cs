namespace StudyCheck.FormsUI.AdminForms
{
    partial class frmAdminPanel
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.ytPanel = new System.Windows.Forms.Panel();
            this.rolPanel = new System.Windows.Forms.Panel();
            this.acPanel = new System.Windows.Forms.Panel();
            this.dbPanel = new System.Windows.Forms.Panel();
            this.btnYetkiler = new System.Windows.Forms.Button();
            this.btnRoller = new System.Windows.Forms.Button();
            this.btnUyeler = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pcbSignOut = new System.Windows.Forms.PictureBox();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.pcbMinimize = new System.Windows.Forms.PictureBox();
            this.pcbExit = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSignOut)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnlSidebar.Controls.Add(this.ytPanel);
            this.pnlSidebar.Controls.Add(this.rolPanel);
            this.pnlSidebar.Controls.Add(this.acPanel);
            this.pnlSidebar.Controls.Add(this.dbPanel);
            this.pnlSidebar.Controls.Add(this.btnYetkiler);
            this.pnlSidebar.Controls.Add(this.btnRoller);
            this.pnlSidebar.Controls.Add(this.btnUyeler);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.pcbSignOut);
            this.pnlSidebar.Controls.Add(this.lblAdminName);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Controls.Add(this.lblWelcome);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 725);
            this.pnlSidebar.TabIndex = 0;
            // 
            // ytPanel
            // 
            this.ytPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.ytPanel.Location = new System.Drawing.Point(194, 314);
            this.ytPanel.Name = "ytPanel";
            this.ytPanel.Size = new System.Drawing.Size(10, 56);
            this.ytPanel.TabIndex = 5;
            // 
            // rolPanel
            // 
            this.rolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.rolPanel.Location = new System.Drawing.Point(194, 252);
            this.rolPanel.Name = "rolPanel";
            this.rolPanel.Size = new System.Drawing.Size(10, 56);
            this.rolPanel.TabIndex = 5;
            // 
            // acPanel
            // 
            this.acPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.acPanel.Location = new System.Drawing.Point(194, 190);
            this.acPanel.Name = "acPanel";
            this.acPanel.Size = new System.Drawing.Size(10, 56);
            this.acPanel.TabIndex = 5;
            // 
            // dbPanel
            // 
            this.dbPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.dbPanel.Location = new System.Drawing.Point(194, 128);
            this.dbPanel.Name = "dbPanel";
            this.dbPanel.Size = new System.Drawing.Size(10, 56);
            this.dbPanel.TabIndex = 5;
            // 
            // btnYetkiler
            // 
            this.btnYetkiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnYetkiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkiler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnYetkiler.FlatAppearance.BorderSize = 0;
            this.btnYetkiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYetkiler.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiler.ForeColor = System.Drawing.Color.White;
            this.btnYetkiler.Image = global::StudyCheck.FormsUI.Properties.Resources.security_lock_32px;
            this.btnYetkiler.Location = new System.Drawing.Point(0, 314);
            this.btnYetkiler.Name = "btnYetkiler";
            this.btnYetkiler.Size = new System.Drawing.Size(194, 56);
            this.btnYetkiler.TabIndex = 4;
            this.btnYetkiler.Text = "Yetkiler";
            this.btnYetkiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYetkiler.UseVisualStyleBackColor = false;
            this.btnYetkiler.Click += new System.EventHandler(this.btnYetkiler_Click);
            // 
            // btnRoller
            // 
            this.btnRoller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnRoller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoller.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnRoller.FlatAppearance.BorderSize = 0;
            this.btnRoller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoller.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoller.ForeColor = System.Drawing.Color.White;
            this.btnRoller.Image = global::StudyCheck.FormsUI.Properties.Resources.checked_user_male_32px;
            this.btnRoller.Location = new System.Drawing.Point(0, 252);
            this.btnRoller.Name = "btnRoller";
            this.btnRoller.Size = new System.Drawing.Size(194, 56);
            this.btnRoller.TabIndex = 4;
            this.btnRoller.Text = "Roller";
            this.btnRoller.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoller.UseVisualStyleBackColor = false;
            this.btnRoller.Click += new System.EventHandler(this.btnRoller_Click);
            // 
            // btnUyeler
            // 
            this.btnUyeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnUyeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnUyeler.FlatAppearance.BorderSize = 0;
            this.btnUyeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeler.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeler.ForeColor = System.Drawing.Color.White;
            this.btnUyeler.Image = global::StudyCheck.FormsUI.Properties.Resources.icons8_admin_settings_male_32;
            this.btnUyeler.Location = new System.Drawing.Point(0, 190);
            this.btnUyeler.Name = "btnUyeler";
            this.btnUyeler.Size = new System.Drawing.Size(194, 56);
            this.btnUyeler.TabIndex = 4;
            this.btnUyeler.Text = "Kullanıcılar";
            this.btnUyeler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUyeler.UseVisualStyleBackColor = false;
            this.btnUyeler.Click += new System.EventHandler(this.btnUyeler_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::StudyCheck.FormsUI.Properties.Resources.icons8_home_32;
            this.btnDashboard.Location = new System.Drawing.Point(0, 128);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(194, 56);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pcbSignOut
            // 
            this.pcbSignOut.Image = global::StudyCheck.FormsUI.Properties.Resources.exit_sign_32px;
            this.pcbSignOut.Location = new System.Drawing.Point(162, 681);
            this.pcbSignOut.Name = "pcbSignOut";
            this.pcbSignOut.Size = new System.Drawing.Size(32, 32);
            this.pcbSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbSignOut.TabIndex = 3;
            this.pcbSignOut.TabStop = false;
            this.pcbSignOut.Click += new System.EventHandler(this.pcbSignOut_Click);
            this.pcbSignOut.MouseEnter += new System.EventHandler(this.pcbSignOut_MouseEnter);
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblAdminName.Location = new System.Drawing.Point(75, 688);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(52, 19);
            this.lblAdminName.TabIndex = 2;
            this.lblAdminName.Text = "Admin";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.pnlLogo.Controls.Add(this.lblDashboardTitle);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 76);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.White;
            this.lblDashboardTitle.Location = new System.Drawing.Point(3, 21);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(194, 35);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "STUDYCHECK";
            this.lblDashboardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(6, 689);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(67, 17);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hoşgeldin";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.lblTarih);
            this.pnlHeader.Controls.Add(this.pcbMinimize);
            this.pnlHeader.Controls.Add(this.pcbExit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1045, 76);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblTarih.Location = new System.Drawing.Point(33, 26);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(39, 19);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "tarih";
            // 
            // pcbMinimize
            // 
            this.pcbMinimize.Image = global::StudyCheck.FormsUI.Properties.Resources.minimize_window_16px;
            this.pcbMinimize.Location = new System.Drawing.Point(987, 13);
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
            this.pcbExit.Location = new System.Drawing.Point(1017, 12);
            this.pcbExit.Name = "pcbExit";
            this.pcbExit.Size = new System.Drawing.Size(16, 16);
            this.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbExit.TabIndex = 0;
            this.pcbExit.TabStop = false;
            this.pcbExit.Click += new System.EventHandler(this.pcbExit_Click);
            this.pcbExit.MouseEnter += new System.EventHandler(this.pcbExit_MouseEnter);
            // 
            // pnlContent
            // 
            this.pnlContent.AutoSize = true;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 76);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1045, 649);
            this.pnlContent.TabIndex = 2;
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 725);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminPanel";
            this.Load += new System.EventHandler(this.frmAdminPanel_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSignOut)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.PictureBox pcbExit;
        private System.Windows.Forms.PictureBox pcbMinimize;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.PictureBox pcbSignOut;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Panel rolPanel;
        private System.Windows.Forms.Panel acPanel;
        private System.Windows.Forms.Panel dbPanel;
        private System.Windows.Forms.Button btnRoller;
        private System.Windows.Forms.Button btnUyeler;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel ytPanel;
        private System.Windows.Forms.Button btnYetkiler;
    }
}