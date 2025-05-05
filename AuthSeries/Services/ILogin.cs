using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface ILogin
    {
        bool CheckValidLogin(string userName, string password);
        AdminUserMst GetLoginData(string userCode, string password);
        AdminUserMstVM GetLoggedData(string userCode, string password);

        //Change Password
        (int status, string[] message) ChangePassword(ChangePasswordViewModel changePass);

    }
}
