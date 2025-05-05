using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class StudentAttendanceInfo
    {
        public string ORG_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public DateTime ATTENDANCE_DATE { get; set; }
        public string USER_CODE { get; set; }
    }


    public class StudentAttendanceInfoParam
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public decimal SUB_MAP_ID { get; set; }
       // public DateTime ATTENDANCE_DATE { get; set; }
        public string USER_CODE { get; set; }
    }

    public class StudentAttendenceInfoVM
    {

        //public string ATTENDANCE_DATE { get; set; }
        public decimal STUDENT_ATTEND_DTL_ID { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string ATTENDANCE_STATUS { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public decimal ABSENT_STATUS_COUNT { get; set; }
        public decimal PRESENT_STATUS_COUNT { get; set; }
        public decimal LATE_STATUS_COUNT { get; set; }
        //public List<string> IN_TIME { get; set; }
        //public List<string> OUT_TIME { get; set; }
        //public string USER_CODE { get; set; }
    }


    public class StudentProfileInfoVM
    {

        public decimal STUDENT_ID { get; set; }
        public string STUDENT_CODE { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string SHIFT_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string GENDER_NAME { get; set; }
        public string GENDER_CODE { get; set; }
        public string BLOOD_GROUP_NAME { get; set; }
        public string BLOOD_GROUP_CODE { get; set; }
        public string RELIGION_NAME { get; set; }
        public string RELIGION_CODE { get; set; }
        public string NATIONALITY_NAME { get; set; }
        public string NATIONALITY_CODE { get; set; }
        public string CLASS_ROLL { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string STUDENT_NAME { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string GURDIAN_NAME { get; set; }
        public string GUARDIAN_CONTACT_NO { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string PRESENT_ADDR { get; set; }
        public string PERMANENT_ADDR { get; set; }
        public string REMARKS { get; set; }
        public string IMAGE_URL { get; set; }
    }

    public class StudentBasicInfo
    {
        public string CAMPUS_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string ORG_SHORT_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string SHIFT_NAME { get; set; }
        public string IMAGE_URL { get; set; }
        public string IMAGE_BYTE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
      
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public decimal TERM_ID { get; set; }
        public string TERM_DESCRIPTION { get; set; }
    }
    public class StudentTermInfo
    {
        public decimal TERM_ID { get; set; }
        public string TERM_DESCRIPTION { get; set; }
       
    }

      public class StudentFormStatusInfo
    {
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string SHIFT_NAME { get; set; }
 
        public string STUDENT_NAME { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string STATUS { get; set; }
        public string IMAGE_URL { get; set; }
        public string IMAGE_BYTE { get; set; }
    }
   
    public class StudentAttendanceStatus
    {
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string ATTENDANCE_STATUS { get; set; }
        public string ATTENDANCE_DATE { get; set; }

    }


    public class StudentAttendanceInfoParamDateWise
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
    }
    
    public class StudentDetailsReportParams
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string USER_CODE { get; set; }
    }

    public class StudentDetailsReportData
    {
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string ORG_SHORT_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string SECTION_CODE{ get; set; }
        public string SECTION_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string SHIFT_NAME { get; set; }
        public decimal STUDENT_ID { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string CLASS_ROLL { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string MOTHER_OCCUPATION_NAME { get; set; }
        public string FATHER_OCCUPATION_NAME { get; set; }
        public string FATHER_CONTACT_NO { get; set; }
        public string MOTHER_CONTACT_NO { get; set; }
        public string NATIONALITY_CODE { get; set; }
        public string NATIONALITY_NAME { get; set; }  
        public string GENDER_CODE { get; set; }
        public string GENDER_NAME { get; set; }
        public string RELIGION_CODE { get; set; }
        public string RELIGION_NAME { get; set; }
        public string PRESENT_ADDR { get; set; }
        public string MARITIAL_STATUS { get; set; }
        public string MARITAL_STATUS { get; set; }
        public string PERMANENT_ADDR { get; set; }
    }
    
    public class StudentListReportData 
    {
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string CUR_SESSION_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string ORG_SHORT_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string SECTION_CODE{ get; set; }
        public string SECTION_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string SHIFT_NAME { get; set; }
        public decimal STUDENT_ID { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string CLASS_ROLL { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string FATHERS_NAME { get; set; }
     
        public string FATHER_CONTACT_NO { get; set; }
      
    }
    
    public class DateWiseAdmissionStudentList
    {
      
        public string CLASS_NAME { get; set; }
        public string SECTION_CODE{ get; set; }
        public string SECTION_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string SHIFT_NAME { get; set; }
        public decimal STUDENT_ID { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string CLASS_ROLL { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string FATHERS_NAME { get; set; }
        public string FATHER_CONTACT_NO { get; set; }
      
    }
    
    public class DateWiseAdmissionStudentParams
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
      
    }

    public class OptSubWiseStudentListParams
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string SUBJECT_CODE { get; set; }
    }
    public class OptSubWiseStudentData
    {
       
        public decimal STUDENT_ID { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string CLASS_ROLL { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string DATE_OF_BIRTH { get; set; }
      

    }

}
