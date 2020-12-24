using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExCache.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExCache.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        ITestService _ITestService;
        public WeatherForecastController(ITestService testService) 
        {
            _ITestService = testService;
        }
        [HttpGet]
        public object Get() 
        {
            return _ITestService.GetTestViewModels();
        }
    }
}
