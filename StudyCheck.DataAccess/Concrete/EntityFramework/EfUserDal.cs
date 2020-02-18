using StudyCheck.Core.DataAccess.EntityFramework;
using StudyCheck.DataAccess.Abstract;
using StudyCheck.Entites.ComplexTypes;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<Uye, StudyCheckContext>, IUserDal
    {
        

        /// <summary>
        /// Uyeler ile Uyedetay tablosunun tüm alanlarını çek
        /// </summary>
        /// <returns>UserDetail</returns>
        public List<UserDetail> GetUserDetails()
        {
            using(StudyCheckContext context = new StudyCheckContext())
            {
                var sonuc = from u in context.Uyeler
                            join ud in context.UyeDetay on u.id equals ud.uye_id
                            select new UserDetail
                            {
                                UyeId = u.id,
                                UyeAd = u.uye_ad,
                                UyeSoyad = u.uye_soyad,
                                KullaniciAdi = ud.kullanici_adi,
                                KullaniciSifre = ud.kullanici_sifre,
                                KullaniciMail = ud.kullanici_mail,
                                KayitTarihi = ud.kayit_tarihi,
                                GuncellemeTarihi = ud.guncelleme_tarihi,
                                sil_id = ud.sil_id,
                                tema_id = ud.tema_id,
                                rol_id = ud.rol_id
                            };
                return sonuc.ToList();
            }
        }
    }
}
