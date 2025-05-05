using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Dashboard
{
    public class DashboardBillColGenList
    {

        public string BILL_YEAR_MONTH { get; set; }
        public string MONTH_NAME { get; set; }
        public string BILL_TYPE { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }

    }
}
