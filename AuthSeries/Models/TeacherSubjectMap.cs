using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class TeacherSubjectMap
    {
        public string Sub_Map_Id { get; set; }
        public string Org_Code { get; set; }
        public string Teacher_Code { get; set; }
        public string Campus_Code { get; set; }
        public string Class_Code { get; set; }
        public string Group_Code { get; set; }
        public string Section_Code { get; set; }
        public string Shift_Code { get; set; }
        public string Version_Code { get; set; }
        public string Session_Code { get; set; }
        public string Subject_Code { get; set; }
        public string User_Name { get; set; }
        public decimal Row_Status { get; set; }
    }
}
