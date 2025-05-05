using DevExpress.XtraEditors.Filtering;
using StackExchange.Redis;

namespace StudentWebAPI.Models.ViewModel.Student
{
   


    public class StudentTransferDataListPrams
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string STUDENT_CODE { get; set; }
        public decimal TERM_ID { get; set; }
       




    }

    public class StudentTransferDataList
    {
        public string STUDENT_CODE { get; set; }
        public string FINAL_LETTER_GRADE { get; set; }
        public string TERM_DESCRIPTION { get; set; }
        public decimal GRADE_POINT_AVERAGE { get; set; }
        public string EXAM_YEAR { get; set; }
        public decimal LARGEST_GRADE_POINT { get; set; }
        public string STUDENT_NAME { get; set; }
        public string GENDER_NAME { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string PRESENT_ADDR { get; set; }
        public string GURDIAN_NAME { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string SHORT_CODE { get; set; }
        public string CLASS_ROLL { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }




    }

    public class StudentAdmitCardDataList
    {
        public string STUDENT_CODE { get; set; }
       
        public string STUDENT_NAME { get; set; }
        public string GENDER_NAME { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string STUDENT_IMAGE_URL { get; set; }
        public string STUDENT_IMAGE_BYTE { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string CLASS_ROLL { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string EXAM_DATE { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }




    }


    public class StudentCertificateDataList
    {
        public string STUDENT_CODE { get; set; }
        public string FINAL_LETTER_GRADE { get; set; }
        public string TERM_DESCRIPTION { get; set; }
        public decimal GRADE_POINT_AVERAGE { get; set; }
        public string EXAM_YEAR { get; set; }
        public decimal LARGEST_GRADE_POINT { get; set; }
        public string STUDENT_NAME { get; set; }
        public string GENDER_NAME { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string PRESENT_ADDR { get; set; }
        public string GURDIAN_NAME { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string SHORT_CODE { get; set; }
        public string CLASS_ROLL { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }




    }


    public class StudentTestimonialDataList
    {
        public string STUDENT_CODE { get; set; }
        public string FINAL_LETTER_GRADE { get; set; }
        public string TERM_DESCRIPTION { get; set; }
        public decimal GRADE_POINT_AVERAGE { get; set; }
        public string EXAM_YEAR { get; set; }
        public decimal LARGEST_GRADE_POINT { get; set; }
        public string STUDENT_NAME { get; set; }
        public string GENDER_NAME { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string PRESENT_ADDR { get; set; }
        public string GURDIAN_NAME { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string SHORT_CODE { get; set; }
        public string CLASS_ROLL { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }




    }



}

