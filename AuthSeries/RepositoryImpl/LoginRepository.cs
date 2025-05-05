using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.RepositoryImpl.GoogleDrive;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class LoginRepository : ILogin
    {
        GoogleUtility _googleDriveUtility;
        Database_ora _context;

        public LoginRepository()
        {
           
            _googleDriveUtility = new GoogleUtility();
          

        }




        public bool CheckValidLogin(string userName, string password)
        {
            bool isLoginValid = false;
            _context = new Database_ora();
            OracleParameter[] prmLogin = new OracleParameter[3];
            prmLogin[0] = _context.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            prmLogin[1] = _context.MakeInParameter(userName, OracleDbType.Varchar2);
            prmLogin[2] = _context.MakeInParameter(password, OracleDbType.Varchar2);

            int status = 0;
            status = _context.RunProcedureWithReturnVal("DPG_ADMIN_LOGIN.DPD_ADMIN_LOGIN", prmLogin);

            if (!status.Equals(0))
            {
                isLoginValid = true;
            }

             return isLoginValid;
        }

        public AdminUserMst GetLoginData(string userCode, string password)
        {
            AdminUserMst loginData = new AdminUserMst();
            _context = new Database_ora();
            OracleParameter[] oracleParameter = new OracleParameter[3];
            oracleParameter[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            oracleParameter[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);
            oracleParameter[2] = _context.MakeInParameter(password, OracleDbType.Varchar2);


            loginData = _context.GetModelData<AdminUserMst>("DPG_ADMIN_LOGIN.DPD_ADMIN_LOGIN_CHECK", oracleParameter);

            return loginData;
        }
        public AdminUserMstVM GetLoggedData(string userCode, string password)
        {
            AdminUserMstVM loginData = new AdminUserMstVM();
            _context = new Database_ora();
            OracleParameter[] oracleParameter = new OracleParameter[3];
            oracleParameter[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            oracleParameter[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);
            oracleParameter[2] = _context.MakeInParameter(password, OracleDbType.Varchar2);


            loginData = _context.GetModelData<AdminUserMstVM>("DPG_ADMIN_LOGIN.DPD_ADMIN_LOGIN_STATUS_CHECK", oracleParameter);


            if (loginData.ORG_IMAGE_URL != null)
            {
                string imageUrl = loginData.ORG_IMAGE_URL?.ToString();

                if (!string.IsNullOrEmpty(imageUrl))
                {
                    string base64Image = _googleDriveUtility.GetFilesByte(imageUrl);

                    loginData.ORG_IMAGE_BYTE = base64Image;
                }



            }





            return loginData;
        }

        //Change Password
        public (int status, string[] message) ChangePassword(ChangePasswordViewModel changePass)
        {
            int status = 0;
            string[] message = new string[2];
            _context = new Database_ora();
            OracleParameter[] oracleParameter = new OracleParameter[5];
            oracleParameter[0] = _context.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            oracleParameter[1] = _context.MakeInParameter(changePass.USER_CODE, OracleDbType.Varchar2);
            oracleParameter[2] = _context.MakeInParameter(changePass.OLD_PASSWORD, OracleDbType.Varchar2);
            oracleParameter[3] = _context.MakeInParameter(changePass.NEW_PASSWORD, OracleDbType.Varchar2);
            oracleParameter[4] = _context.MakeInParameter(changePass.UPDATE_USER, OracleDbType.Varchar2);

            status = _context.RunProcedureWithReturnVal("DPG_ADMIN_LOGIN.DPD_ADMIN_PASS_CHANGE", oracleParameter);

            if (status == 1)
            {
                message[0] = "Password is changed successfully !!";
                message[1] = "#5cb85c";
            }

            else
            {
                message[0] = "Password is not changed. Please try again.";
                message[1] = "#e35b5a";
            }

            return (status, message);
        }
    }
}
