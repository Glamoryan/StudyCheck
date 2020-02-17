using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework.Mappings
{
    public class SinavMap:EntityTypeConfiguration<Sinav>
    {
        public SinavMap()
        {
            ToTable(@"Sinavlar", @"dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.sinav_ad).HasColumnName("sinav_ad");
            Property(x => x.sinav_tarih).HasColumnName("sinav_tarih");
            Property(x => x.eklenme_tarihi).HasColumnName("eklenme_tarihi");
            Property(x => x.ekleyen_id).HasColumnName("ekleyen_id");
            Property(x => x.guncelleme_tarihi).HasColumnName("guncelleme_tarihi");
            Property(x => x.sil_id).HasColumnName("sil_id");


        }
    }
}
