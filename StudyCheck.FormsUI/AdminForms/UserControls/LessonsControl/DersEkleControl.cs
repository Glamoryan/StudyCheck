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
using StudyCheck.FormsUI.ExceptionManage;
using FluentValidation;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;

namespace StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl
{
    public partial class DersEkleControl : UserControl
    {
        private Exception mainException;

        private ILessonService _lessonService;

        private Ders _ders;

        public DersEkleControl()
        {
            InitializeComponent();
            _lessonService = InstanceFactory.GetInstance<ILessonService>();
        }                

        

        private void SetExams()
        {
            cbxDersSinav.ValueMember = "id";
            cbxDersSinav.DisplayMember = "sinav_ad";
            cbxDersSinav.DataSource = LessonControl._aktifSinavlar;
        }

        private void isAdd(Ders ders)
        {
            var dersler = LessonControl._dersler;
            foreach (var dr in dersler)
            {
                if(ders.sinav_id == dr.sinav_id)
                {
                    if (ders.ders_ad.ToLower().Equals(dr.ders_ad.ToLower()))
                        throw new DataAlreadyExistsException("Bu ders , bu sınava zaten kayıtlı!");
                }
            }
        }

        private void CheckFields()
        {
            if (tbxDersAdi.Text.Equals(string.Empty))
                throw new RequiredFieldsException("Ders adı boş bırakılamaz!");
        }

        private void SetLesson()
        {
            CheckFields();
            _ders = new Ders
            {
                ders_ad = tbxDersAdi.Text,
                eklenme_tarihi = DateTime.Now,
                ekleyen_id = LoginInfo.Id,
                guncelleme_tarihi = DateTime.Now,
                guncelleyen_id = LoginInfo.Id,
                sil_id = cbxDurum.SelectedIndex,
                sinav_id = Convert.ToInt32(cbxDersSinav.SelectedValue)                
            };
            isAdd(_ders);
            _lessonService.AddLesson(_ders);
        }

        private void DersEkleControl_Load(object sender, EventArgs e)
        {
            SetExams();
            cbxDurum.SelectedIndex = 1;
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(()=>SetLesson());
            if (mainException is RequiredFieldsException)
                MessageBox.Show(mainException.Message, "Boş Alan Bırakılamaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (mainException is DataAlreadyExistsException)
                MessageBox.Show(mainException.Message, "Ders Zaten Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException is ValidationException)
                MessageBox.Show(mainException.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException == null)
            {
                MessageBox.Show("Ders başarıyla eklendi","Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PageRoute.RefreshAllDataControls();
                PageRoute.contentPanel.Controls.Clear();               
                PageRoute.contentPanel.Controls.Add(PageRoute.lessonControl);
            }
        }
    }
}
