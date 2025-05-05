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
    public class UserTypeRepository:IUserType
    {
        Database_ora _context;
        public List<UserTypeModel> GetUserTypeList() 
        {
            List<UserTypeModel> userTypeList = new List<UserTypeModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            userTypeList = _context.GetList<UserTypeModel>("DPG_ADMIN_USER_TYPE.DPD_ADMIN_USER_TYPE_GIRD", parameters);

            return userTypeList;
        }


        public (int status, string[] message) SaveUserType (AdminUserType userType)
        {
            decimal[] Array_USER_TYPE_ID = userType.USER_TYPE_ID.ToArray();
            string[] Array_USER_TYPE_DESCR = userType.USER_TYPE_DESCR.ToArray();
            decimal[] ArrDtlRowStatus = userType.RowStatus.ToArray();

            int status = 0;
            string[] message = new string[2];
            _context = new Database_ora();
            OracleParameter[] Params = new OracleParameter[5];
            Params[0] = _context.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = _context.MakeCollectionParameter(Array_USER_TYPE_ID, OracleDbType.Decimal, Array_USER_TYPE_ID.Length);
            Params[2] = _context.MakeCollectionParameter(Array_USER_TYPE_DESCR, OracleDbType.Varchar2, Array_USER_TYPE_DESCR.Length);
            Params[3] = _context.MakeCollectionParameter(ArrDtlRowStatus, OracleDbType.Decimal, ArrDtlRowStatus.Length);
            Params[4] = _context.MakeInParameter(userType.User_Name, OracleDbType.Varchar2);
            status = _context.RunProcedureWithReturnVal("DPG_ADMIN_USER_TYPE.DPD_USER_TYPE_INSRT_UPDT_DEL", Params);

            if (status == 1 && userType.RowStatus[0] == 1)
            {
                message[0] = "User Type saved successfully !!";
                message[1] = "#5cb85c";

            }
            else if (status == 1 && userType.RowStatus[0] == 2)
            {
                message[0] = "User Type updated successfully !!";
                message[1] = "#5cb85c";
            }
            else if (status == 1 && userType.RowStatus[0] == 3)
            {
                message[0] = "User Type deleted successfully !!";
                message[1] = "#5cb85c";
            }

            else
            {
                message[0] = "User Type saving is failed. Please try again.";
                message[1] = "#e35b5a";

            }


            return (status, message);
        }

    }
}


