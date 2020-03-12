using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;
using StudyCheck.Entites.Concrete;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.FormsUI.ExceptionManage;
using FluentValidation;

namespace StudyCheck.FormsUI.AdminForms.UserControls.ExamControl
{
    public partial class ExamSettingsControl : UserControl
    {
        public ExamSettingsControl()
        {
            InitializeComponent();
        }
        private static Exception mainException;

        private static EfStudyDal _efStudyDal = new EfStudyDal();
        private static EfExamDal _efExamDal = new EfExamDal();
        private static EfLessonDal _efLessonDal = new EfLessonDal();

        private static StudyManager _studyManager = new StudyManager(_efStudyDal);
        private static ExamManager _examManager = new ExamManager(_efExamDal);
        private static LessonManager _lessonManager = new LessonManager(_efLessonDal);

        private static Sinav _sinav;

        private void CheckFields()
        {
            if (tbxSinavAd.Text.Equals(string.Empty) || !(mtbxSinavTarihi.MaskCompleted))
                throw new RequiredFieldsException("Sınav adı/sınav tarihi boş bırakılamaz!");
        }

        private void CheckIfExamUsing()
        {
            if(cbxDurum.SelectedIndex == 0)
            {
                var calismalar = _studyManager.GetAllStudies();
                var dersler = _lessonManager.GetAllLessons();
                foreach (var calisma in calismalar)
                {
                    if(calisma.sinav_id == Convert.ToInt32(tbxSinavId.Text))
                        throw new DataIsUsingException("Bu sınavı kullanan çalışmalar var(Kullanıcılar tarafından)! Pasifleştirilemez!");
                }
                foreach (var ders in dersler)
                {
                    if(ders.sinav_id == Convert.ToInt32(tbxSinavId.Text))
                        throw new DataIsUsingException("Bu sınavı kullanan dersler var! Pasifleştirilemez!");
                }
            }
        }

        private void SinavGuncelle()
        {
            CheckFields();
            _sinav = new Sinav
            {
                id = Convert.ToInt32(tbxSinavId.Text),
                sinav_ad = tbxSinavAd.Text,
                eklenme_tarihi = Convert.ToDateTime(tbxKayitTarihi.Text),
                ekleyen_id = ExamControl._uyeler.Where(x=>x.kullanici_adi == tbxEkleyen.Text).Single().id,
                guncelleme_tarihi = DateTime.Now,
                guncelleyen_id = LoginInfo.Id,
                sil_id = cbxDurum.SelectedIndex,
                sinav_tarih = Convert.ToDateTime(mtbxSinavTarihi.Text)
            };
            CheckIfExamUsing();
            _examManager.UpdateExam(_sinav);
        }

        private void SetDefault()
        {
            ExamSettingsInfos.sinavAd = tbxSinavAd.Text;
            ExamSettingsInfos.sinavTarihi = mtbxSinavTarihi.Text;
            ExamSettingsInfos.silId = cbxDurum.SelectedIndex;
        }

        private bool CheckEdited()
        {
            if (btnSinavCancel.Visible || btnSinavSuccess.Visible)
                return false;
            return true;
        }

        private void sinavControlChanged(object sender,EventArgs e)
        {
            btnSinavCancel.Visible = true;
            btnSinavSuccess.Visible = true;
            btnSinavDuzenle.Visible = false;
        }

        private void SetExamSettings()
        {
            ExamSettingsInfos.sinavAd = tbxSinavAd.Text;
            ExamSettingsInfos.sinavTarihi = mtbxSinavTarihi.Text;
            ExamSettingsInfos.silId = cbxDurum.SelectedIndex;
        }

        private void ReturnSettings()
        {
            tbxSinavAd.Text = ExamSettingsInfos.sinavAd;
            mtbxSinavTarihi.Text = ExamSettingsInfos.sinavTarihi;
            cbxDurum.SelectedIndex = ExamSettingsInfos.silId;
        }

        private void ExamSettingsControl_Load(object sender, EventArgs e)
        {
            SetDefault();
        }

        private void btnSinavDuzenle_Click(object sender, EventArgs e)
        {
            gbxSinav.Enabled = true;
            if (!btnSinavCancel.Visible)
            {
                foreach (Control control in gbxSinav.Controls)
                {
                    control.TextChanged += new EventHandler(sinavControlChanged);
                }
            }
            else if (btnSinavCancel.Visible)
                btnSinavDuzenle.Visible = true;
        }

        private void btnSinavSuccess_Click(object sender, EventArgs e)
        {
            SetExamSettings();
            MessageBox.Show("Değişiklikler kaydedildi , Onaylamak için güncelleyin", "Onaylama gerekli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gbxSinav.Enabled = false;
            btnSinavCancel.Visible = false;
            btnSinavSuccess.Visible = false;
            btnSinavDuzenle.Visible = true;
        }

        private void btnSinavCancel_Click(object sender, EventArgs e)
        {
            ReturnSettings();
            gbxSinav.Enabled = false;
            btnSinavCancel.Visible = false;
            btnSinavSuccess.Visible = false;
            btnSinavDuzenle.Visible = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            PageRoute.contentPanel.Controls.Add(PageRoute.examControl);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (CheckEdited())
            {
                mainException = ExceptionHandling.HandleException(() => SinavGuncelle());
                if (mainException is RequiredFieldsException)
                    MessageBox.Show(mainException.Message, "Boş Alan Bırakılamaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (mainException is DataIsUsingException)
                    MessageBox.Show(mainException.Message, "Sınav Zaten Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException is ValidationException)
                    MessageBox.Show(mainException.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException != null)
                    MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException == null)
                {
                    MessageBox.Show("Sınav başarıyla güncellendi!", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PageRoute.examControl = new ExamControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    PageRoute.contentPanel.Controls.Clear();
                    PageRoute.contentPanel.Controls.Add(PageRoute.examControl);
                }
            }
            else
                MessageBox.Show("Önce değişiklikler kaydedilmeli!", "Kayıt gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}