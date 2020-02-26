using StudyCheck.FormsUI.Properties;
using StudyCheck.FormsUI.UserControls.Dashboard;
using StudyCheck.FormsUI.UserControls.ExamSettings;
using StudyCheck.FormsUI.UserControls.LessonSettings;
using StudyCheck.FormsUI.UserControls.Role_Settings;
using StudyCheck.FormsUI.UserControls.ThemeSettings;
using StudyCheck.FormsUI.UserControls.UserSettings;
using StudyCheck.FormsUI.UserControls.UserSettings.UserManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI
{
    public partial class AdminForm : Form
    {
        private static DashboardGrid _dashboardGrid;
        private static UserSettingsGrid _userSettingsGrid;
        private static ExamSettingsGrid _examSettingsGrid;
        private static LessonSettingsGrid _lessonSettingsGrid;
        private static RoleSettingsGrid _roleSettingsGrid;
        private static ThemeSettingsGrid _themeSettingsGrid;        

        public AdminForm()
        {
            InitializeComponent();
            contentPanel.Controls.Clear();           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            GetDashboard();
        }

        private void GetDashboard()
        {
            if(_dashboardGrid==null)
                _dashboardGrid = new DashboardGrid();

            if (!contentPanel.Controls.ContainsKey("DashboardGrid"))
            {
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(_dashboardGrid);
            }                
        }        
        
        private void GetUserSettings()
        {            
            if (_userSettingsGrid == null)
                _userSettingsGrid = new UserSettingsGrid(contentPanel);

            if (!contentPanel.Controls.ContainsKey("UserSettingsGrid"))
            {
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(_userSettingsGrid);
            }                
        }

        private void GetExamSettings()
        {
            if (_examSettingsGrid == null)
                _examSettingsGrid = new ExamSettingsGrid(contentPanel);

            if (!contentPanel.Controls.ContainsKey("ExamSettingsGrid"))
            {
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(_examSettingsGrid);
            }
        }

        private void GetLessonSettings()
        {
            if (_lessonSettingsGrid == null)
                _lessonSettingsGrid = new LessonSettingsGrid(contentPanel);

            if (!contentPanel.Controls.ContainsKey("LessonSettingsGrid"))
            {
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(_lessonSettingsGrid);
            }
        }

        private void GetRoleSettings()
        {
            if (_roleSettingsGrid == null)
                _roleSettingsGrid = new RoleSettingsGrid();

            if (!contentPanel.Controls.ContainsKey("RoleSettingsGrid"))
            {
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(_roleSettingsGrid);
            }
        }

        private void GetThemeSettings()
        {
            if (_themeSettingsGrid == null)
                _themeSettingsGrid = new ThemeSettingsGrid();

            if (!contentPanel.Controls.ContainsKey("ThemeSettingsGrid"))
            {
                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(_themeSettingsGrid);
            }
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            GetDashboard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetUserSettings();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetExamSettings();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetLessonSettings();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetRoleSettings();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetThemeSettings();
        }
    }
}
