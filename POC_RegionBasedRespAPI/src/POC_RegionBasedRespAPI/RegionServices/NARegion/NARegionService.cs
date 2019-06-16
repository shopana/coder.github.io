using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_RegionBasedRespAPI.RegionServices.NARegion
{
    public class NARegionService : IRegionService
    {
        // Sums two values
        public int Calculate(int NARegionA, int NARegionB)
        {
            return NARegionA + NARegionB;
        }
    }
}
