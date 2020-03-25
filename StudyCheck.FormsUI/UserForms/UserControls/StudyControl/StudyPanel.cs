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

namespace StudyCheck.FormsUI.UserForms.UserControls.StudyControl
{
    public partial class StudyPanel : UserControl
    {
        private static examInfoControl _examInfoControl;
        private static lessonInfoControl _lessonInfoControl;

        private byte? _durum; // null = Yeni , 1 = Sınav Seçili , 2 = Son dersten devam

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

        }

        private void StudyPanel_Load(object sender, EventArgs e)
        {
            GetExamInfoControl();
            GetLessonInfoControl();
        }
    }
}
