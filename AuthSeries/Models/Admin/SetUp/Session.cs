using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Admin.SetUp
{
    public class Session
    {
        public string Session_Id { get; set; }
        public string Org_Code { get; set; }
        public string Session_Code { get; set; }
        public string Session_Name { get; set; }
        public string Session_Name_Bangla { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public List<decimal> Session_Dtl_Id { get; set; }
        public List<string> Bill_Month { get; set; }
        public List<string> DTL_START_DATE { get; set; }
        public List<string> DTL_END_DATE { get; set; }
        public List<string> Bill_Date { get; set; }
        public List<string> Due_Date { get; set; }
        public List<decimal> Row_Status { get; set; }
        public string User_Code { get; set; }
    }
}
