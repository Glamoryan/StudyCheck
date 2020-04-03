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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGecenZaman
            // 
            this.lblGecenZaman.AutoSize = true;
            this.lblGecenZaman.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecenZaman.ForeColor = System.Drawing.Color.White;
            this.lblGecenZaman.Location = new System.Drawing.Point(344, 19);
            this.lblGecenZaman.Name = "lblGecenZaman";
            this.lblGecenZaman.Size = new System.Drawing.Size(259, 78);
            this.lblGecenZaman.TabIndex = 0;
            this.lblGecenZaman.Text = "00:00:00";
            // 
            // lblBaslamaTarihi
            // 
            this.lblBaslamaTarihi.AutoSize = true;
            this.lblBaslamaTarihi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslamaTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.lblBaslamaTarihi.Location = new System.Drawing.Point(18, 19);
            this.lblBaslamaTarihi.Name = "lblBaslamaTarihi";
            this.lblBaslamaTarihi.Size = new System.Drawing.Size(90, 26);
            this.lblBaslamaTarihi.TabIndex = 0;
            this.lblBaslamaTarihi.Text = "00:00:00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnBasla.Location = new System.Drawing.Point(778, 89);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(170, 42);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBasla);
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
        private System.Windows.Forms.Button button1;
    }
}
