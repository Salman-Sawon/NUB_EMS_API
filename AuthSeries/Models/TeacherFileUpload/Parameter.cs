using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.TeacherFileUpload
{
    public class Parameter
    {
        public decimal TERM_ID { get; set; }
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
        public string SUBJECT_CODE { get; set; }
        public string ASSIGNMENT_OR_LECTURE_CODE { get; set; }
    }




    public class SampleFileInfo
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public decimal BATCH_ID { get; set; }
        public string BATCH_NAME { get; set; }
        public int TERM_ID { get; set; }
        public string TERM_NAME { get; set; }

    }
}
