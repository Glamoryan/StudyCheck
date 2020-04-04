using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.Entites.Concrete;
using StudyCheck.Entites.AccountManagement;
using StudyCheck.FormsUI.UserForms.UserControls.StudyControl.StudyStartControl;
using StudyCheck.FormsUI.ExceptionManage;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;

namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl
{
    public partial class StudyPanel : UserControl
    {
        private Exception mainException;

        private static examInfoControl _examInfoControl;
        private static lessonInfoControl _lessonInfoControl;
        private static examRows _examRows;
        private static lessonRows _lessonRows;

        private studyControl _studyControl;

        private static EfExamDal _efExamDal = new EfExamDal();
        private static EfLessonDal _efLessonDal = new EfLessonDal();
        private static EfStudyDal _efStudyDal = new EfStudyDal();

        private static ExamManager _examManager = new ExamManager(_efExamDal);
        private static LessonManager _lessonManager = new LessonManager(_efLessonDal);
        private static StudyManager _studyManager = new StudyManager(_efStudyDal);

        private byte? _durum; // null = Yeni , 1 = Sınav Seçili , 2 = Son dersten devam
        private List<Sinav> _sinavlar;
        private List<Ders> _dersler;
        private List<Calisma> _calismalar;
        private TimeSpan _sinavToplam;
        private TimeSpan _dersToplam;
        private string _ortalama;
        private List<Calisma> _calisma;        
        private int _kalanGun;

        private int? _secilenSinavId;
        private int? _secilenDersId;        


        private int? _sinavId , _dersId;

        //Scroolbar
        private int location = 0;
        private int dersLocation = 0;
        //--------------------------------

        public StudyPanel(byte? durum=null,int? sinavId=null,int? dersId=null)
        {
            InitializeComponent();
            if (durum != null)
            {
                _durum = durum;
                _sinavId = sinavId;
                _dersId = dersId;
            }
                

            pnlSinavContent.AutoScrollPosition = new Point(0, 0);
            pnlDersContent.AutoScrollPosition = new Point(0, 0);
        }

        private void GetExamInfoControl()
        {
            switch (_durum)
            {
                case null:
                    if (_examInfoControl == null)
                    {
                        _examInfoControl = new examInfoControl();
                        pnlExamInfo.Controls.Clear();
                        pnlExamInfo.Controls.Add(_examInfoControl);
                        PageRoute.examInfoControl = _examInfoControl;
                    }
                    else
                    {
                        pnlExamInfo.Controls.Clear();
                        pnlExamInfo.Controls.Add(PageRoute.examInfoControl);
                    }
                    break;
                case 1:
                    if(_examInfoControl == null)
                    {
                        _examInfoControl = new examInfoControl();
                        pnlExamInfo.Controls.Clear();
                        pnlExamInfo.Controls.Add(_examInfoControl);
                        PageRoute.examInfoControl = _examInfoControl;                        
                        foreach (examRows ctrl in pnlSinavContent.Controls)
                        {
                            foreach (Button btn in ctrl.Controls.OfType<Button>())
                            {
                                if (btn.Text.Equals(_sinavlar.Where(s => s.id == _sinavId).Single().sinav_ad))
                                {
                                    WhichExam(btn);
                                    GetLessonDetails(Convert.ToInt32(_sinavId));
                                    GetExamInfo(Convert.ToInt32(_sinavId));
                                    GetLessonInfo(-1);
                                }
                            }
                        }
                    }
                    else
                    {
                        pnlExamInfo.Controls.Clear();
                        pnlExamInfo.Controls.Add(PageRoute.examInfoControl);
                        foreach (examRows ctrl in pnlSinavContent.Controls)
                        {
                            foreach (Button btn in ctrl.Controls.OfType<Button>())
                            {
                                if (btn.Text.Equals(_sinavlar.Where(s => s.id == _sinavId).Single().sinav_ad))
                                {
                                    WhichExam(btn);
                                }
                            }
                        }
                    }
                    break;
                    

            }    
        }        

        private void GetLessonInfoControl()
        {
            if (_lessonInfoControl == null)
            {
                _lessonInfoControl = new lessonInfoControl();
                pnlLessonInfo.Controls.Clear();
                pnlLessonInfo.Controls.Add(_lessonInfoControl);
                PageRoute.lessonInfoControl = _lessonInfoControl;
            }
            else
            {
                pnlLessonInfo.Controls.Clear();
                pnlLessonInfo.Controls.Add(PageRoute.lessonInfoControl);
            }
        }

        private void GetExams()
        {
            _sinavlar = _examManager.GetActiveExams();
        }

        private void GetLessons(int sinavId)
        {
            _dersler = _lessonManager.GetActiveLessonsById(sinavId);
        }

        public void GetLessonDetails(int sinavId)
        {
            pnlDersContent.Controls.Clear();
            GetLessons(sinavId);
            if (!pnlLessonInfo.Controls.ContainsKey("lessonRows"))
            {
                int i = 0;
                foreach (var lesson in _dersler)
                {
                    _lessonRows = new lessonRows();
                    _lessonRows.Top = (i * 82);
                    _lessonRows.btnDers.Text = lesson.ders_ad;
                    _lessonRows.lblDersId.Text = lesson.id.ToString();
                    //_lessonRows.lblDersAdi.Text = lesson.ders_ad;                    
                    pnlDersContent.Controls.Add(_lessonRows);
                    i++;
                }                
            }
        }

        private void GetExamDetails()
        {
            GetExams();
            if (!pnlSinavContent.Controls.ContainsKey("examRows"))
            {
                int i = 0;
                foreach (var exam in _sinavlar)
                {
                    _examRows = new examRows();
                    _examRows.Top = (i * 82);
                    _examRows.btnSinav.Text = exam.sinav_ad;
                    //_examRows.lblSinavAdi.Text = exam.sinav_ad;
                    _examRows.lblSinavId.Text = exam.id.ToString();
                    pnlSinavContent.Controls.Add(_examRows);
                    i++;
                }                
            }
        }

        private void GetStudies()
        {
            _calismalar = _studyManager.GetStudiesByUyeId(LoginInfo.UyeId);
        }

        private bool CalculateOrtalama(int sinavId)
        {
            _calisma = _calismalar.Where(e => e.sinav_id == sinavId).ToList();
            if (_calisma.Count > 0)
            {
                _sinavToplam = TimeSpan.Zero;
                foreach (var calis in _calisma)
                {
                    _sinavToplam += calis.calisilan_zaman;
                }

                if ((_sinavToplam.TotalMinutes / _calisma.Count) <= 20)
                    _ortalama = "Yetersiz";
                else if ((_sinavToplam.TotalMinutes / _calisma.Count) <= 40)
                    _ortalama = "Yeterli";
                else if ((_sinavToplam.TotalMinutes / _calisma.Count) >= 41)
                    _ortalama = "Çok iyi";

                var sinavTarihi = _sinavlar.Where(s => s.id == sinavId).Single().sinav_tarih;
                _kalanGun = Convert.ToInt32((DateTime.Now - sinavTarihi).TotalDays);
                return true;
            }
            return false;            
        }

        private bool GetLesson(int dersId)
        {
            if(dersId != -1)
            {
                _calisma = _calismalar.Where(l => l.ders_id == dersId).ToList();
                if (_calisma.Count > 0)
                {
                    _dersToplam = TimeSpan.Zero;
                    foreach (var calis in _calisma)
                    {
                        _dersToplam += calis.calisilan_zaman;
                    }
                    return true;
                }                
            }
            return false;
        }
            

        public void GetLessonInfo(int dersId)
        {
            GetStudies();
            if (dersId == -1)
            {
                pnlLessonInfo.Controls.Clear();
                _lessonInfoControl = new lessonInfoControl();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                _lessonInfoControl.lblDersAdi.Text = "-";
                _lessonInfoControl.lblDersToplam.Text = "00:00:00";
                pnlLessonInfo.Controls.Add(_lessonInfoControl);
            }
            else if (GetLesson(dersId))
            {
                pnlDersContent.VerticalScroll.Maximum = pnlDersContent.Controls.OfType<Control>().Select(c => c.Location.Y).Last();
                pnlLessonInfo.Controls.Clear();
                _lessonInfoControl.lblDersAdi.Text = _dersler.Where(l => l.id == dersId).Single().ders_ad;
                _lessonInfoControl.lblDersToplam.Text = _dersToplam.ToString();
                pnlLessonInfo.Controls.Add(_lessonInfoControl);
            }            
            else
            {
                pnlLessonInfo.Controls.Clear();
                _lessonInfoControl.lblDersAdi.Text = _dersler.Where(l => l.id == dersId).Single().ders_ad;
                _lessonInfoControl.lblDersToplam.Text = "00:00:00";
                pnlLessonInfo.Controls.Add(_lessonInfoControl);
            }
        }

        public void GetExamInfo(int sinavId)
        {
            GetLessonInfo(-1); //sınav seçildikten sonra ders silinsin
            GetStudies();            
            if (CalculateOrtalama(sinavId))
            {
                pnlExamInfo.Controls.Clear();
                //_examInfoControl = new examInfoControl();
                _examInfoControl.lblSinavAdi.Text = _sinavlar.Where(s => s.id == sinavId).Single().sinav_ad;
                _examInfoControl.lblCalisilanToplam.Text = _sinavToplam.ToString();
                _examInfoControl.lblCalismaDurum.Text = _ortalama;
                _examInfoControl.lblKalanGun.Text = _kalanGun.ToString();
                pnlExamInfo.Controls.Add(_examInfoControl);
            }
            else
            {
                pnlExamInfo.Controls.Clear();
                _examInfoControl.lblSinavAdi.Text = _sinavlar.Where(s => s.id == sinavId).Single().sinav_ad;
                _examInfoControl.lblCalisilanToplam.Text = "00:00:00";
                _examInfoControl.lblCalismaDurum.Text = "-";
                _examInfoControl.lblKalanGun.Text = _kalanGun.ToString();
                pnlExamInfo.Controls.Add(_examInfoControl);
            }
            
        }

        private void ClearInfos()
        {
            _examInfoControl = null;
            _lessonInfoControl = null;
        }

        private void StudyPanel_Load(object sender, EventArgs e)
        {
            ClearInfos();
            GetExamDetails();
            GetExamInfoControl();
            GetLessonInfoControl();
            
            pnlSinavContent.VerticalScroll.Maximum = pnlSinavContent.Controls.OfType<Control>().Select(c => c.Location.Y).Last();            
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            if (location - 40 > 0)
            {
                location -= 40;
                pnlSinavContent.VerticalScroll.Value = location;
            }
            else
            {
                location = 0;
                pnlSinavContent.AutoScrollPosition = new Point(0, location);
            }
        }

        public void WhichExam(Button button)
        {            
            foreach (examRows uControl in pnlSinavContent.Controls)
            {
                if(uControl is examRows)
                {
                    foreach (Button c in uControl.Controls.OfType<Button>())
                    {
                        if (c.Text == button.Text)
                        {
                            c.FlatAppearance.BorderSize = 2;
                            c.FlatAppearance.BorderColor = Color.FromArgb(255, 83, 17);
                            _secilenSinavId = _examManager.GetAllExams().Where(e => e.sinav_ad == button.Text).Single().id;
                        }
                        else
                            c.FlatAppearance.BorderSize = 0;
                    }
                }
            }
        }

        public void WhichLesson(Button button)
        {            
            foreach (lessonRows lControl in pnlDersContent.Controls)
            {
                if (lControl is lessonRows)
                {
                    foreach (Button c in lControl.Controls.OfType<Button>())
                    {
                        if(c.Text == button.Text)
                        {
                            c.FlatAppearance.BorderSize = 2;
                            c.FlatAppearance.BorderColor = Color.FromArgb(255, 83, 17);
                            _secilenDersId = _lessonManager.GetAllLessons().Where(l => l.ders_ad == button.Text && l.sinav_id == _secilenSinavId).Single().id;
                        }
                        else
                            c.FlatAppearance.BorderSize = 0;
                    }
                }
            }
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            if (location + 40 < pnlSinavContent.VerticalScroll.Maximum)
            {
                location += 40;
                pnlSinavContent.VerticalScroll.Value = location;
            }
            else
            {
                location = pnlSinavContent.VerticalScroll.Maximum;
                pnlSinavContent.AutoScrollPosition = new Point(0, location);
            }
        }

        private void btnDersUp_Click(object sender, EventArgs e)
        {
            if (dersLocation - 40 > 0)
            {
                dersLocation -= 40;
                pnlDersContent.VerticalScroll.Value = dersLocation;                
            }
            else
            {
                dersLocation = 0;
                pnlDersContent.AutoScrollPosition = new Point(0, dersLocation);
            }
        }
        
        private void SetStudyControl()
        {
            if (_secilenSinavId == null)
                throw new NoDataException("Sınav Mutlaka Seçilmeli");
            else if (_secilenDersId == null)
                throw new NoDataException("Ders Mutlaka Seçilmeli");
            else
            {
                if (_studyControl == null)
                {
                    _studyControl = new studyControl(Convert.ToInt32(_secilenSinavId), Convert.ToInt32(_secilenDersId));
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
                        _studyControl = new studyControl(Convert.ToInt32(_secilenSinavId), Convert.ToInt32(_secilenDersId));
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        PageRoute.studyControl = _studyControl;
                        PageRoute.userContentPanel.Controls.Clear();
                        PageRoute.userContentPanel.Controls.Add(_studyControl);
                    }
                }
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => SetStudyControl());
            if (mainException is NoDataException)
                MessageBox.Show(mainException.Message, "Gerekli İşlemler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDersDown_Click(object sender, EventArgs e)
        {
            if(dersLocation + 40 < pnlDersContent.VerticalScroll.Maximum)
            {
                dersLocation += 40;
                pnlDersContent.VerticalScroll.Value = dersLocation;
            }
            else
            {
                dersLocation = pnlDersContent.VerticalScroll.Maximum;
                pnlDersContent.AutoScrollPosition = new Point(0, dersLocation);
            }
        }
    }
}
