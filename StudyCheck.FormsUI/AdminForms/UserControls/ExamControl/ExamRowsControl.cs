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

namespace StudyCheck.FormsUI.AdminForms.UserControls.ExamControl
{
    public partial class ExamRowsControl : UserControl
    {
        public ExamRowsControl()
        {
            InitializeComponent();
        }
        private ExamSettingsControl _examSettingsControl;

        private void SinavAyarlarinaGit()
        {
            var uyeler = ExamControl._uyeler;
            var sinav = ExamControl._sinavlar.Where(x => x.id == Convert.ToInt32(lblSinavId.Text)).Single();
            PageRoute.contentPanel.Controls.Clear();
            _examSettingsControl = new ExamSettingsControl();
            _examSettingsControl.tbxSinavAd.Text = sinav.sinav_ad;
            _examSettingsControl.lblSinavAdi.Text = sinav.sinav_ad;
            _examSettingsControl.tbxSinavId.Text = lblSinavId.Text;
            _examSettingsControl.mtbxSinavTarihi.Text = lblSinavTarihi.Text;
            _examSettingsControl.tbxKayitTarihi.Text = lblKayitTarihi.Text;
            _examSettingsControl.tbxEkleyen.Text = lblEkleyen.Text;
            _examSettingsControl.tbxGuncelleme.Text = sinav.guncelleme_tarihi.ToString();
            _examSettingsControl.cbxDurum.SelectedIndex = sinav.sil_id;
            _examSettingsControl.tbxGuncelleyen.Text = uyeler.Where(x => x.id == sinav.guncelleyen_id).Single().kullanici_adi;
            PageRoute.contentPanel.Controls.Add(_examSettingsControl);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            SinavAyarlarinaGit();
        }
    }
}
