﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.DataAccess.Concrete.EntityFramework;

namespace StudyCheck.FormsUI.AdminForms.UserControls
{
    public partial class DashboardControl : UserControl
    {
        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);

        public DashboardControl()
        {
            InitializeComponent();
        }
        
        private void GetAccountDetails()
        {
            int sonuc = _userManager.GetAllUserDetails().Count;
            accountWidget.lblWidgetTitle.Text = "Kullanıcılar";
            accountWidget.lblWidgetValue.Text = sonuc.ToString();
            accountWidget.pcbWidgetIcon.Image = Properties.Resources.user_groups_32px;
        }

        private void GetUserDetails()
        {
            int sonuc = _userManager.GetAllUsers().Count;
            userWidget.lblWidgetTitle.Text = "Üyeler";
            userWidget.lblWidgetValue.Text = sonuc.ToString();
            userWidget.pcbWidgetIcon.Image = Properties.Resources.icons8_user_account_32;
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            GetUserDetails();
            GetAccountDetails();
        }
    }
}
