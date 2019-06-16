using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_RegionBasedRespAPI.RegionServices.SARegion
{
    public class SARegionService : IRegionService
    {
        // Subtracts two values
        public int Calculate(int SARegionA, int SARegionB)
        {
            return SARegionA - SARegionB;
        }
    }
}
