using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Student
{
    public class StdFingerAttendenceEntry
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public List<string> STD_ATT_NO { get; set; }
        public List<string> STD_ATT_DATE_TIME { get; set; }
        public List<string> STD_ATT_STATUS { get; set; }
        public string USER_NAME { get; set; }
    }
}
