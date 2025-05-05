using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Admin.SetUp
{
    public class OrganizationUserCreationVM
    {
        public decimal USER_ID { get; set; }
        public string USER_CODE { get; set; }
        public string USER_NAME { get; set; }
        public string MOBILE_NO { get; set; }
        public string EMAIL { get; set; }
        public decimal ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public decimal USER_TYPE_ID { get; set; }
        public string USER_TYPE_DESCR { get; set; }
        // public string FULL_NAME { get; set; }       
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        //public string USER_PASSWORD { get; set; }
        public string DESIG_CODE { get; set; }
        public string DESIGNATION_NAME { get; set; }
    }
}
