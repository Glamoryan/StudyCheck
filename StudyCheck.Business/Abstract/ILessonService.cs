using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.Abstract
{
    public interface ILessonService
    {
        List<Ders> GetAllLessons();
        Ders GetLesson(int dersId);
        List<Ders> GetAllLessonsByExam(Sinav sinav);
        Ders AddLesson(Ders ders);
        Ders UpdateLesson(Ders ders);
        List<Ders> GetActiveLessons();
        List<Ders> GetActiveLessonsById(int sinavId);
    }
}
