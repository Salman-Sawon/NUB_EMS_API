using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Student
{
    public class StdAttendenceList
    {
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string ATTENDANCE_DATE { get; set; }
        public string IN_TIME { get; set; }
        public string OUT_TIME { get; set; }
        public string ATTENDANCE_STATUS { get; set; }
        public string OVER_STAY { get; set; }
        public string LATE_TIME { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string MESSAGE_TXT { get; set; }
    }


    public class StdAttendConfigInfo
    {

        public decimal CONFIG_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public decimal RowStatus { get; set; }
        public string USER_NAME { get; set; }

       
                                             


    }


    public class StdAttendConfigGrid
    {
        public decimal STD_ATTEND_CONFIG_ID { get; set; }
        public string IN_TIME { get; set; }
        public string OUT_TIME { get; set; }


    }
}
