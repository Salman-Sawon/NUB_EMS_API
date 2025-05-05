using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IAdminUserMst
    {
        (int status, string[] message) GetUserCreationStatus(AdminUserMst adminUserMst);
        List<AdminUserMstViewModel> GetAdminUserList(string userCode);
        List<AllUserMstViewModel> GetAllUserList(decimal PAGE_INDEX, decimal PAGE_SIZE);
        List<AllUserMstViewModel> GetAllUserFilterList(decimal PAGE_INDEX, decimal PAGE_SIZE, string P_M_WhereString);
        bool UserUpdateStatus(AdminUserMst adminUserMst);

        List<dcUserViewModel> GetDCList(string IS_DC);
       
    }
}
