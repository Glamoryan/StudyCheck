using StudyCheck.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Entites.Concrete
{
    public class Uye:IEntity
    {
        public int id { get; set; }
        public string uye_ad { get; set; }
        public string uye_soyad { get; set; }

    }
}
