using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class TeacherPreAca
    {
        public List<decimal> TEA_PREV_ACAD_INFO_ID { get; set; }
        public List<string> ORG_CODE { get; set; }
        public List<string> TEACHER_CODE { get; set; }
        public List<string> BOARD_UNIV_CODE { get; set; }
        public List<string> RESULT { get; set; }
        public List<string> ROLL_NUM { get; set; }
        public List<string> REG_NUM { get; set; }
        public List<string> PASS_SESSION { get; set; }
        public List<string> PASS_YEAR { get; set; }
        public List<string> COURSE_DUR { get; set; }
        public List<decimal> TOTAL_CREDIT { get; set; }
        public List<string> INSTITUTE { get; set; }
        public List<string> EXAM_NAME { get; set; }
        public List<string> LAST_EDUCATIONAL_QUALIFICATION { get; set; }
        public List<decimal> RowStatus { get; set; }
        public string User_Name { get; set; }
    }
}
