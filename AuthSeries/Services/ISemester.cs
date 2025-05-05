using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface ISemester
    {
        List<SemesterListVM> GetSemesterList(string organizationCode);
    }
}

