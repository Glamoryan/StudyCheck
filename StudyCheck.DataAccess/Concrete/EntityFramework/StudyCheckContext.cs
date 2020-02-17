using StudyCheck.DataAccess.Concrete.EntityFramework.Mappings;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework
{
    public class StudyCheckContext:DbContext
    {

        public StudyCheckContext()
        {
            Database.SetInitializer<StudyCheckContext>(null);//veritabanı üretimini engelleme
        }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Uyedetay> UyeDetay { get; set; }
        public DbSet<Calisma> Calismalar { get; set; }
        public DbSet<Ders> Dersler { get; set; }        
        public DbSet<Sinav> Sinavlar { get; set; }
        public DbSet<Tema> Temalar { get; set; }
        public DbSet<Yetki> Yetkiler { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UyeMap()); //mapping ekleme
            modelBuilder.Configurations.Add(new RolMap());
            modelBuilder.Configurations.Add(new UyeDetayMap());
            modelBuilder.Configurations.Add(new CalismaMap());
            modelBuilder.Configurations.Add(new DersMap());            
            modelBuilder.Configurations.Add(new SinavMap());
            modelBuilder.Configurations.Add(new TemaMap());
            modelBuilder.Configurations.Add(new YetkiMap());
        }


    }
}
