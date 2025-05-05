using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Student
{
    public class StudentSearchData
    {
        public string organizationCode { get; set; }
        public string campusCode { get; set; }
        public string M_WhereString { get; set; }
    }
}
