using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Email.Param
{
    public class BankAdviceParam
    {
        public string MONTH_END_DATE { get; set; }
        public decimal TYPE { get; set; }
        public decimal BONUS_TYPE_ID { get; set; }
    }
}
