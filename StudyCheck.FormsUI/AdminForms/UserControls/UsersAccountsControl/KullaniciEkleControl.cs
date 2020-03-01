using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    public partial class KullaniciEkleControl : UserControl
    {
        public KullaniciEkleControl()
        {
            InitializeComponent();
        }

        private void KullaniciEkleControl_Load(object sender, EventArgs e)
        {
            cbxDurum.SelectedIndex = 1;
            cbxRol.SelectedIndex = 0;
            cbxTema.SelectedIndex = 0;
        }

        private void chbxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSifreGoster.Checked)
                tbxKullaniciSifre.PasswordChar = '\0';//null karakter
            else if (!chbxSifreGoster.Checked)
                tbxKullaniciSifre.PasswordChar = '*';
        }
    }
}
