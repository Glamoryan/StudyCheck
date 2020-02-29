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
using StudyCheck.FormsUI.Statikler;

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    public partial class UserSettingsControl : UserControl
    {        
        public UserSettingsControl()
        {           
            InitializeComponent();            
        }        

        private void SetSettingsInfo()
        {
            UserSettingsInfos.uyeAd = tbxUyeAdi.Text;
            UserSettingsInfos.uyeSoyad = tbxUyeSoyadi.Text;
            UserSettingsInfos.kullaniciAdi = tbxKullaniciAdi.Text;
            UserSettingsInfos.kullaniciSifre = tbxKullaniciSifre.Text;
            UserSettingsInfos.kullaniciMail = tbxKullaniciMail.Text;
            UserSettingsInfos.kayitTarihi = tbxKayitTarihi.Text;
            UserSettingsInfos.temaIndex = cbxTema.SelectedIndex;
            UserSettingsInfos.rolIndex = cbxRol.SelectedIndex;
            UserSettingsInfos.durumIndex = cbxDurum.SelectedIndex;
        }

        private void UserSettingsControl_Load(object sender, EventArgs e)
        {
            SetSettingsInfo();
        }

        private void AktifEt(GroupBox groupBox)
        {
            if (groupBox.Name.Equals("gbxHesap"))
            {
                groupBox.Enabled = true;
                gbxUye.Enabled = false;
            }
            else
            {
                groupBox.Enabled = true;
                gbxHesap.Enabled = false;
            }
        }

        private void cbxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSifreGoster.Checked)
                tbxKullaniciSifre.PasswordChar = '\0';//null karakter
            else if (!cbxSifreGoster.Checked)
                tbxKullaniciSifre.PasswordChar = '*';
        }

        private void btnHesapDuzenle_Click(object sender, EventArgs e)
        {
            AktifEt(gbxHesap);
        }
        
        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {
            AktifEt(gbxUye);
            foreach (Control control in gbxUye.Controls)
            {
                control.TextChanged += new EventHandler(C_ControlDegisti);
            }
        }

        void C_ControlDegisti(object sender,EventArgs e)
        {                       
            btnUyeCancel.Visible = true;
        }

        private void btnUyeCancel_Click(object sender, EventArgs e)
        {
            gbxUye.Enabled = false;
            tbxUyeAdi.Text = UserSettingsInfos.uyeAd;
            tbxUyeSoyadi.Text = UserSettingsInfos.uyeSoyad;
            btnUyeCancel.Visible = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            //user infos sıfırla
        }
    }
}
