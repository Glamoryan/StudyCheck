using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Entites.ComplexTypes
{
    public static class LoginInfo
    {
        public static int Id { get; set; }
        public static int UyeId { get; set; }
        public static string KullaniciAdi { get; set; }
        public static string Sifre { get; set; }
        public static string Mail { get; set; }
        public static int SilId { get; set; }
        public static int TemaId { get; set; }
        public static int RolId { get; set; }
    }
}
