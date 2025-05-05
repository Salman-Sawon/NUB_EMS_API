using System;
using System.Collections.Generic;

#nullable disable

namespace fileManager.Models
{
    public partial class FileData
    {
        //public int Id { get; set; }
        //public string FileName { get; set; }
        //public string FileExtension { get; set; }
        //public string MimeType { get; set; }
        //public string FilePath { get; set; }
        public decimal FILE_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_TITLE { get; set; }
        public string FILE_DESC { get; set; }
        public string FILE_EXTENTION { get; set; }
        public string MIM_TYPE { get; set; }
        public string FILE_PATH { get; set; }
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
        public string FILE_URL { get; set; }
        public decimal RowStatus { get; set; }
    }

    public partial class FileDelete
    {
       
      
        public decimal FILE_ID { get; set; }
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
        public string SUBJECT_CODE { get; set; }
        public string ASSIGNMENT_OR_LECTURE_CODE { get; set; }
        public string GOOGLE_FILE_ID { get; set; }
        public decimal RowStatus { get; set; }
    }
    public class GetDTypeWiseFile
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public decimal SUB_MAP_ID { get; set; }
        public string D_TYPE_CODE { get; set; }
        // public DateTime ATTENDANCE_DATE { get; set; }
        public string USER_CODE { get; set; }
    }

    public class StdUplodedFilesInfo
    {
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public decimal SUB_MAP_ID { get; set; }
        // public DateTime ATTENDANCE_DATE { get; set; }
        public string USER_CODE { get; set; }
        public decimal PARENT_FILE_ID { get; set; }
    }
}
