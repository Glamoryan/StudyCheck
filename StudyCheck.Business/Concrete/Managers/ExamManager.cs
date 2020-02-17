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
    public class ExamManager : IExamService
    {
        private IExamDal _examDal;
        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }
        [FluentValidationAspect(typeof(ExamValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Sinav AddExam(Sinav sinav)
        {
            return _examDal.Add(sinav);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Sinav> GetActiveExams()
        {
            return _examDal.GetList(x => x.sil_id == 1);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Sinav> GetAllExams()
        {
            return _examDal.GetList();
        }
        
        public Sinav GetExamById(int id)
        {
            return _examDal.Get(x => x.id == id);
        }
        [FluentValidationAspect(typeof(ExamValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Sinav UpdateExam(Sinav sinav)
        {
            return _examDal.Update(sinav);
        }
    }
}
