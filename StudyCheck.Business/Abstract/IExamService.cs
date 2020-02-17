using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.Abstract
{
    public interface IExamService
    {
        List<Sinav> GetAllExams();
        Sinav GetExamById(int id);
        Sinav AddExam(Sinav sinav);
        Sinav UpdateExam(Sinav sinav);
        List<Sinav> GetActiveExams();
    } 
}
