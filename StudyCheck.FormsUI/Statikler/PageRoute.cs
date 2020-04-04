using StudyCheck.FormsUI.AdminForms.UserControls;
using StudyCheck.FormsUI.AdminForms.UserControls.ExamControl;
using StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl;
using StudyCheck.FormsUI.AdminForms.UserControls.RightsControl;
using StudyCheck.FormsUI.AdminForms.UserControls.RolesControl;
using StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl;
using StudyCheck.FormsUI.UserForms.UserControls;
using StudyCheck.FormsUI.UserForms.UserControls.StudyControl;
using StudyCheck.FormsUI.UserForms.UserControls.StudyControl.StudyStartControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.Statikler
{
    public static class PageRoute
    {
        // Admin Controls
        public static Panel contentPanel { get; set; }
        public static AccountsControl accountsControl { get; set; }
        public static DashboardControl dashboardControl { get; set; }
        public static RoleControl roleControl { get; set; }
        public static RightControl rightControl { get; set; }
        public static LessonControl lessonControl { get; set; }
        public static ExamControl examControl { get; set; }
        //-----------------------------------------------------------

        // User Controls
        public static Panel userContentPanel { get; set; }
        public static UserDashboardControl userDashboardControl { get; set; }
        public static StudyPanel studyPanel { get; set; }
        public static examInfoControl examInfoControl { get; set; }
        public static lessonInfoControl lessonInfoControl { get; set; }
        public static studyControl studyControl { get; set; }
        //-------------------------------------------------------------

        public static void RefreshAllDataControls()
        {
            accountsControl = new AccountsControl();
            dashboardControl = new DashboardControl();
            lessonControl = new LessonControl();
            examControl = new ExamControl();
            roleControl = new RoleControl();
            rightControl = new RightControl();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }        
    }
}
