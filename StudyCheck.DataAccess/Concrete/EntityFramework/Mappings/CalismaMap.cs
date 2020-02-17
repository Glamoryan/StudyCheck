using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CalismaMap:EntityTypeConfiguration<Calisma>
    {
        public CalismaMap()
        {
            ToTable(@"Calismalar", @"dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.uye_id).HasColumnName("uye_id");
            Property(x => x.sinav_id).HasColumnName("sinav_id");
            Property(x => x.ders_id).HasColumnName("ders_id");
            Property(x => x.calisilan_zaman).HasColumnName("calisilan_zaman");
            Property(x => x.calisilan_tarih).HasColumnName("calisilan_tarih");
        }
    }
}
