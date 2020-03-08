using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework.Mappings
{
    public class RolMap:EntityTypeConfiguration<Rol>
    {
        public RolMap()
        {
            ToTable(@"Roller", @"dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.rol_adi).HasColumnName("rol_adi");
            Property(x => x.rol_guncelleme_tarihi).HasColumnName("rol_guncelleme_tarihi");
            Property(x => x.rol_kayit_tarihi).HasColumnName("rol_kayit_tarihi");
            Property(x => x.sil_id).HasColumnName("sil_id");
            Property(x => x.ekleyen_id).HasColumnName("ekleyen_id");
            Property(x => x.yetki_id).HasColumnName("yetki_id");
            Property(x => x.guncelleyen_id).HasColumnName("guncelleyen_id");
        }
    }
}
