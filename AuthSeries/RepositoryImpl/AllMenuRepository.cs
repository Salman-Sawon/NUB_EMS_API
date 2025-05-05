using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class AllMenuRepository: IAllMenu
    {
        //Database_ora _context = new Database_ora();
        public List<AllMenuViewModel> GetAllMenuList()
        {
            List<AllMenuViewModel> allmenuList = new List<AllMenuViewModel>();
            Database_ora _context = new Database_ora();
            OracleParameter[] parmaeter = new OracleParameter[1];
            parmaeter[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            allmenuList = _context.GetList<AllMenuViewModel>("DPG_ADMIN_ROLE_MENU_MAP.DPD_ADMIN_ALL_MENU_V3", parmaeter);

            return allmenuList;
        }


        
        public (int status, string[] message) SaveRoleMenu(RoleMenuMapViewModel roleMenuMapViewModel)
        {
            decimal[] ArrMenuItemid = roleMenuMapViewModel.MENU_ITEM_ID.ToArray();

            int status = 0;
            string[] message = new string[2];
            Database_ora _context = new Database_ora();
            OracleParameter[] prmRegister = new OracleParameter[4];
            prmRegister[0] = _context.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            prmRegister[1] = _context.MakeInParameter(roleMenuMapViewModel.ROLE_ID, OracleDbType.Decimal);
            prmRegister[2] = _context.MakeCollectionParameter(ArrMenuItemid, OracleDbType.Decimal, ArrMenuItemid.Length);
            prmRegister[3] = _context.MakeInParameter(roleMenuMapViewModel.USER_CODE, OracleDbType.Varchar2);
    
            status = _context.RunProcedureWithReturnVal("DPG_ADMIN_ROLE_MENU_MAP.DPD_ADMIN_ROLE_MENU_MAP_V3", prmRegister);

            if (status == 1)
            {
                message[0] = "Assigned roles are saved successfully !!";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = "Role assign saved failed. Please try again.";
                message[1] = "#e35b5a";
            }


            return (status, message);
        }


    }
}
