using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class EMSCampusMst
    {
        public decimal CAMPUS_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string CAMPUS_ADDRESS { get; set; }
        public string CAMPUS_TYPE { get; set; }
        public string CAMPUS_HEAD { get; set; }
        public string CAMPUS_HEAD_NAME { get; set; }
        public string DESIGNATION { get; set; }
        public string PHONE_NUM { get; set; }
        public string STATUS { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public string CREATE_BY { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }
    }
}
