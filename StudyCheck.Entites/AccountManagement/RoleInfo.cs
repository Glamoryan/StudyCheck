using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Entites.AccountManagement
{
    public static class RoleInfo
    {
        public static int Id { get; set; }
        public static string RolAdi { get; set; }
        public static DateTime RolKayitTarihi { get; set; }
        public static int RoluEkleyenId { get; set; }
        public static DateTime RolGuncellemeTarihi { get; set; }
        public static int SilId { get; set; }
        public static int YetkiId { get; set; }

    }
}
