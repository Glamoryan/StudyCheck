using System;
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
using System.ComponentModel.DataAnnotations;
using StudyCheck.FormsUI.ExceptionManage;

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    public partial class KullaniciEkleControl : UserControl
    {
        private static Exception mainException;

        private static AccountsControl _accountsControl;

        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static UserManager _userManager = new UserManager(_efUserDal,_efUserDetailDal);

        private static Uye _uye;
        private static Uyedetay _uyedetay;
        List<Uyedetay> uyeDetaylari;

        private Uye uyeSonuc;
        public KullaniciEkleControl()
        {
            InitializeComponent();
        }

        private bool isUserAdd(Uyedetay uyedetay)
        {
            uyeDetaylari = _userManager.GetAllUyeDetay();
            foreach (var detay in uyeDetaylari)
            {
                if (uyedetay.kullanici_adi.Equals(detay.kullanici_adi) || uyedetay.kullanici_mail.Equals(detay.kullanici_mail))
                    return true;
            }
            return false;
        }

        private void SetKullanici()
        {            
            _uye = new Uye
            {
                uye_ad = tbxUyeAdi.Text,
                uye_soyad = tbxUyeSoyad.Text
            };
            uyeSonuc = _userManager.AddUser(_uye);
            _uyedetay = new Uyedetay
            {
                uye_id = uyeSonuc.id,
                kullanici_adi = tbxKullaniciAd.Text,
                kullanici_sifre = tbxKullaniciSifre.Text,
                kullanici_mail = tbxKullaniciMail.Text,
                kayit_tarihi = DateTime.Now,
                guncelleme_tarihi = DateTime.Now,
                rol_id = cbxRol.SelectedIndex,
                sil_id = cbxDurum.SelectedIndex,
                tema_id = cbxTema.SelectedIndex                
            };            
        }

        private void KullaniciEkleControl_Load(object sender, EventArgs e)
        {
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
            _accountsControl = new AccountsControl();
            PageRoute.contentPanel.Controls.Add(_accountsControl);
        }

        private void KullaniciEkle()
        {
            SetKullanici();
            if (isUserAdd(_uyedetay))
            {                
                throw new ValidationException("Kullanıcı Adı / Mail alınmış");
            }
            else
            {
                _userManager.AddUserDetail(_uyedetay);
                MessageBox.Show("Kullanıcı Eklendi", "Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() =>
            {
                KullaniciEkle();
            });
            if (mainException != null)
            {
                MessageBox.Show(mainException.Message);
                _userManager.DeleteUser(uyeSonuc);
            }            
        }
    }
}
