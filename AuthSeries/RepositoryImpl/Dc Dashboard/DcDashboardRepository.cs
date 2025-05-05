using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.ViewModel.Dc_Dashboard;
using StudentWebAPI.Services.DC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl.Dc_Dashboard
{



   
    public class DcDashboardRepository: IDcDashboard
    {
        Database_ora db;
        private OracleParameter[] param;


        public List<DcDashboardGrid> getDcDashboardList(string USER_CODE, string FROM_DATE, string TO_DATE)
        {
            List<DcDashboardGrid> dashboardlist = new List<DcDashboardGrid>();

            db = new Database_ora();
            param = new OracleParameter[4];
            param[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            param[1] = db.MakeInParameter(USER_CODE, OracleDbType.Varchar2);
            param[2] = db.MakeInParameter(FROM_DATE, OracleDbType.Varchar2);
            param[3] = db.MakeInParameter(TO_DATE, OracleDbType.Varchar2);

            dashboardlist = db.GetList<DcDashboardGrid>("DPG_EMS_DC_DASHBOARD.DPD_DC_DASHBOARD_LIST", param);

            return dashboardlist;
        }


        public List<DcOrgList> getDcDashboardOrgList(string USER_CODE)
        {
            List<DcOrgList> dashboardlist = new List<DcOrgList>();
            db = new Database_ora();
            param = new OracleParameter[2];
            param[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            param[1] = db.MakeInParameter(USER_CODE, OracleDbType.Varchar2);           
            dashboardlist = db.GetList<DcOrgList>("DPG_EMS_DC_DASHBOARD.DPD_DC_DASHBOARD_ORG_LIST", param);

            return dashboardlist;
        }

        public List<DcOrgAttenCountList> getDcOrgAttenCountList(string ORG_CODE, string CAMPUS_CODE, string FROM_DATE, string TO_DATE)
        {
            List<DcOrgAttenCountList> dashboardlist = new List<DcOrgAttenCountList>();

            db = new Database_ora();
            param = new OracleParameter[5];
            param[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            param[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            param[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            param[3] = db.MakeInParameter(FROM_DATE, OracleDbType.Varchar2);
            param[4] = db.MakeInParameter(TO_DATE, OracleDbType.Varchar2);

            dashboardlist = db.GetList<DcOrgAttenCountList>("DPG_EMS_DC_DASHBOARD.DPD_DC_ORG_ATTEN_COUNT_LIST", param);

            return dashboardlist;
        }

        public List<ClassWiseStduDtlVM> getClassWiseStduDtl(ClassWiseStduDtl classParam)
        {
            List<ClassWiseStduDtlVM> dashboardlist = new List<ClassWiseStduDtlVM>();

            db = new Database_ora();
            param = new OracleParameter[6];
            param[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            param[1] = db.MakeInParameter(classParam.OrgCode, OracleDbType.Varchar2);
            param[2] = db.MakeInParameter(classParam.CampusCode, OracleDbType.Varchar2);
            param[3] = db.MakeInParameter(classParam.ClassCode, OracleDbType.Varchar2);
            param[4] = db.MakeInParameter(classParam.AttDate, OracleDbType.Varchar2);
            param[5] = db.MakeInParameter(classParam.AttStatus, OracleDbType.Varchar2);

            dashboardlist = db.GetList<ClassWiseStduDtlVM>("DPG_DASHBOARD.GET_CLASS_WISE_STD_DTL", param);

            return dashboardlist;
        }
        public List<DcOrgClassAttList> getDcOrgClassAttList(string ORG_CODE, string CAMPUS_CODE, string ATT_DATE)
        {
            List<DcOrgClassAttList> dashboardlist = new List<DcOrgClassAttList>();

            db = new Database_ora();
            param = new OracleParameter[4];
            param[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            param[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            param[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            param[3] = db.MakeInParameter(ATT_DATE, OracleDbType.Varchar2);

            dashboardlist = db.GetList<DcOrgClassAttList>("DPG_DASHBOARD.GET_CLASS_WISE_ATT_DC", param);

            return dashboardlist;
        }

        public List<TeacherTechVM> getteacherTeachProgressMst(string ORG_CODE, string CAMPUS_CODE)
        {
            List<TeacherTechVM> data = new List<TeacherTechVM>();

            db = new Database_ora();
            param = new OracleParameter[3];
            param[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            param[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            param[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            data = db.GetList<TeacherTechVM>("DPG_DASHBOARD.DPD_TEACHER_TEACH_PROGRESS", param);
            return data;
        }

        public List<TeacherTechDtlVM> getteacherTeachProgressDtl(string ORG_CODE, string CAMPUS_CODE, string TEACHER_CODE)
        {
            List<TeacherTechDtlVM> data = new List<TeacherTechDtlVM>();

            db = new Database_ora();
            param = new OracleParameter[4];
            param[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            param[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            param[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            param[3] = db.MakeInParameter(TEACHER_CODE, OracleDbType.Varchar2);
            data = db.GetList<TeacherTechDtlVM>("DPG_DASHBOARD.DPD_TEACHER_TEACH_PROGRESS_DTL", param);
            return data;
        }

        public List<TeacherTechSubDtlVM> getteacherTeachProgressSubDtl(string ORG_CODE, string CAMPUS_CODE, string TEACHER_CODE, decimal SUB_MAP_ID)
        {
            List<TeacherTechSubDtlVM> data = new List<TeacherTechSubDtlVM>();

            db = new Database_ora();
            param = new OracleParameter[5];
            param[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            param[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            param[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);
            param[3] = db.MakeInParameter(TEACHER_CODE, OracleDbType.Varchar2);
            param[4] = db.MakeInParameter(SUB_MAP_ID, OracleDbType.Decimal);
            data = db.GetList<TeacherTechSubDtlVM>("DPG_DASHBOARD.DPD_TEACHER_TEACH_PROGRESS_SUB_DTL", param);
            return data;
        }
    }
}
