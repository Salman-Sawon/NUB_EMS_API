using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IAllCommonSetup
    {
        List<AllCommonSetupViewModel> AllCommonSetupList(string userCode, decimal tableId);
        List<AllCommonSetupViewModelNew> AllCommonSetupListNew(string ORG_CODE, decimal SET_UP_ID);
        List<SystemSettingsGrid> SystemSettingsGridList(string ORG_CODE, string User_Id);
        (int Status, string[] message) CrtUptDltAllCommonSetup(AllCommonSetup allCommonSetup);
        (int Status, string[] message) CrtUptDltAllSetupNew(AllSetupNew allSetupNew);
    }
}
