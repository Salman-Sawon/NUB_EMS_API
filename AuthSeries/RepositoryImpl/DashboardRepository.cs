using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Helper.Redis;
using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Dashboard;
using StudentWebAPI.Models.ViewModel.Student;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using static StudentWebAPI.Models.ViewModel.Dashboard.Dashboard;

namespace StudentWebAPI.RepositoryImpl
{
    public class DashboardRepository : IDashboard
    {
        Database_ora db;
        private readonly ICacheService _cacheService = new CacheService();
       


        public List<DashboardClassList> getDashboardClassList(string ORG_CODE)
        {
            string redisKey = ORG_CODE + "_Dashboard_Class";
            var cacheData = _cacheService.GetData<IEnumerable<DashboardClassList>>(redisKey);
            if (cacheData != null)
            {
                return (List<DashboardClassList>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<DashboardClassList> ClassList = new List<DashboardClassList>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            cacheData = db.GetList<DashboardClassList>("DPG_DASHBOARD.DPD_DASHBOARD_CLASS_LIST", parameters);
            _cacheService.SetData<IEnumerable<DashboardClassList>>(redisKey, cacheData, expirationTime);
            return (List<DashboardClassList>)cacheData;
        }




        public List<DashboardBillColGenList> getDashboardBillColGenList(string ORG_CODE, string CAMPUS_CODE)
        {
            string redisKey = ORG_CODE + "_" +CAMPUS_CODE+ "_dashboardBillCollGen";
            var cacheData = _cacheService.GetData<IEnumerable<DashboardBillColGenList>>(redisKey);
            if (cacheData != null)
            {
                return (List<DashboardBillColGenList>)cacheData;
            }

            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<DashboardBillColGenList> BillColGenList = new List<DashboardBillColGenList>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            parameters[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            cacheData = db.GetList<DashboardBillColGenList>("DPG_DASHBOARD.DPD_DASHBOARD_BILL_COL_GEN_LIST", parameters);
            _cacheService.SetData<IEnumerable<DashboardBillColGenList>>(redisKey, cacheData, expirationTime);
            return (List<DashboardBillColGenList>)cacheData;
        }



        public List<DashboardTotalCollGenList> getDashboardTotalCollGenList(string ORG_CODE, string CAMPUS_CODE)
        {
            string redisKey = ORG_CODE + "_" + CAMPUS_CODE + "_dashboardTotalCollGenList";
            var cacheData = _cacheService.GetData<IEnumerable<DashboardTotalCollGenList>>(redisKey);
            if (cacheData != null)
            {
                return (List<DashboardTotalCollGenList>)cacheData;
            }

            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<DashboardBillColGenList> BillColGenList = new List<DashboardBillColGenList>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            parameters[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            cacheData = db.GetList<DashboardTotalCollGenList>("DPG_DASHBOARD.DPD_DASHBOARD_TOTAL_BILL_COL_GEN_LIST", parameters);
            _cacheService.SetData<IEnumerable<DashboardTotalCollGenList>>(redisKey, cacheData, expirationTime);
            return (List<DashboardTotalCollGenList>)cacheData;

        }

        public List<DashboardTeacherAttenList> getDashboardTeacherAttenList(string ORG_CODE)
        {
            List<DashboardTeacherAttenList> TeacherAttenList = new List<DashboardTeacherAttenList>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);


            TeacherAttenList = db.GetList<DashboardTeacherAttenList>("DPG_DASHBOARD.DPD_DASHBOARD_TEACHER_ATTEN_LIST", parameters);
            return TeacherAttenList;
        }

        public List<DashboardNoticeList> getDashboardNoticeList(string ORG_CODE)
        {
            List<DashboardNoticeList> NoticeList = new List<DashboardNoticeList>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);


            NoticeList = db.GetList<DashboardNoticeList>("DPG_DASHBOARD.DPD_DASHBOARD_NOTICE_LIST", parameters);
            return NoticeList;
        }



       

        public List<DashboardTermList> getDashboardTermList(string ORG_CODE)
        {
            List<DashboardTermList> DashboardTermList = new List<DashboardTermList>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            DashboardTermList = db.GetList<DashboardTermList>("DPG_DASHBOARD.DPD_DASHBOARD_TERM_LIST", parameters);
            return DashboardTermList;
        }



        public List<DashboardStudentTotalCollGenList> getDashboardStudentTotalCollGenList(string STUDENT_CODE, string ORG_CODE, string CAMPUS_CODE)
        {
            List<DashboardStudentTotalCollGenList> TotalBillColGenList = new List<DashboardStudentTotalCollGenList>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[4];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(STUDENT_CODE, OracleDbType.Varchar2);
            parameters[2] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            parameters[3] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);

            TotalBillColGenList = db.GetList<DashboardStudentTotalCollGenList>("DPG_DASHBOARD.DPD_DASHBOARD_STUDENT_BILL_COL_GEN_LIST", parameters);
            return TotalBillColGenList;
        }





        public List<StudentLastPayment> getStudentLastPayment(string STUDENT_CODE, string ORG_CODE)
        {
            List<StudentLastPayment> TotalBillColGenList = new List<StudentLastPayment>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(STUDENT_CODE, OracleDbType.Varchar2);
            parameters[2] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);

            TotalBillColGenList = db.GetList<StudentLastPayment>("DPG_DASHBOARD.DPD_DASHBOARD_STUDENT_LAST_COLLECTION", parameters);
            return TotalBillColGenList;
        }



        //public List<DashboardTeacherAttenList> getDashboardTeacherAttenList(string ORG_CODE)
        //{
        //    List<DashboardTeacherAttenList> TeacherAttenList = new List<DashboardTeacherAttenList>();
        //    db = new Database_ora();
        //    OracleParameter[] parameters = new OracleParameter[2];
        //    parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
        //    parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);


        //    TeacherAttenList = db.GetList<DashboardTeacherAttenList>("DPG_DASHBOARD.DPD_DASHBOARD_TEACHER_ATTEN_LIST", parameters);
        //    return TeacherAttenList;
        //}

        //public List<DashboardNoticeList> getDashboardNoticeList(string ORG_CODE)
        //{
        //    List<DashboardNoticeList> NoticeList = new List<DashboardNoticeList>();
        //    db = new Database_ora();
        //    OracleParameter[] parameters = new OracleParameter[2];
        //    parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
        //    parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);


        //    NoticeList = db.GetList<DashboardNoticeList>("DPG_DASHBOARD.DPD_DASHBOARD_NOTICE_LIST", parameters);
        //    return NoticeList;
        //}


        //public List<ResultSummaryList> getDashboarResultSummaryList(string ORG_CODE)
        //{
        //    List<ResultSummaryList> ResultSummaryList = new List<ResultSummaryList>();
        //    db = new Database_ora();
        //    OracleParameter[] parameters = new OracleParameter[2];
        //    parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
        //    parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
        //    ResultSummaryList = db.GetList<ResultSummaryList>("DPG_DASHBOARD.DPD_DASHBOARD_RESULT_SUMMARY_LIST", parameters);
        //    return ResultSummaryList;
        //}


        //public List<DashboardTermList> getDashboardTermList(string ORG_CODE)
        //{
        //    List<DashboardTermList> DashboardTermList = new List<DashboardTermList>();
        //    db = new Database_ora();
        //    OracleParameter[] parameters = new OracleParameter[2];
        //    parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
        //    parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
        //    DashboardTermList = db.GetList<DashboardTermList>("DPG_DASHBOARD.DPD_DASHBOARD_TERM_LIST", parameters);
        //    return DashboardTermList;
        //}






        public string getDashboardData(string ORG_CODE, string CAMPUS_CODE)
        {
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[3];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            string jsonData = db.GetStringData("DPG_DASHBOARD.GET_DD_DATA", Params);
            return jsonData;
        }


        public List<TermSubjExmcaptionListByOrg> getTermSubjExmcaptionList(string ORG_CODE,string CAMPUS_CODE)
        {
            List<TermSubjExmcaptionListByOrg> TermList = new List<TermSubjExmcaptionListByOrg>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            parameters[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            TermList = db.GetList<TermSubjExmcaptionListByOrg>("DPG_ALL_COMMON_SETUP.DPD_GET_TERM_SUBJ_EXMTYPE_LIST", parameters);
            return TermList;
        }



    }
}
