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
    public class AllCommonSetupRepository : IAllCommonSetup
    {
        Database_ora db;
        public List<AllCommonSetupViewModel> AllCommonSetupList(string userCode, decimal tableId)
        {
            List<AllCommonSetupViewModel> allCommonSetupList = new List<AllCommonSetupViewModel>();
            db= new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(tableId, OracleDbType.Decimal);
            parameters[2] = db.MakeInParameter(userCode, OracleDbType.Varchar2);

            allCommonSetupList = db.GetList<AllCommonSetupViewModel>("DPG_ALL_COMMON_SETUP.DPD_ALL_COMMON_SETUP_GRID", parameters);

            return allCommonSetupList;
        }

        public List<AllCommonSetupViewModelNew> AllCommonSetupListNew(string ORG_CODE, decimal SET_UP_ID)
        {
            List<AllCommonSetupViewModelNew> allCommonSetupList = new List<AllCommonSetupViewModelNew>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            parameters[2] = db.MakeInParameter(SET_UP_ID, OracleDbType.Decimal);

            allCommonSetupList = db.GetList<AllCommonSetupViewModelNew>("DPG_ALL_COMMON_SETUP.DPD_ALL_COMMON_SETUP_GRID_NEW", parameters);

            return allCommonSetupList;
        }

        public List<SystemSettingsGrid> SystemSettingsGridList(string ORG_CODE, string User_Id)
        {
            List<SystemSettingsGrid> SystemSettingsGridList = new List<SystemSettingsGrid>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Decimal);
            parameters[2] = db.MakeInParameter(User_Id, OracleDbType.Varchar2);

            SystemSettingsGridList = db.GetList<SystemSettingsGrid>("DPG_ALL_COMMON_SETUP.DPD_SYSTEM_SETTINGS_GRID", parameters);

            return SystemSettingsGridList;
        }




        public (int Status, string[] message) CrtUptDltAllCommonSetup(AllCommonSetup allCommonSetup)
        {
            int status = 0;
            string[] message = new string[2];
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[27];
            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(allCommonSetup.RowStatus, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(allCommonSetup.COMMON_ID, OracleDbType.Int32);
            Params[3] = db.MakeInParameter(allCommonSetup.TABLE_ID, OracleDbType.Int32);
            Params[4] = db.MakeInParameter(allCommonSetup.ORAGANIZATION_CODE, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(allCommonSetup.DESCRIPTION, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(allCommonSetup.VARCHAR_1, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(allCommonSetup.VARCHAR_2, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(allCommonSetup.VARCHAR_3, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(allCommonSetup.VARCHAR_4, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(allCommonSetup.VARCHAR_5, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(allCommonSetup.VARCHAR_6, OracleDbType.Varchar2);
            Params[12] = db.MakeInParameter(allCommonSetup.VARCHAR_7, OracleDbType.Varchar2);
            Params[13] = db.MakeInParameter(allCommonSetup.NUMBER_1, OracleDbType.Int64);
            Params[14] = db.MakeInParameter(allCommonSetup.NUMBER_2, OracleDbType.Int64);
            Params[15] = db.MakeInParameter(allCommonSetup.NUMBER_3, OracleDbType.Int64);
            Params[16] = db.MakeInParameter(allCommonSetup.NUMBER_4, OracleDbType.Int64);
            Params[17] = db.MakeInParameter(allCommonSetup.NUMBER_5, OracleDbType.Int64);
            Params[18] = db.MakeInParameter(allCommonSetup.NUMBER_6, OracleDbType.Int64);
            Params[19] = db.MakeInParameter(allCommonSetup.NUMBER_7, OracleDbType.Int64);
            Params[20] = db.MakeInParameter(allCommonSetup.DATE_1, OracleDbType.Date);
            Params[21] = db.MakeInParameter(allCommonSetup.DATE_2, OracleDbType.Date);
            Params[22] = db.MakeInParameter(allCommonSetup.DATE_3, OracleDbType.Date);
            Params[23] = db.MakeInParameter(allCommonSetup.DATE_4, OracleDbType.Date);
            Params[24] = db.MakeInParameter(allCommonSetup.DATE_5, OracleDbType.Date);
            Params[25] = db.MakeInParameter(allCommonSetup.DATE_6, OracleDbType.Date);
            Params[26] = db.MakeInParameter(allCommonSetup.User_Name, OracleDbType.Varchar2);
            status = db.RunProcedureWithReturnVal("DPG_ALL_COMMON_SETUP.DPD_ALL_COMMON_SETUP", Params);

            if (status == 1 && allCommonSetup.RowStatus == 1)
            {
                message[0] = $"{allCommonSetup.VARCHAR_1} is saved successfully !!";
                message[1] = "#5cb85c";
            }

            else if (status == 1 && allCommonSetup.RowStatus == 2)
            {
                message[0] = $"{allCommonSetup.VARCHAR_1} is updated successfully !!";
                message[1] = "#5ae2e3";
            }
            else if (status == 1 && allCommonSetup.RowStatus == 3)
            {
                message[0] = $"{allCommonSetup.VARCHAR_1} is Deleted successfully !!";
                message[1] = "#ce2423";
            }
            else
            {
                message[0] = $"{allCommonSetup.VARCHAR_1} is saved failed. Please try again.";
                message[1] = "#e35b5a";
            }

            return (status, message);
        }


        public (int Status, string[] message) CrtUptDltAllSetupNew(AllSetupNew allSetupNew)
        {
            int status = 0;
            string[] message = new string[2];
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[17];
            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(allSetupNew.ORG_CODE, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(allSetupNew.USER_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(allSetupNew.SET_UP_ID, OracleDbType.Int32);
            Params[4] = db.MakeInParameter(allSetupNew.VALUE_1, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(allSetupNew.VALUE_2, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(allSetupNew.VALUE_3, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(allSetupNew.VALUE_4, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(allSetupNew.VALUE_5, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(allSetupNew.VALUE_6, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(allSetupNew.VALUE_7, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(allSetupNew.VALUE_8, OracleDbType.Varchar2);
            Params[12] = db.MakeInParameter(allSetupNew.VALUE_9, OracleDbType.Varchar2);
            Params[13] = db.MakeInParameter(allSetupNew.VALUE_10, OracleDbType.Varchar2);
            Params[14] = db.MakeInParameter(allSetupNew.VALUE_KEY, OracleDbType.Varchar2);
            Params[15] = db.MakeInParameter(allSetupNew.ROW_STATUS, OracleDbType.Decimal);
            Params[16] = db.MakeInParameter(allSetupNew.ID, OracleDbType.Decimal);
            status = db.RunProcedureWithReturnVal("DPG_ALL_COMMON_SETUP.DPD_ALL_COMMON_SETUP_NEW", Params);

            if (status == 1 && allSetupNew.ROW_STATUS == 1)
            {
                message[0] = $"{allSetupNew.VALUE_1} is saved successfully !!";
                message[1] = "#5cb85c";
            }

            else if (status == 1 && allSetupNew.ROW_STATUS == 2)
            {
                message[0] = $"{allSetupNew.VALUE_1} is updated successfully !!";
                message[1] = "#5ae2e3";
            }
            else if (status == 1 && allSetupNew.ROW_STATUS == 3)
            {
                message[0] = $"{allSetupNew.VALUE_1} is Deleted successfully !!";
                message[1] = "#ce2423";
            }
            else if (status == 100 && allSetupNew.ROW_STATUS == 3)
            {
                message[0] = $"{allSetupNew.VALUE_1} can not delete because it is mapped to class.";
                message[1] = "#ce2423";
            }
            else if (status == 101 && allSetupNew.ROW_STATUS == 3)
            {
                message[0] = $"{allSetupNew.VALUE_1} can not delete because it is mapped to student.";
                message[1] = "#ce2423";
            }

            else if (status == 110 && allSetupNew.ROW_STATUS == 1)
            {
                message[0] = $"{allSetupNew.VALUE_1} can not add because already have class given unique code.";
                message[1] = "#ce2423";
            }

            else if (status == 110 && allSetupNew.ROW_STATUS == 2)
            {
                message[0] = $"{allSetupNew.VALUE_1} can not update because already have class given unique code.";
                message[1] = "#ce2423";
            }
            else if(status == 115 && allSetupNew.ROW_STATUS == 1)
            {
                message[0] = $"{allSetupNew.VALUE_1} is saved successfully !!";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = $"Operation failed. Please try again.";
                message[1] = "#e35b5a";
            }

            return (status, message);
        }
    }
}
