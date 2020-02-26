using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.UserControls.LessonSettings
{
    public partial class LessonSettingsGrid : UserControl
    {
        private static LessonSettingsButtons _settingsButtons;
        private static LessonSettingsColumns _settingsColumns;
        private static LessonSettingsContent _settingsContent;
        private static Panel _contentPanel;
        public LessonSettingsGrid(Panel contentPanel)
        {
            _contentPanel = contentPanel;
            InitializeComponent();
            panel1.Controls.Clear();
        }

        private void GetLessonContent()
        {
            if (!lessonContentPanel.Controls.ContainsKey("LessonSettingsContent"))
            {
                lessonContentPanel.Controls.Clear();
                for (int i = 0; i < 3; i++)
                {
                    _settingsContent = new LessonSettingsContent(_contentPanel);
                    _settingsContent.Top = i * 30;
                    _settingsContent.textBox1.Text = i.ToString();
                    _settingsContent.textBox2.Text = "LessonName" + i;
                    _settingsContent.textBox3.Text = "RExam" + i;
                    _settingsContent.textBox4.Text = "CreDate" + i;
                    _settingsContent.textBox5.Text = "UpDate" + i;
                    lessonContentPanel.Controls.Add(_settingsContent);
                }
            }
        }

        private void GetLessonColumns()
        {
            if (_settingsColumns == null)
                _settingsColumns = new LessonSettingsColumns();

            if (!lessonsColumnsPanel.Controls.ContainsKey("LessonSettingsColumns"))
            {
                lessonsColumnsPanel.Controls.Clear();
                lessonsColumnsPanel.Controls.Add(_settingsColumns);
            }
        }

        private void GetLessonButtons()
        {
            if (_settingsButtons == null)
                _settingsButtons = new LessonSettingsButtons(_contentPanel);

            if (!panel1.Controls.ContainsKey("LessonSettingsButtons"))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(_settingsButtons);
            }
        }

        private void LessonSettingsGrid_Load(object sender, EventArgs e)
        {
            GetLessonButtons();
            GetLessonColumns();
            GetLessonContent();
        }
    }
}
