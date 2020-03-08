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
using StudyCheck.Entites.ComplexTypes;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.FormsUI.ExceptionManage;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;
using StudyCheck.Entites.Concrete;

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
        private static EfThemeDal _efThemeDal = new EfThemeDal();
        private static EfRolDal _efRolDal = new EfRolDal();

        private static UserRowsControl _rowsControl;
        private static KullaniciEkleControl _ekleControl;


        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);
        static ThemeManager _themeManager = new ThemeManager(_efThemeDal);
        static RoleManager _roleManager = new RoleManager(_efRolDal);

        private List<UserDetail> _uyeDetaylar; //Complex Type

        public static List<Tema> temalar;
        public static List<Rol> roller;

        private void GetThemesAndRoles()
        {            
            temalar = _themeManager.GetActiveThemes();
            roller = _roleManager.GetActiveRoles();
        }

        private void GetUserDetails()
        {
            GetThemesAndRoles();
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
                    //pnlUserContent.Controls.Add(_rowsControl); idu
                    _rowsControl.lblUyeId.Text = detay.UyeId.ToString();
                    _rowsControl.lblUyeAd.Text = detay.UyeAd;
                    _rowsControl.lblUyeSoyad.Text = detay.UyeSoyad;
                    _rowsControl.lblKullAd.Text = detay.KullaniciAdi;
                    _rowsControl.lblEmail.Text = detay.KullaniciMail;
                    _rowsControl.lblKayitTarih.Text = detay.KayitTarihi.ToString();                    
                    _rowsControl.lblRol.Text = roller.Where(x => x.id == detay.rol_id).Single().rol_adi;                    
                    switch (roller.Where(x => x.id == detay.rol_id).Single().yetki_id)
                    {
                        case 2:
                            _rowsControl.lblRol.ForeColor = Color.FromArgb(50, 130, 184);
                            break; 
                    }
                    switch (detay.sil_id)
                    {
                        case 0:
                            _rowsControl.lblDurum.Text = "Pasif";
                            _rowsControl.lblDurum.ForeColor = Color.Red;
                            break;
                        case 1:
                            _rowsControl.lblDurum.Text = "Aktif";
                            _rowsControl.lblDurum.ForeColor = Color.Green;
                            break;
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
            else if (mainException != null)
                MessageBox.Show(mainException.Message,"Hatalı İşlem",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            _ekleControl = new KullaniciEkleControl();
            PageRoute.contentPanel.Controls.Add(_ekleControl);
        }
    }
}
