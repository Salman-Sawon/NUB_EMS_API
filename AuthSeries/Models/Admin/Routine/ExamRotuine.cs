using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Admin.Routine
{
    public class ExamRoutine
    {
        public decimal EXAM_ROUTINE_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public decimal TERM_ID { get; set; }
       
        public List<DateTime> EXAM_DATE { get; set; }
        public List<string> START_TIME { get; set; }
        public List<string> END_TIME { get; set; }
        public List<string> SUBJECT_CODE { get; set; }
        public string TEACHER_CODE { get; set; }
        public decimal ROOM_ID { get; set; }
        public string USER_CODE { get; set; }
    }

    public class ExamRoutineVM
    {
        public decimal EXAM_ROUTINE_ID { get; set; }
        public string ORG_CODE { get; set; }
        public decimal TERM_ID { get; set; }
        public string CLASS_CODE { get; set; }
        public DateTime EXAM_DATE { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public string SUBJECT_CODE { get; set; }
      //  public string TEACHER_CODE { get; set; }
      //  public decimal ROOM_ID { get; set; }
        public string CREATE_BY { get; set; }
    }

    public class RoutineParameter {
        public string ORG_CODE { get; set; }
        public decimal TERM_ID { get; set; }
        public string CLASS_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SECTION_CODE { get; set; }
    }

    public class stdExamRoutine
    {
       
        public string SUBJECT_NAME { get; set; }
        public string EXAM_DATE { get; set; }
        public string DAY_NAME { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public decimal DURATION { get; set; }
        public decimal COLUMN_NO { get; set; }
        public decimal ROW_NO { get; set; }
        public string ROOM_NAME { get; set; }
        public string TERM_NAME { get; set; }
    }

    public class TeacherExamRoutine
    {

        public string DUTY_START_TIME { get; set; }
        public string DUTY_END_TIME { get; set; }
        public string DUTY_DATE { get; set; }
        public string ROOM_NAME { get; set; }
       
    }

    public class TeacherTermInfo
    {

        public decimal TERM_ID { get; set; }
        public string TERM_DESCRIPTION { get; set; }

    }

}
