using StudyCheck.Core.Aspects.Postsharp.CacheAspects;
using StudyCheck.Core.CrossCuttingConcerns.Caching.Microsoft;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.FormsUI.UserForms.UserControls;
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

namespace StudyCheck.FormsUI.UserForms
{
    public partial class frmUserPanel : Form
    {
        //Animasyonlar
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, FormAnimates.AnimateWindowFlags flags);
        //--------------------------------------------------------------------------
        //Drag Drop
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //----------------------------------------------

        private frmLogin _frmLogin;

        private UserDashboardControl _userDashboardControl;

        public frmUserPanel()
        {
            InitializeComponent();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        private void SetUserDashboardControl()
        {
            if(_userDashboardControl == null)
            {
                _userDashboardControl = new UserDashboardControl();
                PageRoute.userDashboardControl = _userDashboardControl;
                pnlUserContent.Controls.Clear();
                pnlUserContent.Controls.Add(_userDashboardControl);
            }
            else
            {
                if (!pnlUserContent.Controls.ContainsKey("UserDashboardControl"))
                {
                    pnlUserContent.Controls.Clear();
                    pnlUserContent.Controls.Add(PageRoute.userDashboardControl);
                }
                else if (pnlUserContent.Controls.ContainsKey("UserDashboardControl"))
                {
                    _userDashboardControl = new UserDashboardControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    PageRoute.userDashboardControl = _userDashboardControl;
                    pnlUserContent.Controls.Clear();
                    pnlUserContent.Controls.Add(_userDashboardControl);
                }
            }
        }

        private void frmUserPanel_Load(object sender, EventArgs e)
        {
            PageRoute.userContentPanel = pnlUserContent;
            //CheckForIllegalCrossThreadCalls = false; ----------- Thread Çakışmalarına izin ver
            AnimateWindow(this.Handle, 500, FormAnimates.AnimateWindowFlags.AW_BLEND);
            lblTarih.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            SetUserDashboardControl();
        }

        private void pcbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pcbMinimize.Cursor = Cursors.Hand;
        }

        private void pcbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbExit_MouseEnter(object sender, EventArgs e)
        {
            pcbExit.Cursor = Cursors.Hand;
        }

        private void pnlDragDrop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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

        private void pcbSignout_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Yap?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                ClearLogin();
                this.Hide();
                _frmLogin = new frmLogin();
                _frmLogin.FormClosed += (s, args) => this.Close();
                _frmLogin.Show();
            }
        }
    }
}
