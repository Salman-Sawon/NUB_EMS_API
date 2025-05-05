using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Helper.Redis;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class CampusRepository : ICampus
    {
        Database_ora _context;
        OracleParameter[] _parameters;
            private readonly ICacheService _cacheService = new CacheService();

        public List<CampusViewModel> GetCampusList(string organizationCode)
        {
            
        string redisKey = organizationCode + "_campusList";
        var cacheData = _cacheService.GetData<IEnumerable<CampusViewModel>>(redisKey);
            if (cacheData != null)
            {
                return (List<CampusViewModel>) cacheData;
            }

        var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<CampusViewModel> campusList = new List<CampusViewModel>();
            _context = new Database_ora();
            _parameters = new OracleParameter[2];
            _parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            _parameters[1] = _context.MakeInParameter(organizationCode, OracleDbType.Varchar2);
            cacheData = _context.GetList<CampusViewModel>("DPG_EMS_STD_SUB_MSTDTL_MAP.DPD_CAMPUS_LST", _parameters);
            _cacheService.SetData<IEnumerable<CampusViewModel>>(redisKey, cacheData, expirationTime);
            return (List<CampusViewModel>) cacheData;
        }
    
        public List<CampusTypeViewModel> GetCampusTypeList()
        {
            List<CampusTypeViewModel> campusTypeList = new List<CampusTypeViewModel>();
            _context = new Database_ora();
            _parameters = new OracleParameter[1];
            _parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            campusTypeList = _context.GetList<CampusTypeViewModel>("DPG_EMS_CAMPUS_MST.DPD_EMS_CAMPUS_TYPE_LIST", _parameters);

            return campusTypeList;
        }
    }
}
