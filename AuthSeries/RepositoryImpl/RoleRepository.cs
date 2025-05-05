using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class RoleRepository : IRole
    {
        Database_ora _context;
        public List<RoleModel> GetRoleList()
        {
            List<RoleModel> roleList = new List<RoleModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            roleList = _context.GetList<RoleModel>("DPG_ADMIN_ROLE_MST.DPD_ADMIN_USER_ROLE_GIRD", parameters);

            return roleList;
        }

     
        public (int status, string[] message) SaveUserRole (AdminRoleMst userRole)
        {
            decimal[] Array_ROLE_ID = userRole.ROLE_ID.ToArray();
            string[] Array_ROLE_DESCR = userRole.ROLE_DESCR.ToArray();
            decimal[] ArrDtlRowStatus = userRole.RowStatus.ToArray();

            int status = 0;
            string[] message = new string[2];
            _context = new Database_ora();
            OracleParameter[] Params = new OracleParameter[5];
            Params[0] = _context.MakeOutParameter(OracleDbType.Decimal, ParameterDirection.Output);
            Params[1] = _context.MakeCollectionParameter(Array_ROLE_ID, OracleDbType.Decimal, Array_ROLE_ID.Length);
            Params[2] = _context.MakeCollectionParameter(Array_ROLE_DESCR, OracleDbType.Varchar2, Array_ROLE_DESCR.Length);
            Params[3] = _context.MakeCollectionParameter(ArrDtlRowStatus, OracleDbType.Decimal, ArrDtlRowStatus.Length);
            Params[4] = _context.MakeInParameter(userRole.User_Name, OracleDbType.Varchar2);
            status = _context.RunProcedureWithReturnVal("DPG_ADMIN_ROLE_MST.DPD_USER_ROLE_INSRT_UPDT_DEL", Params);
            
            if (status == 1 && userRole.RowStatus[0] == 1)
            {
                message[0] = "User role saved successfully. ";
                message[1] = "#5cb85c";

            }
            else if (status == 1 && userRole.RowStatus[0] == 2)
            {
                message[0] = "User role updated successfully. ";
                message[1] = "#5cb85c";
            }
            else if (status == 1 && userRole.RowStatus[0] == 3)
            {
                message[0] = "User role deleted successfully. ";
                message[1] = "#5cb85c";
            }

            else
            {
                message[0] = "User Role saving is failed. Please try again.";
                message[1] = "#e35b5a";

            }


            return (status, message);
        }

    }
}


