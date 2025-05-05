using StudentWebAPI.Models;
using StudentWebAPI.Models.Admin.SetUp;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IDesignation
    {
        List<DesignationViewModel> GetDesignationList(string userCode);
        List<DesignationViewModel> GetDesigList(string organizationCode);
        (int status, string[] message) CrtUptDltDesignation(Designation desination);
    }
}
