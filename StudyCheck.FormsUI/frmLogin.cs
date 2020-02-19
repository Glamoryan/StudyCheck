﻿using StudyCheck.Entites.Concrete;
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
using StudyCheck.DataAccess.Abstract;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Entites.ComplexTypes;
using StudyCheck.Core.Aspects.Postsharp.CacheAspects;
using StudyCheck.Core.CrossCuttingConcerns.Caching.Microsoft;
using StudyCheck.FormsUI.AdminForms;
using StudyCheck.Entites.AccountManagement;

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
        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();        
        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);

        private static frmAdminPanel _adminForm;

        public frmLogin()
        {
            InitializeComponent();
            
        }
        

        [CacheApplicationExitAspect(typeof(MemoryCacheManager))]
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

        private bool CheckFields()
        {
            if (string.IsNullOrEmpty(tbxUsername.Text) && string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Boş alan bırakılamaz!","Gerekli Alanlar",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }                
            else if (string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Şifre boş geçilemez!","Gerekli Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }                
            else if (string.IsNullOrEmpty(tbxUsername.Text))
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez!","Gerekli Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
                
        }

        private void DoLogin()
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            if (CheckFields())
            {
                var user = _userManager.GetByUsernamePassword(username, password);
                if (user != null)
                {
                    LoginInfo.Id = user.id;
                    LoginInfo.UyeId = user.uye_id;
                    LoginInfo.KullaniciAdi = user.kullanici_adi;
                    LoginInfo.Sifre = user.kullanici_sifre;
                    LoginInfo.Mail = user.kullanici_mail;
                    LoginInfo.SilId = user.sil_id;
                    LoginInfo.TemaId = user.tema_id;
                    LoginInfo.RolId = user.rol_id;
                    if (LoginInfo.RolId == (int)RoleInfo.Roller.Admin)
                    {
                        _adminForm = new frmAdminPanel();
                        _adminForm.ShowDialog();
                    }
                    else
                        MessageBox.Show("Giriş Başarılı!");
                }
                else
                {
                    MessageBox.Show("Hatalı bilgiler!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoLogin();
        }
    }
}
