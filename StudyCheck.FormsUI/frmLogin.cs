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
using System.Runtime.InteropServices;
using StudyCheck.Business.Concrete.Managers;

namespace StudyCheck.FormsUI
{
    public partial class frmLogin : Form
    {
        //Drag Drop
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //----------------------------------------------

        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void pcbCikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void pcbCikisButon_MouseEnter(object sender, EventArgs e)
        {
            pcbCikisButon.Cursor = Cursors.Hand;
        }

        private void pcbMinimizeButon_MouseEnter(object sender, EventArgs e)
        {
            pcbMinimizeButon.Cursor = Cursors.Hand;
        }

        private void pcbMinimizeButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DragDropPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
