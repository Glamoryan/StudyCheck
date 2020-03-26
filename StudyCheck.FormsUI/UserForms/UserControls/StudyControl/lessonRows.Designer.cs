namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl
{
    partial class lessonRows
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
            this.btnDers = new System.Windows.Forms.Button();
            this.lblDersId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDers
            // 
            this.btnDers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btnDers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDers.FlatAppearance.BorderSize = 0;
            this.btnDers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDers.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.btnDers.Image = global::StudyCheck.FormsUI.Properties.Resources.test_passed_38px;
            this.btnDers.Location = new System.Drawing.Point(3, 3);
            this.btnDers.Name = "btnDers";
            this.btnDers.Size = new System.Drawing.Size(194, 72);
            this.btnDers.TabIndex = 4;
            this.btnDers.Text = "Ders Adı";
            this.btnDers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDers.UseVisualStyleBackColor = false;
            this.btnDers.Click += new System.EventHandler(this.btnDers_Click);
            // 
            // lblDersId
            // 
            this.lblDersId.AutoSize = true;
            this.lblDersId.Location = new System.Drawing.Point(137, 4);
            this.lblDersId.Name = "lblDersId";
            this.lblDersId.Size = new System.Drawing.Size(35, 13);
            this.lblDersId.TabIndex = 5;
            this.lblDersId.Text = "label1";
            this.lblDersId.Visible = false;
            // 
            // lessonRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnDers);
            this.Controls.Add(this.lblDersId);
            this.Name = "lessonRows";
            this.Size = new System.Drawing.Size(200, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnDers;
        public System.Windows.Forms.Label lblDersId;
    }
}
