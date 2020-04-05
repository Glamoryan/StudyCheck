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
using StudyCheck.FormsUI.UserForms.UserControls.StudyControl;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.FormsUI.UserForms.UserControls.StudyControl.StudyStartControl;
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;

namespace StudyCheck.FormsUI.UserForms.UserControls
{
    public partial class UserDashboardControl : UserControl
    {
        private Exception mainException;

        private IUserService _userService;
        private IStudiesService _studiesService;
        private IExamService _examService;
        private ILessonService _lessonService;
        private IThemeService _themeService;
        private IRoleService _roleService;

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
        private StudyPanel _studyPanel;
        private studyControl _studyControl;
        
        public UserDashboardControl()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _studiesService = InstanceFactory.GetInstance<IStudiesService>();
            _examService = InstanceFactory.GetInstance<IExamService>();
            _lessonService = InstanceFactory.GetInstance<ILessonService>();
            _themeService = InstanceFactory.GetInstance<IThemeService>();
            _roleService = InstanceFactory.GetInstance<IRoleService>();
        }

        private void GetUserAndAccountThemeRole()
        {
            _uye = _userService.GetUserById(LoginInfo.UyeId);
            _uyedetay = _userService.GetUyeDetayById(LoginInfo.Id);
            int temaId = _uyedetay.tema_id;
            int rolId = _uyedetay.rol_id;
            _tema = _themeService.GetThemeById(temaId);
            _rol = _roleService.GetRoleById(rolId);
        }

        private void GetStudiesAndExamsLessons()
        {
            _calismalar = _studiesService.GetAllStudies().Where(x => x.uye_id == LoginInfo.UyeId).ToList();            
            if (_calismalar.Count > 0)
            {
                int sinavId = _calismalar.Last().sinav_id;
                int dersId = _calismalar.Last().ders_id;
                _sonCalisma = _calismalar.Last().calisilan_tarih;
                _sonSinav = _examService.GetExamById(sinavId);
                _sonDers = _lessonService.GetLessonById(dersId);

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
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SetStudyControl()
        {
            int sonSinavId = _calismalar.Last().sinav_id;
            int sonDersId = _calismalar.Last().ders_id;
            if(_studyControl == null)
            {
                _studyControl = new studyControl(sonSinavId,sonDersId);
                PageRoute.studyControl = _studyControl;
                PageRoute.userContentPanel.Controls.Clear();
                PageRoute.userContentPanel.Controls.Add(_studyControl);
            }
            else
            {
                if (!PageRoute.userContentPanel.Controls.ContainsKey("studyControl"))
                {
                    PageRoute.userContentPanel.Controls.Clear();
                    PageRoute.userContentPanel.Controls.Add(PageRoute.studyControl);
                }
                else if (PageRoute.userContentPanel.Controls.ContainsKey("studyControl"))
                {
                    _studyControl = new studyControl(sonSinavId, sonDersId);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    PageRoute.studyControl = _studyControl;
                    PageRoute.userContentPanel.Controls.Clear();
                    PageRoute.userContentPanel.Controls.Add(_studyControl);
                }
            }
        }

        private void SetStudyPanel(byte? durum=null)
        {
            if(durum == null)
            {
                if (_studyPanel == null)
                {
                    _studyPanel = new StudyPanel();
                    PageRoute.studyPanel = _studyPanel;
                    PageRoute.userContentPanel.Controls.Clear();
                    PageRoute.userContentPanel.Controls.Add(_studyPanel);
                }
                else
                {
                    if (!PageRoute.userContentPanel.Controls.ContainsKey("StudyPanel"))
                    {
                        PageRoute.userContentPanel.Controls.Clear();
                        PageRoute.userContentPanel.Controls.Add(PageRoute.studyPanel);
                    }
                    else if (PageRoute.userContentPanel.Controls.ContainsKey("StudyPanel"))
                    {
                        _studyPanel = new StudyPanel();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        PageRoute.studyPanel = _studyPanel;
                        PageRoute.userContentPanel.Controls.Clear();
                        PageRoute.userContentPanel.Controls.Add(_studyPanel);
                    }
                }
            }
            else
            {
                if (_studyPanel == null)
                {
                    _studyPanel = new StudyPanel(durum,_sonSinav.id,_sonDers.id);
                    PageRoute.studyPanel = _studyPanel;
                    PageRoute.userContentPanel.Controls.Clear();
                    PageRoute.userContentPanel.Controls.Add(_studyPanel);
                }
                else
                {
                    if (!PageRoute.userContentPanel.Controls.ContainsKey("StudyPanel"))
                    {
                        PageRoute.userContentPanel.Controls.Clear();
                        PageRoute.userContentPanel.Controls.Add(PageRoute.studyPanel);
                    }
                    else if (PageRoute.userContentPanel.Controls.ContainsKey("StudyPanel"))
                    {
                        _studyPanel = new StudyPanel(durum, _sonSinav.id, _sonDers.id);
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        PageRoute.studyPanel = _studyPanel;
                        PageRoute.userContentPanel.Controls.Clear();
                        PageRoute.userContentPanel.Controls.Add(_studyPanel);
                    }
                }
            }
            
        }

        private void btnStartNew_Click(object sender, EventArgs e)
        {
            SetStudyPanel();
        }

        private void btnStartWExam_Click(object sender, EventArgs e)
        {
            if (_calismalar.Count > 0)
                SetStudyPanel(1);
            else
                MessageBox.Show("Geçerli bir çalışma bulunamadı", "Çalışma Yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnStartWLesson_Click(object sender, EventArgs e)
        {
            if(_calismalar.Count >0)
                SetStudyControl();
            else
                MessageBox.Show("Geçerli bir çalışma bulunamadı", "Çalışma Yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
