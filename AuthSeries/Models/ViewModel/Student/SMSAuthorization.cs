using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Student
{
    public class SMSAuthorization
    {
        public int SMS_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string CUR_SESSION_CODE { get; set; }
        public string STUDENT_CODE { get; set; }
        public List<string> STUDENT_CODE_ARRAY { get; set; }
        public List<string> SMS_MOBILE_NUM { get; set; }
        public string SMS_CONTENT { get; set; }
        public string IS_APPROVED { get; set; }
        public string APPROVED_BY { get; set; }
        public string User_Name { get; set; }
        public int RowStatus { get; set; }
        public string SMS_TYPE_CODE { get; set; }
    }
}
