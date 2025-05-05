using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class AdminUserType
    {
        public List<decimal> USER_TYPE_ID { get; set; }
        public List<string> USER_TYPE_DESCR { get; set; }
        public List<decimal> RowStatus { get; set; }
        public string User_Name { get; set; }
    }

    public class UserTypeSingle
    {
        public decimal USER_TYPE_ID { get; set; }
        public string USER_TYPE_DESCR { get; set; }
        public decimal RowStatus { get; set; }
        public string User_Name { get; set; }

    }
}
