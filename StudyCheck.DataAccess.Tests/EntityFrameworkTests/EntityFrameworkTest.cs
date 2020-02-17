using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Core;
using System.Data.Entity;
using System.Windows.Forms;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.Entites.Concrete;

namespace StudyCheck.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Tum_uyeleri_getir()
        {
            EfUserDal uyedal = new EfUserDal();
            var sonuc = uyedal.GetList();
            Assert.AreEqual(1, sonuc.Count);
        }
        
        [TestMethod]
        public void Filtreli_uyeleri_getir()
        {
            EfUserDal uyedal = new EfUserDal();
            var sonuc = uyedal.GetList(p=>p.uye_ad.Contains("ad"));
            Assert.AreEqual(1, sonuc.Count);
        }

        [TestMethod]
        public void Tum_rolleri_getir()
        {
            EfRolDal efRolDal = new EfRolDal();
            RoleManager roleManager = new RoleManager(efRolDal);
            var sonuc = roleManager.GetAllRoles();
            Assert.AreEqual(2, sonuc.Count);
        }

        [TestMethod]
        public void Filtreli_rolleri_getir()
        {
            EfRolDal efRolDal = new EfRolDal();
            RoleManager roleManager = new RoleManager(efRolDal);
            var sonuc = roleManager.GetRoleById(2);
            Assert.IsNotNull(sonuc);
        }

        [TestMethod]
        public void rol_ekle_test()
        {
            EfRolDal efRolDal = new EfRolDal();
            RoleManager roleManager = new RoleManager(efRolDal);
            Rol rol = new Rol
            {
                rol_adi="test",
                rol_kayit_tarihi = new DateTime(2020,02,09),
                ekleyen_id=1,
                rol_guncelleme_tarihi= new DateTime(2020, 02, 09),
                sil_id=1,
                yetki_id=1
            };
            roleManager.AddRole(rol);
        }
        [TestMethod]
        public void rol_guncelle_test()
        {
            EfRolDal efRolDal = new EfRolDal();
            RoleManager roleManager = new RoleManager(efRolDal);
            Rol rol = new Rol
            {
                id=3,
                rol_adi = "testUpdated",
                rol_kayit_tarihi = new DateTime(2020, 02, 09),
                ekleyen_id = 1,
                rol_guncelleme_tarihi = new DateTime(2020, 02, 09),
                sil_id = 0,
                yetki_id = 1
            };
            roleManager.UpdateRole(rol);
        }

        [TestMethod]
        public void uyedetay_getir()
        {
            EfUserDetailDal userDetailDal = new EfUserDetailDal();
            var sonuc = userDetailDal.GetList();
            Assert.AreEqual(1, sonuc.Count);
        }


        [TestMethod]
        public void calisma_test()
        {
            EfStudyDal studyDal = new EfStudyDal();
            var sonuc = studyDal.GetList();
            Assert.AreEqual(0, sonuc.Count);
        }

        [TestMethod]
        public void ders_test()
        {
            EfLessonDal lessonDal = new EfLessonDal();
            var sonuc = lessonDal.GetList();
            Assert.AreEqual(0, sonuc.Count);
        }


        
        [TestMethod]
        public void sinav_test()
        {
            EfExamDal examDal = new EfExamDal();
            var sonuc = examDal.GetList();
            Assert.AreEqual(0, sonuc.Count);
        }

        [TestMethod]
        public void tema_test()
        {
            EfThemeDal themeDal = new EfThemeDal();
            var sonuc = themeDal.GetList();
            Assert.AreEqual(1, sonuc.Count);
        }

        [TestMethod]
        public void yetki_ekle_test()
        {
            EfRightDal rightDal = new EfRightDal();
            RightManager rightManager = new RightManager(rightDal);
            Yetki yetki = new Yetki
            {
                yetki_adi="test",
                ekleyen_id=1,
                eklenme_tarihi = new DateTime(2020,02,09)
            };
            rightManager.AddRight(yetki);
        }
        [TestMethod]
        public void yetki_guncelle_test()
        {
            EfRightDal rightDal = new EfRightDal();
            RightManager rightManager = new RightManager(rightDal);
            Yetki yetki = new Yetki
            {
                id=2,
                yetki_adi = "testUpdated",
                ekleyen_id = 1,
                eklenme_tarihi = new DateTime(2020, 02, 09),
                sil_id=0
            };
            rightManager.UpdateRight(yetki);
        }
        [TestMethod]
        public void tum_yetkileri_al()
        {
            EfRightDal rightDal = new EfRightDal();
            RightManager rightManager = new RightManager(rightDal);
            var sonuc = rightManager.GetAllRights();
            Assert.AreEqual(2, sonuc.Count);
        }
        [TestMethod]
        public void yetkiyi_al()
        {
            EfRightDal rightDal = new EfRightDal();
            RightManager rightManager = new RightManager(rightDal);
            var sonuc = rightManager.GetRightById(2);
            Assert.IsNotNull(sonuc);
        }
        [TestMethod]
        public void tum_sinavlari_getir()
        {
            EfExamDal efExamDal = new EfExamDal();
            ExamManager examManager = new ExamManager(efExamDal);
            var sonuc = examManager.GetAllExams();
            Assert.AreEqual(1, sonuc.Count);
        }
        [TestMethod]
        public void tum_aktif_sinavlari_getir()
        {
            EfExamDal efExamDal = new EfExamDal();
            ExamManager examManager = new ExamManager(efExamDal);
            var sonuc = examManager.GetActiveExams();
            Assert.AreEqual(1, sonuc.Count);
        }
        [TestMethod]
        public void sinavi_Getir()
        {
            EfExamDal efExamDal = new EfExamDal();
            ExamManager examManager = new ExamManager(efExamDal);
            var sonuc = examManager.GetExamById(1);
            Assert.IsNotNull(sonuc);
        }
        [TestMethod]
        public void sinav_Ekle_test()
        {
            EfExamDal efExamDal = new EfExamDal();
            ExamManager examManager = new ExamManager(efExamDal);
            Sinav sinav = new Sinav
            {
                sinav_ad="test",
                sinav_tarih = new DateTime(2020,02,09),
                eklenme_tarihi= new DateTime(2020, 02, 09),
                ekleyen_id=1,
                guncelleme_tarihi= new DateTime(2020, 02, 09),
                sil_id=1
            };
            examManager.AddExam(sinav);
        }
        [TestMethod]
        public void sinav_guncelle_Test()
        {
            EfExamDal efExamDal = new EfExamDal();
            ExamManager examManager = new ExamManager(efExamDal);
            Sinav sinav = new Sinav
            {
                id=2,
                sinav_ad = "testUpdated",
                sinav_tarih = new DateTime(2020, 02, 09),
                eklenme_tarihi = new DateTime(2020, 02, 09),
                ekleyen_id = 1,
                guncelleme_tarihi = new DateTime(2020, 02, 09),
                sil_id = 0
            };
            examManager.UpdateExam(sinav);
        }
        [TestMethod]
        public void rol_yetkileri_test()
        {
            EfRolDal efRolDal = new EfRolDal();
            var sonuc = efRolDal.GetRoleDetails();
            foreach (var item in sonuc)
            {
                MessageBox.Show(item.RolAdi);
                MessageBox.Show(item.YetkiAdi);
            }
            
        }
        [TestMethod]
        public void tum_temalari_getir()
        {
            EfThemeDal efThemeDal = new EfThemeDal();
            ThemeManager themeManager = new ThemeManager(efThemeDal);
            var sonuc = themeManager.GetAllThemes();
            Assert.AreEqual(1, sonuc.Count);
        }
        [TestMethod]
        public void temayi_getir()
        {
            EfThemeDal efThemeDal = new EfThemeDal();
            ThemeManager themeManager = new ThemeManager(efThemeDal);
            var sonuc = themeManager.GetThemeById(1);
            Assert.IsNotNull(sonuc);
        }
        [TestMethod]
        public void aktif_temalari_getir()
        {
            EfThemeDal efThemeDal = new EfThemeDal();
            ThemeManager themeManager = new ThemeManager(efThemeDal);
            var sonuc = themeManager.GetActiveThemes();
            Assert.AreEqual(1, sonuc.Count);
        }
        [TestMethod]
        public void tema_ekle_test()
        {
            EfThemeDal efThemeDal = new EfThemeDal();
            ThemeManager themeManager = new ThemeManager(efThemeDal);
            Tema tema = new Tema
            {
                tema_adi="test",
                eklenme_tarihi=new DateTime(2020,02,09),
                ekleyen_id=1,
                sil_id=1
            };
            themeManager.AddTheme(tema);
        }
        [TestMethod]
        public void tema_guncelle_test()
        {
            EfThemeDal efThemeDal = new EfThemeDal();
            ThemeManager themeManager = new ThemeManager(efThemeDal);
            Tema tema = new Tema
            {
                id=2,
                tema_adi = "testUpdated",
                eklenme_tarihi = new DateTime(2020, 02, 09),
                ekleyen_id = 1,
                sil_id = 0
            };
            themeManager.UpdateTheme(tema);
        }
    }
}
