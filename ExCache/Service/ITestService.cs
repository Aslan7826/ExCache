using ExCache.model;
using System.Collections.Generic;

namespace ExCache.Service
{
    public interface ITestService
    {
        IEnumerable<TestViewModel> GetTestViewModels();
    }
}