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
using StudyCheck.FormsUI.Statikler;
using StudyCheck.Entites.Concrete;
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;

namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    public partial class RoleRowsControl : UserControl
    {
        private IRoleService _roleService;
        private IRightService _rightService;
        private IUserService _userService;

        private RoleSettingsControl _roleSettingsControl;
        private List<Yetki> _yetkiler;

        public RoleRowsControl()
        {
            InitializeComponent();
            _roleService = InstanceFactory.GetInstance<IRoleService>();
            _rightService = InstanceFactory.GetInstance<IRightService>();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }
        
        private void SetRights()
        {
            _yetkiler = _rightService.GetActiveRights();
            _roleSettingsControl.cbxYetki.ValueMember = "id";
            _roleSettingsControl.cbxYetki.DisplayMember = "yetki_adi";
            _roleSettingsControl.cbxYetki.DataSource = _yetkiler;
        }

        private void RolAyarlarinaGit()
        {            
            var rol = _roleService.GetRoleById(Convert.ToInt32(lblRolId.Text));
            var yetki = _rightService.GetRightById(rol.yetki_id);
            var uyeler = _userService.GetAllUyeDetay();
            PageRoute.contentPanel.Controls.Clear();
            _roleSettingsControl = new RoleSettingsControl();
            SetRights();
            _roleSettingsControl.lblrolAdi.Text = lblRolAd.Text;
            _roleSettingsControl.tbxRolAdi.Text = lblRolAd.Text;
            _roleSettingsControl.tbxRolId.Text = lblRolId.Text;
            _roleSettingsControl.cbxDurum.SelectedIndex = rol.sil_id;
            _roleSettingsControl.tbxRolGuncelleme.Text = rol.rol_guncelleme_tarihi.ToString();
            _roleSettingsControl.tbxRolKayit.Text = lblRolKayit.Text;
            _roleSettingsControl.tbxEkleyen.Text = lblEkleyen.Text;
            _roleSettingsControl.tbxYetkiId.Text = rol.yetki_id.ToString();
            _roleSettingsControl.cbxYetki.SelectedValue = yetki.id;
            _roleSettingsControl.tbxGuncelleyen.Text = uyeler.Where(x => x.id == rol.guncelleyen_id).Single().kullanici_adi;
            PageRoute.contentPanel.Controls.Add(_roleSettingsControl);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            RolAyarlarinaGit();
        }
    }
}
