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

namespace StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl
{
    public partial class LessonSettingsControl : UserControl
    {
        public LessonSettingsControl()
        {
            InitializeComponent();
        }

        private static Exception mainException;

        private static EfLessonDal _efLessonDal = new EfLessonDal();
        private static EfStudyDal _efStudyDal = new EfStudyDal();

        private static LessonManager _lessonManager = new LessonManager(_efLessonDal);
        private static StudyManager _studyManager = new StudyManager(_efStudyDal);

        private static Ders _ders;
        
        private void CheckFields()
        {
            if (tbxDersAdi.Text.Equals(string.Empty))
                throw new RequiredFieldsException("Ders adı boş bırakılamaz!");
        }

        private void DersGuncelle()
        {
            CheckFields();
            _ders = new Ders
            {
                id = Convert.ToInt32(tbxDersId.Text),
                ders_ad = tbxDersAdi.Text,
                eklenme_tarihi = Convert.ToDateTime(tbxTarih.Text),
                guncelleme_tarihi = DateTime.Now,
                sil_id = cbxDurum.SelectedIndex,
                ekleyen_id = LessonControl._uyeler.Where(x => x.kullanici_adi == tbxEkleyen.Text).Single().id,
                guncelleyen_id = LoginInfo.Id,
                sinav_id = Convert.ToInt32(cbxDersSinav.SelectedValue)
            };
            CheckIfLessonUsing();
            _lessonManager.UpdateLesson(_ders);
        }

        // çözüm bul
        //private void CheckIfAlreadyExist()
        //{
        //    if (!(tbxDersAdi.Text.Equals(LessonSettingsInfos.dersAdi)))
        //    {
        //        var dersler = LessonControl._dersler;
        //        foreach (var ders in dersler)
        //        {
        //            if (ders.sinav_id == Convert.ToInt32(cbxDersSinav.SelectedValue))
        //            {
        //                if (ders.ders_ad.Equals(tbxDersAdi.Text))
        //                    throw new DataAlreadyExistsException("Bu ders adı , bu sınavda zaten mevcut!");
        //            }
        //        }
        //    }            
        //}


        private void SetDefault()
        {
            LessonSettingsInfos.dersAdi = tbxDersAdi.Text;
            LessonSettingsInfos.silId = cbxDurum.SelectedIndex;
            LessonSettingsInfos.sinavId = Convert.ToInt32(cbxDersSinav.SelectedValue);
        }

        private bool CheckEdited()
        {
            if (btnDersCancel.Visible || btnDersSuccess.Visible)
                return false;
            return true;
        }

        private void dersControl_Changed(object sender,EventArgs e)
        {
            btnDersCancel.Visible = true;
            btnDersSuccess.Visible = true;
            btnDersDuzenle.Visible = false;
        }

        private void SetDersSettings()
        {
            LessonSettingsInfos.dersAdi = tbxDersAdi.Text;
            LessonSettingsInfos.silId = cbxDurum.SelectedIndex;
            LessonSettingsInfos.sinavId = Convert.ToInt32(cbxDersSinav.SelectedValue);
        }

        private void ReturnSettings()
        {
            tbxDersAdi.Text = LessonSettingsInfos.dersAdi;
            cbxDurum.SelectedIndex = LessonSettingsInfos.silId;
            cbxDersSinav.SelectedValue = LessonSettingsInfos.sinavId;
        }

        private void LessonSettingsControl_Load(object sender, EventArgs e)
        {
            SetDefault();
        }

        private void btnDersDuzenle_Click(object sender, EventArgs e)
        {
            gbxDers.Enabled = true;
            if (!btnDersCancel.Visible)
            {
                foreach (Control control in gbxDers.Controls)
                {
                    control.TextChanged += new EventHandler(dersControl_Changed);
                }
            }
            else if (btnDersCancel.Visible)
                btnDersDuzenle.Visible = true;
        }

        private void btnDersSuccess_Click(object sender, EventArgs e)
        {
            SetDersSettings();
            MessageBox.Show("Değişiklikler kaydedildi , Onaylamak için güncelleyin", "Onaylama gerekli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gbxDers.Enabled = false;
            btnDersCancel.Visible = false;
            btnDersSuccess.Visible = false;
            btnDersDuzenle.Visible = true;
        }

        private void btnDersCancel_Click(object sender, EventArgs e)
        {
            ReturnSettings();
            gbxDers.Enabled = false;
            btnDersCancel.Visible = false;
            btnDersSuccess.Visible = false;
            btnDersDuzenle.Visible = true;
        }

        private void CheckIfLessonUsing()
        {
            if(cbxDurum.SelectedIndex == 0)
            {
                var calismalar = _studyManager.GetAllStudies();
                foreach (var calisma in calismalar)
                {
                    if (calisma.ders_id == Convert.ToInt32(tbxDersId.Text))
                        throw new DataIsUsingException("Bu dersi kullanan çalışmalar var(Kullanıcılar tarafından)! Pasifleştirilemez!");
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            PageRoute.contentPanel.Controls.Add(PageRoute.lessonControl);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (CheckEdited())
            {
                mainException = ExceptionHandling.HandleException(() => DersGuncelle());
                if (mainException is RequiredFieldsException)
                    MessageBox.Show(mainException.Message, "Boş Alan Bırakılamaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (mainException is DataIsUsingException)
                    MessageBox.Show(mainException.Message, "Bu Ders Kullanılıyor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException is ValidationException)
                    MessageBox.Show(mainException.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException != null)
                    MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException == null)
                {
                    MessageBox.Show("Ders başarıyla güncellendi!","Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PageRoute.RefreshAllDataControls();
                    PageRoute.contentPanel.Controls.Clear();
                    PageRoute.contentPanel.Controls.Add(PageRoute.lessonControl);
                }
            }
            else
                MessageBox.Show("Önce değişiklikler kaydedilmeli!", "Kayıt gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
