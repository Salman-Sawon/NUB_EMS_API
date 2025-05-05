using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class SmsConfigGridList
    {

        public decimal ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string SMS_STATUS { get; set; }
        public string SMS_TYPE_NAME { get; set; }
        public decimal SMS_TYPE_ID { get; set; }

    }
    
    public class SmsGatewayConfigGridList
    {
        public decimal ID { get; set; }
        public string SMS_GATEWAY { get; set; }
        public string IS_DEFAULT { get; set; }



    }
    
    public class SmsGatewayConfigList
    {
    
        public string SMS_GATEWAY { get; set; }
        public string SMS_GATEWAY_CODE { get; set; }
        public string IS_DEFAULT { get; set; }

       

    }





    public class LessonPlanHomeworkList
    {
        public decimal LESSON_PLAN_MAP_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public decimal TERM_ID { get; set; }
        public string TERM_NAME { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public string PLAN_DATE { get; set; }  // Formatted as "DD/MM/YYYY"
        public string DAY { get; set; }        // Day name (e.g., "Monday")
        public string FIRST_DATE { get; set; }
        public string LAST_DATE { get; set; }
        public string SUB_MATTER { get; set; }
        public string LESSON_AND_ACTIVITY { get; set; }
        public string EDU_AID { get; set; }
        public string HOME_WORK { get; set; }
        public string REMARKS { get; set; }
    }






    public class LessonHomeWorkMessage
    {
        public string SMS_MOBILE_NUM { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string MESSAGE { get; set; }
        
    }
    
    public class ExamRoutineMessage
    {
        public string SMS_MOBILE_NUM { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string MESSAGE { get; set; }
        
    }
   
    public class ExamRoutineNotification
    {
      
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string NOTIFICATION_TOKEN { get; set; }
        public string MESSAGE { get; set; }
        public int SEND_COUNT { get; set; }

    }



}
