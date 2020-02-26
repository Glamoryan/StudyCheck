using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCheck.FormsUI.UserControls.Dashboard
{
    public partial class DashboardGrid : UserControl
    {        
        private static DashboardWidgets _dashboardWidgets;
        public DashboardGrid()
        {
            InitializeComponent();            
            panel1.Controls.Clear();            
        }
        
        private void GetDashboardWidgets()
        {
            if (_dashboardWidgets == null)
                _dashboardWidgets = new DashboardWidgets();

            if (!panel1.Controls.ContainsKey("DashboardWidgets"))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(_dashboardWidgets);
            }
            



        }

        private void DashboardGrid_Load(object sender, EventArgs e)
        {
            GetDashboardWidgets();
        }
    }
}
