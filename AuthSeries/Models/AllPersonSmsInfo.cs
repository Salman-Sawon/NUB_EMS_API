using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class AllPersonSmsInfo
    {
        public string ORG_CODE { get; set; }
        public string SMS_CONTENT { get; set; }
        public string USER_NAME { get; set; }
        public string SMS_TYPE_CODE { get; set; }
    }
}
