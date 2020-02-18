using StudyCheck.Core.Aspects.Postsharp.CacheAspects;
using StudyCheck.Core.CrossCuttingConcerns.Caching.Microsoft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.AdminForms
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private void pcbExit_MouseEnter(object sender, EventArgs e)
        {
            pcbExit.Cursor = Cursors.Hand;
        }

        [CacheApplicationExitAspect(typeof(MemoryCacheManager))]
        private void pcbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pcbMinimize.Cursor = Cursors.Hand;
        }

        private void pcbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
