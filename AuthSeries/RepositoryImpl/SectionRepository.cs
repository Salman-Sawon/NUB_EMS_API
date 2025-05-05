using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Global;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class SectionRepository : ISection
    {
        Database_ora db;


        public List<SectionViewModel> GetSectionList(string organizationCode, string classCode)
        {
            // organizationCode = "00000071";
            // classCode = "00000369";
            List<SectionViewModel> list = new List<SectionViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3]; 
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);
            parameters[2] = db.MakeInParameter(classCode, OracleDbType.Varchar2);

            list = db.GetList<SectionViewModel>("DPG_EMS_STD_SUB_MSTDTL_MAP.DPD_SECTION_LST", parameters);

            return list;
        }

        public List<SectionModel> GetSection (string userCode)
        {
            List<SectionModel> list = new List<SectionModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(userCode, OracleDbType.Varchar2);

            list = db.GetList<SectionModel>("DPG_EMS_SECTION_MST.DPD_EMS_SECTION_GRID", parameters);

            return list;
        }
    }
}
