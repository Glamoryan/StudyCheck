using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Entites.AccountManagement;

namespace StudyCheck.FormsUI.AdminForms.UserControls
{
    public partial class DashboardControl : UserControl
    {
        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static EfExamDal _efExamDal = new EfExamDal();
        private static EfLessonDal _efLessonDal = new EfLessonDal();
        private static EfThemeDal _efThemeDal = new EfThemeDal();
        private static EfRolDal _efRolDal = new EfRolDal();

        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);
        private static ExamManager _examManager = new ExamManager(_efExamDal);
        private static LessonManager _lessonManager = new LessonManager(_efLessonDal);
        private static ThemeManager _themeManager = new ThemeManager(_efThemeDal);
        private static RoleManager _roleManager = new RoleManager(_efRolDal);

        public DashboardControl()
        {
            InitializeComponent();
        }

        private void GetLessonDetails()
        {
            int sonuc = _lessonManager.GetAllLessons().Count;
            lessonWidget.lblWidgetTitle.Text = "Dersler";
            lessonWidget.lblWidgetValue.Text = sonuc.ToString();
            lessonWidget.pcbWidgetIcon.Image = Properties.Resources.icons8_test_passed_32;
        }

        private void GetExamDetails()
        {
            int sonuc = _examManager.GetAllExams().Count;
            examWidget.lblWidgetTitle.Text = "Sınavlar";
            examWidget.lblWidgetValue.Text = sonuc.ToString();
            examWidget.pcbWidgetIcon.Image = Properties.Resources.icons8_exam_32;
        }

        private void GetAdminDetails()
        {
            int sonuc = _userManager.GetAllAdmins((int)RoleInfo.Roller.Admin).Count;
            adminWidget.lblWidgetTitle.Text = "Adminler";
            adminWidget.lblWidgetValue.Text = sonuc.ToString();
            adminWidget.pcbWidgetIcon.Image = Properties.Resources.admin;
        }
        
        private void GetAccountDetails()
        {
            int sonuc = _userManager.GetAllUserDetails().Count;
            accountWidget.lblWidgetTitle.Text = "Kullanıcılar";
            accountWidget.lblWidgetValue.Text = sonuc.ToString();
            accountWidget.pcbWidgetIcon.Image = Properties.Resources.user_groups_32px;
        }        
        private void DashboardControl_Load(object sender, EventArgs e)
        {            
            GetAccountDetails();
            GetAdminDetails();
            GetExamDetails();
            GetThemeDetails();
            GetLessonDetails();
            GetRoleDetails();
        }

        private void GetRoleDetails()
        {
            int sonuc = _roleManager.GetAllRoles().Count;
            rolWidget.lblWidgetTitle.Text = "Roller";
            rolWidget.lblWidgetValue.Text = sonuc.ToString();
            rolWidget.pcbWidgetIcon.Image = Properties.Resources.checked_user_male_32px;
        }

        private void GetThemeDetails()
        {
            int sonuc = _themeManager.GetAllThemes().Count;
            themeWidget.lblWidgetTitle.Text = "Temalar";
            themeWidget.lblWidgetValue.Text = sonuc.ToString();
            themeWidget.pcbWidgetIcon.Image = Properties.Resources.icons8_paint_palette_32;
        }
    }
}
