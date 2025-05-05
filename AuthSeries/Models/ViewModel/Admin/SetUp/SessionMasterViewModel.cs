using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Admin.SetUp
{
    public class SessionMasterViewModel
    {
        public decimal SESSION_ID { get; set; }
        public string SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }
        public string SESSION_NAME_BANGLA { get; set; }
        public string ORG_CODE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public List<decimal> SESSION_DTL_ID { get; set; }
        public List<string> BILL_MONTH { get; set; }
        public List<string> DTL_START_DATE { get; set; }
        public List<string> DTL_END_DATE { get; set; }
        public List<string> BILL_DATE { get; set; }
        public List<string> DUE_DATE { get; set; }
    }
}
