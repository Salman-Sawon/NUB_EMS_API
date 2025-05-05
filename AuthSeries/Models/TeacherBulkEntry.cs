using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class TeacherBulkEntry
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public List<string> TEACHER_NAME { get; set; }
        public List<string> FATHERS_NAME { get; set; }
        public List<DateTime> JOINING_DATE { get; set; }      
        public List<string> SMS_MOBILE_NUM { get; set; }     
        public string USER_NAME { get; set; }
    }
    
    public class QuickTeacherEntry
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public List<string> TEACHER_NAME { get; set; }
        public List<string> FATHERS_NAME { get; set; }
        public List<string> JOINING_DATE { get; set; }      
        public List<string> SMS_MOBILE_NUM { get; set; }     
        public string USER_NAME { get; set; }
    }

    public class ActiveTeacherData
    {
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public string JOINING_DATE { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string DATE_OF_BIRTH { get; set; }



    }
}

