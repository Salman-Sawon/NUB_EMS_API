using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Dashboard
{
    public class DashboardNoticeList
    {

        public decimal NOTICE_ID { get; set; }
        public decimal NOTICE_DOCUMENT_TYPE_ID { get; set; }
        public string NOTICE_NAME { get; set; }
        public string NOTICE_DESC { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public string CREATE_BY { get; set; }
        public string DATEE { get; set; }
        public string time_ago { get; set; }






    }
}
