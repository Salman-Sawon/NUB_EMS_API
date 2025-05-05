using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.ViewModel.User;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class UserRepository : IUser
    {
        Database_ora db = new Database_ora();
        public UserViewModel UserList(string userCode)
        {
            UserViewModel userList = new UserViewModel();
            OracleParameter[] oracleParameter = new OracleParameter[2];
            oracleParameter[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            oracleParameter[1] = db.MakeInParameter(userCode, OracleDbType.Varchar2);


            userList = db.GetModelData<UserViewModel>("DPG_ADMIN_LOGIN.DPD_ADMIN_LOGIN_DATA", oracleParameter);

            return userList;
        }
    }
}
