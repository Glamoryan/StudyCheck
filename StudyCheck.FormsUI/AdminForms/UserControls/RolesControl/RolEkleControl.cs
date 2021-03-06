﻿using System;
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
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;

namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    public partial class RolEkleControl : UserControl
    {
        private Exception mainException;

        private IRoleService _roleService;

        private List<Rol> _roller;
        private Rol _rol;

        public RolEkleControl()
        {
            InitializeComponent();
            _roleService = InstanceFactory.GetInstance<IRoleService>();
        }
        
        private void RolEkleControl_Load(object sender, EventArgs e)
        {
            SetYetkiler();
            cbxYetki.SelectedIndex = 0;
            cbxDurum.SelectedIndex = 0;
        }

        private void SetYetkiler()
        {
            cbxYetki.ValueMember = "id";
            cbxYetki.DisplayMember = "yetki_adi";
            cbxYetki.DataSource = RoleControl.yetkiler;
        }

        private void isAdd(Rol rol)
        {
            _roller = _roleService.GetAllRoles();
            foreach (Rol rl in _roller)
            {
                if (rol.rol_adi.ToLower().Equals(rl.rol_adi.ToLower()))
                    throw new DataAlreadyExistsException("Bu rol zaten mevcut!");
            }
        }

        private void CheckFields()
        {
            if (tbxRolAdi.Text.Equals(string.Empty))
                throw new RequiredFieldsException("Rol adı boş bırakılamaz!");
        }

        private void SetRole()
        {
            CheckFields();
            _rol = new Rol
            {
                rol_adi = tbxRolAdi.Text,
                rol_kayit_tarihi = DateTime.Now,
                ekleyen_id = LoginInfo.Id,
                rol_guncelleme_tarihi = DateTime.Now,
                sil_id = cbxDurum.SelectedIndex,
                yetki_id = Convert.ToInt32(cbxYetki.SelectedValue),
                guncelleyen_id = LoginInfo.Id
            };
            isAdd(_rol);
            _roleService.AddRole(_rol);
        }

        private void btnRolEkle_Click(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => SetRole());
            if (mainException is RequiredFieldsException)
                MessageBox.Show(mainException.Message, "Boş alan bırakılamaz!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (mainException is DataAlreadyExistsException)
                MessageBox.Show(mainException.Message, "Rol zaten mevcut!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException is ValidationException)
                MessageBox.Show(mainException.Message, "Doğrulama hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException == null)
            {
                MessageBox.Show("Rol başarıyla eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PageRoute.RefreshAllDataControls();
                PageRoute.contentPanel.Controls.Clear();                
                PageRoute.contentPanel.Controls.Add(PageRoute.roleControl);
            }
                
        }
    }
}
