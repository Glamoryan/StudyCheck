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

namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl
{
    public partial class StudyPanel : UserControl
    {
        private static examInfoControl _examInfoControl;
        private static lessonInfoControl _lessonInfoControl;
        private static examRows _examRows;

        private static EfExamDal _efExamDal = new EfExamDal();

        private static ExamManager _examManager = new ExamManager(_efExamDal);

        private byte? _durum; // null = Yeni , 1 = Sınav Seçili , 2 = Son dersten devam
        private List<Sinav> _sinavlar;

        public StudyPanel(byte? durum=null)
        {
            InitializeComponent();
            if (durum != null)
                _durum = durum;
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
                    _examRows.lblSinavAdi.Text = exam.sinav_ad;
                    pnlSinavContent.Controls.Add(_examRows);
                    i++;
                }
                pnlSinavContent.AutoScroll = false;
                pnlSinavContent.HorizontalScroll.Enabled = false;
                pnlSinavContent.HorizontalScroll.Visible = false;
                pnlSinavContent.HorizontalScroll.Maximum = 0;
                pnlSinavContent.AutoScroll = true;
            }
        }

        private void StudyPanel_Load(object sender, EventArgs e)
        {
            GetExamInfoControl();
            GetLessonInfoControl();
            GetExamDetails();
        }
    }
}
