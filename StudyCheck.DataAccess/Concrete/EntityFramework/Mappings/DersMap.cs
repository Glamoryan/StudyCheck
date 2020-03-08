using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework.Mappings
{
    public class DersMap:EntityTypeConfiguration<Ders>
    {
        public DersMap()
        {
            ToTable(@"Dersler", @"dbo");
            HasKey(x=>x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.sinav_id).HasColumnName("sinav_id");
            Property(x => x.ders_ad).HasColumnName("ders_ad");
            Property(x => x.eklenme_tarihi).HasColumnName("eklenme_tarihi");
            Property(x => x.ekleyen_id).HasColumnName("ekleyen_id");
            Property(x => x.guncelleme_tarihi).HasColumnName("guncelleme_tarihi");
            Property(x => x.sil_id).HasColumnName("sil_id");
            Property(x => x.guncelleyen_id).HasColumnName("guncelleyen_id");
        }
    }
}
