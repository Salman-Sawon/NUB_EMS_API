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
    public class ShiftRepository : IShift
    {
        Database_ora _context;
        public List<ShiftViewModel> GetShiftList(string organizationCode)
        {
            // organizationCode = "00000071";
            List<ShiftViewModel> list = new List<ShiftViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            list = _context.GetList<ShiftViewModel>("DPG_EMS_STD_SUB_MSTDTL_MAP.DPD_EMS_SHIFT_LIST", parameters);

            return list;
        }
    }
}
