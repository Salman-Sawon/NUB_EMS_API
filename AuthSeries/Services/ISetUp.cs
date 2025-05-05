using StudentWebAPI.Models.Admin.SetUp;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface ISetUp
    {
        List<OrganizationInfoViewModel> OrganizationInfoList();
      public  (int status, string[] message) OrganizationInfo(OrganizationInfo organizationInfo);
    }
}
