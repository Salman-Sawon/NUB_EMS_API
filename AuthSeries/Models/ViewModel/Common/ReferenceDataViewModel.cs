using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Common
{
    public class ReferenceDataViewModel
    {
        public string KEY { get; set; }
        public string ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
    }
    public class CurSessionVM
    {
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
       // public string ORG_IMAGE_URL { get; set; }

        
    }
}
