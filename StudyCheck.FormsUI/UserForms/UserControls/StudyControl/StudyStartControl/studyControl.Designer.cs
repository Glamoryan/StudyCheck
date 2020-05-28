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
            this.components = new System.ComponentModel.Container();
            this.lblGecenZaman = new System.Windows.Forms.Label();
            this.lblBaslamaTarihi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVerilenAra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.molaTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.chcPomodora = new System.Windows.Forms.CheckBox();
            this.cbxSes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lessonInfo = new StudyCheck.FormsUI.UserForms.UserControls.StudyControl.lessonInfoControl();
            this.examInfo = new StudyCheck.FormsUI.UserForms.UserControls.StudyControl.examInfoControl();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPomodoraSayisi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGecenZaman
            // 
            this.lblGecenZaman.AutoSize = true;
            this.lblGecenZaman.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecenZaman.ForeColor = System.Drawing.Color.White;
            this.lblGecenZaman.Location = new System.Drawing.Point(377, 80);
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
            this.lblBaslamaTarihi.Size = new System.Drawing.Size(18, 26);
            this.lblBaslamaTarihi.TabIndex = 0;
            this.lblBaslamaTarihi.Text = "-";
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
            this.label2.Location = new System.Drawing.Point(98, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çalışılan Sınav";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(407, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şuan Çalışılan Zaman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(15, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Verilen Toplam Ara :";
            // 
            // lblVerilenAra
            // 
            this.lblVerilenAra.AutoSize = true;
            this.lblVerilenAra.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVerilenAra.ForeColor = System.Drawing.Color.White;
            this.lblVerilenAra.Location = new System.Drawing.Point(204, 337);
            this.lblVerilenAra.Name = "lblVerilenAra";
            this.lblVerilenAra.Size = new System.Drawing.Size(90, 26);
            this.lblVerilenAra.TabIndex = 0;
            this.lblVerilenAra.Text = "00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label5.Location = new System.Drawing.Point(755, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Çalışılan Ders";
            // 
            // molaTimer
            // 
            this.molaTimer.Interval = 1000;
            this.molaTimer.Tick += new System.EventHandler(this.molaTimer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label6.Location = new System.Drawing.Point(666, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pomodora:";
            // 
            // chcPomodora
            // 
            this.chcPomodora.AutoSize = true;
            this.chcPomodora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.chcPomodora.Location = new System.Drawing.Point(779, 224);
            this.chcPomodora.Name = "chcPomodora";
            this.chcPomodora.Size = new System.Drawing.Size(15, 14);
            this.chcPomodora.TabIndex = 4;
            this.chcPomodora.UseVisualStyleBackColor = true;
            // 
            // cbxSes
            // 
            this.cbxSes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxSes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.cbxSes.FormattingEnabled = true;
            this.cbxSes.Items.AddRange(new object[] {
            "Thunder"});
            this.cbxSes.Location = new System.Drawing.Point(779, 256);
            this.cbxSes.Name = "cbxSes";
            this.cbxSes.Size = new System.Drawing.Size(121, 23);
            this.cbxSes.TabIndex = 5;
            this.cbxSes.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label7.Location = new System.Drawing.Point(727, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ses:";
            this.label7.Visible = false;
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnBitir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBitir.Enabled = false;
            this.btnBitir.FlatAppearance.BorderSize = 0;
            this.btnBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitir.Image = global::StudyCheck.FormsUI.Properties.Resources.stop_32px;
            this.btnBitir.Location = new System.Drawing.Point(537, 172);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(58, 42);
            this.btnBitir.TabIndex = 1;
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDurdur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDurdur.Enabled = false;
            this.btnDurdur.FlatAppearance.BorderSize = 0;
            this.btnDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurdur.Image = global::StudyCheck.FormsUI.Properties.Resources.pause_32px;
            this.btnDurdur.Location = new System.Drawing.Point(473, 172);
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
            this.btnBasla.Location = new System.Drawing.Point(409, 172);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(58, 42);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lessonInfo
            // 
            this.lessonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.lessonInfo.Location = new System.Drawing.Point(671, 61);
            this.lessonInfo.Name = "lessonInfo";
            this.lessonInfo.Size = new System.Drawing.Size(295, 131);
            this.lessonInfo.TabIndex = 3;
            // 
            // examInfo
            // 
            this.examInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.examInfo.Location = new System.Drawing.Point(20, 61);
            this.examInfo.Name = "examInfo";
            this.examInfo.Size = new System.Drawing.Size(295, 162);
            this.examInfo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(17)))));
            this.label8.Location = new System.Drawing.Point(613, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pomodora Sayısı:";
            this.label8.Visible = false;
            // 
            // lblPomodoraSayisi
            // 
            this.lblPomodoraSayisi.AutoSize = true;
            this.lblPomodoraSayisi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPomodoraSayisi.ForeColor = System.Drawing.Color.White;
            this.lblPomodoraSayisi.Location = new System.Drawing.Point(779, 299);
            this.lblPomodoraSayisi.Name = "lblPomodoraSayisi";
            this.lblPomodoraSayisi.Size = new System.Drawing.Size(18, 19);
            this.lblPomodoraSayisi.TabIndex = 6;
            this.lblPomodoraSayisi.Text = "0";
            this.lblPomodoraSayisi.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(675, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Her 2 adet , 25+5(mola) dakikalık seans 1 pomodoraya eşittir";
            // 
            // studyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(56)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPomodoraSayisi);
            this.Controls.Add(this.cbxSes);
            this.Controls.Add(this.chcPomodora);
            this.Controls.Add(this.lessonInfo);
            this.Controls.Add(this.examInfo);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVerilenAra);
            this.Controls.Add(this.lblBaslamaTarihi);
            this.Controls.Add(this.lblGecenZaman);
            this.Name = "studyControl";
            this.Size = new System.Drawing.Size(980, 416);
            this.Load += new System.EventHandler(this.studyControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGecenZaman;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblBaslamaTarihi;
        private System.Windows.Forms.Button btnDurdur;
        private examInfoControl examInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVerilenAra;
        private System.Windows.Forms.Label label5;
        private lessonInfoControl lessonInfo;
        private System.Windows.Forms.Timer molaTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chcPomodora;
        private System.Windows.Forms.ComboBox cbxSes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPomodoraSayisi;
        private System.Windows.Forms.Label label9;
    }
}
