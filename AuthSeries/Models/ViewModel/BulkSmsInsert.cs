using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class BulkSmsInsert
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public List<string> NAME { get; set; }
        public List<string> SMS_MOBILE_NUM { get; set; }
        public string SMS_CONTENT { get; set; }
        public string User_Name { get; set; }
        public string SMS_TYPE_CODE { get; set; }




    }
}
 