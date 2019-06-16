using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POC_RegionBasedRespAPI.RegionServices;
using POC_RegionBasedRespAPI.Constant;

namespace POC_RegionBasedRespAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private Func<RegionName, IRegionService> _mathRepositoryDelegate;

        public ValuesController(Func<RegionName, IRegionService> mathRepositoryDelegate)
        {
            _mathRepositoryDelegate = mathRepositoryDelegate;

        }


        [HttpGet]
        [Route("Calculate")]
        public int Get(string regionName, int A, int B)
        {
            IRegionService mathRepository = _mathRepositoryDelegate((RegionName)Enum.Parse(typeof(RegionName), regionName));
            
            return mathRepository.Calculate(A, B);
        }
    }
}
