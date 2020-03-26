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
        
        private void lblSinavAdi_Click(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            PageRoute.studyPanel.GetLessonDetails(Convert.ToInt32(lblSinavId.Text));
        }
    }
}
