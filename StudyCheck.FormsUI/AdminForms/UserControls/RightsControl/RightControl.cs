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

namespace StudyCheck.FormsUI.AdminForms.UserControls.RightsControl
{
    public partial class RightControl : UserControl
    {
        public RightControl()
        {
            InitializeComponent();
        }

        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static EfRightDal _efRightDal = new EfRightDal();

        private static UserManager _userManager = new UserManager(_efUserDal, _efUserDetailDal);
        private static RightManager _rightManager = new RightManager(_efRightDal);

        private static YetkiEkleControl _yetkiEkleControl;
        private static RightRowsControl _rightRowsControl;
        public static List<Uyedetay> _uyeler;
        public static List<Yetki> _yetkiler;

        private static Exception mainException;

        private void GetUsersAndRights()
        {
            _uyeler = _userManager.GetAllUyeDetay();
            _yetkiler = _rightManager.GetAllRights();
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
