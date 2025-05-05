using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class EMSOrganizationMst
    {
        public decimal ORG_ID { get; set; }

        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string ORG_IMAGE { get; set; }
        public string REG_NUM { get; set; }
        public DateTime REG_DATE { get; set; }
        public decimal ORG_TYPE_ID { get; set; }
        public string MOBILE { get; set; }
        public string MOBILE_WALLET_NO { get; set; }
        public string CONT_MOBILE1 { get; set; }
        public string CONT_PERSION1 { get; set; }
        public string CONT_MOBILE2 { get; set; }
        public string CONT_PERSION2 { get; set; }
        public string ADDR1 { get; set; }
        public string ADDR2 { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string DIV_CODE { get; set; }
        public string DIST_CODE { get; set; }
        public string THANA_CODE { get; set; }
        public string ZIP_CODE { get; set; }
        public string EMAIL { get; set; }
        public string WEB_ADDR { get; set; }

        public string STATUS { get; set; }
        public DateTime CreatCREATE_DATEeDate { get; set; }
        public string CREATE_USER { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }
        //[Column("ORG_ID")]
        //public decimal OrganizationId { get; set; }

        //[Column("ORG_CODE")]
        //public string OrganizationCode { get; set; }
        //[Column("ORG_NAME")]
        //public string OrganizationName { get; set; }
        //[Column("ORG_IMAGE")]
        //public string OrganizationImage { get; set; }
        //[Column("REG_NUM")]
        //public string RegistrationNumber { get; set; }
        //[Column("REG_DATE")]
        //public DateTime RegistrationDate { get; set; }
        //[Column("ORG_TYPE_ID")]
        //public decimal OrganizationTypeId { get; set; }
        //[Column("MOBILE")]
        //public string Mobile { get; set; }
        //[Column("MOBILE_WALLET_NO")]
        //public string MobileWalletNo { get; set; }
        //[Column("CONT_MOBILE1")]
        //public string ContactMobile1 { get; set; }
        //[Column("CONT_PERSION1")]
        //public string ContactPerson1 { get; set; }
        //[Column("CONT_MOBILE2")]
        //public string ContactMobile2 { get; set; }
        //[Column("CONT_PERSION2")]
        //public string ContactPerson2 { get; set; }
        //[Column("ADDR1")]
        //public string Address1 { get; set; }
        //[Column("ADDR2")]
        //public string Address2 { get; set; }
        //[Column("COUNTRY_CODE")]
        //public string CountryCode { get; set; }
        //[Column("DIV_CODE")]
        //public string DivisionCode { get; set; }
        //[Column("DIST_CODE")]
        //public string DistrictCode { get; set; }
        //[Column("THANA_CODE")]
        //public string ThanaCode { get; set; }
        //[Column("ZIP_CODE")]
        //public string ZipCode { get; set; }
        //[Column("EMAIL")]
        //public string Email { get; set; }
        //[Column("WEB_ADDR")]
        //public string WebAddress { get; set; }

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
