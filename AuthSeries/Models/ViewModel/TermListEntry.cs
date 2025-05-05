using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class TermListEntry
    {
        public string ORG_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public List<string> TERM_DESCRIPTION { get; set; }
        public List<string>? TERM_DESCRIPTION_BANGLA { get; set; }
        public List<DateTime> START_DATE { get; set; }
        public List<DateTime> END_DATE { get; set; }
        public List<decimal> SERIAL { get; set; }
    }
}
