using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class StudentAttendenceInfoMD
    {
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_CODE { get; set; }
        public string GROUP_NAME { get; set; }
        public string SECTION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SECTION_NAME { get; set; }
        public string SHIFT_CODE { get; set; }
        public string SHIFT_NAME { get; set; }
        public string VERSION_CODE { get; set; }
        public string VERSION_NAME { get; set; }
        public string SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }
        public string ATTENDANCE_DATE { get; set; }
        public List<decimal> STUDENT_ATTEND_DTL_ID { get; set; }
        public List<string> STUDENT_CODE { get; set; }
        public List<string> STUDENT_NAME { get; set; }
        public List<string> ATTENDANCE_STATUS { get; set; }
        public List<string> IN_TIME { get; set; }
        public List<string> OUT_TIME { get; set; }
        public string USER_CODE { get; set; }
    }


    public class StudentAttendenceInfo
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public decimal SUB_MAP_ID { get; set; }
        //public string ATTENDANCE_DATE { get; set; }
        public List<decimal> STUDENT_ATTEND_DTL_ID { get; set; }
        public List<string> STUDENT_CODE { get; set; }
        public List<string> ATTENDENCE_STATUS { get; set; }
        public List<string> SMS_MOBILE_NUM { get; set; }
        public List<string> STUDENT_NAME { get; set; }
        public string User_Id { get; set; }
    }


    public class StudentAttendenceInfoUpdate
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public decimal SUB_MAP_ID { get; set; }
        //public string ATTENDANCE_DATE { get; set; }
        public decimal STUDENT_ATTEND_DTL_ID { get; set; }
        public string STUDENT_CODE { get; set; }
        public string ATTENDENCE_STATUS { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string STUDENT_NAME { get; set; }
        public string User_Id { get; set; }
    }

    public class StudentAttendenceInfoSave
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string ATTENDANCE_DATE { get; set; }
        public List<decimal> STUDENT_ATTEND_DTL_ID { get; set; }
        public List<string> STUDENT_CODE { get; set; }
        public List<string> ATTENDANCE_STATUS { get; set; }
        public List<string> SMS_MOBILE_NUM { get; set; }
        public List<string> STUDENT_NAME { get; set; }
        public string USER_CODE { get; set; }
    }

    public class AddressInfoGrid
    {
        public string ADDRESS_CODE { get; set; }
        public string ADDRESS_DESCR { get; set; }

    }
    
    public class FormFillupStatusUpdate
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STATUS { get; set; }
        public string CLASS_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
       

    }
    
    public class FormFillupStudentParams
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }

        public string STATUS { get; set; }
        public string CLASS_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
       

    }

    public class FormFillupStatusRptData
    {
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string CLASS_ROLL { get; set; }
        public string STATUS { get; set; }
     
       

    }


    public class UnseenNotificationVM
    {

        public decimal USER_ID { get; set; }

    }









    }
