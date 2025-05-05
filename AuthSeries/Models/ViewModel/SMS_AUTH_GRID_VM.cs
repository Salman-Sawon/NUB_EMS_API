using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class SMS_AUTH_GRID_VM
    {
        public decimal SMS_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string SMS_CONTENT { get; set; }
    }
}
