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

namespace StudyCheck.FormsUI.AdminForms.UserControls.RightsControl
{
    public partial class RightRowsControl : UserControl
    {
        public RightRowsControl()
        {
            InitializeComponent();
        }

        private void YetkiAyarlarinaGit()
        {
            var uyeler = RightControl._uyeler;
            var yetkiler = RightControl._yetkiler;
            PageRoute.contentPanel.Controls.Clear();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

        }
    }
}
