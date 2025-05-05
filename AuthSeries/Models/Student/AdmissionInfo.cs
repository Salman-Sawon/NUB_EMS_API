using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Student
{
    public class AdmissionInfo
    {
        public IFormFile MyFile { get; set; }
        public string STUDENT_FILE_URL { get; set; }
        public decimal STUDENT_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string STUDENT_IMAGE { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }
        public string CUR_SESSION_CODE { get; set; }
        public string SESSION_NAME_1 { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_CODE { get; set; }
        public string GROUP_NAME { get; set; }
        public string SECTION_CODE { get; set; }
        public string SECTION_NAME { get; set; }
        public string ADMISSION_TEST_MARK { get; set; }
        public string ADMISSION_TEST_POS { get; set; }
        public string CLASS_ROLL { get; set; }
        public string GENDER_CODE { get; set; }
        public string GENDER_NAME { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string BOARD_UNIV_CODE { get; set; }
        public string BOARD_UNIV_NAME { get; set; }
        public string SHIFT_CODE { get; set; }
        public string SHIFT_NAME { get; set; }
        public string VERSION_CODE { get; set; }
        public string VERSION_NAME { get; set; }
        public string RELIGION_CODE { get; set; }
        public string RELIGION_NAME { get; set; }
        public string BLOOD_GROUP_CODE { get; set; }
        public string BLOOD_GROUP_NAME { get; set; }
        public string NATIONALITY_CODE { get; set; }
        public string NATIONALITY_NAME { get; set; }
        public string BIRTH_PLACE_CODE { get; set; }
        public string BIRTH_PLACE { get; set; }
        public string LAST_SCHOOL_NAME_ADDR { get; set; }
        public string PRESENT_ADDR { get; set; }
        public string PERMANENT_ADDR { get; set; }
        public string FATHERS_NAME { get; set; }
        public string FATHER_OCCUPATION { get; set; }
        public string OCCUPATION_NAME { get; set; }
        public string FATHER_CONTACT_NO { get; set; }
        public string FATHERS_IMAGE { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string MOTHER_OCCUPATION { get; set; }
        public string OCCUPATION_NAME_1 { get; set; }
        public string MOTHER_CONTACT_NO { get; set; }
        public string MOTHERS_IMAGE { get; set; }
        public string GURDIAN_NAME { get; set; }
        public string GUARDIAN_OCCUPATION { get; set; }
        public string OCCUPATION_NAME_2 { get; set; }
        public string GUARDIAN_CONTACT_NO { get; set; }
        public string GUARDIAN_IMAGE { get; set; }
        public string GUARDIAN_RELATION_TYPE_CODE { get; set; }
        public string RELATION_TYPE_NAME { get; set; }
        public string REMARKS { get; set; }
        public string ACTIVE_STATUS { get; set; }
        public string USER_NAME { get; set; }
        public decimal RowStatus { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SUR_NAME { get; set; }
        public string BIRTH_REG_NUMBER { get; set; }
        public string EMAIL_ADDRESS { get; set; }
        public string FACEBOOK_ID { get; set; }
        public string STUDENT_NID { get; set; }
        public string FATHERS_NID { get; set; }
        public string MOTHERS_NID { get; set; }
        public string GUARDIAN_NID { get; set; }
        public string SIBLING_STUDENT_CODE { get; set; }
        public string SIBLING_CLASS_CODE { get; set; }
       
        public string TRANSPORT { get; set; }
        public string STUDENT_IMG { get; set; }
      

    }


    public class StudentAdmissionFormInfo
    {
        public IFormFile MyFile { get; set; }
        public string STUDENT_FILE_URL { get; set; }
        public decimal STUDENT_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string ORG_NAME { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string ? STUDENT_IMAGE { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }
        public string CUR_SESSION_CODE { get; set; }
        public string SESSION_NAME_1 { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string GROUP_CODE { get; set; }
        public string GROUP_NAME { get; set; }
        public string SECTION_CODE { get; set; }
        public string SECTION_NAME { get; set; }
        public string ADMISSION_TEST_MARK { get; set; }
        public string ADMISSION_TEST_POS { get; set; }
        public string CLASS_ROLL { get; set; }
        public string GENDER_CODE { get; set; }
        public string GENDER_NAME { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string BOARD_UNIV_CODE { get; set; }
        public string BOARD_UNIV_NAME { get; set; }
        public string SHIFT_CODE { get; set; }
        public string SHIFT_NAME { get; set; }
        public string VERSION_CODE { get; set; }
        public string VERSION_NAME { get; set; }
        public string ? RELIGION_CODE { get; set; }
        public string ? RELIGION_NAME { get; set; }
        public string ? BLOOD_GROUP_CODE { get; set; }
        public string ? BLOOD_GROUP_NAME { get; set; }
        public string ? NATIONALITY_CODE { get; set; }
        public string ? NATIONALITY_NAME { get; set; }
        public string ? BIRTH_PLACE_CODE { get; set; }
        public string ? BIRTH_PLACE { get; set; }
        public string LAST_SCHOOL_NAME_ADDR { get; set; }
        public string ? PRESENT_ADDR { get; set; }
        public string ? PERMANENT_ADDR { get; set; }
        public string FATHERS_NAME { get; set; }
        public string ? FATHER_OCCUPATION { get; set; }
        public string ? OCCUPATION_NAME { get; set; }
        public string ? FATHER_CONTACT_NO { get; set; }
        public string ? FATHERS_IMAGE { get; set; }
        public string ? MOTHERS_NAME { get; set; }
        public string ? MOTHER_OCCUPATION { get; set; }
        public string ? OCCUPATION_NAME_1 { get; set; }
        public string ? MOTHER_CONTACT_NO { get; set; }
        public string ? MOTHERS_IMAGE { get; set; }
        public string ? GURDIAN_NAME { get; set; }
        public string ? GUARDIAN_OCCUPATION { get; set; }
        public string ? OCCUPATION_NAME_2 { get; set; }
        public string ? GUARDIAN_CONTACT_NO { get; set; }
        public string ? GUARDIAN_IMAGE { get; set; }
        public string ? GUARDIAN_RELATION_TYPE_CODE { get; set; }
        public string? RELATION_TYPE_NAME { get; set; }
        public string REMARKS { get; set; }
        public string ACTIVE_STATUS { get; set; }
        public string USER_NAME { get; set; }
        public decimal RowStatus { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string ? SUR_NAME { get; set; }
        public string ? BIRTH_REG_NUMBER { get; set; }
        public string ? EMAIL_ADDRESS { get; set; }
        public string ? FACEBOOK_ID { get; set; }
        public string ?  STUDENT_NID { get; set; }
        public string ?  FATHERS_NID { get; set; }
        public string? MOTHERS_NID { get; set; }
        public string ? GUARDIAN_NID { get; set; }
        public string ? SIBLING_STUDENT_CODE { get; set; }
        public string ? SIBLING_CLASS_CODE { get; set; }

        public string ? TRANSPORT { get; set; }
        public string ? STUDENT_IMG { get; set; }


    }

}
