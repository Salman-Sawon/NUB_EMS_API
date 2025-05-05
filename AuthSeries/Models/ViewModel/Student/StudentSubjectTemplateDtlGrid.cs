using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Student
{
    public class StudentSubjectTemplateDtlGrid
    {
        public decimal SUB_TMPL_MST_ID { get; set; }
        public string SUB_TMPL_NAME { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
      
        public decimal SUB_TMPL_DTL_ID { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string IS_4TH_SUBJECT { get; set; }

    }
}
