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
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;
using StudyCheck.FormsUI.ExceptionManage;

namespace StudyCheck.FormsUI.UserForms.UserControls
{
    public partial class UserDashboardControl : UserControl
    {
        private Exception mainException;

        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static EfStudyDal _efStudyDal = new EfStudyDal();
        private static EfExamDal _efExamDal = new EfExamDal();
        private static EfLessonDal _efLessonDal = new EfLessonDal();
        private static EfThemeDal _efThemeDal = new EfThemeDal();
        private static EfRolDal _efRolDal = new EfRolDal();

        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);
        private static StudyManager _studyManager = new StudyManager(_efStudyDal);
        private static ExamManager _examManager = new ExamManager(_efExamDal);
        private static LessonManager _lessonManager = new LessonManager(_efLessonDal);
        private static ThemeManager _themeManager = new ThemeManager(_efThemeDal);
        private static RoleManager _roleManager = new RoleManager(_efRolDal);

        private Uye _uye;
        private Uyedetay _uyedetay;
        private List<Calisma> _calismalar;
        private Sinav _sonSinav;
        private Ders _sonDers;
        private Tema _tema;
        private Rol _rol;
        private DateTime _sonCalisma;
        private TimeSpan _toplamDakika;
        private TimeSpan _sinavToplam;
        private TimeSpan _dersToplam;

        public UserDashboardControl()
        {
            InitializeComponent();
        }

        private void GetUserAndAccountThemeRole()
        {
            _uye = _userManager.GetUserById(LoginInfo.UyeId);
            _uyedetay = _userManager.GetUyeDetayById(LoginInfo.Id);
            int temaId = _uyedetay.tema_id;
            int rolId = _uyedetay.rol_id;
            _tema = _themeManager.GetThemeById(temaId);
            _rol = _roleManager.GetRoleById(rolId);
        }

        private void GetStudiesAndExamsLessons()
        {
            _calismalar = _studyManager.GetAllStudies().Where(x => x.uye_id == LoginInfo.UyeId).ToList();            
            if (_calismalar.Count > 0)
            {
                int sinavId = _calismalar.Last().sinav_id;
                int dersId = _calismalar.Last().ders_id;
                _sonCalisma = _calismalar.Last().calisilan_tarih;
                _sonSinav = _examManager.GetExamById(sinavId);
                _sonDers = _lessonManager.GetLesson(dersId);

                foreach (var calisma in _calismalar)
                {
                    if (calisma.uye_id == LoginInfo.UyeId && calisma.sinav_id == _sonSinav.id)
                    {
                        _sinavToplam += calisma.calisilan_zaman;
                    }
                    if (calisma.uye_id == LoginInfo.UyeId && calisma.ders_id == _sonDers.id)
                    {
                        _dersToplam += calisma.calisilan_zaman;
                    }
                    if (calisma.uye_id == LoginInfo.UyeId)
                    {
                        _toplamDakika += calisma.calisilan_zaman;
                    }
                }
            }            
            else if (_calismalar.Count == 0)
                throw new NoDataException("Kayıtlı Çalışma Bulunamadı");
        }        

        private void GetInfoDetail()
        {
            GetUserAndAccountThemeRole();            
            userWidgetAccountInfo.lblKullaniciAdi.Text = _uyedetay.kullanici_adi;
            userWidgetAccountInfo.lblMail.Text = _uyedetay.kullanici_mail;
            userWidgetAccountInfo.lblKayitTarihi.Text = _uyedetay.kayit_tarihi.ToString("dd/MM/yyyy");
            userWidgetAccountInfo.lblTemaAdi.Text = _tema.tema_adi;
            userWidgetAccountInfo.lblRolAdi.Text = _rol.rol_adi;
            userWidgetBilgiler.lblUyeAd.Text = _uye.uye_ad;
            userWidgetBilgiler.lblUyeSoyad.Text = _uye.uye_soyad;
            GetStudiesAndExamsLessons();
            userWidgetBilgiler.lblToplamCalisilanSaat.Text = _toplamDakika.ToString();
            userWidgetBilgiler.lblSonSinav.Text = _sonSinav.sinav_ad;
            userWidgetBilgiler.lblSonDers.Text = _sonDers.ders_ad;
            userWidgetBilgiler.lblSonCalismaTarihi.Text = _sonCalisma.ToString("dd/MM/yyyy");
            userWidgetSonSinav.lblSinavAd.Text = _sonSinav.sinav_ad;
            userWidgetSonSinav.lblToplamCalisilanSaat.Text = _sinavToplam.ToString();
            userWidgetSonSinav.lblSinavTarih.Text = _sonSinav.sinav_tarih.ToString("dd/MM/yyyy");
            userWidgetSonDers.lblDersAd.Text = _sonDers.ders_ad;
            userWidgetSonDers.lblToplamCalisilanSaat.Text = _dersToplam.ToString();
            userWidgetSonDers.lblSonZaman.Text = _calismalar.Last().calisilan_zaman.ToString();
            
        }

        private void UserDashboardControl_Load(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => GetInfoDetail());
            if (mainException is NoDataException)
                MessageBox.Show(mainException.Message, "Çalışma Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
