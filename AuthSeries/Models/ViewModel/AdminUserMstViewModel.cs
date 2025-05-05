using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class AdminUserMstViewModel
    {
        public decimal USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_CODE { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE_NO { get; set; }
        public decimal ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public decimal USER_TYPE_ID { get; set; }
        public string USER_TYPE_DESCR { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; } 

        public string USER_PASSWORD { get; set; }

        public string DESIG_CODE { get; set; }

        public string DESIGNATION_NAME { get; set; }
    }

    public class AllUserMstViewModel
    {
        public decimal USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_CODE { get; set; }
        public string EMAIL { get; set; }
        public string USER_PASSWORD { get; set; }
        public string MOBILE_NO { get; set; }
        public decimal ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public decimal USER_TYPE_ID { get; set; }
        public string USER_TYPE_DESCR { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public decimal TOTAL_ROWS { get; set; }
        public decimal SL { get; set; }
    }

    public class dcUserViewModel
    {
        public decimal USER_ID { get; set; }
        public string USER_CODE { get; set; }
    
    }
}
