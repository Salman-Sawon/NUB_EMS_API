using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Dc_Dashboard
{
    public class DcDashboardGrid
    {
        public string ORG_NAME { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string MOBILE { get; set; }
        public string EMAIL { get; set; }
        public decimal PRESENT { get; set; }
        public decimal ABSENT { get; set; }
        public decimal LATE { get; set; }
       


    }
}
