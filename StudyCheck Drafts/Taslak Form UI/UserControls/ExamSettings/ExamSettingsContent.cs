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
    public partial class ExamSettingsContent : UserControl
    {
        private static ExamManageGrid _manageGrid;
        private static Panel _contentPanel;
        public ExamSettingsContent(Panel contentPanel)
        {
            _contentPanel = contentPanel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_manageGrid == null)
                _manageGrid = new ExamManageGrid();

            if (!_contentPanel.Controls.ContainsKey("ExamManageGrid"))
            {
                _contentPanel.Controls.Clear();
                _manageGrid.textBox1.Text = textBox1.Text;
                _manageGrid.textBox2.Text = textBox2.Text;
                _manageGrid.textBox3.Text = textBox3.Text;
                _manageGrid.textBox7.Text = textBox4.Text;
                _contentPanel.Controls.Add(_manageGrid);
            }
        }
    }
}
