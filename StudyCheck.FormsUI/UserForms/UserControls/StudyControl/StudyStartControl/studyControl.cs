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

namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl.StudyStartControl
{
    public partial class studyControl : UserControl
    {
        private Timer _timer;
        private DateTime _baslangic = DateTime.MinValue;
        private TimeSpan _gecenZaman = TimeSpan.Zero;
        private TimeSpan _toplamZaman = TimeSpan.Zero;

        private static EfExamDal _efExamDal = new EfExamDal();
        private static EfLessonDal _efLessonDal = new EfLessonDal();
        private static EfStudyDal _efStudyDal = new EfStudyDal();

        private ExamManager _examManager = new ExamManager(_efExamDal);
        private LessonManager _lessonManager = new LessonManager(_efLessonDal);
        private StudyManager _studyManager = new StudyManager(_efStudyDal);

        private Sinav _sinav;
        private Ders _ders;
        private List<Calisma> _calismalar;

        private bool _timerRunning = false;

        private int _sinavId, _dersId;
        public studyControl(int sinavId ,int dersId)
        {
            InitializeComponent();

            _sinavId = sinavId;
            _dersId = dersId;

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timerTick);
        }

        private void _timerTick(object sender,EventArgs e)
        {
            var baslamaZamani = DateTime.Now - _baslangic;
            baslamaZamani = new TimeSpan(baslamaZamani.Hours, baslamaZamani.Minutes, baslamaZamani.Seconds);

            _gecenZaman = baslamaZamani + _toplamZaman;
            lblGecenZaman.Text = _gecenZaman.ToString();
            lblBaslamaTarihi.Text = _baslangic.ToString();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (!_timerRunning)
            {
                _baslangic = DateTime.Now;
                _toplamZaman = _gecenZaman;
                _timer.Start();
                _timerRunning = true;
            }
            else
            {
                _timer.Stop();
                _timerRunning = false;
            }
        }

        private void GetExamDetails()
        {
            TimeSpan toplamSinav = TimeSpan.Zero;
            _calismalar = _studyManager.GetAllStudies().Where(s => s.uye_id == LoginInfo.UyeId).ToList();
            _sinav = _examManager.GetExamById(_sinavId);            
            examInfo.lblSinavAdi.Text = _sinav.sinav_ad;
            foreach (var cls in _calismalar.Where(s=>s.sinav_id==_sinavId))
            {
                toplamSinav += cls.calisilan_zaman;
            }

            examInfo.lblCalisilanToplam.Text = toplamSinav.ToString();

            if ((toplamSinav.TotalMinutes / _calismalar.Count) <= 20)
                examInfo.lblCalismaDurum.Text = "Yetersiz";
            else if ((toplamSinav.TotalMinutes / _calismalar.Count) <= 40)
                examInfo.lblCalismaDurum.Text = "Yeterli";
            else if ((toplamSinav.TotalMinutes / _calismalar.Count) >= 41)
                examInfo.lblCalismaDurum.Text = "Çok iyi";

            var sinavTarihi = _sinav.sinav_tarih;
            examInfo.lblKalanGun.Text = (DateTime.Now - sinavTarihi).TotalDays.ToString();
        }

        /// <summary>
        /// GetExamDetails methodundan önce yazılmalı
        /// </summary>
        private void GetLessonDetails()
        {
            TimeSpan toplamDers = TimeSpan.Zero;
            _ders = _lessonManager.GetLessonById(_dersId);
            lessonInfo.lblDersAdi.Text = _ders.ders_ad;
            foreach (var drs in _calismalar.Where(s=>s.ders_id == _dersId))
            {
                toplamDers += drs.calisilan_zaman;
            }
            lessonInfo.lblDersToplam.Text = toplamDers.ToString();
        }

        private void studyControl_Load(object sender, EventArgs e)
        {
            GetExamDetails();
            GetLessonDetails();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _timerRunning = false;
            _toplamZaman = TimeSpan.Zero;
            _gecenZaman = TimeSpan.Zero;
        }
    }
}
