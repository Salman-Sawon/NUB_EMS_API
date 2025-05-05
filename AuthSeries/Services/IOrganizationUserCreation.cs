using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IOrganizationUserCreation
    {
        //List<OrganizationUserCreationGRID> GetOrganizationUser(string userCode);
        (int status, string[] message) AddUserOrganizationCreation(OrgUserCreation organizationUserCreation);
    }
}