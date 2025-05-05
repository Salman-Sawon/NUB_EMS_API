using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Service;
using System.Collections.Generic;
using System.Data;

namespace StudentWebAPI.RepositoryImpl
{
    public class AdminUserMstRepository: IAdminUserMst
    {
        Database_ora _context;
        public List<AdminUserMstViewModel> GetAdminUserList(string userCode)
        {
            List<AdminUserMstViewModel> adminUserList = new List<AdminUserMstViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);

            adminUserList = _context.GetList<AdminUserMstViewModel>("DPG_ADMIN_USER_MST.DPD_USER_MASTER_GRID", parameters);

            return adminUserList;
        }

           public List<dcUserViewModel> GetDCList(string IS_DC)
        {
            List<dcUserViewModel> dcList = new List<dcUserViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(IS_DC, OracleDbType.Varchar2);

            dcList = _context.GetList<dcUserViewModel>("DPG_ADMIN_USER_MST.DPD_EMS_DC_LIST", parameters);

            return dcList;
        }

        public List<AllUserMstViewModel> GetAllUserList(decimal PAGE_INDEX, decimal PAGE_SIZE)
        {
            List<AllUserMstViewModel> adminUserList = new List<AllUserMstViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(PAGE_INDEX, OracleDbType.Decimal);
            parameters[2] = _context.MakeInParameter(PAGE_SIZE, OracleDbType.Decimal);
            adminUserList = _context.GetList<AllUserMstViewModel>("DPG_ADMIN_USER_MST.DPD_USER_MASTER_GRID_ALL", parameters);

            return adminUserList;
        }
        public List<AllUserMstViewModel> GetAllUserFilterList(decimal PAGE_INDEX, decimal PAGE_SIZE, string P_M_WhereString)
        {
            List<AllUserMstViewModel> adminUserList = new List<AllUserMstViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[4];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(PAGE_INDEX, OracleDbType.Decimal);
            parameters[2] = _context.MakeInParameter(PAGE_SIZE, OracleDbType.Decimal);
            parameters[3] = _context.MakeInParameter(P_M_WhereString, OracleDbType.Varchar2);
            adminUserList = _context.GetList<AllUserMstViewModel>("DPG_ADMIN_USER_MST.DPD_USER_MASTER_GRID_FILTER", parameters);

           return adminUserList;
        }
        public (int status, string[] message) GetUserCreationStatus(AdminUserMst adminUserMst)
        {
            int status = 0;
            string[] message = new string[2];
            _context = new Database_ora();
            OracleParameter[] prmRegister = new OracleParameter[13];
            prmRegister[0] = _context.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            prmRegister[1] = _context.MakeInParameter(adminUserMst.USER_ID, OracleDbType.Decimal);
            prmRegister[2] = _context.MakeInParameter(adminUserMst.USER_CODE, OracleDbType.Varchar2);
            prmRegister[3] = _context.MakeInParameter(adminUserMst.USER_NAME, OracleDbType.Varchar2);
            prmRegister[4] = _context.MakeInParameter(adminUserMst.EMAIL, OracleDbType.Varchar2);
            prmRegister[5] = _context.MakeInParameter(adminUserMst.ORG_CODE, OracleDbType.Varchar2);
            prmRegister[6] = _context.MakeInParameter(adminUserMst.MOBILE_NO, OracleDbType.Varchar2);
            prmRegister[7] = _context.MakeInParameter(adminUserMst.USER_PASSWORD, OracleDbType.Varchar2);
            prmRegister[8] = _context.MakeInParameter(adminUserMst.ROLE_ID, OracleDbType.Decimal);
            prmRegister[9] = _context.MakeInParameter(adminUserMst.USER_TYPE_ID, OracleDbType.Int16);
            prmRegister[10] = _context.MakeInParameter(adminUserMst.DESIG_CODE, OracleDbType.Varchar2);
            prmRegister[11] = _context.MakeInParameter(adminUserMst.rowStatus, OracleDbType.Int16);
            prmRegister[12] = _context.MakeInParameter(adminUserMst.CREATE_USER, OracleDbType.Varchar2);
            status = _context.RunProcedureWithReturnVal("DPG_ADMIN_USER_MST.DPD_USER_MASTER", prmRegister);

            if (status == 1 && adminUserMst.rowStatus == 1)
            {
                message[0] = "User";
                message[1] = "#5cb85c";
            }

            else if (status == 1 && adminUserMst.rowStatus == 2)
            {
                message[0] = "User";
                message[1] = "#5ae2e3";
            }
            else if (status == 1 && adminUserMst.rowStatus == 3)
            {
                message[0] = "User";
                message[1] = "#ce2423";
            }
            else
            {
                message[0] = "User ";
                message[1] = "#e35b5a";
            }

            return (status, message);
        }

        public bool UserUpdateStatus (AdminUserMst adminUserMst)
        {
            bool adminUserUpdate = false;
            _context = new Database_ora();
            OracleParameter[] prmRegister = new OracleParameter[13];
            prmRegister[0] = _context.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            prmRegister[1] = _context.MakeInParameter(adminUserMst.USER_ID, OracleDbType.Decimal);
            prmRegister[2] = _context.MakeInParameter(adminUserMst.USER_CODE, OracleDbType.Varchar2);
            prmRegister[3] = _context.MakeInParameter(adminUserMst.USER_NAME, OracleDbType.Varchar2);
            prmRegister[4] = _context.MakeInParameter(adminUserMst.EMAIL, OracleDbType.Varchar2);
            prmRegister[5] = _context.MakeInParameter(adminUserMst.ORG_CODE, OracleDbType.Varchar2);
            prmRegister[6] = _context.MakeInParameter(adminUserMst.MOBILE_NO, OracleDbType.Varchar2);
            prmRegister[7] = _context.MakeInParameter(null, OracleDbType.Varchar2);
            prmRegister[8] = _context.MakeInParameter(adminUserMst.ROLE_ID, OracleDbType.Decimal);
            prmRegister[9] = _context.MakeInParameter(adminUserMst.USER_TYPE_ID, OracleDbType.Int16);
            prmRegister[10] = _context.MakeInParameter(adminUserMst.DESIG_CODE, OracleDbType.Varchar2);
            prmRegister[11] = _context.MakeInParameter(adminUserMst.rowStatus, OracleDbType.Int16);
            prmRegister[12] = _context.MakeInParameter(adminUserMst.CREATE_USER, OracleDbType.Varchar2);
            
            int status = 0;
            status = _context.RunProcedureWithReturnVal("DPG_ADMIN_USER_MST.DPD_USER_MASTER", prmRegister);

            if (!status.Equals(0))
            {
                adminUserUpdate = true;
            }

            return adminUserUpdate;
        }
    }
}
