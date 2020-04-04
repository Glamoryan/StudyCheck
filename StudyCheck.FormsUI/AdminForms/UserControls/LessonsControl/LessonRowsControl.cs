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

namespace StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl
{
    public partial class LessonRowsControl : UserControl
    {
        private LessonSettingsControl _lessonSettingsControl;

        public LessonRowsControl()
        {
            InitializeComponent();
        }

        private void SetExams()
        {
            _lessonSettingsControl.cbxDersSinav.ValueMember = "id";
            _lessonSettingsControl.cbxDersSinav.DisplayMember = "sinav_ad";
            _lessonSettingsControl.cbxDersSinav.DataSource = LessonControl._sinavlar.Where(x => x.sil_id == 1).ToList();
        }

        private void DersAyarlarinaGit()
        {
            var uyeler = LessonControl._uyeler;
            var ders = LessonControl._dersler.Where(x => x.id == Convert.ToInt32(lblDersId.Text)).Single();
            var sinavlar = LessonControl._sinavlar;
            PageRoute.contentPanel.Controls.Clear();
            _lessonSettingsControl = new LessonSettingsControl();
            SetExams();
            _lessonSettingsControl.lblDersAdi.Text = lblDersAd.Text;
            _lessonSettingsControl.tbxDersAdi.Text = lblDersAd.Text;
            _lessonSettingsControl.tbxDersId.Text = lblDersId.Text;
            _lessonSettingsControl.tbxEkleyen.Text = lblEkleyen.Text;
            _lessonSettingsControl.tbxGuncelleme.Text = ders.guncelleme_tarihi.ToString();
            _lessonSettingsControl.tbxGuncelleyen.Text = uyeler.Where(x => x.id == ders.guncelleyen_id).Single().kullanici_adi;
            _lessonSettingsControl.tbxTarih.Text = lblTarih.Text;
            _lessonSettingsControl.cbxDurum.SelectedIndex = ders.sil_id;
            _lessonSettingsControl.cbxDersSinav.SelectedValue = sinavlar.Where(x => x.id == ders.sinav_id).Single().id;
            PageRoute.contentPanel.Controls.Add(_lessonSettingsControl);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DersAyarlarinaGit();
        }
    }
}
