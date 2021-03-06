﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Entites.Concrete;
using StudyCheck.FormsUI.ExceptionManage;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;
using FluentValidation;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    public partial class KullaniciEkleControl : UserControl
    {
        private Exception mainException;

        private IUserService _userService;
       
        private Uye _uye;
        private Uyedetay _uyedetay;
        List<Uyedetay> uyeDetaylari;
        private Uye uyeSonuc;

        public KullaniciEkleControl()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void SetRolesAndThemes()
        {
            cbxTema.ValueMember = "id";
            cbxTema.DisplayMember = "tema_adi";
            cbxTema.DataSource = AccountsControl.temalar;
            cbxRol.ValueMember = "id";
            cbxRol.DisplayMember = "rol_adi";
            cbxRol.DataSource = AccountsControl.roller;
        }

        private bool isUserAdd(Uyedetay uyedetay)
        {
            uyeDetaylari = _userService.GetAllUyeDetay();
            foreach (var detay in uyeDetaylari)
            {
                if (uyedetay.kullanici_adi.ToLower().Equals(detay.kullanici_adi.ToLower()) || uyedetay.kullanici_mail.ToLower().Equals(detay.kullanici_mail.ToLower()))
                    return true;
            }
            return false;
        }

        private void isFieldsNull()
        {
            if (tbxUyeAdi.Text.Equals(string.Empty) || tbxUyeSoyad.Text.Equals(string.Empty))
                throw new RequiredFieldsException("Üye Bilgilerinde Boş Alan Bırakılamaz!");
            else if (tbxKullaniciAd.Text.Equals(string.Empty) || tbxKullaniciSifre.Text.Equals(string.Empty) || tbxKullaniciMail.Text.Equals(string.Empty))
                throw new RequiredFieldsException("Hesap Bilgilerinde Boş Alan Bırakılamaz!");     
            else if (cbxRol.SelectedIndex == -1 || cbxTema.SelectedIndex == -1)
                throw new RequiredFieldsException("Hesap Bilgilerinde Tema ve Rol Seçilmelidir!");
        }

        private void SetKullanici()
        {
            isFieldsNull(); 
            _uye = new Uye
            {
                uye_ad = tbxUyeAdi.Text,
                uye_soyad = tbxUyeSoyad.Text
            };
            uyeSonuc = _userService.AddUser(_uye);
            _uyedetay = new Uyedetay
            {
                uye_id = uyeSonuc.id,
                kullanici_adi = tbxKullaniciAd.Text,
                kullanici_sifre = tbxKullaniciSifre.Text,
                kullanici_mail = tbxKullaniciMail.Text,
                kayit_tarihi = DateTime.Now,
                guncelleme_tarihi = DateTime.Now,
                rol_id = Convert.ToInt32(cbxRol.SelectedValue),
                sil_id = cbxDurum.SelectedIndex,
                tema_id = Convert.ToInt32(cbxTema.SelectedValue),
                guncelleyen_id = LoginInfo.Id
            };            
        }

        private void KullaniciEkleControl_Load(object sender, EventArgs e)
        {
            SetRolesAndThemes();
            cbxDurum.SelectedIndex = 1;
            cbxRol.SelectedIndex = 0;
            cbxTema.SelectedIndex = 0;            
        }

        private void chbxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSifreGoster.Checked)
                tbxKullaniciSifre.PasswordChar = '\0';//null karakter
            else if (!chbxSifreGoster.Checked)
                tbxKullaniciSifre.PasswordChar = '*';
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            PageRoute.contentPanel.Controls.Add(PageRoute.accountsControl);
        }

        private void KullaniciEkle()
        {
            SetKullanici();
            if (isUserAdd(_uyedetay))
            {
                throw new DataAlreadyExistsException("Kullanıcı Adı / Mail alınmış");
            }
            else
                _userService.AddUserDetail(_uyedetay);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() =>
            {
                KullaniciEkle();
            });
            if (!(mainException is RequiredFieldsException) && mainException != null)
            {
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _userService.DeleteUser(_uye);
            }                
            else if (mainException is ValidationException)
                MessageBox.Show(mainException.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException == null)
            {
                MessageBox.Show("Kullanıcı Başarıyla Eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PageRoute.RefreshAllDataControls();
                PageRoute.contentPanel.Controls.Clear();                
                PageRoute.contentPanel.Controls.Add(PageRoute.accountsControl);
            }
        }
    }
}
