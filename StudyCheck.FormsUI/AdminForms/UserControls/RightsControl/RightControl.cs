using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.Entites.Concrete;
using StudyCheck.FormsUI.ExceptionManage;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;

namespace StudyCheck.FormsUI.AdminForms.UserControls.RightsControl
{
    public partial class RightControl : UserControl
    {
        private Exception mainException;

        private IUserService _userService;
        private IRightService _rightService;

        private YetkiEkleControl _yetkiEkleControl;
        private RightRowsControl _rightRowsControl;
        public static List<Uyedetay> _uyeler;
        public static List<Yetki> _yetkiler;

        public RightControl()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _rightService = InstanceFactory.GetInstance<IRightService>();
        }        

        private void GetUsersAndRights()
        {
            _uyeler = _userService.GetAllUyeDetay();
            _yetkiler = _rightService.GetAllRights();
        }

        private void GetRightDetails()
        {
            GetUsersAndRights();
            if (!pnlRightContent.Controls.ContainsKey("RightRowsControl"))
            {
                int i = 0;
                foreach (var yetki in _yetkiler)
                {
                    _rightRowsControl = new RightRowsControl();
                    _rightRowsControl.Top = (i * 40);
                    if (yetki.id == 1 || yetki.id == 2)
                        _rightRowsControl.lblYetkiAd.ForeColor = Color.FromArgb(255, 83, 17);
                    _rightRowsControl.lblYetkiId.Text = yetki.id.ToString();
                    _rightRowsControl.lblYetkiAd.Text = yetki.yetki_adi;
                    _rightRowsControl.lblTarih.Text = yetki.eklenme_tarihi.ToString();
                    switch (yetki.sil_id)
                    {
                        case 0:
                            _rightRowsControl.lblDurum.Text = "Pasif";
                            _rightRowsControl.lblDurum.ForeColor = Color.Red;
                            break;
                        case 1:
                            _rightRowsControl.lblDurum.Text = "Aktif";
                            _rightRowsControl.lblDurum.ForeColor = Color.Green;
                            break;
                    }
                    _rightRowsControl.lblEkleyen.Text = _uyeler.Where(x => x.id == yetki.ekleyen_id).Single().kullanici_adi;
                    pnlRightContent.Controls.Add(_rightRowsControl);
                    i++;
                }
            }
        }

        private void RightControl_Load(object sender, EventArgs e)
        {
            mainException = ExceptionHandling.HandleException(() => GetRightDetails());
            if (mainException != null)
                MessageBox.Show(mainException.Message, "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnYetkiEkle_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            _yetkiEkleControl = new YetkiEkleControl();
            PageRoute.contentPanel.Controls.Add(_yetkiEkleControl);
        }
    }
}
