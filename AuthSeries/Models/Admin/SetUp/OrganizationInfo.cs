using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Admin.SetUp
{
    public class OrganizationInfo
    {
        public IFormFile MyFile { get; set; }
        public string FILE_URL { get; set; }
        public decimal ORG_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string ORG_NAME_BANGLA { get; set; }
        public string ORG_IMAGE { get; set; }
        public string REG_NUM { get; set; }
        public string REG_DATE { get; set; }
        public string ORG_TYPE_ID { get; set; }
        public string MOBILE { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string DIV_CODE { get; set; }
        public string DIST_CODE { get; set; }
        public string THANA_CODE { get; set; }
        public string MOBILE_WALLET_NO { get; set; }
        public string CONT_MOBILE1 { get; set; }
        public string CONT_PERSION1 { get; set; }
        public string ADDR1 { get; set; }
        public string CONT_MOBILE2 { get; set; }
        public string CONT_PERSION2 { get; set; }
        public string ADDR2 { get; set; }
        public string ZIP_CODE { get; set; }
        public string EMAIL { get; set; }
        public string WEB_ADDR { get; set; }
        public string USER_NAME { get; set; }
        public decimal RowStatus { get; set; }
        public string SHORT_CODE { get; set; }
    }
}
