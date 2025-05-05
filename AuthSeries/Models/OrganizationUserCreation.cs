using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class OrganizationUserCreation
    {
        public decimal USER_ID { get; set; }
        public string USER_CODE { get; set; }
        public string USER_NAME { get; set; }      
        public string MOBILE_NO { get; set; }
        public string EMAIL { get; set; }
        public decimal ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public decimal USER_TYPE_ID { get; set; }
        public string USER_TYPE_DESCR { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }

        public string USER_PASSWORD { get; set; }
        public decimal RowStatus { get; set; }
        public string CREATE_USER { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }

        [NotMapped]
        public string Token { get; set; }
    }


    public class OrganizationUserCreationGRID
    {
        public decimal USER_ID { get; set; }
        public string USER_CODE { get; set; }
        public string USER_NAME { get; set; }
        public string MOBILE_NO { get; set; }
        public string EMAIL { get; set; }
        public decimal ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public decimal USER_TYPE_ID { get; set; }
        public string USER_TYPE_DESCR { get; set; }
        // public string FULL_NAME { get; set; }       
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }      
        //public string USER_PASSWORD { get; set; }
        public string DESIG_CODE { get; set; }
        public string DESIGNATION_NAME { get; set; }

    }

    public class OrgUserCreation
    {
        public decimal USER_ID { get; set; }
        public string USER_CODE { get; set; }
        public string USER_NAME { get; set; }
        public string EMAIL { get; set; }
        public string ORG_CODE { get; set; }
        public string MOBILE_NO { get; set; }
        public string USER_PASSWORD { get; set; }
        public decimal ROLE_ID { get; set; }
        public decimal USER_TYPE_ID { get; set; }

        public int RowStatus { get; set; }
        public string CREATE_USER { get; set; }
    }


    }
