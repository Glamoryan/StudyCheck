using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl.StudyStartControl
{
    public partial class studyControl : UserControl
    {
        private Timer _timer;
        private DateTime _baslangic = DateTime.MinValue;
        private TimeSpan _gecenZaman = TimeSpan.Zero;
        private TimeSpan _toplamZaman = TimeSpan.Zero;

        private bool _timerRunning = false;
        public studyControl()
        {
            InitializeComponent();

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

        private void button1_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _timerRunning = false;
            _toplamZaman = TimeSpan.Zero;
            _gecenZaman = TimeSpan.Zero;
        }
    }
}
