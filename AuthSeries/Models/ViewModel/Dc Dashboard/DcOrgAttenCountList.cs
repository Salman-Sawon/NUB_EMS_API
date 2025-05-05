using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel.Dc_Dashboard
{
    public class DcOrgAttenCountList
    {

        public decimal ATTENDANCE_TOTAL { get; set; }
        public decimal ABSENT { get; set; }
        public decimal LATE { get; set; }
        public decimal PRESENT { get; set; }


    }


    public class DcOrgClassAttList
    {
        public string CLASS_CODE { get; set; }
        public string CLASS_NAME { get; set; }
        public decimal TOTAL_STD { get; set; }
        public decimal STD_PRESENT { get; set; }
        public decimal STD_LATE { get; set; }
        public decimal STD_ABS { get; set; }


    }
}
