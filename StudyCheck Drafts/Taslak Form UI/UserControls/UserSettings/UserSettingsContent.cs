using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.FormsUI;
using StudyCheck.FormsUI.UserControls.UserSettings.UserManage;

namespace StudyCheck.FormsUI.UserControls.UserSettings
{
    public partial class UserSettingsContent : UserControl
    {
        private static UserManageGrid _userManageGrid;
        private Panel _contentPanel;

        public UserSettingsContent(Panel contentPanel)
        {
            _contentPanel = contentPanel;
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            if (_userManageGrid == null)
                _userManageGrid = new UserManageGrid();

            if (!_contentPanel.Controls.ContainsKey("UserManagedGrid"))
            {
                _contentPanel.Controls.Clear();
                _userManageGrid.textBox1.Text = textBox1.Text;
                _userManageGrid.textBox2.Text = textBox2.Text;
                _userManageGrid.textBox3.Text = textBox3.Text;
                _userManageGrid.textBox4.Text = textBox4.Text;
                _userManageGrid.textBox7.Text = textBox5.Text;
                _contentPanel.Controls.Add(_userManageGrid);
            }
        }
    }
   
}
