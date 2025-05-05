using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Report
{
    public class StudentTabulationSheetReport
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
        public string SECTION_NAME { get; set; }
        public string SHIFT_CODE { get; set; }
        public string SHIFT_NAME { get; set; }
        public string VERSION_CODE { get; set; }
        public string VERSION_NAME { get; set; }
        public string SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }
        public List<string> SUBJECT_CODE { get; set; }
        public List<string> SUBJECT_NAME { get; set; }
        public List<string> SHORT_SUBJECT_NAME { get; set; }
        public List<string> TEACHER_CODE { get; set; }
        public List<string> TEACHER_NAME { get; set; }
        public string EXAM_CODE { get; set; }
        public string EXAM_NAME { get; set; }
        public List<string> EXAM_DTL_CODE { get; set; }
        public List<string> SHORT_NAME { get; set; }
        public List<string> STUDENT_CODE { get; set; }
        public List<string> STUDENT_NAME { get; set; }
        public List<decimal> MARK { get; set; }
        public List<string> GRADE { get; set; }
        public List<string> GPA { get; set; }
        public List<decimal> HIGHEST_MARK { get; set; }
        public List<decimal> CGPA_W4TH_SUB { get; set; }
        public List<string> GRADE_W4TH_SUB { get; set; }
    }
}
