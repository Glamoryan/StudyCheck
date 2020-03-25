using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCheck.FormsUI.ExceptionManage.CustomExceptions;
using StudyCheck.Entites.Concrete;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.FormsUI.ExceptionManage;
using FluentValidation;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.Entites.AccountManagement;

namespace StudyCheck.FormsUI.AdminForms.UserControls.RolesControl
{
    public partial class RoleSettingsControl : UserControl
    {
        public RoleSettingsControl()
        {
            InitializeComponent();
        }
        private static Exception mainException;

        private static EfUserDal _efUserDal = new EfUserDal();
        private static EfUserDetailDal _efUserDetailDal = new EfUserDetailDal();
        private static EfRolDal _efRolDal = new EfRolDal();
        private static EfRightDal _efRightDal = new EfRightDal();

        private static RoleManager _roleManager = new RoleManager(_efRolDal);
        private static UserManager _userManager = new UserManager(_efUserDal,_efUserDetailDal);
        private static RightManager _rightManager = new RightManager(_efRightDal);

        private static Rol _rol;
        private static List<Uyedetay> _uyeler;        

        private void CheckFields()
        {
            if (tbxRolAdi.Text.Equals(string.Empty))
                throw new RequiredFieldsException("Rol adı boş bırakılamaz!");            
        }

        private void GetUsers()
        {
            _uyeler = _userManager.GetAllUyeDetay();            
        }
       
        private void CheckIfRoleBase()
        {
            if(tbxRolId.Text.Equals("1") || tbxRolId.Text.Equals("2"))
            {
                label7.Visible = false;
                label9.Visible = false;
                cbxDurum.Visible = false;
                cbxYetki.Visible = false;
            }
        }

        private void RolGuncelle()
        {
            CheckFields();
            GetUsers();
            _rol = new Rol
            {
                id = Convert.ToInt32(tbxRolId.Text),
                rol_adi = tbxRolAdi.Text,
                rol_guncelleme_tarihi = DateTime.Now,
                rol_kayit_tarihi = Convert.ToDateTime(tbxRolKayit.Text),
                sil_id = cbxDurum.SelectedIndex,
                yetki_id = Convert.ToInt32(cbxYetki.SelectedValue),
                ekleyen_id = _uyeler.Where(x => x.kullanici_adi == tbxEkleyen.Text).Single().id,
                guncelleyen_id = LoginInfo.Id
            };            
            CheckIfRoleUsing();
            _roleManager.UpdateRole(_rol);
        }

        private void SetDefault()//ilk halleri
        {            
            RoleSettingsInfos.rolAdi = tbxRolAdi.Text;
            RoleSettingsInfos.silId = cbxDurum.SelectedIndex;
            RoleSettingsInfos.yetkiId = Convert.ToInt32(cbxYetki.SelectedValue);
        }

        private bool CheckEdited()
        {
            if (btnRolCancel.Visible || btnRolSuccess.Visible)
                return false;
            return true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (CheckEdited())
            {
                mainException = ExceptionHandling.HandleException(() => RolGuncelle());
                if (mainException is RequiredFieldsException)
                    MessageBox.Show(mainException.Message, "Boş alan bırakılamaz!", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                else if (mainException is ValidationException)
                    MessageBox.Show(mainException.Message, "Doğrulama hatası!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (mainException != null)
                    MessageBox.Show(mainException.Message, "Hatalı işlem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException == null)
                {
                    MessageBox.Show("Rol başarıyla güncellendi", "İşlem başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PageRoute.roleControl = new RoleControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    PageRoute.contentPanel.Controls.Clear();
                    PageRoute.contentPanel.Controls.Add(PageRoute.roleControl);
                }
            }
            else
                MessageBox.Show("Önce değişiklikler kaydedilmeli!", "Kayıt gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void rolControl_Changed(object sender,EventArgs e)
        {
            btnRolSuccess.Visible = true;
            btnRolCancel.Visible = true;
            btnRolDuzenle.Visible = false;
        }

        private void SetRoleSettings()
        {
            RoleSettingsInfos.rolAdi = tbxRolAdi.Text;
            RoleSettingsInfos.silId = cbxDurum.SelectedIndex;
            RoleSettingsInfos.yetkiId = Convert.ToInt32(cbxYetki.SelectedValue);
        }

        private void ReturnSettings()
        {
            tbxRolAdi.Text = RoleSettingsInfos.rolAdi;
            cbxDurum.SelectedIndex = RoleSettingsInfos.silId;
            cbxYetki.SelectedValue = RoleSettingsInfos.yetkiId;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            PageRoute.contentPanel.Controls.Add(PageRoute.roleControl);
        }

        private void btnRolDuzenle_Click(object sender, EventArgs e)
        {
            gbxRol.Enabled = true;
            if (!btnRolCancel.Visible)
            {
                foreach (Control control in gbxRol.Controls)
                {
                    control.TextChanged += new EventHandler(rolControl_Changed);
                }
            }
            else if (btnRolCancel.Visible)
            {
                btnRolDuzenle.Visible = true;
            }

        }

        private void btnRolSuccess_Click(object sender, EventArgs e)
        {
            SetRoleSettings();
            MessageBox.Show("Değişiklikler kaydedildi , onaylamak için güncelleyin!", "Onaylama Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gbxRol.Enabled = false;
            btnRolCancel.Visible = false;
            btnRolSuccess.Visible = false;
            btnRolDuzenle.Visible = true;
        }

        private void CheckIfRoleUsing()
        {
            if(cbxDurum.SelectedIndex == 0)
            {
                var uyedetaylar = _userManager.GetAllUyeDetay();
                foreach (var uye in uyedetaylar)
                {
                    if(uye.rol_id == Convert.ToInt32(tbxRolId.Text))
                        throw new DataIsUsingException("Bu rolü kullanan kullanıcılar var! Pasifleştirilemez!");
                }
            }
        }

        private void btnRolCancel_Click(object sender, EventArgs e)
        {
            ReturnSettings();
            gbxRol.Enabled = false;
            btnRolCancel.Visible = false;
            btnRolSuccess.Visible = false;
            btnRolDuzenle.Visible = true;
        }

        private void RoleSettingsControl_Load(object sender, EventArgs e)
        {
            CheckIfRoleBase();
            SetDefault();            
        }
    }
}
