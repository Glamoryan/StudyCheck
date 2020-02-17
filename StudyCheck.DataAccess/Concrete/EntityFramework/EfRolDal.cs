using StudyCheck.Core.DataAccess.EntityFramework;
using StudyCheck.DataAccess.Abstract;
using StudyCheck.Entites.ComplexTypes;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework
{
    public class EfRolDal : EfEntityRepositoryBase<Rol, StudyCheckContext>, IRolDal
    {
        public List<Rolyetki> GetRoleDetails()
        {
            using(StudyCheckContext context = new StudyCheckContext())
            {
                var sonuc = from r in context.Roller
                            join y in context.Yetkiler on r.yetki_id equals y.id
                            select new Rolyetki
                            {
                                Rolid = r.id,
                                YetkiId = r.yetki_id,
                                RolAdi = r.rol_adi,
                                RolKayitTarihi = r.rol_kayit_tarihi,
                                RolEkleyenId = r.ekleyen_id,
                                RolGuncellemeTarihi = r.rol_guncelleme_tarihi,
                                RolSilId = r.sil_id,
                                YetkiAdi = y.yetki_adi,
                                YetkiEkleyenId = y.ekleyen_id,
                                YetkiEklenmeTarihi = y.eklenme_tarihi
                            };
                return sonuc.ToList();
            }
        }
    }
}
