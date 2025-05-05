using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface ISection
    {
        List<SectionViewModel> GetSectionList(string organizationCode,string classCode);
        List<SectionModel> GetSection (string userCode);
    }
}
