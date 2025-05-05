using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class StudentBulkEntry
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string CURRENT_SESSION_CODE { get; set; }
        public List<string> ADMISSION_DATE { get; set; }
        public List<string> SMS_MOBILE_NUM { get; set; }
        public List<string> CLASS_ROLL { get; set; }
        public List<string> STUDENT_NAME { get; set; }
        public List<string> FATHERS_NAME { get; set; }
        public decimal RowStatus { get; set; }
        public string User_Name { get; set; }
    }
}
