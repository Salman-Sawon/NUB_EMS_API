using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.Admin.SetUp;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class SessionRepository : IEMSSession
    {
        Database_ora _context;

        public List<SessionViewModel> GetSessionList(string organizationCode)
        {
            // organizationCode = "00000071";
            List<SessionViewModel> list = new List<SessionViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            list = _context.GetList<SessionViewModel>("DPG_EMS_STD_SUB_MSTDTL_MAP.DPD_SESSION_LST", parameters);

            return list;
        }
        public List<StdWiseSession> GetStudentWiseSession(string ORG_CODE, string CAMPUS_CODE, string STUDENT_CODE)
        {
            List<StdWiseSession> sessinlist = new List<StdWiseSession>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[4];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            parameters[2] = _context.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            parameters[3] = _context.MakeInParameter(STUDENT_CODE, OracleDbType.Varchar2);

            sessinlist =_context.GetList<StdWiseSession>("DPG_EMS_SESSION_MST.DPD_STUDENT_WISE_SESSION", parameters);

            return sessinlist;
        }

        public (int status, string[] message) saveSession(Session session)
        {
            try { 
            decimal[] ArrSessionDtlid = session.Session_Dtl_Id.ToArray();
            string[] ArrBillMonth = session.Bill_Month.ToArray();
            string[] ArrBillMonthStartDate = session.DTL_START_DATE.ToArray();
            string[] ArrBillMonthEndDate = session.DTL_END_DATE.ToArray();
            string[] ArrBillDate = session.Bill_Date.ToArray();
            string[] ArrDueDate = session.Due_Date.ToArray();
            decimal[] ArrDtlRowStatus = session.Row_Status.ToArray();

            int status = 0;
            string[] message = new string[2];
            _context = new Database_ora();

            OracleParameter[] Params = new OracleParameter[16];
            Params[0] = _context.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = _context.MakeInParameter(session.Session_Id, OracleDbType.Decimal);
            Params[2] = _context.MakeInParameter(session.Org_Code, OracleDbType.Varchar2);
            Params[3] = _context.MakeInParameter(session.Session_Code, OracleDbType.Varchar2);
            Params[4] = _context.MakeInParameter(session.Session_Name, OracleDbType.Varchar2);
            Params[5] = _context.MakeInParameter(session.Session_Name_Bangla, OracleDbType.Varchar2);
            Params[6] = _context.MakeInParameter(session.Start_Date, OracleDbType.Varchar2);
            Params[7] = _context.MakeInParameter(session.End_Date, OracleDbType.Varchar2);
            Params[8] = _context.MakeInParameter(session.User_Code, OracleDbType.Varchar2);
            Params[9] = _context.MakeCollectionParameter(ArrSessionDtlid, OracleDbType.Decimal, ArrSessionDtlid.Length);
            Params[10] = _context.MakeCollectionParameter(ArrBillMonth, OracleDbType.Varchar2, ArrBillMonth.Length);
            Params[11] = _context.MakeCollectionParameter(ArrBillMonthStartDate, OracleDbType.Varchar2, ArrBillMonthStartDate.Length);
            Params[12] = _context.MakeCollectionParameter(ArrBillMonthEndDate, OracleDbType.Varchar2, ArrBillMonthEndDate.Length);
            Params[13] = _context.MakeCollectionParameter(ArrBillDate, OracleDbType.Varchar2, ArrBillDate.Length);
            Params[14] = _context.MakeCollectionParameter(ArrDueDate, OracleDbType.Varchar2, ArrDueDate.Length);
            Params[15] = _context.MakeCollectionParameter(ArrDtlRowStatus, OracleDbType.Decimal, ArrDtlRowStatus.Length);
            status = _context.RunProcedureWithReturnVal("DPG_EMS_SESSION_MST.DPD_EMS_SESSION_MSTDTL", Params);

            if (status == 1 && session.Row_Status[0] == 1)
            {
                message[0] = "Session Info saved successfully !!";
                message[1] = "#5cb85c";
                //message[2] = status.ToString();
            }
            else if (status == 1 && session.Row_Status[0] == 2)
            {
                message[0] = "Session Info updated successfully !!";
                message[1] = "#5cb85c";
                //message[2] = status.ToString();
            }
            else
            {
                message[0] = "Session Info saved failed. Please try again.";
                message[1] = "#e35b5a";
                //message[2] = status.ToString();
            }

            return (status, message);
            }
            catch (Exception ex)
            {
                string[] message = new string[2];
                message[0] = ex.Message;
                int status = 0;
                return (status, message);
            }
        }

        public SessionMasterViewModel getSessionGridView(string userCode, decimal sessionCode)
        {
            SessionMasterViewModel getSessionMasterList = new SessionMasterViewModel();
            List<SessionDtlViewModel> sessionList = new List<SessionDtlViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters;
            parameters = new OracleParameter[3];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);
            parameters[2] = _context.MakeInParameter(sessionCode, OracleDbType.Decimal);

            getSessionMasterList = _context.GetModelData<SessionMasterViewModel>("DPG_EMS_SESSION_MST.DPD_EMS_SESSION_MST_GRID", parameters);

            _context = new Database_ora();
            parameters = new OracleParameter[3];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);
            parameters[2] = _context.MakeInParameter(sessionCode, OracleDbType.Decimal);

            sessionList = _context.GetList<SessionDtlViewModel>("DPG_EMS_SESSION_MST.DPD_EMS_SESSION_DTL_GRID", parameters);

            if (getSessionMasterList != null)
            {

                getSessionMasterList.SESSION_DTL_ID = new List<decimal>();
                getSessionMasterList.BILL_MONTH = new List<string>();
                getSessionMasterList.DTL_START_DATE = new List<string>();
                getSessionMasterList.DTL_END_DATE = new List<string>();
                getSessionMasterList.BILL_DATE = new List<string>();
                getSessionMasterList.DUE_DATE = new List<string>();

                for (int i = 0; i < sessionList.Count; i++)
                {
                    getSessionMasterList.SESSION_DTL_ID.Add(sessionList[i].SESSION_DTL_ID);
                    getSessionMasterList.BILL_MONTH.Add(sessionList[i].BILL_MONTH);
                    getSessionMasterList.DTL_START_DATE.Add(sessionList[i].START_DATE);
                    getSessionMasterList.DTL_END_DATE.Add(sessionList[i].END_DATE);
                    getSessionMasterList.BILL_DATE.Add(sessionList[i].BILL_DATE);
                    getSessionMasterList.DUE_DATE.Add(sessionList[i].DUE_DATE);

                }
            }

            return getSessionMasterList;
        }
      
        
             
                
        
    }
}
