using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class SmsAuthIfo
    {

        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public decimal SMS_TYPE { get; set; }
        public List<decimal> SMS_ID { get; set; }
        public List<string> STUDENT_CODE { get; set; }
        public List<string> SMS_MOBILE_NUM { get; set; }
        public List<string> SMS_CONTENT { get; set; }
        public string USER_NAME { get; set; }
    }


    public class SMSCredential
    {
        public string API_TOKEN { get;set; }
        public string SID { get;set; }
    }


    public class CheckSmsStatus
    {
        public string SMS_STATUS { get; set; }
        
    }
     public class CheckNotificationStatus
    {
        public string NOTIF_STATUS { get; set; }
        
    }



}
