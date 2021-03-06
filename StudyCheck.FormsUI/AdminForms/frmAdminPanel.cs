﻿using StudyCheck.Core.Aspects.Postsharp.CacheAspects;
using StudyCheck.Core.CrossCuttingConcerns.Caching.Microsoft;
using StudyCheck.Core.Entities;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.Entites.ComplexTypes;
using StudyCheck.FormsUI.AdminForms.UserControls;
using StudyCheck.FormsUI.AdminForms.UserControls.ExamControl;
using StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl;
using StudyCheck.FormsUI.AdminForms.UserControls.RightsControl;
using StudyCheck.FormsUI.AdminForms.UserControls.RolesControl;
using StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl;
using StudyCheck.FormsUI.Statikler;
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

        private DashboardControl _dashboardControl;
        private AccountsControl _accountsControl;
        private RoleControl _roleControl;
        private RightControl _rightControl;
        private LessonControl _lessonControl;
        private ExamControl _examControl;
        private frmLogin _loginForm;


        public frmAdminPanel()
        {
            InitializeComponent();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        private void SetAccountControl()
        {            
            if (_accountsControl == null)
            {
                _accountsControl = new AccountsControl();
                PageRoute.accountsControl = _accountsControl;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(_accountsControl);
            }
            else
            {
                if (!pnlContent.Controls.ContainsKey("AccountsControl"))
                {
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(PageRoute.accountsControl);
                }                
                else if (pnlContent.Controls.ContainsKey("AccountsControl"))
                {
                    _accountsControl = new AccountsControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    PageRoute.accountsControl = _accountsControl;
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(_accountsControl);
                }
            }            
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        private void SetRoleControl()
        {
            if(_roleControl == null)
            {
                _roleControl = new RoleControl();
                PageRoute.roleControl = _roleControl;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(_roleControl);
            }
            else
            {
                if (!pnlContent.Controls.ContainsKey("RoleControl"))
                {
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(PageRoute.roleControl);
                }
                else if (pnlContent.Controls.ContainsKey("RoleControl"))
                {
                    _roleControl = new RoleControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    PageRoute.roleControl = _roleControl;
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(_roleControl);
                }
            }
        }

        private void SetRightControl()
        {
            if(_rightControl == null)
            {
                _rightControl = new RightControl();
                PageRoute.rightControl = _rightControl;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(_rightControl);
            }
            else
            {
                if (!pnlContent.Controls.ContainsKey("RightControl"))
                {
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(PageRoute.rightControl);
                }
                else if (pnlContent.Controls.ContainsKey("RightControl"))
                {
                    _rightControl = new RightControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    PageRoute.rightControl = _rightControl;
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(_rightControl);
                }
            }
        }

        private void SetLessonControl()
        {
            if(_lessonControl == null)
            {
                _lessonControl = new LessonControl();
                PageRoute.lessonControl = _lessonControl;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(_lessonControl);
            }
            else
            {
                if (!pnlContent.Controls.ContainsKey("LessonControl"))
                {
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(PageRoute.lessonControl);
                }
                else if (pnlContent.Controls.ContainsKey("LessonControl"))
                {
                    _lessonControl = new LessonControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    PageRoute.lessonControl = _lessonControl;
                    pnlContent.Controls.Add(_lessonControl);
                }
            }
        }

        private void SetExamControl()
        {
            if(_examControl == null)
            {
                _examControl = new ExamControl();
                PageRoute.examControl = _examControl;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(_examControl);
            }
            else
            {
                if (!pnlContent.Controls.ContainsKey("ExamControl"))
                {
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(PageRoute.examControl);
                }
                else if (pnlContent.Controls.ContainsKey("ExamControl"))
                {
                    _examControl = new ExamControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    PageRoute.examControl = _examControl;
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(_examControl);
                }
            }
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        private void SetDashboardControl()
        {            
            if(_dashboardControl == null)
            {
                _dashboardControl = new DashboardControl();
                PageRoute.dashboardControl = _dashboardControl;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(_dashboardControl);
            }
            else
            {
                if(!pnlContent.Controls.ContainsKey("DashboardControl"))
                {
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(PageRoute.dashboardControl);
                }                
                else if (pnlContent.Controls.ContainsKey("DashboardControl"))
                {
                    _dashboardControl = new DashboardControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    PageRoute.dashboardControl = _dashboardControl;
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(_dashboardControl);
                }
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

        
        

        private void GetAdminName()
        {
            lblAdminName.Text = LoginInfo.KullaniciAdi.ToUpper();
        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {
            PageRoute.contentPanel = pnlContent;
            WhichTab(dbPanel);
            lblTarih.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            AnimateWindow(this.Handle, 500, FormAnimates.AnimateWindowFlags.AW_BLEND);
            GetAdminName();
            SetDashboardControl();
        }

        [CacheApplicationExitAspect(typeof(MemoryCacheManager))]
        private void pcbSignOut_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Yap?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {                
                ClearLogin();
                this.Hide();
                _loginForm = new frmLogin();
                _loginForm.FormClosed += (s, args) => this.Close();
                _loginForm.Show();                
            }

        }
        private void WhichTab(Panel panel)
        {            
            panel.BringToFront();
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if(ctrl is Panel && ctrl.Name != pnlLogo.Name)
                {
                    if (ctrl.Name == panel.Name)
                        ctrl.BackColor = Color.FromArgb(255, 83, 17);
                    else
                        ctrl.BackColor = Color.Transparent;
                }
            } 
        }

        private void pcbSignOut_MouseEnter(object sender, EventArgs e)
        {
            pcbSignOut.Cursor = Cursors.Hand;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            WhichTab(dbPanel);
            SetDashboardControl();
        }

        private void btnUyeler_Click(object sender, EventArgs e)
        {
            WhichTab(acPanel);
            SetAccountControl();
        }

        private void btnRoller_Click(object sender, EventArgs e)
        {
            WhichTab(rolPanel);
            SetRoleControl();
        }

        private void btnYetkiler_Click(object sender, EventArgs e)
        {
            WhichTab(ytPanel);
            SetRightControl();
        }

        private void btnDersler_Click(object sender, EventArgs e)
        {
            WhichTab(drsPanel);
            SetLessonControl();
        }

        private void btnSinavlar_Click(object sender, EventArgs e)
        {
            WhichTab(snvPanel);
            SetExamControl();
        }

        private void btnTemalar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tema ayarları yakında eklenecektir", "Tema Ayarları Mevcut Değil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
