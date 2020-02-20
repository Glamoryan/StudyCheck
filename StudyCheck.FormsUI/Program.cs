using Microsoft.VisualBasic.ApplicationServices;
using StudyCheck.FormsUI.AdminForms;
using StudyCheck.FormsUI.SplashForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI
{
    static class Program
    {
        static Form SplashScreen;
        static Form MainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //-----------------------
            SplashScreen = new StartLoadingScreen();
            var splashThread = new Thread(new ThreadStart(() => Application.Run(SplashScreen)));
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

            MainForm = new frmLogin();            
            MainForm.Load += MainForm_LoadCompleted;            
            Application.Run(MainForm);

        }

        private static void MainForm_LoadCompleted(object sender,EventArgs e)
        {
            if (SplashScreen != null && !SplashScreen.Disposing && !SplashScreen.IsDisposed)
                SplashScreen.Invoke(new Action(() => SplashScreen.Close()));
            MainForm.TopMost = true;
            MainForm.Activate();
            MainForm.TopMost = false;
        }
    }
}
