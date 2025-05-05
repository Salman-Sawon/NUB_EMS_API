using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models;
using StudentWebAPI.Models.Admin.SetUp;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class DesignationRepository:IDesignation
    {
        Database_ora db ;
        public List<DesignationViewModel> GetDesignationList(string userCode)
        {
            List<DesignationViewModel> designationList = new List<DesignationViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(userCode, OracleDbType.Varchar2);

            designationList = db.GetList<DesignationViewModel>("DPG_DESIGNATION_MST.DPD_DESIGNATION_GRID", parameters);

            return designationList;
        }

        public List<DesignationViewModel> GetDesigList(string organizationCode)
        {
            List<DesignationViewModel> designationList = new List<DesignationViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            designationList = db.GetList<DesignationViewModel>("DPG_EMS_CAMPUS_MST.DPD_DESIGNATION_MST_LIST", parameters);

            return designationList;
        }

        public (int status, string[] message) CrtUptDltDesignation(Designation designation)
        {
            int status = 0;
            string[] message = new string[2];
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[7];
            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(designation.RowStatus, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(designation.ORG_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(designation.DESIGNATION_ID, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(designation.DESIGNATION_CODE, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(designation.DESIGNATION_NAME, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(designation.USER_NAME, OracleDbType.Varchar2);
            status = db.RunProcedureWithReturnVal("DPG_DESIGNATION_MST.DPD_DESIGNATION_MST", Params);

            if (status == 1 && designation.RowStatus == 1)
            {
                message[0] = "Designation is saved successfully !!";
                message[1] = "#5cb85c";
            }

            else if (status == 1 && designation.RowStatus == 2)
            {
                message[0] = "Designation is updated successfully !!";
                message[1] = "#5ae2e3";
            }
            else if (status == 1 && designation.RowStatus == 3)
            {
                message[0] = "Designation is Deleted successfully !!";
                message[1] = "#ce2423";
            }
            else
            {
                message[0] = "Designation is saved failed. Please try again.";
                message[1] = "#e35b5a";
            }

            return (status, message);
        }
    }
}
