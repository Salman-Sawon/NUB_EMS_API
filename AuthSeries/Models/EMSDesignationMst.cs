using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class EMSDesignationMst
    {
        public decimal DESIGNATION_ID { get; set; }
        public string DESIGNATION_CODE { get; set; }
        public string ORG_CODE { get; set; }
        public string DESIGNATION_NAME { get; set; }

        public string STATUS { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }

        //[Column("DESIGNATION_ID")]
        //public decimal DesignationId { get; set; }
        //[Column("DESIGNATION_CODE")]
        //public string DesignationCode { get; set; }
        //[Column("ORG_CODE")]
        //public string OrganizationCode { get; set; }
        //[Column("DESIGNATION_NAME")]
        //public string DesignationName { get; set; }

        //[Column("STATUS")]
        //[StringLength(2)]
        //public string Status { get; set; }
        //[Column("CREATE_DATE")]
        //[DataType(DataType.Date)]
        //public DateTime CreateDate { get; set; }
        //[Column("CREATE_USER")]
        //public string CreateUser { get; set; }
        //[Column("UPDATE_DATE")]
        //[DataType(DataType.Date)]
        //public DateTime UpdateDate { get; set; }
        //[Column("UPDATE_USER")]
        //public string UpdateUser { get; set; }
    }
}
