using StudyCheck.Business.Abstract;
using StudyCheck.Business.Validations.FluentValidation;
using StudyCheck.Core.Aspects.Postsharp;
using StudyCheck.Core.Aspects.Postsharp.CacheAspects;
using StudyCheck.Core.Aspects.Postsharp.ValidationAspects;
using StudyCheck.Core.CrossCuttingConcerns.Caching.Microsoft;
using StudyCheck.DataAccess.Abstract;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.Concrete.Managers
{
    public class LessonManager : ILessonService
    {
        private ILessonDal _lessonDal;
        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }
        [FluentValidationAspect(typeof(LessonValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Ders AddLesson(Ders ders)
        {
            return _lessonDal.Add(ders);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Ders> GetActiveLessons()
        {
            return _lessonDal.GetList(x => x.sil_id == 1);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Ders> GetActiveLessonsById(int sinavId)
        {
            return _lessonDal.GetList(x => x.sil_id == 1 && x.sinav_id == sinavId);    
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Ders> GetAllLessons()
        {
            return _lessonDal.GetList();
        }

        [CacheAspect(typeof(MemoryCacheManager),30)]
        public List<Ders> GetAllLessonsByExam(Sinav sinav)
        {
            return _lessonDal.GetList(x => x.sinav_id == sinav.id);
        }
        
        public Ders GetLesson(int dersId)
        {
            return _lessonDal.Get(x => x.id == dersId);
        }

        [FluentValidationAspect(typeof(LessonValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Ders UpdateLesson(Ders ders)
        {
            return _lessonDal.Update(ders);
        }
    }
}
