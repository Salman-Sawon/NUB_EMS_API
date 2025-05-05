using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class TeacherAttendance
    {
        public string ORG_CODE { get; set; }
        public string ATTENDANCE_DATE { get; set; }

        public List<string> TEACHER_CODE { get; set; }
        public List<string> TEACHER_NAME { get; set; }
        public List<string> ATTENDANCE_STATUS { get; set; }
        public List<decimal> TEACHER_ATTEND_MST_ID { get; set; }
        public List<string> IN_TIME { get; set; }
        public List<string> OUT_TIME { get; set; }
        public string USER_NAME { get; set; }
    }


    public class TeacherAttendanceInfo
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string TEACHER_CODE { get; set; }
        public string TEACHER_LATITUTE { get; set; }
        public string TEACHER_LONGITUDE { get; set; }
        public decimal ATT_TYPE { get; set; }
        public decimal ORG_DISTANCE { get; set; }
    }



    public class TeacherAttInfoVM
    {
        public string ATT_DATE { get; set; }
        public string LOCATION_VALIDATE { get; set; }
        public string ATT_STATUS { get; set; }
       
    }

    public class TeacherAttType
    {
        public decimal ATT_TYPE_ID { get; set; }
        public string ATT_TYPE_DESCRIPTION { get; set; }

    }

    public class TeacherAttDtl
    {
        public decimal ORG_DISTANCE { get; set; }
        public decimal TEACHER_ATT_TYPE { get; set; }
        public string ATT_TYPE_DESC { get; set; }
        public string ATT_TIME { get; set; }

    }



    public class TeacherSummaryTableHeader
    {
        public string DATE_NAME { get; set; }
        public string DAY_NAME { get; set; }
        public string TEACHER_NAME { get; set; }
        public string TEACHER_CODE { get; set; }
        public string ATTENDANCE_STATUS { get; set; }

    }



    public class TeacherAttStatus
    {
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public string ATTENDANCE_DATE { get; set; }
        public string IN_TIME { get; set; }
        public string OUT_TIME { get; set; }
        public string ATTENDANCE_STATUS { get; set; }
        public string OVER_STAY { get; set; }
        public string LATE_TIME { get; set; }

    }
   

    public class TeacherAttStatusParam
    {
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }

    }

}
