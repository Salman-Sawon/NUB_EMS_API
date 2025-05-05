using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class RemarkViewModel
    {  
        public decimal EXAM_RESULT_MST_ID { get; set; }
        public decimal EXAM_RESULT_SUB_REL_ID { get; set; }
        public decimal EXAM_RESULT_DIST_MST_ID { get; set; }
        public string REMARKS { get; set; }
    }
}
