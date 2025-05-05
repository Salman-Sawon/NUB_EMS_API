using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class StudentSiblingInfoMst
    {
       // public List<decimal> SIBLING_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string STUDENT_CODE { get; set; }
        public List<string> SIBLING_STUDENT_CODE { get; set; }
        public List<string> SIBLING_NAME { get; set; }
        public List<string> RELATION { get; set; }
        public List<string> EDUCATION_INSTITUTE { get; set; }
        //public List<decimal> RowStatus { get; set; }
        public string User_Name { get; set; }

    }
}
