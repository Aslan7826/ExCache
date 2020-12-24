using ExCache.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExCache.Service
{
    public class TestService:ITestService
    {
        public IEnumerable<TestViewModel> GetTestViewModels() 
        {
            var db = new List<TestViewModel>() 
            {
                new TestViewModel() { Id =1 ,Name = "A" }  ,
                new TestViewModel() { Id =2 ,Name = "B" }  
            }.AsQueryable();

            return db.ToCaching(CacheName.Unit,"all");
        }
    }
}
