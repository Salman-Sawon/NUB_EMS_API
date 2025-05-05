using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IClass
    {
        List<ClassViewModel> GetClassList(string organizationCode);
    }
}
