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
using StudyCheck.Entites.AccountManagement;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.FormsUI.Statikler;
using StudyCheck.FormsUI.ExceptionManage;
using FluentValidation;
using StudyCheck.Business.Abstract;
using StudyCheck.Business.DependencyResolvers.Ninject;

namespace StudyCheck.FormsUI.AdminForms.UserControls.RightsControl
{
    public partial class RightSettingsControl : UserControl
    {
        private Exception mainException;

        private IRightService _rightService;
        private IRoleService _roleService;

        private Yetki _yetki;

        public RightSettingsControl()
        {
            InitializeComponent();
            _rightService = InstanceFactory.GetInstance<IRightService>();
            _roleService = InstanceFactory.GetInstance<IRoleService>();
        }

        private void CheckFields()
        {
            if (tbxYetkiAdi.Text.Equals(string.Empty))
                throw new RequiredFieldsException("Yetki adı boş bırakılamaz!");
        }

        private void yetkiGuncelle()
        {
            CheckFields();
            _yetki = new Yetki
            {
                id = Convert.ToInt32(tbxYetkiId.Text),
                yetki_adi = tbxYetkiAdi.Text,
                eklenme_tarihi = Convert.ToDateTime(tbxKayitTarih.Text),
                guncelleme_tarihi = DateTime.Now,
                sil_id = cbxDurum.SelectedIndex,
                ekleyen_id = RightControl._uyeler.Where(x => x.kullanici_adi == tbxEkleyen.Text).Single().id,
                guncelleyen_id = LoginInfo.Id,                
            };            
            CheckIfRightUsing();
            _rightService.UpdateRight(_yetki);
        }

        private void SetDefault()
        {
            RightSettingsInfos.silId = cbxDurum.SelectedIndex;
            RightSettingsInfos.yetkiAdi = tbxYetkiAdi.Text;
        }

        private bool CheckEdited()
        {
            if (btnYetkiCancel.Visible || btnYetkiSuccess.Visible)
                return false;
            return true;
        }

        private void yetkiControl_Changed(object sender,EventArgs e)
        {
            btnYetkiCancel.Visible = true;
            btnYetkiSuccess.Visible = true;
            btnYetkiDuzenle.Visible = false;
        }

        private void SetYetkiSettings()
        {
            RightSettingsInfos.yetkiAdi = tbxYetkiAdi.Text;
            RightSettingsInfos.silId = cbxDurum.SelectedIndex;
        }

        private void ReturnSettings()
        {
            tbxYetkiAdi.Text = RightSettingsInfos.yetkiAdi;
            cbxDurum.SelectedIndex = RightSettingsInfos.silId;
        }

        private void RightSettingsControl_Load(object sender, EventArgs e)
        {
            CheckBaseRight();
            SetDefault();            
        }

        private void btnYetkiDuzenle_Click(object sender, EventArgs e)
        {
            gbxYetki.Enabled = true;
            if (!btnYetkiCancel.Visible)
            {
                foreach (Control control in gbxYetki.Controls)
                {
                    control.TextChanged += new EventHandler(yetkiControl_Changed);
                }
            }
            else if (btnYetkiCancel.Visible)
                btnYetkiDuzenle.Visible = true;
                
        }

        private void btnYetkiSuccess_Click(object sender, EventArgs e)
        {
            SetYetkiSettings();
            MessageBox.Show("Değişiklikler kaydedildi , Onaylamak için güncelleyin", "Onaylama gerekli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gbxYetki.Enabled = false;
            btnYetkiCancel.Visible = false;
            btnYetkiSuccess.Visible = false;
            btnYetkiDuzenle.Visible = true;
        }

        private void btnYetkiCancel_Click(object sender, EventArgs e)
        {
            ReturnSettings();
            gbxYetki.Enabled = false;
            btnYetkiCancel.Visible = false;
            btnYetkiSuccess.Visible = false;
            btnYetkiDuzenle.Visible = true;
        }

        private void CheckIfRightUsing() //yeki kullanılıyorsa
        {
            if(cbxDurum.SelectedIndex == 0)
            {
                var roller = _roleService.GetAllRoles();
                foreach (var rol in roller)
                {
                    if (rol.yetki_id == Convert.ToInt32(tbxYetkiId.Text))
                        throw new DataIsUsingException("Bu yetkiyi kullanan rol/roller var! Pasifleştirilemez!");
                }
            }            
        }

        private void CheckBaseRight()
        {
            if(tbxYetkiId.Text.Equals("1") || tbxYetkiId.Text.Equals("2"))
            {
                label6.Visible = false;
                cbxDurum.Visible = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (CheckEdited())
            {
                mainException = ExceptionHandling.HandleException(() => yetkiGuncelle());
                if (mainException is RequiredFieldsException)
                    MessageBox.Show(mainException.Message, "Boş alan bırakılamaz!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                else if (mainException is DataIsUsingException)
                    MessageBox.Show(mainException.Message, "Yetki Kullanılıyor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException is BaseRightException)
                    MessageBox.Show(mainException.Message, "Bu yetkiler pasifleştirilemez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException is ValidationException)
                    MessageBox.Show(mainException.Message, "Doğrulama hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException != null)
                    MessageBox.Show(mainException.Message, "Hatalı işlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException == null)
                {
                    MessageBox.Show("Yetki başarıyla güncellendi", "Güncelleme başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PageRoute.RefreshAllDataControls();
                    PageRoute.contentPanel.Controls.Clear();
                    PageRoute.contentPanel.Controls.Add(PageRoute.rightControl);
                }                    
            }
            else
                MessageBox.Show("Önce değişiklikler kaydedilmeli!", "Kayıt gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            PageRoute.contentPanel.Controls.Clear();
            PageRoute.contentPanel.Controls.Add(PageRoute.rightControl);
        }
    }
}
