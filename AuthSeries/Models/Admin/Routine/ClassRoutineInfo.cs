using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.Admin.Routine
{
    public class ClassRoutineInfo
    {
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
        public string DAY_CODE { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string START_TIME { get; set; }
        public string PERIOD_CODE { get; set; }
        public string END_TIME { get; set; }
        public List<decimal> ROOM_ID { get; set; }
        public string TEACHER_CODE { get; set; }
     
    }
    public class ClassRoutineInfospzrdc
    {
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
        public string DAY_CODE { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public List<decimal> ROOM_ID { get; set; }
        public string TEACHER_CODE { get; set; }

    }
    public class ClassRoutineInfoGendar
    {
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
        public string DAY_CODE { get; set; }
        public string SUBJECT_CODE { get; set; }
       // public string START_TIME { get; set; }
        public string PERIOD_CODE { get; set; }
        public List<decimal> ROOM_ID { get; set; }
        public string TEACHER_CODE { get; set; }
        public string GENDER_CODE { get; set; }

    }




    public class ClassRoutineVM
    {

        public decimal ROUTINE_ID { get; set; }
        public string DAY_CODE { get; set; }
        public string DAY_NAME { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public string PERIOD_CODE { get; set; }
        public string PERIOD_NAME { get; set; }
        public decimal ROOM_ID { get; set; }
        public string ROOM_NAME { get; set; }
        public string GENDER { get; set; }

        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }

    } 
    public class ClassRoutinePeriodBaseVM
    {

        public decimal ROUTINE_ID { get; set; }
        public string DAY_CODE { get; set; }
        public string DAY_NAME { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string PERIOD_NAME { get; set; }
        public decimal PERIOD_ID { get; set; }
        public string  DURATION { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public decimal ROOM_ID { get; set; }
        public string ROOM_NAME { get; set; }
        public string GENDER { get; set; }

        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }

    }

    public class ParameterInfo
    {
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
        public string DAY_CODE { get; set; }
    }
    public class ParameterTS
    {
        public string ORG_CODE { get; set; }
        public string USER_CODE { get; set; }
    }

    public class ParameterDay
    {
        public string ORG_CODE { get; set; }
        public string DAY_CODE { get; set; }
        public string USER_CODE { get; set; }
    }


    public class Day
    {
        public decimal DAY_ID { get; set; }
        public string DAY_CODE { get; set; }
        public string DAY_NAME { get; set; }
    }


    public class TeacherSubMapInfo
    {
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
    }

    public class TeacherSubMapInfoVm
    {
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }
        public Int16 SUJBECT_SRLNO { get; set; }
       
    }

    public class TeacherMapInfoVm
    {
       
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }

    }

    public class TeacherRoomStatus
    {

        public decimal STATUS_COUNT { get; set; }
        public string NAME { get; set; }
        public string STATUS { get; set; }

    }

    public class ClassRoutineItemDelete
    {

        public string ORG_CODE { get; set; }

        public decimal ROUTINE_ID { get; set; }
       

    }


    public class PeriodMst
    {

        public decimal PERIOD_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string PERIOD_NAME { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public string DURATION { get; set; }
        public string USER_CODE { get; set; }
        public decimal ROW_STATUS { get; set; }

    }

    public class PeriodGrid
    {

        public decimal PERIOD_ID { get; set; }
        public string PERIOD_NAME { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public string DURATION { get; set; }

    }



    public class PeriodWiseClassRoutineVm
    {

        public decimal ROUTINE_ID { get; set; }
        public string DAY_CODE { get; set; }
        public string DAY_NAME { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string PERIOD_CODE { get; set; }
        public string PERIOD_NAME { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public string  DURATION { get; set; }
        public decimal ROOM_ID { get; set; }
        public string ROOM_NAME { get; set; }
        public string GENDER { get; set; }
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }

    }



    public class PeriodWiseOrgRoutineVm
    {

        public decimal ROUTINE_ID { get; set; }
        public string DAY_CODE { get; set; }
        public string DAY_NAME { get; set; }
        public string CLASS_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string SECTION_NAME { get; set; }
        public string CLASS_NAME { get; set; }
        public string SUBJECT_CODE { get; set; }
        public string SUBJECT_NAME { get; set; }
        public string PERIOD_CODE { get; set; }
        public string PERIOD_NAME { get; set; }
        public string START_TIME { get; set; }
        public string END_TIME { get; set; }
        public string DURATION { get; set; }
        public decimal ROOM_ID { get; set; }
        public string ROOM_NAME { get; set; }
        public string GENDER { get; set; }
        public string TEACHER_CODE { get; set; }
        public string TEACHER_NAME { get; set; }

    }





}
