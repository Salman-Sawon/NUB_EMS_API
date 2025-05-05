using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class RoleMenuMapViewModel
    {
        public decimal ROLE_ID { get; set; }
        public List<decimal> MENU_ITEM_ID { get; set; }
        public string USER_CODE { get; set; }
       
    }
}
