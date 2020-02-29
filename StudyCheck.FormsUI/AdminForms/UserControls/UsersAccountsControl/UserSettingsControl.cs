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
using StudyCheck.Entites.AccountManagement;

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    public partial class UserSettingsControl : UserControl
    {
       
        public UserSettingsControl()
        {           
            InitializeComponent();            
        }        

        private void UserSettingsControl_Load(object sender, EventArgs e)
        {
            
        }

        private void cbxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSifreGoster.Checked)
                tbxKullaniciSifre.PasswordChar = '\0';
            else if (!cbxSifreGoster.Checked)
                tbxKullaniciSifre.PasswordChar = '*';
        }
    }
}
