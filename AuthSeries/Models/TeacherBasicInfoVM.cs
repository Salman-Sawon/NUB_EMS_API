using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class TeacherBasicInfoVM
    {
        public string TEACHER_NAME { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public DateTime JOINING_DATE { get; set; }
        public DateTime DATE_OF_BIRTH { get; set; }
        public string PRESENT_ADDR { get; set; }
        public string TEACHER_IMAGE_URL { get; set; }
        public string TEACHER_SIGNATURE_URL { get; set; }
    }
}
