using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.UserControls.ExamSettings
{
    public partial class ExamSettingsGrid : UserControl
    {
        private static ExamSettingsButtons _settingsButtons;
        private static ExamSettingsColumns _settingsColumns;
        private static ExamSettingsContent _settingsContent;
        private static Panel _contentPanel;
        public ExamSettingsGrid(Panel contentPanel)
        {
            _contentPanel = contentPanel;
            InitializeComponent();
            panel1.Controls.Clear();
        }

        private void GetExamButtons()
        {
            if (_settingsButtons == null)
                _settingsButtons = new ExamSettingsButtons(_contentPanel);

            if (!panel1.Controls.ContainsKey("ExamSettingsButtons"))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(_settingsButtons);
            }
        }

        private void GetExamContent()
        {            
            if (!examsPanel.Controls.ContainsKey("ExamSettingsContent"))
            {
                examsPanel.Controls.Clear();
                for (int i = 0; i < 2; i++)
                {
                    _settingsContent = new ExamSettingsContent(_contentPanel);
                    _settingsContent.Top = i * 30;
                    _settingsContent.textBox1.Text = i.ToString();
                    _settingsContent.textBox2.Text = "ExamName" + i;
                    _settingsContent.textBox3.Text = "ExamDate" + i;
                    _settingsContent.textBox4.Text = "ExamCreDate" + i;
                    _settingsContent.textBox5.Text = "ExamUdate" + i;
                    examsPanel.Controls.Add(_settingsContent);
                }
                
                
            }
        }

        private void GetExamColumns()
        {
            if (_settingsColumns == null)
                _settingsColumns = new ExamSettingsColumns();

            if (!examColumnsPanel.Controls.ContainsKey("ExamSettingsColumns"))
            {
                examColumnsPanel.Controls.Clear();
                examColumnsPanel.Controls.Add(_settingsColumns);
            }
        }

        private void ExamSettingsGrid_Load(object sender, EventArgs e)
        {
            GetExamButtons();
            GetExamColumns();
            GetExamContent();
        }
    }
}
