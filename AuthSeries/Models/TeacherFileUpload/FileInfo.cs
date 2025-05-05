using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.TeacherFileUpload
{
    public class FileInfo
    {
            public decimal FILE_ID { get; set; }
            public string FILE_NAME { get; set; }
            public string FILE_TITLE { get; set; }
            public string FILE_DESC { get; set; }
            public string FILE_EXTENTION { get; set; }
            public string MIM_TYPE { get; set; }
            public string ORG_CODE { get; set; }
            public string CAMPUS_CODE { get; set; }
            public string CLASS_CODE { get; set; }
            public string SECTION_CODE { get; set; }
            public string GROUP_CODE { get; set; }
            public string SESSION_CODE { get; set; }
            public string VERSION_CODE { get; set; }
            public string YEAR_CODE { get; set; }
            public string SEMESTER_CODE { get; set; }
            public string SHIFT_CODE { get; set; }
            public string USER_CODE { get; set; }
            public decimal RowStatus { get; set; }

    }
}
