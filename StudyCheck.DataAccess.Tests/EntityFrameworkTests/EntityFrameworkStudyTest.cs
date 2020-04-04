using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using StudyCheck.Entites.Concrete;

namespace StudyCheck.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkStudyTest
    {
        [TestMethod]
        public void calisma_ekle_test()
        {
            EfStudyDal efStudyDal = new EfStudyDal();
            StudyManager studyManager = new StudyManager(efStudyDal);
            Calisma calisma = new Calisma
            {
                uye_id = 1,
                sinav_id = 1,
                ders_id = 1,
                calisilan_zaman = new TimeSpan(03, 13, 20),
                calisilan_tarih = new DateTime(2020, 02, 09)
            };
            studyManager.AddStudy(calisma);
        }

        [TestMethod]
        public void tum_calismalari_al()
        {
            EfStudyDal efStudyDal = new EfStudyDal();
            StudyManager studyManager = new StudyManager(efStudyDal);

            var sonuc = studyManager.GetAllStudies();
            Assert.AreEqual(1, sonuc.Count);
        }

        [TestMethod]
        public void kullanici_calismalarini_al()
        {
            EfStudyDal efStudyDal = new EfStudyDal();
            StudyManager studyManager = new StudyManager(efStudyDal);            
            Uyedetay uyedetay = new Uyedetay
            {
                uye_id=1
            };
            var sonuc = studyManager.GetUserStudies(uyedetay);
            Assert.AreEqual(2, sonuc.Count);
        }

        [TestMethod]
        public void ders_ekle_test()
        {
            EfLessonDal efLessonDal = new EfLessonDal();
            LessonManager lessonManager = new LessonManager(efLessonDal);
            Ders ders = new Ders
            {
                sinav_id=1,
                ders_ad="türkçe",
                eklenme_tarihi=new DateTime(2020,02,09),
                ekleyen_id=1,
                guncelleme_tarihi=new DateTime(2020,02,09),
                sil_id=1
            };
            lessonManager.AddLesson(ders);
        }
        [TestMethod]
        public void tum_dersleri_getir()
        {
            EfLessonDal efLessonDal = new EfLessonDal();
            LessonManager lessonManager = new LessonManager(efLessonDal);
            var sonuc = lessonManager.GetAllLessons();
            Assert.AreEqual(3, sonuc.Count);
        }
        [TestMethod]
        public void sinava_kayitli_dersleri_getir()
        {
            EfLessonDal efLessonDal = new EfLessonDal();
            LessonManager lessonManager = new LessonManager(efLessonDal);
            Sinav sinav = new Sinav
            {
                id = 1
            };
            var sonuc = lessonManager.GetAllLessonsByExam(sinav);
            Assert.AreEqual(3, sonuc.Count);
        }
        [TestMethod]
        public void get_ders_by_id()
        {
            EfLessonDal efLessonDal = new EfLessonDal();
            LessonManager lessonManager = new LessonManager(efLessonDal);
            var sonuc = lessonManager.GetLessonById(1);
            Assert.IsNotNull(sonuc);
        }
        [TestMethod]
        public void dersi_guncelle()
        {
            EfLessonDal efLessonDal = new EfLessonDal();
            LessonManager lessonManager = new LessonManager(efLessonDal);
            Ders ders = new Ders
            {
                id = 1,
                sinav_id=1,
                ders_ad = "updated",
                eklenme_tarihi = new DateTime(2020, 02, 09),
                ekleyen_id=1,
                guncelleme_tarihi = new DateTime(2020, 02, 09),
                sil_id = 1 
            };
            
            lessonManager.UpdateLesson(ders);
        }
    }
}
