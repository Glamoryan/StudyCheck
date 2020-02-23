using StudyCheck.Core.Aspects.Postsharp.CacheAspects;
using StudyCheck.Core.CrossCuttingConcerns.Caching.Microsoft;
using StudyCheck.Core.Entities;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.Entites.ComplexTypes;
using StudyCheck.FormsUI.AdminForms.UserControls;
using StudyCheck.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.AdminForms
{
    public partial class frmAdminPanel : Form 
    {

        //Animasyonlar
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, FormAnimates.AnimateWindowFlags flags);
        //Drag Drop
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //----------------------------------------------

        private static DashboardControl _dashboardControl;
        private static frmLogin _loginForm;


        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private void ClearLogin()
        {
            LoginInfo.Id = -1;
            LoginInfo.KullaniciAdi = null;
            LoginInfo.Mail = null;
            LoginInfo.RolId = -1;
            LoginInfo.Sifre = null;
            LoginInfo.SilId = -1;
            LoginInfo.TemaId = -1;
            LoginInfo.UyeId = -1;
        }

        private void pcbExit_MouseEnter(object sender, EventArgs e)
        {
            pcbExit.Cursor = Cursors.Hand;
        }

        [CacheApplicationExitAspect(typeof(MemoryCacheManager))]
        private void pcbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pcbMinimize.Cursor = Cursors.Hand;
        }

        private void pcbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void GetDashboardControl()
        {
            _dashboardControl = new DashboardControl();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_dashboardControl);            
        }

        private void GetAdminName()
        {
            lblAdminName.Text = LoginInfo.KullaniciAdi.ToUpper();
        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {            
            AnimateWindow(this.Handle, 500, FormAnimates.AnimateWindowFlags.AW_BLEND);
            GetAdminName();
            GetDashboardControl();
        }

        [CacheApplicationExitAspect(typeof(MemoryCacheManager))]
        private void pcbSignOut_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Yap?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sonuc == DialogResult.Yes)
            {
                ClearLogin();
                this.Hide();
                _loginForm = new frmLogin();
                _loginForm.FormClosed += (s, args) => this.Close();
                _loginForm.Show();
            }

        }

        private void pcbSignOut_MouseEnter(object sender, EventArgs e)
        {
            pcbSignOut.Cursor = Cursors.Hand;
        }

        
    }
}
