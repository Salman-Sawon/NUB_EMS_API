using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class SectionListByRoutine
    {

        public string SECTION_CODE { get; set; }
        public string SECTION_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }


    }


    public class YearListByRoutine
    {

        public string YEAR_CODE { get; set; }
        public string YEAR_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }


    }

    public class SemesterListByRoutine
    {

        public string SEMESTER_CODE { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }


    }


    

 public class Routineparpm
    {

        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public List<string> CLASS_CODE { get; set; }
        public List<string> GROUP_CODE { get; set; }
        public List<string> VERSION_CODE { get; set; }
        public List<string> SESSION_CODE { get; set; }
        public List<string> SECTION_CODE { get; set; }
        public List<string> YEAR_CODE { get; set; }
        public List<string> SEMESTER_CODE { get; set; }
        public List<string> SHIFT_CODE { get; set; }
       


    }


}
