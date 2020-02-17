using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.Abstract
{
    public interface IRightService
    {
        List<Yetki> GetAllRights();
        Yetki GetRightById(int id);
        Yetki AddRight(Yetki yetki);
        Yetki UpdateRight(Yetki yetki);
        List<Yetki> GetActiveRights();
    }
}
