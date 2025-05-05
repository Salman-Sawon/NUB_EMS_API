using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class SmsConfigInfo
    {

        public decimal SMS_CONFIG_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public decimal SMS_TYPE_ID { get; set; }
        public string STATUS { get; set; }
        public decimal RowStatus { get; set; }




    }
    
    public class SmsGateWayConfigInfo
    {

        public decimal SMS_GATEWAY_CONFIG_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string SMS_GATEWAY { get; set; }
        public string STATUS { get; set; }
        public decimal RowStatus { get; set; }




    }
    
    
 



    public class multipleSmsInfoprams
    {


        //public string ORG_CODE { get; set; }
        //public string CAMPUS_CODE { get; set; }
        //public string CLASS_CODE { get; set; }
        //public string SECTION_CODE { get; set; }
        //public string GROUP_CODE { get; set; }
        //public string SESSION_CODE { get; set; }
        //public string VERSION_CODE { get; set; }
        //public string YEAR_CODE { get; set; }
        //public string SEMESTER_CODE { get; set; }
        //public string SHIFT_CODE { get; set; }
        //public string SMS_CONTENT { get; set; }

        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public List<string> CLASS_CODE { get; set; }
        public List<string> SECTION_CODE { get; set; }
        public List<string> GROUP_CODE { get; set; }
        public List<string> SESSION_CODE { get; set; }
        public List<string> VERSION_CODE { get; set; }
        public List<string> YEAR_CODE { get; set; }
        public List<string> SEMESTER_CODE { get; set; }
        public List<string> SHIFT_CODE { get; set; }
        public string SMS_CONTENT { get; set; }
        public string USER_NAME { get; set; }



    }








    public class SmsContentInfo
    {

        public decimal SMS_CONTENT_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string SMS_KEY { get; set; }
        public string SMS_VALUE { get; set; }
        public decimal RowStatus { get; set; }
        public string USER_NAME { get; set; }




    }
    
    
    public class SmsContentGridList
    {
        public decimal ID { get; set; }
        public string KEY { get; set; }
        public string VALUE { get; set; }
     

    }
    
 



}
