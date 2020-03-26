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

namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl
{
    public partial class StudyPanel : UserControl
    {
        private static examInfoControl _examInfoControl;
        private static lessonInfoControl _lessonInfoControl;
        private static examRows _examRows;
        private static lessonRows _lessonRows;
        

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
        private string _ortalama;
        private List<Calisma> _sinavCalisma;
        private int _kalanGun;


        //Scroolbar
        private int location = 0;
        //--------------------------------

        public StudyPanel(byte? durum=null)
        {
            InitializeComponent();
            if (durum != null)
                _durum = durum;

            pnlSinavContent.AutoScrollPosition = new Point(0, 0);            
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
            }    
        }

        private void GetLessonInfoControl()
        {
            switch (_durum)
            {
                case null:
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
                    break;
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
                pnlDersContent.AutoScroll = false;
                pnlDersContent.HorizontalScroll.Enabled = false;
                pnlDersContent.HorizontalScroll.Visible = false;
                pnlDersContent.HorizontalScroll.Maximum = 0;
                pnlDersContent.AutoScroll = true;
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
            _sinavCalisma = _calismalar.Where(e => e.sinav_id == sinavId).ToList();
            if (_sinavCalisma.Count > 0)
            {
                foreach (var calis in _sinavCalisma)
                {
                    _sinavToplam += calis.calisilan_zaman;
                }

                if ((_sinavToplam.TotalMinutes / _sinavCalisma.Count) <= 20)
                    _ortalama = "Yetersiz";
                else if ((_sinavToplam.TotalMinutes / _sinavCalisma.Count) <= 40)
                    _ortalama = "Yeterli";
                else if ((_sinavToplam.TotalMinutes / _sinavCalisma.Count) >= 41)
                    _ortalama = "Çok iyi";

                var sinavTarihi = _sinavlar.Where(s => s.id == sinavId).Single().sinav_tarih;
                _kalanGun = Convert.ToInt32((DateTime.Now - sinavTarihi).TotalDays);
                return true;
            }
            return false;
            
        }

        public void GetExamInfo(int sinavId)
        {
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

        private void StudyPanel_Load(object sender, EventArgs e)
        {
            GetExamInfoControl();
            GetLessonInfoControl();
            GetExamDetails();
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
    }
}
