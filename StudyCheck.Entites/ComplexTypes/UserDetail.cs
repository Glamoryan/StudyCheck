using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Entites.ComplexTypes
{
    public class UserDetail
    {
        public int UyeDetayId { get; set; }
        public int UyeId { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
        public string KullaniciMail { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public int sil_id { get; set; }
        public int tema_id { get; set; }
        public int rol_id { get; set; }
        public int guncelleyen_id { get; set; }
    }
}
