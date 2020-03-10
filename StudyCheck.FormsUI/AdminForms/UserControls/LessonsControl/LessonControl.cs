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

namespace StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl
{
    public partial class LessonControl : UserControl
    {
        public LessonControl()
        {
            InitializeComponent();
        }

        private static Exception mainException;

        private static EfLessonDal _efLessonDal = new EfLessonDal();
        private static EfExamDal _efExamDal = new EfExamDal();
        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();

        private static LessonManager _lessonManager = new LessonManager(_efLessonDal);
        private static ExamManager _examManager = new ExamManager(_efExamDal);
        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);

        private static LessonRowsControl _lessonRowsControl;
        private static DersEkleControl _dersEkleControl;
        public static List<Ders> _dersler;
        public static List<Sinav> _sinavlar;
        public static List<Uyedetay> _uyeler;

        private void LessonControl_Load(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => GetLessonDetails());
            if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GetLessonsAndExamsAndUsers()
        {
            _dersler = _lessonManager.GetAllLessons();
            _sinavlar = _examManager.GetAllExams();
            _uyeler = _userManager.GetAllUyeDetay();
        }

        private void GetLessonDetails()
        {
            GetLessonsAndExamsAndUsers();
            if (!pnlLessonContent.Controls.ContainsKey("LessonRowsControl"))
            {
                int i = 0;
                foreach (var lesson in _dersler)
                {
                    _lessonRowsControl = new LessonRowsControl();
                    _lessonRowsControl.Top = (i * 40);
                    _lessonRowsControl.lblDersId.Text = lesson.id.ToString();
                    _lessonRowsControl.lblDersAd.Text = lesson.ders_ad;
                    _lessonRowsControl.lblTarih.Text = lesson.eklenme_tarihi.ToString();
                    switch (lesson.sil_id)
                    {
                        case 0:
                            _lessonRowsControl.lblDurum.Text = "Pasif";
                            _lessonRowsControl.lblDurum.ForeColor = Color.Red;
                            break;
                        case 1:
                            _lessonRowsControl.lblDurum.Text = "Aktif";
                            _lessonRowsControl.lblDurum.ForeColor = Color.Green;
                            break;
                    }
                    _lessonRowsControl.lblEkleyen.Text = _uyeler.Where(x => x.id == lesson.ekleyen_id).Single().kullanici_adi;
                    _lessonRowsControl.lblSinavi.Text = _sinavlar.Where(x => x.id == lesson.sinav_id).Single().sinav_ad;
                    pnlLessonContent.Controls.Add(_lessonRowsControl);
                    i++;
                }
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            _dersEkleControl = new DersEkleControl();
            PageRoute.contentPanel.Controls.Add(_dersEkleControl);
        }
    }
}
