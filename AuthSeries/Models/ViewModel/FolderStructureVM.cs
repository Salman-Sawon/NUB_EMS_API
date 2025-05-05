using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class FolderStructureVM
    {
        public IFormFile MyFile { get; set; }
        public decimal FILE_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_TITLE { get; set; }
        public string FILE_DESC { get; set; }
        public string FILE_EXTENTION { get; set; }
        public string MIM_TYPE { get; set; }
        public string FILE_URL { get; set; }
        public string GOOGLE_FILE_ID { get; set; }    
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
        public string USER_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string CLASS_NAME { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string LECTURE_OR_ASSIGNMENT { get; set; }
        public string DUE_DATE { get; set; }
        public string DUE_TIME { get; set; }
        public decimal PARENT_FILE_ID { get; set; }
        public decimal RowStatus { get; set; }
        public string REFRESH_TOKEN { get; set; }
        public string ACCESS_TOKEN { get; set; }
    }

    public class TeacherFolderStructureVM
    {
        public IFormFile MyFile { get; set; }
        public decimal FILE_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_TITLE { get; set; }
        public string FILE_DESC { get; set; }
        public string FILE_EXTENTION { get; set; }
        public string MIM_TYPE { get; set; }
        public string FILE_URL { get; set; }
        public string GOOGLE_FILE_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public decimal SUB_MAP_ID { get; set; }
        public string ASSIGNMENT_OR_LECTURE_CODE { get; set; }
        public string USER_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string CLASS_NAME { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string LECTURE_OR_ASSIGNMENT { get; set; }
        public string DUE_DATE { get; set; }
        public string DUE_TIME { get; set; }
        public decimal PARENT_FILE_ID { get; set; }
        public decimal RowStatus { get; set; }
        public string REFRESH_TOKEN { get; set; }
        public string ACCESS_TOKEN { get; set; }
    }
    public class FolderStructureSaveDB
    {
        public decimal FILE_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_TITLE { get; set; }
        public string FILE_DESC { get; set; }
        public string FILE_EXTENTION { get; set; }
        public string MIM_TYPE { get; set; }
        public string FILE_URL { get; set; }
        public string GOOGLE_FILE_ID { get; set; }
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
        public string USER_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string CLASS_NAME { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string LECTURE_OR_ASSIGNMENT { get; set; }
        public string DUE_DATE { get; set; }
        public string DUE_TIME { get; set; }
        public decimal PARENT_FILE_ID { get; set; }
        public decimal RowStatus { get; set; }
    }



    


    public class TeacherFolderStructureSaveDB
    {
        public decimal FILE_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_TITLE { get; set; }
        public string FILE_DESC { get; set; }
        public string FILE_EXTENTION { get; set; }
        public string MIM_TYPE { get; set; }
        public string FILE_URL { get; set; }
        public string GOOGLE_FILE_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public decimal SUB_MAP_ID { get; set; }
        public string ASSIGNMENT_OR_LECTURE_CODE { get; set; }
        public string USER_CODE { get; set; }
        public string DUE_DATE { get; set; }
        public string DUE_TIME { get; set; }
        public decimal PARENT_FILE_ID { get; set; }
        public decimal RowStatus { get; set; }
    }

}
