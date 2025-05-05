using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Report
{
    public class StudentTranscriptReportViewModel
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
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string SHORT_SUBJECT_NAME { get; set; }
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public string EXAM_CODE { get; set; }
        public string EXAM_NAME { get; set; }
        public string EXAM_DTL_CODE { get; set; }
        public string SHORT_NAME { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public decimal MARK { get; set; }
        public string GRADE { get; set; }
        public decimal GPA { get; set; }
        public decimal HIGHEST_MARK { get; set; }
        public decimal CGPA_W4TH_SUB { get; set; }
        public string GRADE_W4TH_SUB { get; set; }
        public string FINAL_COMMENTS { get; set; }
        public string GRADE_COMMENTS { get; set; }
    }
}
