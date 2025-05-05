using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class HolidaysEntry
    {
        public string ORG_CODE { get; set; }    
        public List<string> HOLIDAY_TYPE { get; set; }
        public List<DateTime> HOLIDAY_DATE { get; set; }
        public List<string> SESSION_CODE { get; set; }
    }
}
