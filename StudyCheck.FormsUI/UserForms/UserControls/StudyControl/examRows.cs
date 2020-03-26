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
    public partial class examRows : UserControl
    {
        public examRows()
        {
            InitializeComponent();
        }

        private void btnSinav_Click(object sender, EventArgs e)
        {            
            PageRoute.studyPanel.WhichExam((Button)sender);
            PageRoute.studyPanel.GetLessonDetails(Convert.ToInt32(lblSinavId.Text));
            PageRoute.studyPanel.GetExamInfo(Convert.ToInt32(lblSinavId.Text));
        }
    }
}
