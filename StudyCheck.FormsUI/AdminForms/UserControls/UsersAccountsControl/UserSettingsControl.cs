using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.Entites.Concrete;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.FormsUI.Statikler;
using System.Data.SqlTypes;

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    public partial class UserSettingsControl : UserControl
    {
        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static UserManager _userManager = new UserManager(_efUserDal,_efUserDetailDal);

        private static Uye _uye;
        private static Uyedetay _uyedetay;
        public UserSettingsControl()
        {           
            InitializeComponent();            
        }    
        
        private void KullaniciGuncelle()
        {
            try
            {
                _uye = new Uye
                {
                    id = Convert.ToInt32(tbxUyeId.Text),
                    uye_ad = UserSettingsInfos.uyeAd,
                    uye_soyad = UserSettingsInfos.uyeSoyad
                };
                var UyeSonuc = _userManager.UpdateUser(_uye);
                MessageBox.Show(UyeSonuc.uye_ad + " üyesi başarıyla güncellendi", "Üye Güncellemesi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _uyedetay = new Uyedetay
                {
                    id = Convert.ToInt32(lblUyeDId.Text),
                    uye_id = Convert.ToInt32(tbxUyeId.Text),
                    kullanici_adi = UserSettingsInfos.kullaniciAdi,
                    kullanici_sifre = UserSettingsInfos.kullaniciSifre,
                    kullanici_mail = UserSettingsInfos.kullaniciMail,
                    tema_id = UserSettingsInfos.temaIndex,
                    rol_id = UserSettingsInfos.rolIndex,
                    sil_id = UserSettingsInfos.durumIndex,
                    guncelleme_tarihi = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")),
                    kayit_tarihi = Convert.ToDateTime(tbxKayitTarihi.Text)
                };
                
                var HesapSonuc = _userManager.UpdateUserDetail(_uyedetay);
                MessageBox.Show(HesapSonuc.kullanici_adi + " kullanıcısı başarıyla güncellendi", "Hesap Güncellemesi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);                           
            }            
        }

        private void SetSettingsInfo()
        {
            UserSettingsInfos.uyeAd = tbxUyeAdi.Text;
            UserSettingsInfos.uyeSoyad = tbxUyeSoyadi.Text;
            UserSettingsInfos.kullaniciAdi = tbxKullaniciAdi.Text;
            UserSettingsInfos.kullaniciSifre = tbxKullaniciSifre.Text;
            UserSettingsInfos.kullaniciMail = tbxKullaniciMail.Text;
            UserSettingsInfos.kayitTarihi = tbxKayitTarihi.Text;
            UserSettingsInfos.temaIndex = cbxTema.SelectedIndex;
            UserSettingsInfos.rolIndex = cbxRol.SelectedIndex;
            UserSettingsInfos.durumIndex = cbxDurum.SelectedIndex;
        }

        private void UserSettingsControl_Load(object sender, EventArgs e)
        {
            SetSettingsInfo();            
        }

        private void AktifEt(GroupBox groupBox)
        {
            if (groupBox.Name.Equals("gbxHesap"))
            {
                groupBox.Enabled = true;
                gbxUye.Enabled = false;
            }
            else
            {
                groupBox.Enabled = true;
                gbxHesap.Enabled = false;
            }
        }

        private void cbxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSifreGoster.Checked)
                tbxKullaniciSifre.PasswordChar = '\0';//null karakter
            else if (!cbxSifreGoster.Checked)
                tbxKullaniciSifre.PasswordChar = '*';
        }       
        private void btnHesapDuzenle_Click(object sender, EventArgs e)
        {
            if (!btnUyeCancel.Visible)
            {
                AktifEt(gbxHesap);
                foreach (Control control in gbxHesap.Controls)
                {
                    control.TextChanged += new EventHandler(Hesap_ControlDegisti);
                }                
            }
            else if (btnUyeCancel.Visible)
            {
                DialogResult sonuc = MessageBox.Show("Değişiklikler kaydedilsin mi?", "Değişiklikleri Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                    MessageBox.Show("Değişiklikler kaydedildi", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (sonuc == DialogResult.No)
                {
                    SetUyeDefault();
                }
                AktifEt(gbxHesap);
                btnUyeCancel.Visible = false;
                btnUyeSuccess.Visible = false;
                btnUyeDuzenle.Visible = true;
            }
            
        }
        
        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {            
            if (!btnHesapCancel.Visible)
            {
                AktifEt(gbxUye);
                foreach (Control control in gbxUye.Controls)
                {
                    control.TextChanged += new EventHandler(Uye_ControlDegisti);
                }
            }    
            else if (btnHesapCancel.Visible)
            {
                DialogResult sonuc = MessageBox.Show("Değişiklikler kaydedilsin mi?", "Değişiklikleri Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                    MessageBox.Show("Değişiklikler kaydedildi", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (sonuc == DialogResult.No)
                {
                    SetHesapDefault();                   
                }
                AktifEt(gbxUye);
                btnHesapCancel.Visible = false;
                btnHesapSuccess.Visible = false;
                btnHesapDuzenle.Visible = true;
            }
        }

        private void SetUyeDefault()
        {
            tbxUyeAdi.Text = UserSettingsInfos.uyeAd;
            tbxUyeSoyadi.Text = UserSettingsInfos.uyeSoyad;
        }
        private void SetHesapDefault()
        {
            tbxKullaniciAdi.Text = UserSettingsInfos.kullaniciAdi;
            tbxKullaniciSifre.Text = UserSettingsInfos.kullaniciSifre;
            tbxKullaniciMail.Text = UserSettingsInfos.kullaniciMail;
            tbxKayitTarihi.Text = UserSettingsInfos.kayitTarihi;
            cbxTema.SelectedIndex = UserSettingsInfos.temaIndex;
            cbxRol.SelectedIndex = UserSettingsInfos.rolIndex;
            cbxDurum.SelectedIndex = UserSettingsInfos.durumIndex;
        }

        void Uye_ControlDegisti(object sender,EventArgs e)
        {
            btnUyeDuzenle.Visible = false;
            btnUyeCancel.Visible = true;
            btnUyeSuccess.Visible = true;
        }

        void Hesap_ControlDegisti(object sender,EventArgs e)
        {
            btnHesapDuzenle.Visible = false;
            btnHesapCancel.Visible = true;
            btnHesapSuccess.Visible = true;
        }

        private void btnUyeCancel_Click(object sender, EventArgs e)
        {            
            gbxUye.Enabled = false;
            SetUyeDefault();
            btnUyeCancel.Visible = false;
            btnUyeSuccess.Visible = false;
            btnUyeDuzenle.Visible = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            PageRoute.contentPanel.Controls.Add(Pages.accountsControl);
        }

        private void btnHesapCancel_Click(object sender, EventArgs e)
        {
            gbxHesap.Enabled = false;
            SetHesapDefault();
            btnHesapCancel.Visible = false;
            btnHesapSuccess.Visible = false;
            btnHesapDuzenle.Visible = true;
        }

        private void btnHesapSuccess_Click(object sender, EventArgs e)
        {
            if (cbxTema.SelectedIndex == 0)
                MessageBox.Show("Tema Seçimi zorunludur!", "Zorunlu Alan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cbxRol.SelectedIndex == 0)
                MessageBox.Show("Rol Seçimi zorunludur!", "Zorunlu Alan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SetSettingsInfo();
                MessageBox.Show("Değişiklikler Kaydedildi", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbxHesap.Enabled = false;
                btnHesapCancel.Visible = false;
                btnHesapSuccess.Visible = false;
                btnHesapDuzenle.Visible = true;
            }                       
        }

        private void btnUyeSuccess_Click(object sender, EventArgs e)
        {
            SetSettingsInfo();
            MessageBox.Show("Değişiklikler Kaydedildi", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gbxUye.Enabled = false;
            btnUyeCancel.Visible = false;
            btnUyeSuccess.Visible = false;
            btnUyeDuzenle.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (gbxHesap.Enabled || gbxUye.Enabled)
                MessageBox.Show("Güncellemeden önce değişiklikler kayıt edilmeli!", "Kayıt Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KullaniciGuncelle();
        }
    }
}
