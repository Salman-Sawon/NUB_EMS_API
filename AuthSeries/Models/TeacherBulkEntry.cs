using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class TeacherBulkEntry
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public List<string> TEACHER_NAME { get; set; }
        public List<string> FATHERS_NAME { get; set; }
        public List<DateTime> JOINING_DATE { get; set; }      
        public List<string> SMS_MOBILE_NUM { get; set; }     
        public string USER_NAME { get; set; }
    }
    
    public class QuickTeacherEntry
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public List<string> TEACHER_NAME { get; set; }
        public List<string> FATHERS_NAME { get; set; }
        public List<string> JOINING_DATE { get; set; }      
        public List<string> SMS_MOBILE_NUM { get; set; }     
        public string USER_NAME { get; set; }
    }

    public class ActiveTeacherData
    {
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public string JOINING_DATE { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string DATE_OF_BIRTH { get; set; }



    }

    public class ResultSubjectListViewModel
    {

        public Int16 SUBJECT_ID { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string SUBJECT_NAME_BANGLA { get; set; }
        public string SUBJECT_SHORT_NAME { get; set; }
        public string SUBJECT_PART { get; set; }
        public string SUBJECT_DEFAULT_TYPE { get; set; }
        public string SUJBECT_IS_PRACTICAL { get; set; }
        public Int16 SUJBECT_SRLNO { get; set; }
    }

    public class SubjectInfoMst
    {
        //  public List<decimal> SUBJECT_ID { get; set; }
        public List<string> SUBJECT_CODE { get; set; }
        public List<string> SUBJECT_NAME { get; set; }
        public List<string> SUBJECT_NAME_BANGLA { get; set; }
        public List<string> SUBJECT_SHORT_NAME { get; set; }
        public List<string> SUBJECT_PART { get; set; }
        public List<string> SUBJECT_DEFAULT_TYPE { get; set; }
        public List<string> SUJBECT_IS_PRACTICAL { get; set; }
        public List<decimal> SUJBECT_SRLNO { get; set; }
        //public List<decimal> RowStatus { get; set; }
        public string ORG_CODE { get; set; }
        public string User_Name { get; set; }
    }
}

