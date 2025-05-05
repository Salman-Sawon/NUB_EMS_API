using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Global
{
    public class SectionModel
    {
        public decimal SECTION_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string SECTION_CODE { get; set; }
        public string SECTION_NAME { get; set; }
        public string userCode { get; set; }

    }
}
