using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Admin.SetUp
{
    public class SessionDtlViewModel
    {
        public decimal SESSION_DTL_ID { get; set; }
        public decimal SESSION_ID { get; set; }
        public string SESSION_CODE { get; set; }
        public string BILL_MONTH { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string BILL_DATE { get; set; }
        public string DUE_DATE { get; set; }
    }
}

// SESSION_DTL_ID, SESSION_ID, SESSION_CODE, SESSION_NAME, ORG_CODE, ORG_NAME, BILL_MONTH, START_DATE, END_DATE, BILL_DATE, DUE_DATE
