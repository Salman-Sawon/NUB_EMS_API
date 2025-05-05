using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.User
{
    public class UserViewModel
    {
        public decimal USER_ID { get; set; }
        public string USER_CODE { get; set; }
        public string USER_NAME { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE_NO { get; set; }
        public string USER_PASSWORD { get; set; }
        public decimal ROLE_ID { get; set; }
        public string ORG_CODE { get; set; }
    }
}
