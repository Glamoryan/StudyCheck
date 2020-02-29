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

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    public partial class UserRowsControl : UserControl
    {
        private static UserSettingsControl _userSettingsControl;
        

        

        public UserRowsControl()
        {
            InitializeComponent();
        }
        private void KullaniciAyarlariGetir()
        {            
            PageRoute.contentPanel.Controls.Clear();
            _userSettingsControl = new UserSettingsControl();
            _userSettingsControl.lblKullaniciAdi.Text = lblKullAd.Text;
            _userSettingsControl.tbxKullaniciAdi.Text = lblKullAd.Text;
            _userSettingsControl.tbxKullaniciSifre.Text = lblKullaniciSifre.Text;
            _userSettingsControl.tbxKullaniciMail.Text = lblEmail.Text;
            _userSettingsControl.tbxKayitTarihi.Text = lblKayitTarih.Text;
            _userSettingsControl.tbxUyeId.Text = lblUyeId.Text;
            _userSettingsControl.tbxUyeAdi.Text = lblUyeAd.Text;
            _userSettingsControl.tbxUyeSoyadi.Text = lblUyeSoyad.Text;
            _userSettingsControl.lblUyeDId.Text = lblUyeDetayId.Text;
            if (lblDurum.Text.Equals(UserInfos.Durumlar.Aktif.ToString()))
                _userSettingsControl.cbxDurum.SelectedIndex = 1;
            else if (lblDurum.Text.Equals(UserInfos.Durumlar.Pasif.ToString()))
                _userSettingsControl.cbxDurum.SelectedIndex = 0;            
            _userSettingsControl.tbxGuncellemeTarihi.Text = lblGuncelleme.Text;
            _userSettingsControl.cbxTema.SelectedIndex = lblTema.Text.Equals(UserInfos.Temalar.Default.ToString()) ? 1 : 2;
            _userSettingsControl.cbxRol.SelectedIndex = lblRol.Text.Equals(RoleInfo.Roller.Admin.ToString()) ? 1 : 2;
            PageRoute.contentPanel.Controls.Add(_userSettingsControl);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            KullaniciAyarlariGetir();
        }
    }
}
