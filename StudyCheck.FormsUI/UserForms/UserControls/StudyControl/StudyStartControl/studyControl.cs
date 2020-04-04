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

namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl.StudyStartControl
{
    public partial class studyControl : UserControl
    {
        private Exception mainException;

        private Timer _timer;
        private DateTime _baslangic = DateTime.MinValue;
        private TimeSpan _gecenZaman = TimeSpan.Zero;
        private TimeSpan _toplamZaman = TimeSpan.Zero;

        private DateTime _molaBaslangic = DateTime.MinValue;
        private TimeSpan _molaGecenZaman = TimeSpan.Zero;
        private TimeSpan _molaToplamZaman = TimeSpan.Zero;

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
        }

        private void molaTimer_Tick(object sender, EventArgs e)
        {
            var molaBaslama = DateTime.Now - _molaBaslangic;
            molaBaslama = new TimeSpan(molaBaslama.Hours, molaBaslama.Minutes, molaBaslama.Seconds);
            _molaGecenZaman = molaBaslama + _molaToplamZaman;
            lblVerilenAra.Text = _molaGecenZaman.ToString();
        }

        private void CheckButtons(Button button)
        {
            switch (button.Name)
            {
                case "btnBasla":
                    btnBasla.Enabled = false;
                    btnDurdur.Enabled = true;
                    btnBitir.Enabled = true;
                    btnBasla.BackColor = Color.FromArgb(85, 85, 85);
                    btnDurdur.BackColor = Color.FromArgb(255,83,17);
                    btnBitir.BackColor = Color.Red;
                    break;
                case "btnDurdur":
                    btnDurdur.Enabled = false;
                    btnBasla.Enabled = true;
                    btnBasla.BackColor = Color.FromArgb(33, 191, 115);
                    btnDurdur.BackColor = Color.FromArgb(85, 85, 85);
                    break;
                case "btnBitir":
                    btnDurdur.Enabled = false;
                    btnBitir.Enabled = false;
                    btnBasla.Enabled = true;
                    btnBitir.BackColor = Color.FromArgb(85, 85, 85);
                    btnDurdur.BackColor = Color.FromArgb(85,85,85);
                    btnBasla.BackColor = Color.FromArgb(33, 191, 115);
                    break;
            }
            
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (!_timerRunning)
            {                
                _baslangic = DateTime.Now;
                _toplamZaman = _gecenZaman;
                _timer.Start();
                _timerRunning = true;

                CheckButtons((Button)sender);

                if(_gecenZaman == TimeSpan.Zero)
                    lblBaslamaTarihi.Text = _baslangic.ToString();

                molaTimer.Stop();
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

        private void SaveStudy()
        {       
            if (_gecenZaman <= TimeSpan.FromMinutes(3))
                throw new InsufficientTimeException("Çalışmayı kaydetmek için en az 3 dakika çalışmalısınız!");

            _timer.Stop();
            _timerRunning = false;

            _toplamZaman = TimeSpan.Zero;
            _gecenZaman = TimeSpan.Zero;

            molaTimer.Enabled = false;

            lblGecenZaman.Text = _gecenZaman.ToString();
            lblVerilenAra.Text = "00:00:00";
           
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {            
            mainException = ExceptionHandling.HandleException(() => SaveStudy());
            if (mainException is InsufficientTimeException)
                MessageBox.Show(mainException.Message, "Çalışma Kaydedilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (mainException == null)
                CheckButtons((Button)sender);

        }        

        private void btnDurdur_Click(object sender, EventArgs e)
        {  
            _timer.Stop();
            _timerRunning = false;

            _molaBaslangic = DateTime.Now;
            _molaToplamZaman = _molaGecenZaman;
            molaTimer.Enabled = true;

            CheckButtons((Button)sender);
        }
    }
}
