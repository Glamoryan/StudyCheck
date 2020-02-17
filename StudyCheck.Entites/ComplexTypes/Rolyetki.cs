using StudyCheck.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Entites.ComplexTypes
{
    public class Rolyetki
    {
        public int Rolid { get; set; }
        public int YetkiId { get; set; }
        public string RolAdi { get; set; }
        public DateTime RolKayitTarihi { get; set; }
        public int RolEkleyenId { get; set; }
        public DateTime RolGuncellemeTarihi { get; set; }
        public int RolSilId { get; set; }
        public string YetkiAdi { get; set; }
        public int YetkiEkleyenId { get; set; }
        public DateTime YetkiEklenmeTarihi { get; set; }


    }
}
