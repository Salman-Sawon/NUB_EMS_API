using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IYear
    {
        public List<YearListVM> GetYearList(string organizationCode);
    }
}
