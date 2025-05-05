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
    public class VersionRepository : IVersion
    {
        Database_ora _context;
        private readonly ICacheService _cacheService = new CacheService();

        public List<VersionViewModel> GetVersionList(string organizationCode)
        {
            string redisKey = organizationCode + "_VersionList";
            var cacheData = _cacheService.GetData<IEnumerable<VersionViewModel>>(redisKey);
            if (cacheData != null)
            {
                return (List<VersionViewModel>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<VersionViewModel> versionList = new List<VersionViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(organizationCode, OracleDbType.Varchar2);
            versionList = _context.GetList<VersionViewModel>("DPG_EMS_STD_SUB_MSTDTL_MAP.DPD_EMS_VERSION_LIST", parameters);
            cacheData = versionList;
            _cacheService.SetData<IEnumerable<VersionViewModel>>(redisKey, cacheData, expirationTime);
            return (List<VersionViewModel>)cacheData;
        }
    }
}
