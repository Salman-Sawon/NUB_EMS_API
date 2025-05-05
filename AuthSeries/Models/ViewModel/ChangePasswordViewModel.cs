using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class ChangePasswordViewModel
    {
        public string USER_CODE { get; set; }
        public string OLD_PASSWORD { get; set; }
        public string NEW_PASSWORD { get; set; }
        public string CONFIRM_PASSWORD { get; set; }
        public string UPDATE_USER { get; set; }
        public string Token { get; set; }
    }
}
