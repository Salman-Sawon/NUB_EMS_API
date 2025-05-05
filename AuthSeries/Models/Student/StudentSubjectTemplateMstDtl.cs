using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Student
{
    public class StudentSubjectTemplateMstDtl
    {
        public decimal SUB_TMPL_MST_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string SUB_TMPL_NAME { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_CODE { get; set; }
        public string GROUP_NAME { get; set; }
        public string SECTION_CODE { get; set; }
        public string SECTION_NAME { get; set; }
        public string SHIFT_CODE { get; set; }
        public string SHIFT_NAME { get; set; }
        public string VERSION_CODE { get; set; }
        public string VERSION_NAME { get; set; }
        public string SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }
       

        public List<decimal> SUB_TMPL_DTL_ID { get; set; }
        public List<string> SUBJECT_CODE { get; set; }
        public List<string> SUBJECT_NAME { get; set; }
        public List<string> IS_4TH_SUBJECT { get; set; }
        public List<decimal> RowStatus { get; set; }
        public string User_Name { get; set; }
        
    }
}
