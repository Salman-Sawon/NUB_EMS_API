using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class TeacherInfo
    {
        public IFormFile TEACHER_IMAGE { get; set; }
        public IFormFile TEACHER_SIGNATURE { get; set; }
        public string Teacher_Id { get; set; }
        public string Org_Code { get; set; }
        public string Org_Name { get; set; }
        public string Teacher_Code { get; set; }
        public string Joining_Date { get; set; }
        public string Campus_Code { get; set; }
        public string Campus_Name { get; set; }
        public string Gender_Code { get; set; }
        public string Sms_Mobile_Num { get; set; }
        public string Teacher_Name { get; set; }
        public string Fathers_Name { get; set; }
        public string Mothers_Name { get; set; }
        public string Date_Of_Birth { get; set; }
        public string Religion_Code { get; set; }
        public string Blood_Group_Code { get; set; }
        public string Nationality_Code { get; set; }
        public string Birth_Place_Code { get; set; }
        public string Present_Addr { get; set; }
        public string Permanent_Addr { get; set; }
        public string Remarks { get; set; }
        public string Teacher_Image_Url { get; set; }
        public string Teacher_Signature_Url { get; set; }
        public decimal RowStatus { get; set; }
        public string User_Name { get; set; }
        public string IS_SENIORITY_ID { get; set; }
        public decimal SENIOR_LEVEL { get; set; }

    }

    public class TeacherServiceInfo
    {
        
        public string TEACHER_NAME { get; set; }
        public string DESIGNATION_NAME { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public string JOINING_DATE { get; set; }
        public string DURATION_AS_TEACHER { get; set; }
        

    }

}
