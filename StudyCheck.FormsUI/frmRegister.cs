﻿using FluentValidation;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.Core.Aspects.Postsharp.CacheAspects;
using StudyCheck.Core.CrossCuttingConcerns.Caching.Microsoft;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Entites.Concrete;
using StudyCheck.FormsUI.ExceptionManage;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;
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

namespace StudyCheck.FormsUI
{
    public partial class frmRegister : Form
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
        
        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();

        private static UserManager _userManager = new UserManager(_efUserDal,_efUserDetailDal);        

        private static Exception mainException;

        private static Uye _uye;
        public frmRegister()
        {
            InitializeComponent();
        }

       

        private void CheckFields()
        {
            if (string.IsNullOrEmpty(tbxAd.Text) || string.IsNullOrEmpty(tbxSoyad.Text))
                throw new RequiredFieldsException("Ad veya Soyad alanları boş bırakılamaz!");
            else if (string.IsNullOrEmpty(tbxKullanici.Text) || string.IsNullOrEmpty(tbxSifre.Text))
                throw new RequiredFieldsException("Kullanıcı Adı veya Şifre alanları boş bırakılamaz!");
            else if (string.IsNullOrEmpty(tbxMail.Text))
                throw new RequiredFieldsException("Mail alanı boş bırakılamaz!");
        }

        private void isAdd(Uyedetay uyedetay)
        {            
            var uyeler = _userManager.GetAllUyeDetay();
            foreach (var detay in uyeler)
            {
                if (detay.kullanici_adi.ToLower().Equals(uyedetay.kullanici_adi.ToLower()) || detay.kullanici_mail.ToLower().Equals(uyedetay.kullanici_mail.ToLower()))
                    throw new DataAlreadyExistsException("Bu kullanıcı adı veya mail daha önce alınmış!");
            }
        }

        private void doRegister()
        {
            CheckFields();
            _uye = new Uye
            {
                uye_ad = tbxAd.Text,
                uye_soyad = tbxSoyad.Text
            };
            var uyeSonuc = _userManager.AddUser(_uye);
            Uyedetay uyedetay = new Uyedetay
            {
                uye_id = uyeSonuc.id,
                kullanici_adi = tbxKullanici.Text,
                kullanici_sifre = tbxSifre.Text,
                kullanici_mail = tbxMail.Text,
                kayit_tarihi = DateTime.Now,
                guncelleme_tarihi = DateTime.Now,
                sil_id = 1,
                tema_id = Convert.ToInt32(cbxTema.SelectedValue),
                rol_id = 2
            };
            isAdd(uyedetay);
            _userManager.AddUserDetail(uyedetay);
        }

        private void pcbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [CacheApplicationExitAspect(typeof(MemoryCacheManager))]
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DragDropPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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

        private void frmRegister_Load(object sender, EventArgs e)
        {
            FormRoute.registerForm = this;
        }
        
        private void ReturnLoginForm()
        {
            this.Hide();
            FormRoute.loginForm.FormClosed += (s, args) => this.Close();
            FormRoute.loginForm.Show();            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => doRegister());            
            if (!(mainException is RequiredFieldsException) && mainException != null)
            {
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _userManager.DeleteUser(_uye);
            }
            else if (mainException is RequiredFieldsException)
                MessageBox.Show(mainException.Message, "Gerekli Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (mainException is ValidationException)
                MessageBox.Show(mainException.Message, "Validasyon Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException is DataAlreadyExistsException)
                MessageBox.Show(mainException.Message, "Kullanıcı Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException == null)
            {
                MessageBox.Show("Kullanıcı Başarıyla Eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnLoginForm();
            }
                
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            ReturnLoginForm();
        }
    }
}
