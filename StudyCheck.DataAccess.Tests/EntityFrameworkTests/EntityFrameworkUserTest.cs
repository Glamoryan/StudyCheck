using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Core;
using System.Data.Entity;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.Business.Abstract;
using StudyCheck.Entites.Concrete;
using System.Windows.Forms;

namespace StudyCheck.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkUserTest
    {
        [TestMethod]
        public void kullanici_detay_ekle_test()
        {
            EfUserDal efUserDal = new EfUserDal();
            EfUserDetailDal efUserDetailDal = new EfUserDetailDal();
            UserManager userManager = new UserManager(efUserDal,efUserDetailDal);            
            Uyedetay uyedetay = new Uyedetay
            {
                uye_id = 5,
                kullanici_adi = "asdasd",
                kullanici_sifre = "12dwa3",
                kullanici_mail = "af",
                kayit_tarihi = new DateTime(2020, 02, 08),
                guncelleme_tarihi = new DateTime(2020, 02, 08),
                sil_id = 1,
                tema_id = 1,
                rol_id = 2,
            };
            userManager.AddUserDetail(uyedetay);            
        }

        [TestMethod]
        public void kullanici_ekle_test()
        {
            EfUserDal efUserDal = new EfUserDal();
            EfUserDetailDal efUserDetailDal = new EfUserDetailDal();
            UserManager userManager = new UserManager(efUserDal, efUserDetailDal);
            Uye uye = new Uye
            {
                uye_ad="ados",
                uye_soyad="dsawd"
            };
            userManager.AddUser(uye);
        }

        [TestMethod]
        public void kullanici_guncelle_test()
        {
            EfUserDal efUserDal = new EfUserDal();
            EfUserDetailDal efUserDetailDal = new EfUserDetailDal();
            UserManager userManager = new UserManager(efUserDal, efUserDetailDal);
            Uye uye = new Uye
            {
                id=5,
                uye_ad = "updated2",
                uye_soyad = "A13"
            };
            userManager.UpdateUser(uye);
        }

        [TestMethod]
        public void kullanici_detay_guncelle_test()
        {
            EfUserDal efUserDal = new EfUserDal();
            EfUserDetailDal efUserDetailDal = new EfUserDetailDal();
            UserManager userManager = new UserManager(efUserDal, efUserDetailDal);
            Uyedetay uyedetay = new Uyedetay
            {       
                id=12,
                uye_id=4,
                kullanici_adi="updateds",
                kullanici_sifre="5aawd63",
                kullanici_mail="updatedmail2",
                kayit_tarihi = new DateTime(2020,02,08),
                guncelleme_tarihi = new DateTime(2020, 02, 08),
                sil_id=1,
                tema_id=1,
                rol_id=2
            };
            userManager.UpdateUserDetail(uyedetay);
        }
    }
}
