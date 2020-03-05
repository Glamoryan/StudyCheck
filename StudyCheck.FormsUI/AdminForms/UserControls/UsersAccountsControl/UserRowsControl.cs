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
using StudyCheck.Entites.AccountManagement;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Entites.Concrete;
using StudyCheck.Entites.ComplexTypes;

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    public partial class UserRowsControl : UserControl
    {
        private static UserSettingsControl _userSettingsControl;

        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static EfThemeDal _efThemeDal = new EfThemeDal();
        private static EfRolDal _efRolDal = new EfRolDal();

        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);
        static ThemeManager _themeManager = new ThemeManager(_efThemeDal);
        static RoleManager _roleManager = new RoleManager(_efRolDal);

        private static UserDetail detay = new UserDetail();

        public UserRowsControl()
        {
            InitializeComponent();
            AccountsControl.deger = detay;
        }

        private void GetThemes()
        {                                 
            _userSettingsControl.cbxTema.ValueMember = "id";
            _userSettingsControl.cbxTema.DisplayMember = "tema_adi";
            _userSettingsControl.cbxTema.DataSource = AccountsControl.temalar;            
        }

        private void GetRoles()
        {                      
            _userSettingsControl.cbxRol.ValueMember = "id";
            _userSettingsControl.cbxRol.DisplayMember = "rol_adi";
            _userSettingsControl.cbxRol.DataSource = AccountsControl.roller;            
        }

        private void KullaniciAyarlariGetir()
        {
            var uyeDetay = _userManager.GetUserDetailById(Convert.ToInt32(lblUyeId.Text));
            PageRoute.contentPanel.Controls.Clear();
            _userSettingsControl = new UserSettingsControl();
            GetThemes();
            GetRoles();
            _userSettingsControl.lblKullaniciAdi.Text = uyeDetay.KullaniciAdi; //Hangi kullanıcı için yapılan ayarları belirten label
            _userSettingsControl.tbxKullaniciAdi.Text = uyeDetay.KullaniciAdi;
            _userSettingsControl.tbxKullaniciSifre.Text = uyeDetay.KullaniciSifre;
            _userSettingsControl.tbxKullaniciMail.Text = uyeDetay.KullaniciMail;
            _userSettingsControl.tbxKayitTarihi.Text = uyeDetay.KayitTarihi.ToString();
            _userSettingsControl.tbxUyeId.Text = uyeDetay.UyeId.ToString();
            _userSettingsControl.tbxUyeAdi.Text = uyeDetay.UyeAd;
            _userSettingsControl.tbxUyeSoyadi.Text = uyeDetay.UyeSoyad;
            _userSettingsControl.lblUyeDId.Text = uyeDetay.UyeDetayId.ToString();
            _userSettingsControl.cbxDurum.SelectedIndex = uyeDetay.sil_id;
            _userSettingsControl.tbxGuncellemeTarihi.Text = uyeDetay.GuncellemeTarihi.ToString();
            _userSettingsControl.cbxTema.SelectedValue = AccountsControl.temalar.Where(x => x.id == uyeDetay.tema_id).Single().id;
            _userSettingsControl.cbxRol.SelectedValue = AccountsControl.roller.Where(x => x.id == uyeDetay.rol_id).Single().id;
            PageRoute.contentPanel.Controls.Add(_userSettingsControl);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            KullaniciAyarlariGetir();
        }
    }
}
