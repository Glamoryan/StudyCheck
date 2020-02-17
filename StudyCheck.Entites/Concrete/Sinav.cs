using StudyCheck.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Entites.Concrete
{
    public class Sinav:IEntity
    {
        public int id { get; set; }
        public string sinav_ad { get; set; }
        public DateTime sinav_tarih { get; set; }
        public DateTime eklenme_tarihi { get; set; }
        public int ekleyen_id { get; set; }
        public DateTime guncelleme_tarihi { get; set; }
        public int sil_id { get; set; }


    }
}
