using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class SeatPlanInfo
    {
        public decimal ROOM_ID { get; set; }
        public decimal BUILDING_ID { get; set; }
        public string STUDENT_CODE { get; set; }
        public List<decimal?> ROW_NO { get; set; }
        public List<decimal?> COLUMN_NO { get; set; }
        public decimal TERM_ID { get; set; }
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

    public class SeatPlanVM
    {
       
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string CLASS_ROLL { get; set; }
        public decimal ROW_NO { get; set; }
        public decimal COLUMN_NO { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public string SECTION_CODE { get; set; }
        public string SECTION_NAME { get; set; }
        public string GROUP_CODE { get; set; }
        public string GROUP_NAME { get; set; }
        public string SESSION_CODE { get; set; }
        public string SESSION_NAME { get; set; }
        public string VERSION_CODE { get; set; }
        public string VERSION_NAME { get; set; }
        public string YEAR_CODE { get; set; }
        public string YEAR_NAME { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SEMESTER_NAME { get; set; }
        public string SHIFT_CODE { get; set; }
        public decimal BUILDING_ID { get; set; }
        public string BUILDING_NAME { get; set; }

    }
    public class SeatPlanVMParam
    {
        public decimal TERM_ID { get; set; }
        public string ORG_CODE { get; set; }
        public decimal ROOM_ID { get; set; }
        public string CAMPUS_CODE { get; set; }
        public decimal BUILDING_ID { get; set; }

    }
    public class RoomMst
    {

        public decimal ROOM_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string ROOM_NAME { get; set; }
        public decimal CAPACITY { get; set; }
        public decimal NUM_OF_ROWS { get; set; }
        public decimal NUM_OF_COLUMNS { get; set; }
        public string USER_CODE { get; set; }
        public decimal RowStatus { get; set; }
        public decimal BUILDING_ID { get; set; }

    }
    public class CampusBulildingMst
    {

        public decimal BUILDING_ID { get; set; }
        public string ORG_CODE { get; set; }
        public string CAMPUS_CODE { get; set; }
        public string BUILDING_NAME { get; set; }
        public string USER_CODE { get; set; }
        public decimal RowStatus { get; set; }

    }

    public class getBuildingList
    {

        public decimal BUILDING_ID { get; set; }
        public string BUILDING_NAME { get; set; }

    }
    public class SeatPlanRPT
    {

        public string column_one { get; set; }
        public string column_two { get; set; }

    }

}
