using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class CommonTableInfoViewModel
    {
        public int TABLE_ID { get; set; }
        public string TABLE_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string CAPTION { get; set; }
        public string OTHER1 { get; set; }
        public string OTHER2 { get; set; }
        public string OTHER3 { get; set; }
    }


    public class setUpInfoViewModel
    {
        public decimal ID { get; set; }
        public string SET_UP_NAME { get; set; }
        
    }
}
