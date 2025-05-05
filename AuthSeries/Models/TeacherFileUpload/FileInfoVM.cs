using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.TeacherFileUpload
{
    public class FileInfoVM
    {
        public decimal FILE_ID { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string USER_UPLOAD { get; set; }
        public string CREATE_BY { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_TITLE { get; set; }
        public string FILE_DESC { get; set; }
        public string FILE_EXTENTION { get; set; }
        public string FILE_URL { get; set; }
        public string D_TYPE { get; set; }
        public string ASSIGNMENT_OR_LECTURE_CODE { get; set; }
        public string IS_ASSIGNMENT { get; set; }
        public string DUE_DATE { get; set; }
        public string DUE_TIME { get; set; }
    }

    public class FileUploadedVM
    {
        public decimal FILE_ID { get; set; }
        public decimal PARENT_FILE_ID { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string STATUS { get; set; }
        public string CREATE_DATE { get; set; }
        public string CREATE_TIME { get; set; }  
        public string FILE_EXTENTION { get; set; }  
        public string FILE_URL { get; set; }
     
    }




    public class StdUploadedFilesVM
    {
        public decimal FILE_ID { get; set; }
        public string STATUS { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string CREATE_DATE { get; set; }
        public string CREATE_TIME { get; set; }
        public string FILE_URL { get; set; }

    }


}
