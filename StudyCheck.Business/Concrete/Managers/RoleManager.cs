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
    public class RoleManager : IRoleService
    {
        private IRolDal _rolDal;
        public RoleManager(IRolDal rolDal)
        {
            _rolDal = rolDal;
        }
        [FluentValidationAspect(typeof(RoleValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Rol AddRole(Rol rol)
        {
            return _rolDal.Add(rol);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Rol> GetActiveRoles()
        {
            return _rolDal.GetList(x => x.sil_id == 1);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Rol> GetAllRoles()
        {
            return _rolDal.GetList();
        }

        [CacheAspect(typeof(MemoryCacheManager),30)]
        public List<Rol> GetAllRolesByRightId(int yetkiId)
        {
            return _rolDal.GetList(x => x.yetki_id == yetkiId);
        }
        
        public Rol GetRoleById(int id)
        {
            return _rolDal.Get(x => x.id == id);
        }

        [FluentValidationAspect(typeof(RoleValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Rol UpdateRole(Rol rol)
        {
            return _rolDal.Update(rol);
        }
    }
}
