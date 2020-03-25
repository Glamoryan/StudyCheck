using StudyCheck.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.UserForms
{
    public partial class frmUserPanel : Form
    {
        //Animasyonlar
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, FormAnimates.AnimateWindowFlags flags);
        //--------------------------------------------------------------------------

        public frmUserPanel()
        {
            InitializeComponent();
        }

        private void frmUserPanel_Load(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false; ----------- Thread Çakışmalarına izin ver
            AnimateWindow(this.Handle, 500, FormAnimates.AnimateWindowFlags.AW_BLEND);
            lblTarih.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
    }
}
