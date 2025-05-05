using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class AdminUserMst
    {

        public decimal USER_ID { get; set; }

        public string USER_CODE { get; set; }

        public string USER_NAME { get; set; }

        public string EMAIL { get; set; }

        public string MOBILE_NO { get; set; }

        public string USER_PASSWORD { get; set; }

        public decimal ROLE_ID { get; set; }

        public decimal USER_TYPE_ID { get; set; }


        public string USER_TYPE_DESC { get; set; }

        public string ORG_CODE { get; set; }

        public string DESIG_CODE { get; set; }

        public int rowStatus { get; set; }

      //  public DateTime CREATE_DATE { get; set; }

        public string CREATE_USER { get; set; }

       // public DateTime UPDATE_DATE { get; set; }

       // public string UPDATE_USER { get; set; }

        public string STATUS { get; set; }

        [NotMapped]
        public string Token { get; set; }

        [NotMapped]
        public string ORG_NAME { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public decimal SENIORITY_LEVEL_ID { get; set; }

    }
}
