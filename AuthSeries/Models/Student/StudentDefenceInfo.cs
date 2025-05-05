using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Student
{
    public class StudentDefenceInfo
    {
        public decimal STUDENT_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string FATHER_RANK { get; set; }
        public string REGIMENT_NO { get; set; }
        public string JOB_LOCATION { get; set; }
        public string SERVICE_STATUS { get; set; }
        public string RETIREMENT_DATE { get; set; }
        public string UNIT { get; set; }
        public string STATION { get; set; }
        public string DORMITORY { get; set; }
        public string BUILDING_NAME { get; set; }
        public string FACULTY_HOUSE { get; set; }
        public string USER_NAME { get; set; }
        public decimal RowStatus { get; set; }
    }
}
