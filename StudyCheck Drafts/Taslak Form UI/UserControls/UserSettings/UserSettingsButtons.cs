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
    public partial class UserSettingsButtons : UserControl
    {
        private UserAddGrid _addGrid;
        private Panel _contentPanel;

        public UserSettingsButtons(Panel contentPanel)
        {
            _contentPanel = contentPanel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_addGrid == null)
                _addGrid = new UserAddGrid();

            if (!_contentPanel.Controls.ContainsKey("UserAddGrid"))
            {
                _contentPanel.Controls.Clear();
                _contentPanel.Controls.Add(_addGrid);
            }
        }
    }
}
