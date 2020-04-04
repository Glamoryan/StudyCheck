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
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.FormsUI.ExceptionManage;
using FluentValidation;
using StudyCheck.FormsUI.Statikler;

namespace StudyCheck.FormsUI.AdminForms.UserControls.RightsControl
{
    public partial class YetkiEkleControl : UserControl
    {
        public YetkiEkleControl()
        {
            InitializeComponent();
        }
        private static Exception mainException;

        private static EfRightDal _efRightDal = new EfRightDal();

        private static RightManager _rightManager = new RightManager(_efRightDal);

        private static Yetki _yetki;
        private void btnYetkiEkle_Click(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => SetRight());
            if (mainException is RequiredFieldsException)
                MessageBox.Show(mainException.Message, "Boş alan bırakılamaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (mainException is DataAlreadyExistsException)
                MessageBox.Show(mainException.Message, "Zaten kayıtlı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException is ValidationException)
                MessageBox.Show(mainException.Message, "Doğrulama hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException == null)
            {
                MessageBox.Show("Yetki başarıyla eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PageRoute.RefreshAllDataControls();
                PageRoute.contentPanel.Controls.Clear();                
                PageRoute.contentPanel.Controls.Add(PageRoute.rightControl);
            }
        }

        private void YetkiEkleControl_Load(object sender, EventArgs e)
        {
            cbxDurum.SelectedIndex = 1;
        }

        private void isAdd(Yetki yetki)
        {
            var yetkiler = _rightManager.GetAllRights();
            foreach (var yt in yetkiler)
            {
                if (yetki.yetki_adi.ToLower().Equals(yt.yetki_adi.ToLower()))
                    throw new DataAlreadyExistsException("Bu yetki zaten mevcut!");
            }
        }

        private void CheckFields()
        {
            if (tbxYetkiAdi.Text.Equals(string.Empty))
                throw new RequiredFieldsException("Boş alan bırakılamaz!");
        }

        private void SetRight()
        {
            CheckFields();
            _yetki = new Yetki
            {
                yetki_adi = tbxYetkiAdi.Text,
                guncelleme_tarihi = DateTime.Now,
                eklenme_tarihi = DateTime.Now,
                sil_id = cbxDurum.SelectedIndex,
                ekleyen_id = LoginInfo.Id,
                guncelleyen_id = LoginInfo.Id
            };
            isAdd(_yetki);
            _rightManager.AddRight(_yetki);
        }
    }
}
