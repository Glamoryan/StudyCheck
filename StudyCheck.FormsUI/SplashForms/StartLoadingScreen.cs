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

namespace StudyCheck.FormsUI.SplashForms
{
    public partial class StartLoadingScreen : Form
    {
        //Animasyonlar
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, FormAnimates.AnimateWindowFlags flags);
        //--------------------------------------------------------------------------
        public StartLoadingScreen()
        {
            InitializeComponent();
        }

        private void StartLoadingScreen_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 500, FormAnimates.AnimateWindowFlags.AW_BLEND);
        }
    }
}
