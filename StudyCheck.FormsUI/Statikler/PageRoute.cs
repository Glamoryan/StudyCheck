using StudyCheck.FormsUI.AdminForms.UserControls;
using StudyCheck.FormsUI.AdminForms.UserControls.LessonsControl;
using StudyCheck.FormsUI.AdminForms.UserControls.RightsControl;
using StudyCheck.FormsUI.AdminForms.UserControls.RolesControl;
using StudyCheck.FormsUI.AdminForms.UserControls.UsersAccountsControl;
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
        public static Panel contentPanel { get; set; }
        public static AccountsControl accountsControl { get; set; }
        public static DashboardControl dashboardControl { get; set; }
        public static RoleControl roleControl { get; set; }
        public static RightControl rightControl { get; set; }
        public static LessonControl lessonControl { get; set; }
    }
}
