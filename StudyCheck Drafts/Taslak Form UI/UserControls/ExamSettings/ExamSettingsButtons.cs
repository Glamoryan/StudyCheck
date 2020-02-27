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
    public partial class ExamSettingsButtons : UserControl
    {
        private static ExamAddGrid _addGrid;
        private static Panel _contentPanel;
        public ExamSettingsButtons(Panel contentPanel)
        {
            _contentPanel = contentPanel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_addGrid == null)
                _addGrid = new ExamAddGrid();
            if (!_contentPanel.Controls.ContainsKey("ExamAddGrid"))
            {
                _contentPanel.Controls.Clear();
                _contentPanel.Controls.Add(_addGrid);
            }
        }
    }
}
