using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IAllMenu
    {
        List<AllMenuViewModel> GetAllMenuList();

        (int status, string[] message) SaveRoleMenu(RoleMenuMapViewModel roleMenuMapViewModel);
    }
}
