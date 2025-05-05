using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class AdminRoleMst
    {
        public List<decimal> ROLE_ID { get; set; }
        public List<string> ROLE_DESCR { get; set; }
        public List<decimal> RowStatus { get; set; }
        public string User_Name { get; set; }
        
    }

    public class AdminRoleSingle
    {
        public decimal ROLE_ID { get; set; }
        public string ROLE_DESCR { get; set; }
        public decimal RowStatus { get; set; }
        public string User_Name { get; set; }

    }
}
