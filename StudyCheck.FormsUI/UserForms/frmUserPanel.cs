﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.UserForms
{
    public partial class frmUserPanel : Form
    {
        public frmUserPanel()
        {
            InitializeComponent();
        }

        private void frmUserPanel_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
    }
}
