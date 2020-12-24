using EasyCaching.Core;
using ExCache.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExCache.Service
{
    public class CachingManager : ICachingManager
    {
        IEasyCachingProvider _IEasyCachingProvider;
        public CachingManager(IEasyCachingProvider easyCachingProvider) 
        {
            _IEasyCachingProvider = easyCachingProvider;
        }
        public IEnumerable<T> Get<T>(IEnumerable<T> data,string cacheKey) 
        {
            var cache = _IEasyCachingProvider.Get(cacheKey, () => data,TimeSpan.FromMinutes(30));
            return cache.Value;
        }

        public void CacheRemove(IEnumerable<string> keys) 
        {
            _IEasyCachingProvider.RemoveAll(keys);
        }
    }
}
