using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class ShiftGrid
    {

        public decimal SHIFT_ID { get; set; }
        public string SHIFT_NAME { get; set; }
        public string IN_TIME { get; set; }
        public string OUT_TIME { get; set; }
      
    }
    public class ShiftMst
    {

        public decimal SHIFT_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string SHIFT_NAME { get; set; }
        public string IN_TIME { get; set; }
        public string  OUT_TIME { get; set; }
        public string USER_CODE { get; set; }
        public decimal ROW_STATUS { get; set; }

    }

    public class TeacherShiftMap
    {

        public string ORG_CODE { get; set; }
       
        public List<decimal> SHIFT_ID { get; set; }
        public List<string> TEACHER_CODE { get; set; }
        public List<decimal> TEACHER_ATT_ID { get; set; }
        public List<string> IN_TIME { get; set; }
        public List<string> OUT_TIME { get; set; }
        
        public string USER_CODE { get; set; }

    }

    public class ShiftMappingGrid
    {
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public decimal SHIFT_ID { get; set; }
        public decimal TEACHER_ATT_ID { get; set; }
        public string IN_TIME { get; set; }
        public string OUT_TIME { get; set; }



    }
    public class ShiftGridList
    {

        public decimal SHIFT_ID { get; set; }
        public string SHIFT_NAME { get; set; }
        public string IN_TIME { get; set; }
        public string OUT_TIME { get; set; }

    }

    public class SingleTeacherAttStatusParam
    {
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
       // public string TEACHER_CODE { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string TEACHER_CODE { get; set; }

    }

    public class SingleTeacherAttStatusList
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public string ATTENDANCE_DATE { get; set; }
        public string IN_TIME { get; set; }
        public string OUT_TIME { get; set; }
        public string ATTENDANCE_STATUS { get; set; }
        public string OVER_STAY { get; set; }
        public string LATE_TIME { get; set; }

    }


    public class AttendenceProcess
    {


        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string PROCESS_DATE { get; set; }


    }

    public class TeacherAttendenceList
    {

       
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public DateTime ATTENDANCE_DATE { get; set; }
        public string IN_TIME { get; set; }
        public string OUT_TIME { get; set; }
        public string ATTENDANCE_STATUS { get; set; }
        public string OVER_STAY { get; set; }
        public string LATE_TIME { get; set; }
     

    }

    public class TeacherAttendenceParam
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }
      
      
      

    }

    public class TeacherAttendenceSumamryList
    {
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public decimal Absent_Count { get; set; }
        public decimal   Late_Count { get; set; }
        public decimal Present_Count { get; set; }
        public string Total_Present_Overstay { get; set; }



    }

}
