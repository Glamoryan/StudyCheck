using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.Entites.Concrete;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;
using StudyCheck.FormsUI.ExceptionManage;

namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    public partial class RoleControl : UserControl
    {
        public RoleControl()
        {
            InitializeComponent();
        }
        private static Exception mainException;

        private static EfRolDal _efRolDal = new EfRolDal();
        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();

        private static RoleManager _roleManager = new RoleManager(_efRolDal);
        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);

        private static List<Rol> _roller;
        private static RoleRowsControl _roleRowsControl;
        private static List<Uyedetay> _uyeler;

        private void GetUsers()
        {
            _uyeler = _userManager.GetAllUyeDetay();
        }

        private void GetRoleDetails()
        {
            GetUsers();
            _roller = _roleManager.GetAllRoles();
            if (_roller.Count <= 0)
                throw new NoDataException("Hiçbir rol bulunamadı");
            else if (!pnlRoleContent.Controls.ContainsKey("RoleRowsControl"))
            {
                int i = 0;
                foreach (var rol in _roller)
                {
                    _roleRowsControl = new RoleRowsControl();
                    _roleRowsControl.Top = (i * 40);
                    //pnlRoleContent.Controls.Add(_roleRowsControl);  idu
                    _roleRowsControl.lblRolId.Text = rol.id.ToString();
                    _roleRowsControl.lblRolAd.Text = rol.rol_adi;
                    _roleRowsControl.lblRolKayit.Text = rol.rol_kayit_tarihi.ToString();
                    _roleRowsControl.lblEkleyen.Text = _uyeler.Where(x => x.id == rol.ekleyen_id).Single().kullanici_adi;
                    switch (rol.sil_id)
                    {
                        case 0:
                            _roleRowsControl.lblDurum.Text = "Pasif";
                            _roleRowsControl.lblDurum.ForeColor = Color.Red;
                            break;
                        case 1:
                            _roleRowsControl.lblDurum.Text = "Aktif";
                            _roleRowsControl.lblDurum.ForeColor = Color.Green;
                            break;
                    }
                    pnlRoleContent.Controls.Add(_roleRowsControl);
                    i++;
                }
            }
        }

        private void RoleControl_Load(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => GetRoleDetails());
            if (mainException is NoDataException)
                MessageBox.Show(mainException.Message, "Veri Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRolEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
