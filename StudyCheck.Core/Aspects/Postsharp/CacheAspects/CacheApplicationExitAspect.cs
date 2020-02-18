using PostSharp.Aspects;
using StudyCheck.Core.CrossCuttingConcerns.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Core.Aspects.Postsharp.CacheAspects
{
    [Serializable]
    public class CacheApplicationExitAspect:OnMethodBoundaryAspect
    {
        private string _pattern;
        private Type _cacheType;
        private ICacheManager _cacheManager;
        public CacheApplicationExitAspect(Type cacheType)
        {
            _cacheType = cacheType;
        }
        public CacheApplicationExitAspect(string pattern, Type cacheType)
        {
            _pattern = pattern;
            _cacheType = cacheType;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)// _cacheType Icachemanager türünde değilse
                throw new Exception("Wrong Cache Manager");
            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            _cacheManager.clear();
        }
    }
}
