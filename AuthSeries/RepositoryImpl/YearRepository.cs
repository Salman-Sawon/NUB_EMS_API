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
    public class YearRepository : IYear
    {
        Database_ora _context;
        public List<YearListVM> GetYearList(string organizationCode)
        {
            List<YearListVM> list = new List<YearListVM>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            list = _context.GetList<YearListVM>("DPG_EMS_STD_SUB_MSTDTL_MAP.DPD_YEAR_LST", parameters);

            return list;
        }
    }
}
