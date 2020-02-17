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
    public class ThemeManager : IThemeService
    {
        private IThemeDal _themeDal;
        public ThemeManager(IThemeDal themeDal)
        {
            _themeDal = themeDal;
        }

        [FluentValidationAspect(typeof(ThemeValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Tema AddTheme(Tema tema)
        {
            return _themeDal.Add(tema);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Tema> GetActiveThemes()
        {
            return _themeDal.GetList(x => x.sil_id == 1);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Tema> GetAllThemes()
        {
            return _themeDal.GetList();
        }
        
        public Tema GetThemeById(int id)
        {
            return _themeDal.Get(x => x.id == id);
        }

        [FluentValidationAspect(typeof(ThemeValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Tema UpdateTheme(Tema tema)
        {
            return _themeDal.Update(tema);
        }
    }
}
