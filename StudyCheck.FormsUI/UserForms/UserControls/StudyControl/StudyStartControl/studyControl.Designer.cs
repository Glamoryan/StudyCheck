namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl.StudyStartControl
{
    partial class studyControl
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
            this.lblGecenZaman = new System.Windows.Forms.Label();
            this.lblBaslamaTarihi = new System.Windows.Forms.Label();
            this.examInfoControl1 = new StudyCheck.FormsUI.UserForms.UserControls.StudyControl.examInfoControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGecenZaman
            // 
            this.lblGecenZaman.AutoSize = true;
            this.lblGecenZaman.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecenZaman.ForeColor = System.Drawing.Color.White;
            this.lblGecenZaman.Location = new System.Drawing.Point(692, 61);
            this.lblGecenZaman.Name = "lblGecenZaman";
            this.lblGecenZaman.Size = new System.Drawing.Size(259, 78);
            this.lblGecenZaman.TabIndex = 0;
            this.lblGecenZaman.Text = "00:00:00";
            // 
            // lblBaslamaTarihi
            // 
            this.lblBaslamaTarihi.AutoSize = true;
            this.lblBaslamaTarihi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslamaTarihi.ForeColor = System.Drawing.Color.White;
            this.lblBaslamaTarihi.Location = new System.Drawing.Point(191, 272);
            this.lblBaslamaTarihi.Name = "lblBaslamaTarihi";
            this.lblBaslamaTarihi.Size = new System.Drawing.Size(90, 26);
            this.lblBaslamaTarihi.TabIndex = 0;
            this.lblBaslamaTarihi.Text = "00:00:00";
            // 
            // examInfoControl1
            // 
            this.examInfoControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.examInfoControl1.Location = new System.Drawing.Point(20, 61);
            this.examInfoControl1.Name = "examInfoControl1";
            this.examInfoControl1.Size = new System.Drawing.Size(295, 162);
            this.examInfoControl1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(15, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Zamanı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çalışılan Sınav";
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnDurdur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDurdur.FlatAppearance.BorderSize = 0;
            this.btnDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurdur.Image = global::StudyCheck.FormsUI.Properties.Resources.pause_32px;
            this.btnDurdur.Location = new System.Drawing.Point(867, 151);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(58, 42);
            this.btnDurdur.TabIndex = 1;
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(191)))), ((int)(((byte)(115)))));
            this.btnBasla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBasla.FlatAppearance.BorderSize = 0;
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasla.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.ForeColor = System.Drawing.Color.White;
            this.btnBasla.Image = global::StudyCheck.FormsUI.Properties.Resources.load;
            this.btnBasla.Location = new System.Drawing.Point(803, 151);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(58, 42);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // studyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.examInfoControl1);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBaslamaTarihi);
            this.Controls.Add(this.lblGecenZaman);
            this.Name = "studyControl";
            this.Size = new System.Drawing.Size(980, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGecenZaman;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblBaslamaTarihi;
        private System.Windows.Forms.Button btnDurdur;
        private examInfoControl examInfoControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
