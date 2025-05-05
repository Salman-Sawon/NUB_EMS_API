using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IOrganization
    {
        List<OrganizationViewModel> GetOrganizationList(string userCode);
        List<OrganizationViewModel> GetAllOrganizationList();
        List<OrganizationTypeViewModel> OrganizationTypeList();
        List<OrganizationUserCreationVM> GetOrganizationUser(string userCode);
    }
}
