using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Global
{
    public class SMSViewModel
    {
        public decimal SMS_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string STUDENT_CODE { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string STUDENT_NAME { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }
        public string CUR_SESSION_CODE { get; set; }
        public string SESSION_NAME_1 { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_CODE { get; set; }
        public string GROUP_NAME { get; set; }
        public string SHIFT_CODE { get; set; }
        public string SHIFT_NAME { get; set; }
        public string VERSION_CODE { get; set; }
        public string VERSION_NAME { get; set; }
        public string SMS_CONTENT { get; set; }
        public string IS_APPROVED { get; set; }
        public string APPROVED_BY { get; set; }
        public DateTime APPROVED_DATE { get; set; }
        public string USER_CODE { get; set; }

    }
}

