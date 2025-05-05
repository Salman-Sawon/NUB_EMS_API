using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IVersion
    {
        List<VersionViewModel> GetVersionList(string organizationCode);
    }
}
