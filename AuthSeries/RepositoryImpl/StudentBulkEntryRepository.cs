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
    public class StudentBulkEntryRepository : IStudentBulkEntry
    {
        Database_ora db;
        public (int status, string[] message) SaveStudentBulkEntry(StudentBulkEntry stdBulkEntry)
        {
            string[] ArrStudentName = stdBulkEntry.STUDENT_NAME.ToArray();
            string[] ArrFatherName = stdBulkEntry.FATHERS_NAME.ToArray();
            string[] ArrClassRoll = stdBulkEntry.CLASS_ROLL.ToArray();
            string[] ArrAdmissionDate = stdBulkEntry.ADMISSION_DATE.ToArray();
            string[] ArrSmsMobileNo = stdBulkEntry.SMS_MOBILE_NUM.ToArray();            
            string[] message = new string[2];
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[20];
            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeOutParameter(OracleDbType.Char, ParameterDirection.Output);
            Params[2] = db.MakeInParameter(stdBulkEntry.ORG_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(stdBulkEntry.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(stdBulkEntry.CLASS_CODE, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(stdBulkEntry.GROUP_CODE, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(stdBulkEntry.SECTION_CODE, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(stdBulkEntry.YEAR_CODE, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(stdBulkEntry.SEMESTER_CODE, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(stdBulkEntry.SHIFT_CODE, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(stdBulkEntry.VERSION_CODE, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(stdBulkEntry.START_SESSION_CODE, OracleDbType.Varchar2);
            Params[12] = db.MakeInParameter(stdBulkEntry.CURRENT_SESSION_CODE, OracleDbType.Varchar2);
            Params[13] = db.MakeCollectionParameter(ArrAdmissionDate, OracleDbType.Varchar2, ArrAdmissionDate.Length);
            Params[14] = db.MakeCollectionParameter(ArrClassRoll, OracleDbType.Varchar2, ArrClassRoll.Length); 
            Params[15] = db.MakeCollectionParameter(ArrStudentName, OracleDbType.Varchar2, ArrStudentName.Length);
            Params[16] = db.MakeCollectionParameter(ArrFatherName, OracleDbType.Varchar2, ArrFatherName.Length);
            Params[17] = db.MakeCollectionParameter(ArrSmsMobileNo, OracleDbType.Varchar2, ArrSmsMobileNo.Length);
            Params[18] = db.MakeInParameter(stdBulkEntry.RowStatus, OracleDbType.Decimal);
            Params[19] = db.MakeInParameter(stdBulkEntry.User_Name, OracleDbType.Varchar2);
            
            var response = db.RunProcedureWithReturnValAndStatus("DPG_EMS_SEARCH_STUDENT_INFO.DPD_EMS_STUDENT_MAST_DTL_ENTRY", Params);

            if (response.status == 1 && stdBulkEntry.RowStatus == 1)
            {
               
                   message[0] = "Students entry is saved successfully.";
            } else if (response.status != 0 && response.status != 1) {
                message[0] = $"Students entry is failed due to duplicate class roll {response.response} is found.";
            }
            else
            {
                message[0] = "Students entry is failed.";
            }

            return (response.status, message);
        }
    }
}

