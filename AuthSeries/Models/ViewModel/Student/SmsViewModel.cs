using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Student
{
    public class SmsViewModel
    {
        //public List<string> STUDENT_CODE { get; set; }
        public List<string> csms_id { get; set; }
        public string sms { get; set; }
    }

    public class SmsMultipleViewModel
    {
        public List<string> csms_id { get; set; }
        public List<string> sms { get; set; }
    }
}
