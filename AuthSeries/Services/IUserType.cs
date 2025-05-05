using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IUserType
    {
        List<UserTypeModel> GetUserTypeList();
        (int status, string[] message) SaveUserType (AdminUserType userType);





    }
}
