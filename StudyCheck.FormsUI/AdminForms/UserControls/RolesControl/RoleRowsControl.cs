﻿using System;
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

namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    public partial class RoleRowsControl : UserControl
    {
        public RoleRowsControl()
        {
            InitializeComponent();
        }
        private static EfRolDal _efRolDal = new EfRolDal();

        private static RoleManager _roleManager = new RoleManager(_efRolDal);
        private static RoleSettingsControl _roleSettingsControl;

        private void RolAyarlarinaGit()
        {
            var rol = _roleManager.GetRoleById(Convert.ToInt32(lblRolId.Text));
            PageRoute.contentPanel.Controls.Clear();
            _roleSettingsControl = new RoleSettingsControl();
            _roleSettingsControl.lblrolAdi.Text = lblRolAd.Text;
            _roleSettingsControl.tbxRolAdi.Text = lblRolAd.Text;
            _roleSettingsControl.tbxRolId.Text = lblRolId.Text;
            _roleSettingsControl.cbxDurum.SelectedIndex = rol.sil_id;
            _roleSettingsControl.tbxRolGuncelleme.Text = rol.rol_guncelleme_tarihi.ToString();
            _roleSettingsControl.tbxRolKayit.Text = lblRolKayit.Text;
            _roleSettingsControl.tbxEkleyen.Text = lblEkleyen.Text;
            _roleSettingsControl.tbxYetkiId.Text = rol.yetki_id.ToString();
            PageRoute.contentPanel.Controls.Add(_roleSettingsControl);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            RolAyarlarinaGit();
        }
    }
}