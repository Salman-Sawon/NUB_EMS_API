using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class UserRoleAssignRepository: IUserRoleAssign
    {
        Database_ora _context;
        public List<UserRoleAssign> GetUserRoleAssignList(int roleId)
        {
            List<UserRoleAssign> user_role_assignList = new List<UserRoleAssign>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(roleId, OracleDbType.Int16);

            user_role_assignList = _context.GetList<UserRoleAssign>("DPG_ADMIN_ROLE_MENU_MAP.DPD_USER_MENU_LIST_ASSIGN_V3", parameters);

            return user_role_assignList;
        }

        public List<UserRoleAssign> GetUserRoleUnassignList(int roleId)
        {
            List<UserRoleAssign> user_role_unassignList = new List<UserRoleAssign>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(roleId, OracleDbType.Int16);

            user_role_unassignList = _context.GetList<UserRoleAssign>("DPG_ADMIN_ROLE_MENU_MAP.DPD_USER_MENU_LIST_UNASSIGN", parameters);

            return user_role_unassignList;
        }

    }
}
