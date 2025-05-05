using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IRemark
    {
        List<RemarkViewModel> GetRemarkList(string organizationCode);

        List<RemarkViewModel> GetDistributionRemarkList(string organizationCode, string userCode);
        List<RemarkViewModel> GetResultEntryRemarkList(string organizationCode, string userCode);
    }
}
