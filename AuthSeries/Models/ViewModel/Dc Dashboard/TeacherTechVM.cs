using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Dc_Dashboard
{
    public class TeacherTechVM
    {
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public string SMS_MOBILE_NUMBER { get; set; }
        public decimal AVG_PROGRESS_PER { get; set; }
    }
    public class TeacherTechDtlVM
    {
        public decimal SUB_MAP_ID { get; set; }
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public string CLASS_NAME { get; set; }
        public string SECTION_NAME { get; set; }
        public string SUBJECT_NAME { get; set; }
        public decimal PROGRESS_PER { get; set; }
    }

    public class TeacherTechSubDtlVM
    {
        public decimal CHAPTER_ID { get; set; }
        public string CHAPTER_NAME { get; set; }
        public string END_DATE { get; set; }
        public string IS_COMPLETE_STATUS { get; set; }
        public string REMARKS { get; set; }
    }
}
