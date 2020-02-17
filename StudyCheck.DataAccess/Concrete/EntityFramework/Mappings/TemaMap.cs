using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TemaMap:EntityTypeConfiguration<Tema>
    {
        public TemaMap()
        {
            ToTable(@"Temalar", @"dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.tema_adi).HasColumnName("tema_adi");
            Property(x => x.eklenme_tarihi).HasColumnName("eklenme_tarihi");
            Property(x => x.ekleyen_id).HasColumnName("ekleyen_id");
            Property(x => x.sil_id).HasColumnName("sil_id");

        }
    }
}
