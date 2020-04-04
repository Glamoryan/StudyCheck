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

namespace StudyCheck.FormsUI.AdminForms.UserControls.RightsControl
{
    public partial class RightRowsControl : UserControl
    {
        private RightSettingsControl _rightSettingsControl;

        public RightRowsControl()
        {
            InitializeComponent();
        }

        private void YetkiAyarlarinaGit()
        {
            var uyeler = RightControl._uyeler;
            var yetki = RightControl._yetkiler.Where(x=>x.id == Convert.ToInt32(lblYetkiId.Text)).Single();
            PageRoute.contentPanel.Controls.Clear();
            _rightSettingsControl = new RightSettingsControl();
            _rightSettingsControl.lblYetkiAdi.Text = lblYetkiAd.Text;
            _rightSettingsControl.tbxYetkiId.Text = lblYetkiId.Text;
            _rightSettingsControl.tbxYetkiAdi.Text = lblYetkiAd.Text;
            _rightSettingsControl.tbxKayitTarih.Text = lblTarih.Text;
            _rightSettingsControl.tbxEkleyen.Text = lblEkleyen.Text;
            _rightSettingsControl.cbxDurum.SelectedIndex = yetki.sil_id;
            _rightSettingsControl.tbxGuncelleyen.Text = uyeler.Where(x => x.id == yetki.guncelleyen_id).Single().kullanici_adi;
            _rightSettingsControl.tbxGuncellemeTarih.Text = yetki.guncelleme_tarihi.ToString();
            PageRoute.contentPanel.Controls.Add(_rightSettingsControl);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            YetkiAyarlarinaGit();
        }
    }
}
