using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Student
{
    public class StudentQuickAdmissionInfoVM
    {
        public decimal STUDENT_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string CUR_SESSION_CODE { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string CLASS_ROLL { get; set; }
        public string STUDENT_NAME { get; set; }
        public string FATHERS_NAME { get; set; }
        public decimal RowStatus { get; set; }
        public string USER_NAME { get; set; }
    }

}
