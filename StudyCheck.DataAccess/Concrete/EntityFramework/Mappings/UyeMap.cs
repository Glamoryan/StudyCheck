using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UyeMap:EntityTypeConfiguration<Uye>
    {
        public UyeMap()
        {
            ToTable(@"Uyeler", @"dbo");
            HasKey(x => x.id);            

            Property(x => x.id).HasColumnName("id");
            Property(x => x.uye_ad).HasColumnName("uye_ad");
            Property(x => x.uye_soyad).HasColumnName("uye_soyad");
        }
    }
}
