using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface ICommon
    {

        List<ReferenceDataViewModel> GetAllReferenceDataList(string userCode);
        List<CurSessionVM> GetCurSessionList(string userCode);
        List<Org_image_Url_grid> GetOrg_image_Url_grid(string userCode);
        public string GetSystemSettingsValueByKey(string Key, string ORG_CODE);



       
    }
}
