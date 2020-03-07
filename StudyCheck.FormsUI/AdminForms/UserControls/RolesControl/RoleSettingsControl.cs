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
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.FormsUI.ExceptionManage;
using FluentValidation;

namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    public partial class RoleSettingsControl : UserControl
    {
        public RoleSettingsControl()
        {
            InitializeComponent();
        }
        private static Exception mainException;

        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static EfRolDal _efRolDal = new EfRolDal();

        private static RoleManager _roleManager = new RoleManager(_efRolDal);
        private static UserManager _userManager = new UserManager(_efUserDal,_efUserDetailDal);

        private static Rol _rol;
        private static List<Uyedetay> _uyeler;

        private void CheckFields()
        {
            if (tbxRolAdi.Text.Equals(string.Empty))
                throw new RequiredFieldsException("Rol adı boş bırakılamaz!");
        }

        private void GetUsers()
        {
            _uyeler = _userManager.GetAllUyeDetay();
        }

        private void RolGuncelle()
        {
            CheckFields();
            GetUsers();
            _rol = new Rol
            {
                id = Convert.ToInt32(tbxRolId.Text),
                rol_adi = tbxRolAdi.Text,
                rol_guncelleme_tarihi = DateTime.Now,
                rol_kayit_tarihi = Convert.ToDateTime(tbxRolKayit.Text),
                sil_id = cbxDurum.SelectedIndex,
                yetki_id = Convert.ToInt32(tbxYetkiId.Text),
                ekleyen_id = _uyeler.Where(x => x.kullanici_adi == tbxEkleyen.Text).Single().id               
            };
            _roleManager.UpdateRole(_rol);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => RolGuncelle());
            if (mainException is RequiredFieldsException)
                MessageBox.Show(mainException.Message, "Boş alan bırakılamaz!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException is ValidationException)
                MessageBox.Show(mainException.Message, "Doğrulama hatası!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı işlem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException == null)
                MessageBox.Show("Rol başarıyla güncellendi", "İşlem başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
