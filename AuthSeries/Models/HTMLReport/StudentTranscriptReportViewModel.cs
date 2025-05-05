using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.HTMLReport
{
    public class StudentTranscriptReportViewModel
    {
        public decimal UNIQUE_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string STUDENT_CODE { get; set; }
        public string STUDENT_ID { get; set; }
        public int PROCESS_ID { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public double SUBJECT_ID { get; set; }
        public double SUBJECT_TYPE { get; set; }
        public string IS_UPDATABLE { get; set; }
        public double T1_SUBJECT_JOIN { get; set; }
        public string T1_IS_SHOWABLE { get; set; }
        public string T1_IS_EFFECTIVE { get; set; }
        public double T1_EXAM_1_MARK { get; set; }
        public double T1_EXAM_1_CONVERTED { get; set; }
        public double T1_EXAM_2_MARK { get; set; }
        public double T1_EXAM_2_CONVERTED { get; set; }
        public double T1_EXAM_3_MARK { get; set; }
        public double T1_EXAM_3_CONVERTED { get; set; }
        public double T1_EXAM_4_MARK { get; set; }
        public double T1_EXAM_4_CONVERTED { get; set; }
        public double T1_EXAM_5_MARK { get; set; }
        public double T1_EXAM_5_CONVERTED { get; set; }
        public double T1_EXAM_6_MARK { get; set; }
        public double T1_EXAM_6_CONVERTED { get; set; }
        public string T1_PF_TYPE { get; set; }
        public double T1_EXAM_1_AR { get; set; }
        public double T1_EXAM_2_AR { get; set; }
        public double T1_EXAM_4_AR { get; set; }
        public double T1_EXAM_5_AR { get; set; }
        public double T1_EXAM_6_AR { get; set; }
        public double T1_TOTAL_MARK { get; set; }
        public double T1_HIGHEST_MARK { get; set; }
        public string T1_LATTER_GRADE { get; set; }
        public double T1_GRADE_POINT { get; set; }
        public string T1_LATTER_GRADE_SHOW { get; set; }
        public double T1_GRADE_POINT_SHOW { get; set; }
        public double T2_SUBJECT_JOIN { get; set; }
        public string T2_IS_SHOWABLE { get; set; }
        public string T2_IS_EFFECTIVE { get; set; }
        public double T2_EXAM_1_MARK { get; set; }
        public double T2_EXAM_1_CONVERTED { get; set; }
        public double T2_EXAM_2_MARK { get; set; }
        public double T2_EXAM_2_CONVERTED { get; set; }
        public double T2_EXAM_3_MARK { get; set; }
        public double T2_EXAM_3_CONVERTED { get; set; }
        public double T2_EXAM_4_MARK { get; set; }
        public double T2_EXAM_4_CONVERTED { get; set; }
        public double T2_EXAM_5_MARK { get; set; }
        public double T2_EXAM_5_CONVERTED { get; set; }
        public double T2_EXAM_6_MARK { get; set; }
        public double T2_EXAM_6_CONVERTED { get; set; }
        public string T2_PF_TYPE { get; set; }
        public double T2_EXAM_1_AR { get; set; }
        public double T2_EXAM_2_AR { get; set; }
        public double T2_EXAM_4_AR { get; set; }
        public double T2_EXAM_5_AR { get; set; }
        public double T2_EXAM_6_AR { get; set; }
        public double T2_TOTAL_MARK { get; set; }
        public double T2_HIGHEST_MARK { get; set; }
        public string T2_LATTER_GRADE { get; set; }
        public double T2_GRADE_POINT { get; set; }
        public string T2_LATTER_GRADE_SHOW { get; set; }
        public double T2_GRADE_POINT_SHOW { get; set; }
        public double T3_SUBJECT_JOIN { get; set; }
        public string T3_IS_SHOWABLE { get; set; }
        public string T3_IS_EFFECTIVE { get; set; }
        public double T3_EXAM_1_MARK { get; set; }
        public double T3_EXAM_1_CONVERTED { get; set; }
        public double T3_EXAM_2_MARK { get; set; }
        public double T3_EXAM_2_CONVERTED { get; set; }
        public double T3_EXAM_3_MARK { get; set; }
        public double T3_EXAM_3_CONVERTED { get; set; }
        public double T3_EXAM_4_MARK { get; set; }
        public double T3_EXAM_4_CONVERTED { get; set; }
        public double T3_EXAM_5_MARK { get; set; }
        public double T3_EXAM_5_CONVERTED { get; set; }
        public double T3_EXAM_6_MARK { get; set; }
        public double T3_EXAM_6_CONVERTED { get; set; }
        public string T3_PF_TYPE { get; set; }
        public double T3_EXAM_1_AR { get; set; }
        public double T3_EXAM_2_AR { get; set; }
        public double T3_EXAM_4_AR { get; set; }
        public double T3_EXAM_5_AR { get; set; }
        public double T3_EXAM_6_AR { get; set; }
        public double T3_TOTAL_MARK { get; set; }
        public double T3_HIGHEST_MARK { get; set; }
        public string T3_LATTER_GRADE { get; set; }
        public double T3_GRADE_POINT { get; set; }
        public string T3_LATTER_GRADE_SHOW { get; set; }
        public double T3_GRADE_POINT_SHOW { get; set; }
        public double T4_SUBJECT_JOIN { get; set; }
        public string T4_IS_SHOWABLE { get; set; }
        public string T4_IS_EFFECTIVE { get; set; }
        public double T4_EXAM_1_MARK { get; set; }
        public double T4_EXAM_1_CONVERTED { get; set; }
        public double T4_EXAM_2_MARK { get; set; }
        public double T4_EXAM_2_CONVERTED { get; set; }
        public double T4_EXAM_3_MARK { get; set; }
        public double T4_EXAM_3_CONVERTED { get; set; }
        public double T4_EXAM_4_MARK { get; set; }
        public double T4_EXAM_4_CONVERTED { get; set; }
        public double T4_EXAM_5_MARK { get; set; }
        public double T4_EXAM_5_CONVERTED { get; set; }
        public double T4_EXAM_6_MARK { get; set; }
        public double T4_EXAM_6_CONVERTED { get; set; }
        public string T4_PF_TYPE { get; set; }
        public double T4_EXAM_1_AR { get; set; }
        public double T4_EXAM_2_AR { get; set; }
        public double T4_EXAM_4_AR { get; set; }
        public double T4_EXAM_5_AR { get; set; }
        public double T4_EXAM_6_AR { get; set; }
        public double T4_TOTAL_MARK { get; set; }
        public double T4_HIGHEST_MARK { get; set; }
        public string T4_LATTER_GRADE { get; set; }
        public double T4_GRADE_POINT { get; set; }
        public string T4_LATTER_GRADE_SHOW { get; set; }
        public double T4_GRADE_POINT_SHOW { get; set; }
        public double AR_TM { get; set; }
        public double AR_HM { get; set; }
        public string AR_LG { get; set; }
        public double AR_GP { get; set; }
        public string AR_LGSHOW { get; set; }
        public double AR_GPSHOW { get; set; }
        public double FULLMARK { get; set; }
        public double SHORT_MARK_JOIN { get; set; }
        //UNIQUE_ID, ORG_CODE, CAMPUS_CODE, CLASS_CODE, GROUP_CODE, SECTION_CODE, SHIFT_CODE, VERSION_CODE, SESSION_CODE, 
        //    STUDENT_CODE, STUDENT_ID, PROCESS_ID, SUBJECT_CODE, SUBJECT_ID, SUBJECT_TYPE, IS_UPDATABLE, 
        //    T1_SUBJECT_JOIN, T1_IS_SHOWABLE, T1_IS_EFFECTIVE, T1_EXAM_1_MARK, T1_EXAM_1_CONVERTED, T1_EXAM_2_MARK, 
        //    T1_EXAM_2_CONVERTED, T1_EXAM_3_MARK, T1_EXAM_3_CONVERTED, T1_EXAM_4_MARK, T1_EXAM_4_CONVERTED, 
        //    T1_EXAM_5_MARK, T1_EXAM_5_CONVERTED, T1_EXAM_6_MARK, T1_EXAM_6_CONVERTED, T1_PF_TYPE, T1_EXAM_1_AR, 
        //    T1_EXAM_2_AR, T1_EXAM_4_AR, T1_EXAM_5_AR, T1_EXAM_6_AR, T1_TOTAL_MARK, T1_HIGHEST_MARK, T1_LATTER_GRADE, 
        //    T1_GRADE_POINT, T1_LATTER_GRADE_SHOW, T1_GRADE_POINT_SHOW, T2_SUBJECT_JOIN, T2_IS_SHOWABLE, T2_IS_EFFECTIVE,
        //    T2_EXAM_1_MARK, T2_EXAM_1_CONVERTED, T2_EXAM_2_MARK, T2_EXAM_2_CONVERTED, T2_EXAM_3_MARK, T2_EXAM_3_CONVERTED, T2_EXAM_4_MARK, T2_EXAM_4_CONVERTED, T2_EXAM_5_MARK, T2_EXAM_5_CONVERTED, T2_EXAM_6_MARK, T2_EXAM_6_CONVERTED, T2_PF_TYPE, T2_EXAM_1_AR, T2_EXAM_2_AR, T2_EXAM_4_AR, T2_EXAM_5_AR, T2_EXAM_6_AR, T2_TOTAL_MARK, T2_HIGHEST_MARK, T2_LATTER_GRADE, T2_GRADE_POINT, T2_LATTER_GRADE_SHOW, T2_GRADE_POINT_SHOW, 
        //    T3_SUBJECT_JOIN, T3_IS_SHOWABLE, T3_IS_EFFECTIVE, T3_EXAM_1_MARK, T3_EXAM_1_CONVERTED, T3_EXAM_2_MARK, T3_EXAM_2_CONVERTED, T3_EXAM_3_MARK, T3_EXAM_3_CONVERTED, T3_EXAM_4_MARK, T3_EXAM_4_CONVERTED, T3_EXAM_5_MARK, T3_EXAM_5_CONVERTED, T3_EXAM_6_MARK, T3_EXAM_6_CONVERTED, T3_PF_TYPE, T3_EXAM_1_AR, T3_EXAM_2_AR, T3_EXAM_4_AR, T3_EXAM_5_AR, T3_EXAM_6_AR, T3_TOTAL_MARK, T3_HIGHEST_MARK, T3_LATTER_GRADE, T3_GRADE_POINT, T3_LATTER_GRADE_SHOW, T3_GRADE_POINT_SHOW, 
        //    T4_SUBJECT_JOIN, T4_IS_SHOWABLE, T4_IS_EFFECTIVE, T4_EXAM_1_MARK, T4_EXAM_1_CONVERTED, T4_EXAM_2_MARK, T4_EXAM_2_CONVERTED, T4_EXAM_3_MARK, T4_EXAM_3_CONVERTED, T4_EXAM_4_MARK, T4_EXAM_4_CONVERTED, T4_EXAM_5_MARK, T4_EXAM_5_CONVERTED, T4_EXAM_6_MARK, T4_EXAM_6_CONVERTED, T4_PF_TYPE, T4_EXAM_1_AR, T4_EXAM_2_AR, T4_EXAM_4_AR, T4_EXAM_5_AR, T4_EXAM_6_AR, T4_TOTAL_MARK, T4_HIGHEST_MARK, T4_LATTER_GRADE, T4_GRADE_POINT, T4_LATTER_GRADE_SHOW, T4_GRADE_POINT_SHOW, 
        //    AR_TM, AR_HM, AR_LG, AR_GP, AR_LGSHOW, AR_GPSHOW, FULLMARK, SHORT_MARK_JOIN, STATUS, CREATE_DATE, CREATE_BY, UPDATE_DATE, UPDATE_BY
    }
}
