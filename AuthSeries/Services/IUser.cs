using StudentWebAPI.Models.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IUser
    {
        UserViewModel UserList(string userCode);
    }
}
