using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Student
{
    public class StudentListCount
    {
        public decimal TOTAL_STUDENT_LIST { get; set; }
        public decimal TOTAL_TEACHERS_LIST { get; set; }
        public decimal TOTAL_COURSES_LIST { get; set; }
        public decimal TODAYS_COLLECTION { get; set; }
    }
}
