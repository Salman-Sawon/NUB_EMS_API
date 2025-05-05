using System.Collections.Generic;

namespace StudentWebAPI.Models.ViewModel.Report
{
    public class PassFailedListPrams
    {

        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public decimal TERM_ID { get; set; }

        public string STATUS { get; set; }







    }



    public class SubjectWiseFailedListPrams
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
        public decimal TERM_ID { get; set; }
       // public List<string> SUBJECT_CODE { get; set; }
        public string SUBJECT_CODE { get; set; }







    }





    public class ParameterWiseSubFailedListPrams
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
        public decimal TERM_ID { get; set; }
        // public List<string> SUBJECT_CODE { get; set; }
        public decimal NUM_OF_SUB { get; set; }







    }















}
