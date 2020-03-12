using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.Entites.Concrete;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.FormsUI.ExceptionManage;
using StudyCheck.FormsUI.Statikler;

namespace StudyCheck.FormsUI.AdminForms.UserControls.ExamControl
{
    public partial class ExamControl : UserControl
    {
        public ExamControl()
        {
            InitializeComponent();
        }
        private static Exception mainException;

        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static EfExamDal _efExamDal = new EfExamDal();

        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);
        private static ExamManager _examManager = new ExamManager(_efExamDal);

        private static SinavEkleControl _sinavEkleControl;
        private static ExamRowsControl _examRowsControl;
        public static List<Sinav> _sinavlar;
        public static List<Uyedetay> _uyeler;

        private void GetExamsAndUsers()
        {
            _sinavlar = _examManager.GetAllExams();
            _uyeler = _userManager.GetAllUyeDetay();
        }

        private void GetExamDetails()
        {
            GetExamsAndUsers();
            if (!pnlExamContent.Controls.ContainsKey("ExamRowsControl"))
            {
                int i = 0;
                foreach (var exam in _sinavlar)
                {
                    _examRowsControl = new ExamRowsControl();
                    _examRowsControl.Top = (i * 40);
                    _examRowsControl.lblSinavId.Text = exam.id.ToString();
                    _examRowsControl.lblSinavAd.Text = exam.sinav_ad;
                    _examRowsControl.lblSinavTarihi.Text = exam.sinav_tarih.ToString("dd/MM/yyyy");
                    _examRowsControl.lblKayitTarihi.Text = exam.eklenme_tarihi.ToString();
                    _examRowsControl.lblEkleyen.Text = _uyeler.Where(x => x.uye_id == exam.ekleyen_id).Single().kullanici_adi;
                    switch (exam.sil_id)
                    {
                        case 0:
                            _examRowsControl.lblDurum.Text = "Pasif";
                            _examRowsControl.lblDurum.ForeColor = Color.Red;
                            break;
                        case 1:
                            _examRowsControl.lblDurum.Text = "Aktif";
                            _examRowsControl.lblDurum.ForeColor = Color.Green;
                            break;
                    }
                    pnlExamContent.Controls.Add(_examRowsControl);
                    i++;
                }
            }
        }

        private void ExamControl_Load(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => GetExamDetails());
            if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSinavEkle_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            _sinavEkleControl = new SinavEkleControl();
            PageRoute.contentPanel.Controls.Add(_sinavEkleControl);
        }
    }
}
