﻿using System;
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

namespace StudyCheck.FormsUI.AdminForms.UserControls.RightsControl
{
    public partial class RightSettingsControl : UserControl
    {
        public RightSettingsControl()
        {
            InitializeComponent();
        }

        private static Exception mainException;

        private static EfRightDal _efRightDal = new EfRightDal();

        private static RightManager _rightManager = new RightManager(_efRightDal);

        private static Yetki _yetki;        


        private void CheckFields()
        {
            if (tbxYetkiAdi.Text.Equals(string.Empty))
                throw new RequiredFieldsException("Yetki adı boş bırakılamaz!");
        }

        private void isAdd(Yetki yetki)
        {
            var yetkiler = _rightManager.GetAllRights();
            foreach (var yt in yetkiler)
            {
                if (yt.yetki_adi.ToLower().Equals(yetki.yetki_adi.ToLower()))
                    throw new DataAlreadyExistsException("Bu yetki zaten mevcut!");
            }
        }

        private void yetkiGuncelle()
        {
            CheckFields();
            _yetki = new Yetki
            {
                yetki_adi = tbxYetkiAdi.Text,
                eklenme_tarihi = Convert.ToDateTime(tbxKayitTarih.Text),
                guncelleme_tarihi = Convert.ToDateTime(tbxGuncellemeTarih.Text),
                sil_id = cbxDurum.SelectedIndex,
                ekleyen_id = RightControl._uyeler.Where(x => x.kullanici_adi == tbxEkleyen.Text).Single().id,
                guncelleyen_id = LoginInfo.Id,                
            };
            isAdd(_yetki);
            _rightManager.UpdateRight(_yetki);
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
            SetDefault();
            cbxDurum.SelectedIndex = 1;
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (CheckEdited())
            {
                mainException = ExceptionHandling.HandleException(() => yetkiGuncelle());
                if (mainException is RequiredFieldsException)
                    MessageBox.Show(mainException.Message, "Boş alan bırakılamaz!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (mainException is DataAlreadyExistsException)
                    MessageBox.Show(mainException.Message, "Zaten mevcut", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException is ValidationException)
                    MessageBox.Show(mainException.Message, "Doğrulama hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException != null)
                    MessageBox.Show(mainException.Message, "Hatalı işlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (mainException == null)
                    MessageBox.Show("Yetki başarıyla güncellendi","Güncelleme başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Önce değişiklikler kaydedilmeli!", "Kayıt gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
