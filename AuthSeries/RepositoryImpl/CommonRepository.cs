
using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Helper.Redis;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Common;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class CommonRepository : ICommon
    {
        Database_ora _context;
        private readonly ICacheService _cacheService = new CacheService();
        public List<ReferenceDataViewModel> GetAllReferenceDataList(string userCode) 
        {
            //will not stay
            string redisKey = userCode + "_AllReferenceData";
            var cacheData = _cacheService.GetData<IEnumerable<ReferenceDataViewModel>>(redisKey);
            if (cacheData != null)
            {
                return (List<ReferenceDataViewModel>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<ReferenceDataViewModel> ClassList = new List<ReferenceDataViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);
            cacheData = _context.GetList<ReferenceDataViewModel>("DPG_EMS_STD_SUB_MSTDTL_MAP.DPD_ALL_REFERENCE_DATA_LIST", parameters);
            _cacheService.SetData<IEnumerable<ReferenceDataViewModel>>(redisKey, cacheData, expirationTime);
            return (List<ReferenceDataViewModel>)cacheData;
        }

        public List<CurSessionVM> GetCurSessionList(string userCode)
        {
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);
            return _context.GetList<CurSessionVM>("DPG_EMS_STD_SUB_MSTDTL_MAP.DPD_CUR_SESSION", parameters);
        }

        public string GetSystemSettingsValueByKey(string Key, string ORG_CODE)
        {
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = _context.MakeReturnValue("ReturnValue", OracleDbType.Varchar2, 5000);
            parameters[1] = _context.MakeInParameter(Key, OracleDbType.Varchar2);
            parameters[2] = _context.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            return _context.RunFunctionString("DPG_EMS_TEACHER_FILE_MST.DPF_EMS_SYSTEM_SETTINGS", parameters);
        }




        public List<Org_image_Url_grid> GetOrg_image_Url_grid(string userCode)
        {
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);
            return _context.GetList<Org_image_Url_grid>("DPG_ORG_MST.DPD_ORG_IMAGE_URL", parameters);
        }










    }
}
