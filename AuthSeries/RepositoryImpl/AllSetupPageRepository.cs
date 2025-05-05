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
    public class AllSetupPageRepository: IAllSetupPage
    {
        Database_ora db;

        public (int status, string[] message) SaveUptDelAllSetupPage(AllSetupPage allSetupPage)
        {
            int status = 0;
            string[] message = new string[2];
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[24];
            Params[0] = db.MakeInParameter(allSetupPage.COMMON_ID, OracleDbType.Decimal);
            Params[1] = db.MakeInParameter(allSetupPage.TABLE_ID, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(allSetupPage.ORAGANIZATION_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(allSetupPage.DESCRIPTION, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(allSetupPage.VARCHAR_1, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(allSetupPage.VARCHAR_2, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(allSetupPage.VARCHAR_3, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(allSetupPage.VARCHAR_4, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(allSetupPage.VARCHAR_5, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(allSetupPage.VARCHAR_6, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(allSetupPage.VARCHAR_7, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(allSetupPage.NUMBER_1, OracleDbType.Decimal);
            Params[12] = db.MakeInParameter(allSetupPage.NUMBER_2, OracleDbType.Decimal);
            Params[13] = db.MakeInParameter(allSetupPage.NUMBER_3, OracleDbType.Decimal);
            Params[14] = db.MakeInParameter(allSetupPage.NUMBER_4, OracleDbType.Decimal);
            Params[15] = db.MakeInParameter(allSetupPage.NUMBER_5, OracleDbType.Decimal);
            Params[16] = db.MakeInParameter(allSetupPage.NUMBER_6, OracleDbType.Decimal);
            Params[17] = db.MakeInParameter(allSetupPage.NUMBER_7, OracleDbType.Decimal);
            Params[18] = db.MakeInParameter(allSetupPage.DATE_1, OracleDbType.Varchar2);
            Params[19] = db.MakeInParameter(allSetupPage.DATE_2, OracleDbType.Varchar2);
            Params[20] = db.MakeInParameter(allSetupPage.DATE_3, OracleDbType.Varchar2);
            Params[21] = db.MakeInParameter(allSetupPage.DATE_4, OracleDbType.Varchar2);
            Params[22] = db.MakeInParameter(allSetupPage.DATE_5, OracleDbType.Varchar2);
            Params[23] = db.MakeInParameter(allSetupPage.DATE_6, OracleDbType.Varchar2);

            status = db.RunProcedureWithReturnVal("PKG_EMS_ALL_COMMON_SETUP.INS_EMS_ALL_COMMON_SETUP", Params);

            if (status == 1)
            {
                message[0] = "Setup page saved successfully !!";
                message[1] = "#5cb85c";
            }
            
            else
            {
                message[0] = "Setup page saved failed. Please try again.";
                message[1] = "#e35b5a";
            }

            return (status, message);
        }


        public List<ComboVM> getComboSerialList(string ORG_CODE, string CAMPUS_CODE)
        {
            List<ComboVM> billMonthList = new List<ComboVM>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            parameters[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            billMonthList = db.GetList<ComboVM>("DPG_ALL_SYSTEM_SETTINGS.DPD_COMBO_SERIAL_LIST", parameters);

            return billMonthList;
        }
    }
}
