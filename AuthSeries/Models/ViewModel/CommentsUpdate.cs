using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class CommentsUpdate
    {
        public string ORG_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public decimal TERM_ID { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public List<string> editorComment { get; set; }
        public List<string> STUDENT_CODE { get; set; }


    }
}
