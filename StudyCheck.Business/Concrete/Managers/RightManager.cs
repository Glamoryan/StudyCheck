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
    public class RightManager : IRightService
    {
        private IRightDal _rightDal;
        public RightManager(IRightDal rightDal)
        {
            _rightDal = rightDal;
        }
        [FluentValidationAspect(typeof(RightValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Yetki AddRight(Yetki yetki)
        {
            return _rightDal.Add(yetki);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Yetki> GetActiveRights()
        {
            return _rightDal.GetList(x => x.sil_id == 1);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Yetki> GetAllRights()
        {
            return _rightDal.GetList();
        }
        
        public Yetki GetRightById(int id)
        {
            return _rightDal.Get(x => x.id == id);
        }

        [FluentValidationAspect(typeof(RightValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Yetki UpdateRight(Yetki yetki)
        {
            return _rightDal.Update(yetki);
        }
    }
}
