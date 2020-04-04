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
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;

namespace StudyCheck.FormsUI.AdminForms.UserControls
{
    public partial class DashboardControl : UserControl
    {
        private IUserService _userService;
        private IExamService _examService;
        private ILessonService _lessonService;
        private IThemeService _themeService;
        private IRoleService _roleService;
        private IRightService _rightService;       

        public DashboardControl()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _examService = InstanceFactory.GetInstance<IExamService>();
            _lessonService = InstanceFactory.GetInstance<ILessonService>();
            _themeService = InstanceFactory.GetInstance<IThemeService>();
            _roleService = InstanceFactory.GetInstance<IRoleService>();
            _rightService = InstanceFactory.GetInstance<IRightService>();
        }

        private void GetLessonDetails()
        {            
            int sonuc = _lessonService.GetAllLessons().Count;
            lessonWidget.lblWidgetTitle.Text = "Dersler";
            lessonWidget.lblWidgetValue.Text = sonuc.ToString();
            lessonWidget.pcbWidgetIcon.Image = Properties.Resources.icons8_test_passed_32;
        }

        private void GetExamDetails()
        {
            int sonuc = _examService.GetAllExams().Count;
            examWidget.lblWidgetTitle.Text = "Sınavlar";
            examWidget.lblWidgetValue.Text = sonuc.ToString();
            examWidget.pcbWidgetIcon.Image = Properties.Resources.icons8_exam_32;
        }

        private void GetAdminDetails()
        {
            var roller = _roleService.GetAllRoles();            
            int sonuc=0;
            foreach (var dd in roller.Where(r=>r.yetki_id == 2).ToList())
            {                
                sonuc += _userService.GetAllUyeDetay().Where(x => x.rol_id == dd.id).Count();
            }
            adminWidget.lblWidgetTitle.Text = "Adminler";
            adminWidget.lblWidgetValue.Text = sonuc.ToString();
            adminWidget.pcbWidgetIcon.Image = Properties.Resources.admin;
        }

        private void GetRightDetails()
        {
            int sonuc = _rightService.GetAllRights().Count;
            yetkiWidget.lblWidgetTitle.Text = "Yetkiler";
            yetkiWidget.lblWidgetValue.Text = sonuc.ToString();
            yetkiWidget.pcbWidgetIcon.Image = Properties.Resources.security_lock_32px;
        }
        
        private void GetAccountDetails()
        {
            int sonuc = _userService.GetAllUserDetails().Count;
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
            GetRightDetails();
        }

        private void GetRoleDetails()
        {
            int sonuc = _roleService.GetAllRoles().Count;
            rolWidget.lblWidgetTitle.Text = "Roller";
            rolWidget.lblWidgetValue.Text = sonuc.ToString();
            rolWidget.pcbWidgetIcon.Image = Properties.Resources.checked_user_male_32px;
        }

        private void GetThemeDetails()
        {
            int sonuc = _themeService.GetAllThemes().Count;
            themeWidget.lblWidgetTitle.Text = "Temalar";
            themeWidget.lblWidgetValue.Text = sonuc.ToString();
            themeWidget.pcbWidgetIcon.Image = Properties.Resources.icons8_paint_palette_32;
        }
    }
}
