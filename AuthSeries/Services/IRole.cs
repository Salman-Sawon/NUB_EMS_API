using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IRole
    {
        List<RoleModel> GetRoleList();
        (int status, string[] message) SaveUserRole(AdminRoleMst userRole);
    }
}
