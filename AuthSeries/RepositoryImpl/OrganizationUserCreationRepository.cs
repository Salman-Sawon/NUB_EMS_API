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
    public class OrganizationUserCreationRepository : IOrganizationUserCreation
    {
        Database_ora db;
        public List<OrganizationUserCreationGRID> GetOrganizationUser(string userCode)
        {
            List<OrganizationUserCreationGRID> organizationUserList = new List<OrganizationUserCreationGRID>();
            db = new Database_ora(); 
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(userCode, OracleDbType.Varchar2);

            organizationUserList = db.GetList<OrganizationUserCreationGRID>("DPG_ADMIN_USER_MST_WOADMIN.DPD_USER_MASTER_GRID", parameters);

            return organizationUserList;
        }

    //    public (int status, string[] message) AddUserOrganizationCreation(OrganizationUserCreation organizationUserCreation)
    //    {
    //        int status = 0;
    //        string[] message = new string[2];
    //        db = new Database_ora();
    //        OracleParameter[] prmRegister = new OracleParameter[12];
    //        prmRegister[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
    //        prmRegister[1] = db.MakeInParameter(organizationUserCreation.USER_ID, OracleDbType.Decimal);
    //        prmRegister[2] = db.MakeInParameter(organizationUserCreation.USER_CODE, OracleDbType.Varchar2);
    //        prmRegister[3] = db.MakeInParameter(organizationUserCreation.USER_NAME, OracleDbType.Varchar2);
    //        prmRegister[4] = db.MakeInParameter(organizationUserCreation.EMAIL, OracleDbType.Varchar2);
    //        prmRegister[5] = db.MakeInParameter(organizationUserCreation.ORG_CODE, OracleDbType.Varchar2);
    //        prmRegister[6] = db.MakeInParameter(organizationUserCreation.MOBILE_NO, OracleDbType.Varchar2);
    //        prmRegister[7] = db.MakeInParameter(organizationUserCreation.USER_PASSWORD, OracleDbType.Varchar2);
    //        prmRegister[8] = db.MakeInParameter(organizationUserCreation.ROLE_ID, OracleDbType.Decimal);
    //        prmRegister[9] = db.MakeInParameter(organizationUserCreation.USER_TYPE_ID, OracleDbType.Decimal);        
    //        prmRegister[10] = db.MakeInParameter(organizationUserCreation.RowStatus, OracleDbType.Varchar2);
    //        prmRegister[11] = db.MakeInParameter(organizationUserCreation.CREATE_USER, OracleDbType.Varchar2);

    //        status = db.RunProcedureWithReturnVal("DPG_ADMIN_USER_MST_WOADMIN.DPD_USER_MASTER", prmRegister);

    //        if (status == 1 && organizationUserCreation.RowStatus == 1)
    //        {
    //            message[0] = "Organization user creation saved successfully !!";
    //            message[1] = "#5cb85c";
    //        }

    //        else if (status == 1 && organizationUserCreation.RowStatus == 2)
    //        {
    //            message[0] = "Organization user creation updated successfully !!";
    //            message[1] = "#5ae2e3";
    //        }
    //        else if (status == 1 && organizationUserCreation.RowStatus == 3)
    //        {
    //            message[0] = "Organization user creation Deleted successfully !!";
    //            message[1] = "#ce2423";
    //        }
    //        else
    //        {
    //            message[0] = "Organization user creation saved failed. Please try again.";
    //            message[1] = "#e35b5a";
    //        }

    //        return (status, message);
    //    }
    //}
        public (int status, string[] message) AddUserOrganizationCreation(OrgUserCreation organizationUserCreation)
        {
            int status = 0;
            string[] message = new string[2];
            db = new Database_ora();
            OracleParameter[] prmRegister = new OracleParameter[12];
            prmRegister[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            prmRegister[1] = db.MakeInParameter(organizationUserCreation.USER_ID, OracleDbType.Decimal);
            prmRegister[2] = db.MakeInParameter(organizationUserCreation.USER_CODE, OracleDbType.Varchar2);
            prmRegister[3] = db.MakeInParameter(organizationUserCreation.USER_NAME, OracleDbType.Varchar2);
            prmRegister[4] = db.MakeInParameter(organizationUserCreation.EMAIL, OracleDbType.Varchar2);
            prmRegister[5] = db.MakeInParameter(organizationUserCreation.ORG_CODE, OracleDbType.Varchar2);
            prmRegister[6] = db.MakeInParameter(organizationUserCreation.MOBILE_NO, OracleDbType.Varchar2);
            prmRegister[7] = db.MakeInParameter(organizationUserCreation.USER_PASSWORD, OracleDbType.Varchar2);
            prmRegister[8] = db.MakeInParameter(organizationUserCreation.ROLE_ID, OracleDbType.Decimal);
            prmRegister[9] = db.MakeInParameter(organizationUserCreation.USER_TYPE_ID, OracleDbType.Decimal);        
            prmRegister[10] = db.MakeInParameter(organizationUserCreation.RowStatus, OracleDbType.Varchar2);
            prmRegister[11] = db.MakeInParameter(organizationUserCreation.CREATE_USER, OracleDbType.Varchar2);

            status = db.RunProcedureWithReturnVal("DPG_ADMIN_USER_MST_WOADMIN.DPD_USER_MASTER", prmRegister);
            if (status == 1 && organizationUserCreation.RowStatus == 1)
            {
                message[0] = "Organization user creation saved successfully !!";
                message[1] = "#5cb85c";
            }
         

            else if (status == 1 && organizationUserCreation.RowStatus == 2)
            {
                message[0] = "Organization user creation updated successfully !!";
                message[1] = "#5ae2e3";
            }
            else if (status == 1 && organizationUserCreation.RowStatus == 3)
            {
                message[0] = "Organization user creation Deleted successfully !!";
                message[1] = "#ce2423";
            }
            else
            {
                message[0] = "Organization user creation saved failed. Please try again.";
                message[1] = "#e35b5a";
            }

            return (status, message);
        }
    }
}
