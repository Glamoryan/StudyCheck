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
    public class StudyManager : IStudiesService
    {
        private IStudyDal _studyDal;

        public StudyManager(IStudyDal studyDal)
        {
            _studyDal = studyDal;
        }

        [FluentValidationAspect(typeof(StudyValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Calisma AddStudy(Calisma calisma)
        {
            return _studyDal.Add(calisma);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Calisma> GetAllStudies()
        {
            return _studyDal.GetList();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Calisma> GetUserStudies(Uyedetay uyedetay)
        {
            return _studyDal.GetList(x => x.uye_id == uyedetay.uye_id);
        }
    }
}
