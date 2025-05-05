using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IMenu
    {
        MenuViewModel GetMenuList(string userCode, int roleId);
        List<Menu> GetDBMenuList(string userCode, int roleId);
        List<MenuNew> getDBMenuListNew(string userCode, int roleId);
    }
}
