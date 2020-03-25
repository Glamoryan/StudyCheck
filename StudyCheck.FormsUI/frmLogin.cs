using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.DataAccess.Abstract;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Entites.ComplexTypes;
using StudyCheck.Core.Aspects.Postsharp.CacheAspects;
using StudyCheck.Core.CrossCuttingConcerns.Caching.Microsoft;
using StudyCheck.FormsUI.AdminForms;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.Utilities;
using StudyCheck.FormsUI.SplashForms;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;
using StudyCheck.FormsUI.ExceptionManage;
using FluentValidation;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.FormsUI.UserForms;

namespace StudyCheck.FormsUI
{
    public partial class frmLogin : Form
    {
        //Animasyonlar
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, FormAnimates.AnimateWindowFlags flags);
        //--------------------------------------------------------------------------
        //Drag Drop
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //----------------------------------------------
        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static EfThemeDal _efThemeDal = new EfThemeDal();
        private static EfRightDal _efRightDal = new EfRightDal();
        private static EfRolDal _efRolDal = new EfRolDal();

        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);
        private static ThemeManager _themeManager = new ThemeManager(_efThemeDal);
        private static RightManager _rightManager = new RightManager(_efRightDal);
        private static RoleManager _roleManager = new RoleManager(_efRolDal);

        private static frmUserPanel _userPanel;
        private static frmAdminPanel _adminForm;
        private static frmRegister _frmRegister;

        private static PictureBox pcbLoading;

        private static Exception mainException;

        public frmLogin()
        {
            //Thread.Sleep(500);
            InitializeComponent();            
            if (Program.SplashScreen != null && !Program.SplashScreen.Disposing && !Program.SplashScreen.IsDisposed)
                Program.SplashScreen.Invoke(new Action(() => Program.SplashScreen.Close()));
        }

        [CacheApplicationExitAspect(typeof(MemoryCacheManager))]
        private void pcbCikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   

        private void pcbCikisButon_MouseEnter(object sender, EventArgs e)
        {
            pcbCikisButon.Cursor = Cursors.Hand;
        }

        private void pcbMinimizeButon_MouseEnter(object sender, EventArgs e)
        {
            pcbMinimizeButon.Cursor = Cursors.Hand;
        }

        private void pcbMinimizeButon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DragDropPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private bool CheckFields()
        {
            if (string.IsNullOrEmpty(tbxUsername.Text) && string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Boş alan bırakılamaz!", "Gerekli Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Şifre boş geçilemez!", "Gerekli Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(tbxUsername.Text))
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez!", "Gerekli Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void CallUserForm()
        {
            this.Hide();
            _userPanel = new frmUserPanel();
            _userPanel.FormClosed += (s, args) => this.Close();
            _userPanel.Show();
        }
        delegate void CallUserFormDelegate();
        
        private void CallAdminForm()
        {
            this.Hide();
            _adminForm = new frmAdminPanel();
            _adminForm.FormClosed += (s, args) => this.Close();
            _adminForm.Show();
        }
        delegate void CallAdminFormDelegate();
        private void DoLogin()
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            var user = _userManager.GetByUsernamePassword(username, password);
            var yetkiler = _rightManager.GetAllRights();            
            if (user != null)
            {
                var rol = _roleManager.GetRoleById(user.rol_id);
                int yetkiId = yetkiler.Where(x => x.id == rol.yetki_id).Single().id;
                LoginInfo.Id = user.id;
                LoginInfo.UyeId = user.uye_id;
                LoginInfo.KullaniciAdi = user.kullanici_adi;
                LoginInfo.Sifre = user.kullanici_sifre;
                LoginInfo.Mail = user.kullanici_mail;
                LoginInfo.SilId = user.sil_id;
                LoginInfo.TemaId = user.tema_id;
                LoginInfo.RolId = user.rol_id;
                LoginInfo.YetkiId = yetkiId;
                if (LoginInfo.SilId == 0)
                {
                    throw new AccountInactiveException("Hesabınız pasif durumdadır! Admin ile iletişime geçin!");
                }
                else
                {
                    if (LoginInfo.YetkiId == 2)
                    {
                        if (this.InvokeRequired)
                        {
                            CallAdminFormDelegate del = new CallAdminFormDelegate(CallAdminForm);
                            Invoke(del, new object[] { });
                        }
                    }
                    else
                    {
                        if (this.InvokeRequired)
                        {
                            CallUserFormDelegate del = new CallUserFormDelegate(CallUserForm);
                            Invoke(del, new object[] { });
                        }
                    }
                }
            }
            else
            {
                throw new InvalidAccountException("Kullanıcı Adı veya Şifre Hatalı");
            }

        }

        private void doLoadingAnimation(Bitmap resim)
        {
            if (pcbLoading != null)
            {
                pcbLoading.BringToFront();
                pcbLoading.Visible = true;
            }
            else
            {
                pcbLoading = new PictureBox();
                pcbLoading.SizeMode = PictureBoxSizeMode.CenterImage;
                pcbLoading.Location = new Point(0, 0);
                pcbLoading.Width = this.Width;
                pcbLoading.Height = this.Height;
                pcbLoading.Image = resim;
                this.Controls.Add(pcbLoading);
                pcbLoading.BringToFront();
                pcbLoading.Visible = true;
            }
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                doLoadingAnimation(Properties.Resources._494);
                await Task.Run(()=>mainException = ExceptionHandling.HandleException(() => DoLogin())); 
                pcbLoading.Visible = false;
                pcbLoading.SendToBack();
                if (mainException is ValidationException)
                    MessageBox.Show(mainException.Message, "Geçersiz Değerler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (mainException is InvalidAccountException)
                    MessageBox.Show(mainException.Message, "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException is AccountInactiveException)
                    MessageBox.Show(mainException.Message, "Hesap Aktif Değil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (mainException != null)
                    MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);                               
            }            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false; ----------- Thread Çakışmalarına izin ver
            AnimateWindow(this.Handle, 500, FormAnimates.AnimateWindowFlags.AW_BLEND);
            FormRoute.loginForm = this;
        }

        private void CallRegisterForm()
        {                        
            this.Hide();            
            _frmRegister.FormClosed += (s, args) =>this.Close();
            _frmRegister.Show();
        }
        delegate void CallRegisterFormDelegate();
        private void GetRegisterForm()
        {
            List<Tema> temalar = _themeManager.GetActiveThemes();
            _frmRegister = new frmRegister();
            _frmRegister.cbxTema.ValueMember = "id";
            _frmRegister.cbxTema.DisplayMember = "tema_adi";
            _frmRegister.cbxTema.DataSource = temalar;
            if (this.InvokeRequired)
            {
                CallRegisterFormDelegate del= new CallRegisterFormDelegate(CallRegisterForm);
                Invoke(del, new object[] { });
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            doLoadingAnimation(Properties.Resources._494);
            await Task.Run(() => GetRegisterForm());
            pcbLoading.Visible = false;
            pcbLoading.SendToBack();                        
        }       
    }
}
