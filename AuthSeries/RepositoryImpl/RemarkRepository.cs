using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class RemarkRepository: IRemark
    {
        Database_ora _context;

        //Exam Subject Relation
        public List<RemarkViewModel> GetRemarkList(string organizationCode)
        {
            // organizationCode = "00000071";
            List<RemarkViewModel> list = new List<RemarkViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            list = _context.GetList<RemarkViewModel>("DPG_EMS_EXM_RES_SUB_MSTDTL.DPD_REMARKS_LST", parameters);
            

            return list;
        }
        
        //Exam Result Distribution
        public List<RemarkViewModel> GetDistributionRemarkList(string organizationCode, string userCode)
        {
            // organizationCode = "00000071";
            List<RemarkViewModel> list = new List<RemarkViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(organizationCode, OracleDbType.Varchar2);
            parameters[2] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);

            list = _context.GetList<RemarkViewModel>("DPG_EMS_EXAM_RESLT_DIST_MSTDTL.DPD_REMARKS_LST", parameters);

            return list;
        }

        //Exam Result Entry
        public List<RemarkViewModel> GetResultEntryRemarkList(string organizationCode, string userCode)
        {
            // organizationCode = "00000071";
            List<RemarkViewModel> list = new List<RemarkViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(organizationCode, OracleDbType.Varchar2);
            parameters[2] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);

            list = _context.GetList<RemarkViewModel>("DPG_EMS_EXAM_RESULT_MSTDTL.DPD_EXAM_RESULT_REMARKS_LST", parameters);

            return list;
        }
    }
}
