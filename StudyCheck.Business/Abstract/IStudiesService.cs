using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.Abstract
{
    public interface IStudiesService
    {
        List<Calisma> GetUserStudies(Uyedetay uyedetay);
        List<Calisma> GetAllStudies();
        Calisma AddStudy(Calisma calisma);
    }
}
