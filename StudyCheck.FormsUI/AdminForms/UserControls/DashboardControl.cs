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

namespace StudyCheck.FormsUI.AdminForms.UserControls
{
    public partial class DashboardControl : UserControl
    {
        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);

        public DashboardControl()
        {
            InitializeComponent();
        }
        
        private void GetUserCount()
        {
            int sonuc = _userManager.GetAllUsers().Count;
            userWidget.lblWidgetTitle.Text = "Üyeler";
            userWidget.lblWidgetValue.Text = sonuc.ToString();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            GetUserCount();
        }
    }
}
