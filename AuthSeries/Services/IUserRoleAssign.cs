using StudentWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IUserRoleAssign
    {
        List<UserRoleAssign> GetUserRoleAssignList(int roleId);
        List<UserRoleAssign> GetUserRoleUnassignList(int roleId);

    }
}
