using System;

namespace StudentWebAPI.Models.ViewModel.Report
{
    public class StudentPassFailedList
    {



        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string CLASS_ROLL { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string TERM_NAME { get; set; }
        public float TOTAL_MARKS { get; set; }
        public string LETTER_GRADE { get; set; }
        public float GRADE_POINT_AVERAGE { get; set; }
        public decimal TOTAL_FAIL_SUB { get; set; }
        public string FAIL_SUB_DTL { get; set; }







    }
    public class SubjectWiseFailedList
    {



        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string CLASS_ROLL { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string TERM_NAME { get; set; }








    }



    public class ParameterWiseSubjectFailedList
    {



        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string CLASS_ROLL { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_NAME { get; set; }
        public string VERSION_NAME { get; set; }
        public string SESSION_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string TERM_NAME { get; set; }
        public string SUBJECTS { get; set; }








    }


























}
