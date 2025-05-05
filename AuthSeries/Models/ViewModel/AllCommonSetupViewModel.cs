using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class AllCommonSetupViewModel
    {
        public Int32 COMMON_ID { get; set; }
        public Int32 TABLE_ID { get; set; }
        public string ORAGANIZATION_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string VARCHAR_1 { get; set; }
        public string VARCHAR_2 { get; set; }
        public string VARCHAR_3 { get; set; }
        public string VARCHAR_4 { get; set; }
        public string VARCHAR_5 { get; set; }
        public string VARCHAR_6 { get; set; }
        public string VARCHAR_7 { get; set; }
        public string CLASS_NAME { get; set; }
        public string YEAR_NAME { get; set; }
        public Int64 NUMBER_1 { get; set; }
        public Int64 NUMBER_2 { get; set; }
        public Int64 NUMBER_3 { get; set; }
        public Int64 NUMBER_4 { get; set; }
        public Int64 NUMBER_5 { get; set; }
        public Int64 NUMBER_6 { get; set; }
        public Int64 NUMBER_7 { get; set; }
        public DateTime DATE_1 { get; set; }
        public DateTime DATE_2 { get; set; }
        public DateTime DATE_3 { get; set; }
        public DateTime DATE_4 { get; set; }
        public DateTime DATE_5 { get; set; }
        public DateTime DATE_6 { get; set; }
    }


    public class AllCommonSetupViewModelNew
    {
        public string VALUE_1 { get; set; }
        public string VALUE_2 { get; set; }
        public string VALUE_3 { get; set; }
        public string VALUE_4 { get; set; }
        public string VALUE_5 { get; set; }
        public string VALUE_6 { get; set; }
        public string VALUE_7 { get; set; }
        public string VALUE_8 { get; set; }
        public string VALUE_9 { get; set; }
        public string VALUE_10 { get; set; }
        public string VALUE_KEY { get; set; }
        public decimal ID { get; set; }
    }
}
