using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.Entites.Concrete;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.FormsUI.ExceptionManage;
using FluentValidation;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;

namespace StudyCheck.FormsUI.AdminForms.UserControls.ExamControl
{
    public partial class SinavEkleControl : UserControl
    {
        private Exception mainException;

        private IExamService _examService;

        public SinavEkleControl()
        {
            InitializeComponent();
            _examService = InstanceFactory.GetInstance<IExamService>();
        }                

        private Sinav _sinav;

        private void isAdd(Sinav sinav)
        {
            var sinavlar = ExamControl._sinavlar;
            foreach (var snv in sinavlar)
            {
                if (snv.sinav_ad.ToLower().Equals(sinav.sinav_ad.ToLower()))
                    throw new DataAlreadyExistsException("Bu sınav zaten mevcut!");
            }
        }

        private void CheckFields()
        {
            if (tbxSinavAdi.Text.Equals(string.Empty) || !(mtbxSinavTarihi.MaskCompleted))
                throw new RequiredFieldsException("Sınav adı ve Tarihi boş bırakılamaz!");
        }

        private void SetExam()
        {
            CheckFields();
            _sinav = new Sinav
            {
                sinav_ad = tbxSinavAdi.Text,
                sinav_tarih = Convert.ToDateTime(mtbxSinavTarihi.Text),
                eklenme_tarihi = DateTime.Now,
                ekleyen_id = LoginInfo.Id,
                guncelleme_tarihi = DateTime.Now,
                sil_id = cbxDurum.SelectedIndex,
                guncelleyen_id = LoginInfo.Id
            };
            isAdd(_sinav);
            _examService.AddExam(_sinav);
        }

        private void btnSinavEkle_Click(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => SetExam());
            if (mainException is RequiredFieldsException)
                MessageBox.Show(mainException.Message, "Boş alan bırakılamaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (mainException is DataAlreadyExistsException)
                MessageBox.Show(mainException.Message, "Sınav Zaten Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException is ValidationException)
                MessageBox.Show(mainException.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException == null)
            {
                MessageBox.Show("Sınav başarıyla eklendi", "Ekleme başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PageRoute.RefreshAllDataControls();
                PageRoute.contentPanel.Controls.Clear();              
                PageRoute.contentPanel.Controls.Add(PageRoute.examControl);
            }

        }

        private void SinavEkleControl_Load(object sender, EventArgs e)
        {
            cbxDurum.SelectedIndex = 1;
        }
    }
}
