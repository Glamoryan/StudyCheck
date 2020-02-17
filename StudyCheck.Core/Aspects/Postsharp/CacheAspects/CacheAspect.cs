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
    public class CacheAspect:MethodInterceptionAspect
    {
        private Type _cacheType;
        private int _cacheByMinute;
        private ICacheManager _cacheManager;

        public CacheAspect(Type cacheType,int cacheByMinute=60)
        {
            _cacheType = cacheType;
            _cacheByMinute = cacheByMinute;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)// _cacheType Icachemanager türünde değilse
                throw new Exception("Wrong Cache Manager");
            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);
        }

        public override void OnInvoke(MethodInterceptionArgs args)//method çalışmadan önce
        {
            var methodDetail = string.Format("{0}.{1}.{2}", args.Method.ReflectedType.Namespace, args.Method.ReflectedType.Name, args.Method.Name);
            var arguments = args.Arguments.ToList();
            var key = string.Format("{0}({1})", methodDetail, string.Join(",", arguments.Select(x => x != null ? x.ToString() : "<Null>")));
            if (_cacheManager.IsAdd(key))
                args.ReturnValue = _cacheManager.Get<object>(key);//devam etme
            base.OnInvoke(args);
            _cacheManager.AddCache(key, args.ReturnValue, _cacheByMinute);
        }
    }
}
