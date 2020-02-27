using System;
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
using StudyCheck.Entites.ComplexTypes;
using StudyCheck.Entites.AccountManagement;

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    public partial class AccountsControl : UserControl
    {
        public AccountsControl()
        {
            InitializeComponent();
        }
        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();

        private static UserRowsControl _rowsControl;
        private static UserManager _userManager;
        private List<UserDetail> _uyeDetaylar;

        private void GetUserDetails()
        {            
            if (_userManager == null)
            {
                _userManager = new UserManager(_efUserDal, _efUserDetailDal);
            }
            _uyeDetaylar = _userManager.GetAllUserDetails();
            if (!pnlUserContent.Controls.ContainsKey("UserRowsControl"))
            {
                int i = 0;
                foreach (var detay in _uyeDetaylar)
                {
                    _rowsControl = new UserRowsControl();
                    _rowsControl.Top = (i * 40);
                    pnlUserContent.Controls.Add(_rowsControl);
                    _rowsControl.lblUyeId.Text = detay.UyeId.ToString();
                    _rowsControl.lblUyeAd.Text = detay.UyeAd;
                    _rowsControl.lblUyeSoyad.Text = detay.UyeSoyad;
                    _rowsControl.lblKullAd.Text = detay.KullaniciAdi;
                    _rowsControl.lblEmail.Text = detay.KullaniciMail;
                    _rowsControl.lblKayitTarih.Text = detay.KayitTarihi.ToString();
                    if (detay.rol_id != (int)RoleInfo.Roller.Admin)
                    {
                        if (detay.rol_id == (int)RoleInfo.Roller.User)
                            _rowsControl.lblRol.Text = "Kullanıcı";
                    }
                    else
                    {
                        _rowsControl.lblRol.Text = "Admin";
                        _rowsControl.lblRol.ForeColor = Color.FromArgb(50, 130, 184);
                    }
                    if (detay.sil_id == 0)
                    {
                        _rowsControl.lblDurum.Text = "Pasif";
                        _rowsControl.lblDurum.ForeColor = Color.Red;
                    }
                    else if (detay.sil_id == 1)
                    {
                        _rowsControl.lblDurum.Text = "Aktif";
                        _rowsControl.lblDurum.ForeColor = Color.Green;
                    }
                    pnlUserContent.Controls.Add(_rowsControl);
                    i++;
                }
            }
        }

        private void AccountsControl_Load(object sender, EventArgs e)
        {
            GetUserDetails();
        }
    }
}
