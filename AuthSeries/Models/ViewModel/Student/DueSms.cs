using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Student
{
    public class DueSms
    {

        public List<string> STUDENT_CODE { get; set; }
        public List<string> SMS_MOBILE_NUM { get; set; }
        public List<string> SMS_CONTENT { get; set; }
        public string User_Name { get; set; }
        public string SMS_GATEWAY_CODE { get; set; }
        
    }
}
