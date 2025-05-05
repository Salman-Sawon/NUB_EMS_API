using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class BirthPlaceViewModel
    {
        public string DIST_CODE { get; set; }
        public string DIST_DESCR { get; set; }
    }
     public class DesignationList
    {
        public string DESIGNATION_CODE { get; set; }
        public string DESIGNATION_NAME { get; set; }
    }
     public class DepartmentList
    {
        public decimal DEPT_ID { get; set; }
        public string DEPT_NAME { get; set; }
    }


}
