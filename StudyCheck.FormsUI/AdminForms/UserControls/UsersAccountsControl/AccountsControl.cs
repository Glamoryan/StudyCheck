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
using StudyCheck.FormsUI.Statikler;
using StudyCheck.FormsUI.ExceptionManage;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;

namespace StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl
{
    public partial class AccountsControl : UserControl
    {
        private static Exception mainException;
        public AccountsControl()
        {
            InitializeComponent();
        }        

        public static UserDetail deger = null;

        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();

        private static UserRowsControl _rowsControl;
        private static KullaniciEkleControl _ekleControl;


        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);
        private List<UserDetail> _uyeDetaylar; //Complex Type

        private void GetUserDetails()
        {           
            _uyeDetaylar = _userManager.GetAllUserDetails();            
            if (_uyeDetaylar.Count <= 0)
                throw new NoDataException("Hiçbir Kayıt Bulunamadı");

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
                    //Gizli LAbel şifre
                    _rowsControl.lblKullaniciSifre.Text = detay.KullaniciSifre;
                    //Gizli Label tema
                    if (detay.tema_id == (int)UserInfos.Temalar.Default)
                        _rowsControl.lblTema.Text = "Default";
                    else if (detay.tema_id == (int)UserInfos.Temalar.Dark)
                        _rowsControl.lblTema.Text = "Dark";
                    //Gizli Label Güncelleme
                    _rowsControl.lblGuncelleme.Text = detay.GuncellemeTarihi.ToString();
                    //Gizli Label UyeDetayId
                    _rowsControl.lblUyeDetayId.Text = detay.UyeDetayId.ToString();
                    if (detay.rol_id != (int)RoleInfo.Roller.Admin)
                    {
                        if (detay.rol_id == (int)RoleInfo.Roller.Kullanıcı)
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
                    deger = detay;
                }
            }
        }

        private void AccountsControl_Load(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => { GetUserDetails(); });
            if (mainException is NoDataException)
                MessageBox.Show(mainException.Message,"Kullanıcı Bulunamadı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            _ekleControl = new KullaniciEkleControl();
            PageRoute.contentPanel.Controls.Add(_ekleControl);
        }
    }
}
