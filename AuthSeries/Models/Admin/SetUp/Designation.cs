using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Admin.SetUp
{
    public class Designation
    {
        public decimal DESIGNATION_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string DESIGNATION_CODE { get; set; }
        public string DESIGNATION_NAME { get; set; }
        public string USER_NAME { get; set; }
        public decimal RowStatus { get; set; }
    }
}
