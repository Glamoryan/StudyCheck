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
            this.lblSinavId = new System.Windows.Forms.Label();
            this.btnSinav = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSinavId
            // 
            this.lblSinavId.AutoSize = true;
            this.lblSinavId.Location = new System.Drawing.Point(117, 4);
            this.lblSinavId.Name = "lblSinavId";
            this.lblSinavId.Size = new System.Drawing.Size(62, 13);
            this.lblSinavId.TabIndex = 2;
            this.lblSinavId.Text = "gizliSinavID";
            this.lblSinavId.Visible = false;
            // 
            // btnSinav
            // 
            this.btnSinav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnSinav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinav.FlatAppearance.BorderSize = 0;
            this.btnSinav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinav.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnSinav.Image = global::StudyCheck.FormsUI.Properties.Resources.exam_38px;
            this.btnSinav.Location = new System.Drawing.Point(3, 3);
            this.btnSinav.Name = "btnSinav";
            this.btnSinav.Size = new System.Drawing.Size(194, 72);
            this.btnSinav.TabIndex = 3;
            this.btnSinav.Text = "Sınav Adı";
            this.btnSinav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSinav.UseVisualStyleBackColor = false;
            this.btnSinav.Click += new System.EventHandler(this.btnSinav_Click);
            // 
            // examRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnSinav);
            this.Controls.Add(this.lblSinavId);
            this.Name = "examRows";
            this.Size = new System.Drawing.Size(200, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblSinavId;
        public System.Windows.Forms.Button btnSinav;
    }
}
