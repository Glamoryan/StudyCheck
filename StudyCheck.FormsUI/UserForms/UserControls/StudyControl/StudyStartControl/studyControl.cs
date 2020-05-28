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
using StudyCheck.FormsUI.Statikler;
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;
using System.Media;
using System.IO;
using StudyCheck.Utilities;

namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl.StudyStartControl
{
    public partial class studyControl : UserControl
    {
        private Exception mainException;

        private IExamService _examService;
        private ILessonService _lessonService;
        private IStudiesService _studiesService;

        private Timer _timer;
        private DateTime _baslangic = DateTime.MinValue;
        private TimeSpan _gecenZaman = TimeSpan.Zero;
        private TimeSpan _toplamZaman = TimeSpan.Zero;
        private DateTime _molaBaslangic = DateTime.MinValue;
        private TimeSpan _molaGecenZaman = TimeSpan.Zero;
        private TimeSpan _molaToplamZaman = TimeSpan.Zero;
        private Sinav _sinav;
        private Ders _ders;
        private List<Calisma> _calismalar;
        private List<Calisma> _calisma;
        private Calisma _suankiCalisma;
        private bool _timerRunning = false;
        private int _sinavId, _dersId, _kalangun;
        private UserDashboardControl _userDashboardControl;
        private TimeSpan _pomodoraSuresi = TimeSpan.Zero;
        SoundPlayer _player;
        private int _pomodoraSayac = 0;

        public studyControl(int sinavId, int dersId)
        {
            InitializeComponent();
            _examService = InstanceFactory.GetInstance<IExamService>();
            _lessonService = InstanceFactory.GetInstance<ILessonService>();
            _studiesService = InstanceFactory.GetInstance<IStudiesService>();

            _sinavId = sinavId;
            _dersId = dersId;

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timerTick);

            cbxSes.SelectedIndex = 0;            
        }

        private void ShowPomodora()
        {
            cbxSes.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            lblPomodoraSayisi.Visible = true;
        }

        private void _timerTick(object sender, EventArgs e)
        {
            if (chcPomodora.Checked && _pomodoraSuresi == TimeSpan.Zero)
            {
                _pomodoraSuresi = TimeSpan.FromSeconds(25);
                chcPomodora.Enabled = false;
            }                
            else if (!chcPomodora.Checked && chcPomodora.Visible == true)
            {
                chcPomodora.Visible = false;
                label6.Visible = false;
            }
                
            var baslamaZamani = DateTime.Now - _baslangic;
            baslamaZamani = new TimeSpan(baslamaZamani.Hours, baslamaZamani.Minutes, baslamaZamani.Seconds);

            _gecenZaman = baslamaZamani + _toplamZaman;
            lblGecenZaman.Text = _gecenZaman.ToString();

            if (chcPomodora.Checked)
            {
                if (cbxSes.Visible != true)
                {
                    ShowPomodora();
                }
                if (_gecenZaman == _pomodoraSuresi)
                {
                    if (_player == null)
                    {
                        _player = new SoundPlayer(Properties.Resources.Tornado_Siren_II_Delilah_747233690);
                    }
                    _player.PlayLooping();
                    _pomodoraSuresi += TimeSpan.FromSeconds(25);
                    _pomodoraSayac++;
                    MessageBox.Show("25 dakikaya ulaşıldı, 5 dakika mola verin!", "25 Dakika Doldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _player.Stop();                    
                }
                if (_pomodoraSayac % 2 == 0)
                    lblPomodoraSayisi.Text = (_pomodoraSayac / 2).ToString();

            }
            else
            {
                if (cbxSes.Visible != false)
                {
                    cbxSes.Visible = false;
                    label7.Visible = false;
                }
            }
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
                    btnDurdur.BackColor = Color.FromArgb(255, 83, 17);
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
                    btnDurdur.BackColor = Color.FromArgb(85, 85, 85);
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

                if (_gecenZaman == TimeSpan.Zero)
                    lblBaslamaTarihi.Text = _baslangic.ToString();

                molaTimer.Stop();
            }

        }

        private void GetExamDetails()
        {
            TimeSpan toplamSinav = TimeSpan.Zero;
            _calismalar = _studiesService.GetAllStudies().Where(s => s.uye_id == LoginInfo.UyeId).ToList();
            _calisma = _calismalar.Where(e => e.sinav_id == _sinavId).ToList();
            _sinav = _examService.GetExamById(_sinavId);
            examInfo.lblSinavAdi.Text = _sinav.sinav_ad;
            foreach (var cls in _calismalar.Where(s => s.sinav_id == _sinavId))
            {
                toplamSinav += cls.calisilan_zaman;
            }

            examInfo.lblCalisilanToplam.Text = toplamSinav.ToString();

            if ((toplamSinav.TotalMinutes / _calisma.Count) <= 20)
                examInfo.lblCalismaDurum.Text = "Yetersiz";
            else if ((toplamSinav.TotalMinutes / _calisma.Count) <= 40)
                examInfo.lblCalismaDurum.Text = "Yeterli";
            else if ((toplamSinav.TotalMinutes / _calisma.Count) >= 41)
                examInfo.lblCalismaDurum.Text = "Çok iyi";

            DateTime sinavTarihi = _sinav.sinav_tarih;
            _kalangun = Convert.ToInt32((sinavTarihi - DateTime.Now).TotalDays);
            examInfo.lblKalanGun.Text = _kalangun < 0 ? "sınav tarihi geçti" : _kalangun.ToString();
        }

        /// <summary>
        /// GetExamDetails methodundan önce yazılmalı
        /// </summary>
        private void GetLessonDetails()
        {
            TimeSpan toplamDers = TimeSpan.Zero;
            _ders = _lessonService.GetLessonById(_dersId);
            lessonInfo.lblDersAdi.Text = _ders.ders_ad;
            foreach (var drs in _calismalar.Where(s => s.ders_id == _dersId))
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
            if (_gecenZaman <= TimeSpan.FromMinutes(1))
                throw new InsufficientTimeException("Çalışmayı kaydetmek için en az 1 dakika çalışmalısınız!");

            _timer.Stop();
            _timerRunning = false;

            _suankiCalisma = new Calisma
            {
                uye_id = LoginInfo.UyeId,
                sinav_id = _sinavId,
                ders_id = _dersId,
                calisilan_zaman = _gecenZaman,
                calisilan_tarih = DateTime.Now
            };
            _studiesService.AddStudy(_suankiCalisma);

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
            {
                MessageBox.Show("Çalışma başarıyla kaydedildi", "Çalışma Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CheckButtons((Button)sender);
                _userDashboardControl = new UserDashboardControl();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                PageRoute.userDashboardControl = _userDashboardControl;
                PageRoute.userContentPanel.Controls.Clear();
                PageRoute.userContentPanel.Controls.Add(_userDashboardControl);
            }
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
