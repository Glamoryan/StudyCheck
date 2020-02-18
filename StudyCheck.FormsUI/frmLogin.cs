using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
                   
        }

        private void pcbCikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void pcbCikisButon_MouseEnter(object sender, EventArgs e)
        {
            pcbCikisButon.Cursor = Cursors.Hand;
        }
    }
}
