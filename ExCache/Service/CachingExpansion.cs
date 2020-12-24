using Autofac;
using ExCache.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExCache.Service
{
    public static class CachingExpansion
    {
        public static ICachingManager _ICachingManager;
        public static List<string> CacheNameList ;
        
        public static IEnumerable<T> ToCaching<T>(this IEnumerable<T> data , CacheName cachingkey,params string[] value) 
        {

            var key = string.Format(cachingkey.GetDescriptionText(), value);
            if(CacheNameList.FirstOrDefault(o=>o == key) is null) 
            {
                CacheNameList.Add(key);
            }
            return _ICachingManager.Get(data, key);

        }

        public static void Remove(this CacheName cache) 
        {
            var needDelKeys = CacheNameList.Where(o => o.Contains(cache.ToString()));
            _ICachingManager.CacheRemove(needDelKeys);
        }

    }
}
