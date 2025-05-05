using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Student
{
    public class SMSResponse
    {
        public string status { get; set; }
        public string status_code { get; set; }
        public string error_message { get; set; }
        public List<SMSInfo> smsinfo { get; set; }
    }

    public class SMSInfo
    {
        public string status_message { get; set; }
        public string msisdn { get; set; }
    }
}
