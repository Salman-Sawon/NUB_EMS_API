using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class EMSStudentMst
    {
        public EMSStudentMst()
        {
            ACTIVE_STATUS = "Y";
            STATUS = "N";
        }
      public decimal STUDENT_ID { get; set; }
      public string ORG_CODE { get; set; }
        public string STUDENT_CODE { get; set; }
        public DateTime ADMISSION_DATE { get; set; }
        public string START_SESSION_CODE { get; set; }
        public string CUR_SESSION_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public decimal ADMISSION_TEST_MARK { get; set; }
        public decimal ADMISSION_TEST_POS { get; set; }
        public string CLASS_ROLL { get; set; }
        public string GENDER_CODE { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
        public string STUDENT_NAME { get; set; }
        public string FATHERS_NAME { get; set; }
        public string MOTHERS_NAME { get; set; }
        public string GURDIAN_NAME { get; set; }
        public string FATHER_OCCUPATION { get; set; }
        public string FATHER_CONTACT_NO { get; set; }
        public string MOTHER_OCCUPATION { get; set; }
        public string MOTHER_CONTACT_NO { get; set; }
        public string GUARDIAN_OCCUPATION { get; set; }
        public string GUARDIAN_CONTACT_NO { get; set; }
        public string GUARDIAN_RELATION_TYPE_CODE { get; set; }
        public DateTime DATE_OF_BIRTH { get; set; }
        public string BOARD_UNIV_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string RELIGION_CODE { get; set; }
        public string BLOOD_GROUP_CODE { get; set; }
        public string NATIONALITY_CODE { get; set; }
        public string BIRTH_PLACE_CODE { get; set; }
        public string LAST_SCHOOL_NAME_ADDR { get; set; }
        public string PRESENT_ADDR { get; set; }
        public string PERMANENT_ADDR { get; set; }
        public string REMARKS { get; set; }
        public string STUDENT_IMAGE { get; set; }
        public string FATHERS_IMAGE { get; set; }
        public string MOTHERS_IMAGE { get; set; }
        public string GUARDIAN_IMAGE { get; set; }

        public string ACTIVE_STATUS { get; set; }
        public string STATUS { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public string CREATE_BY { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }
    }
}
