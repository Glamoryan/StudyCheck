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
    public partial class lessonRows : UserControl
    {
        public lessonRows()
        {
            InitializeComponent();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            PageRoute.studyPanel.WhichLesson((Button)sender);
            PageRoute.studyPanel.GetLessonInfo(Convert.ToInt32(lblDersId.Text));
        }
    }
}
