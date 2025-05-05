using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class ParameterData
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
        public string SESSION_CODE { get; set; }
        public string EXAM_CODE { get; set; }
        public string STUDENT_CODE { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string TEACHER_CODE { get; set; }
        public string EXAM_DTL_CODE { get; set; }
        public string USER_CODE { get; set; }
        public string User_Name { get; set; }
        public string User_Id { get; set; }
  
           
          
    }
    
    public class DueListParameterData
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
       
         public string USER_CODE { get; set; }
      
     
    }



    public class CollectionParameterData
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
         public DateTime FROM_DATE { get; set; }
         public DateTime TO_DATE { get; set; }
      
     
    }




    public class TeacheraAttenSumaryParameterData
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string MONTH { get; set; }
        public string YEAR { get; set; }
       


    }


    public class AllTeacheraAttenParameterData
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string FROM_DATE { get; set; }
        public string TO_DATE { get; set; }



    }

    public class TrandcriptParameterData
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
        public string TERM_ID { get; set; }
        public string USER_CODE { get; set; }
      


    }


}
