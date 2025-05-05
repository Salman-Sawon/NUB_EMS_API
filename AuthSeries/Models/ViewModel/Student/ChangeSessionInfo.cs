using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Student
{
    public class ChangeSessionInfo
    {
        public List<string> STUDENT_CODE { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string classCode { get; set; }
        public string groupCode { get; set; }
        public string shiftCode { get; set; }
        public string versionCode { get; set; }
        public string sectionCode { get; set; }
        public string yearCode { get; set; }
        public string semesterCode { get; set; }
        public string startSessionCode { get; set; }
        public string currentSessionCode { get; set; }
        public string newSessionCode { get; set; }
        public string newYearCode { get; set; }
        public string newSemesterCode { get; set; }
        public string USER_NAME { get; set; }

    }
}
