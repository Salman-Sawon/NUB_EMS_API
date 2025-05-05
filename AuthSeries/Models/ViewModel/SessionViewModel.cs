using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class SessionViewModel
    {
        public decimal SESSION_ID { get; set; }
        public string SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }                
        public string START_DATE { get; set; }                
        public string END_DATE { get; set; }                
    }
    
    
    public class StdWiseSession
    {
     
        public string SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }                
    }
}
