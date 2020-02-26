using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.UserControls.UserSettings
{
    public partial class UserSettingsGrid : UserControl
    {
        private static UserSettingsButtons _settingsButtons;
        private static UserSettingsColumns _settingsColumns;
        private  UserSettingsContent _settingsContent;

        private Panel _contentPanel;
        public UserSettingsGrid(Panel contentPanel)
        {
            _contentPanel = contentPanel;
            InitializeComponent();
            panel1.Controls.Clear();
        }

        private void GetColumns()
        {
            if (_settingsColumns == null)
                _settingsColumns = new UserSettingsColumns();
            if (!userColumnsPanel.Controls.ContainsKey("UserSettingsColumns"))
            {
                userColumnsPanel.Controls.Clear();
                userColumnsPanel.Controls.Add(_settingsColumns);
            }
        }

        private void GetButtons()
        {
            if(_settingsButtons==null)
                _settingsButtons = new UserSettingsButtons(_contentPanel);

            if (!panel1.Controls.ContainsKey("UserSettingsButtons"))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(_settingsButtons);
            }
        }

        private void GetUsersContent()
        {
//            if (_settingsContent == null)
                

            if (!usersPanel.Controls.ContainsKey("UserSettingsContent"))
            {
                usersPanel.Controls.Clear();
                for (int i = 0; i <= 30; i++)
                {
                    _settingsContent = new UserSettingsContent(_contentPanel);
                    _settingsContent.textBox1.Text = i.ToString();
                    _settingsContent.textBox2.Text = "User" + i;
                    _settingsContent.textBox3.Text = "Usersname" + i;
                    _settingsContent.textBox4.Text = "Usermail" + i;
                    _settingsContent.textBox5.Text = "Date" + i;
                    _settingsContent.textBox6.Text = "Udate" + i;                    
                    _settingsContent.Top = (i * 30);
                    usersPanel.Controls.Add(_settingsContent);
                }
                
            }
        }

        private void UserSettingsGrid_Load(object sender, EventArgs e)
        {
            usersPanel.HorizontalScroll.Enabled = false;
            usersPanel.HorizontalScroll.Visible = false;
            usersPanel.HorizontalScroll.Maximum = 0;
            usersPanel.AutoScroll = true;
            GetButtons();
            GetColumns();
            GetUsersContent();
        }
    }
}
