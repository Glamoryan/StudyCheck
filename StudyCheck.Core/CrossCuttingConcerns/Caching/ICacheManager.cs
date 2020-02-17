using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        void AddCache(string key, object data, int caheDuration);
        bool IsAdd(string key);
        void RemoveCache(string key);
        void RemoveByExpression(string pattern);
        void clear();
    }
}
