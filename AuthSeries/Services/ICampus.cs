using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface ICampus
    {
        List<CampusViewModel> GetCampusList(string organizationCode);
        List<CampusTypeViewModel> GetCampusTypeList();
    }
}
