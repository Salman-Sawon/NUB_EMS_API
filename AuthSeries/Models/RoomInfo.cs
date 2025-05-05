using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class RoomInfo
    {
      
        public string ORG_CODE { get; set; }
        public string ROOM_NAME { get; set; }
        public List<decimal> CAPACITY { get; set; }
        public List<decimal> NUM_OF_ROWS { get; set; }
        public List<decimal> NUM_OF_COLUMNS { get; set; }
        public string USER_CODE { get; set; }

    }

    public class RoomInfoVM
    {

        public decimal ROOM_ID { get; set; }
        public string ROOM_NAME { get; set; }
        public decimal CAPACITY { get; set; }
        public decimal NUMBER_OF_ROWS { get; set; }
        public decimal NUMBER_OF_COLUMNS { get; set; }
        public string BUILDING_NAME { get; set; }
        public decimal BUILDING_ID { get; set; }

    }

    public class StdInfoVM
    {

        public decimal STUDENT_CODE { get; set; }


    }

    public class StdExistInfoVM
    {
        public string CLASS_CODE { get; set; }
        public string SECTION_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string SESSION_CODE { get; set; }
        public string VERSION_CODE { get; set; }
        public string YEAR_CODE { get; set; }
        public string SEMESTER_CODE { get; set; }
        public string SHIFT_CODE { get; set; }
        public decimal STUDENT_CODE { get; set; }


    }

    public class RoomList
    {
        public decimal ROOM_ID { get; set; }
        public string ROOM_NAME { get; set; }

    }

    public class RoomAssign
    {
        public string ORG_CODE { get; set; }
        public List<decimal> ROOM_ID { get; set; }
        //public string ROOM_NAME { get; set; }
        public List<string> ROOM_CONTROLLER { get; set; }
        public List<string> JUNIOR_TEACHER { get; set; }
        public List<string> TEACHER_ASSISTANT { get; set; }
        public string User_Name { get; set; }
        public string IS_TEACHER_LEVEL_CONSIDERED { get; set; }
       

    }

    public class RoomAssignVM
    {
        public string ORG_CODE { get; set; }
        public decimal ROOM_ID { get; set; }
        public string ROOM_NAME { get; set; }
        public string ROOM_CONTROLLER { get; set; }
        public string JUNIOR_TEACHER { get; set; }
        public string TEACHER_ASSISTANT { get; set; }
        public string User_Name { get; set; }
        public string IS_TEACHER_LEVEL_CONSIDERED { get; set; }


    }

}
