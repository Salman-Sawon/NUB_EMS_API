using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class TermListGrid
    {
        public string TERM_DESCRIPTION { get; set; }
        public string TERM_DESCRIPTION_BANGLA { get; set; }
        public decimal SERIAL { get; set; }
        public decimal TERM_ID { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime END_DATE { get; set; }


    }
}
