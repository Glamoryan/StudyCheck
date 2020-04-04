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
using StudyCheck.FormsUI.Statikler;
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;

namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    public partial class RoleControl : UserControl
    {
        private Exception mainException;

        private IRoleService _roleService;
        private IUserService _userService;
        private IRightService _rightService;

        private List<Rol> _roller;
        private RoleRowsControl _roleRowsControl;
        private List<Uyedetay> _uyeler;
        private RolEkleControl _rolEkleControl;
        public static List<Yetki> yetkiler;

        public RoleControl()
        {
            InitializeComponent();
            _roleService = InstanceFactory.GetInstance<IRoleService>();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _rightService = InstanceFactory.GetInstance<IRightService>();
        }                        

        private void GetUsers()
        {
            _uyeler = _userService.GetAllUyeDetay();
        }

        private void GetRights()
        {
            yetkiler = _rightService.GetActiveRights();
        }

        private void GetRoleDetails()
        {
            GetRights();
            GetUsers();
            _roller = _roleService.GetAllRoles();
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
                    if (rol.id == 1 || rol.id == 2)
                        _roleRowsControl.lblRolAd.ForeColor = Color.FromArgb(255, 83, 17);
                    _roleRowsControl.lblRolId.Text = rol.id.ToString();
                    _roleRowsControl.lblRolAd.Text = rol.rol_adi;
                    _roleRowsControl.lblRolKayit.Text = rol.rol_kayit_tarihi.ToString();
                    _roleRowsControl.lblRolYetki.Text = yetkiler.Where(x => x.id == rol.yetki_id).Single().yetki_adi;
                    switch (rol.yetki_id)
                    {
                        case 2:
                            _roleRowsControl.lblRolYetki.ForeColor = Color.FromArgb(232, 240, 68);
                            break;
                    }
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
            PageRoute.contentPanel.Controls.Clear();
            _rolEkleControl = new RolEkleControl();
            PageRoute.contentPanel.Controls.Add(_rolEkleControl);
        }
    }
}
