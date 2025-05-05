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
    public class GroupRepository : IGroup
    {
        Database_ora _context;
        public List<GroupViewModel> GetGroupList(string organizationCode)
        {
           // organizationCode = "00000071";
            List<GroupViewModel> list = new List<GroupViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            list = _context.GetList<GroupViewModel>("DPG_EMS_STD_SUB_MSTDTL_MAP.DPD_GROUP_LST", parameters);

            return list;
        }
    }
}
