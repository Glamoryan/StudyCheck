using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UyeDetayMap:EntityTypeConfiguration<Uyedetay>
    {
        public UyeDetayMap()
        {
            ToTable(@"UyeDetay", @"dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.uye_id).HasColumnName("uye_id");
            Property(x => x.kullanici_adi).HasColumnName("kullanici_adi");
            Property(x => x.kullanici_sifre).HasColumnName("kullanici_sifre");
            Property(x => x.kullanici_mail).HasColumnName("kullanici_mail");
            Property(x => x.kayit_tarihi).HasColumnName("kayit_tarihi");
            Property(x => x.guncelleme_tarihi).HasColumnName("guncelleme_tarihi");
            Property(x => x.sil_id).HasColumnName("sil_id");
            Property(x => x.tema_id).HasColumnName("tema_id");
            Property(x => x.rol_id).HasColumnName("rol_id");
            Property(x => x.guncelleyen_id).HasColumnName("guncelleyen_id");
        }
    }
}
