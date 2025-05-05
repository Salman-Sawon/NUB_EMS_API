using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class OrganizationLocationInfo
    {
        public string ORG_LATITUTE { get; set; }
        public string ORG_LONGITUDE { get; set; }
        public string EARTH_RADIUS { get; set; }
        public decimal ACCEPTABLE_METER { get; set; }
    }
}
