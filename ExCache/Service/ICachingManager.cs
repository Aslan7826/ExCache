using ExCache.model;
using System.Collections.Generic;

namespace ExCache.Service
{
    public interface ICachingManager
    {
        IEnumerable<T> Get<T>(IEnumerable<T> data, string cacheKey);
        void CacheRemove(IEnumerable<string> keys);
    }
}