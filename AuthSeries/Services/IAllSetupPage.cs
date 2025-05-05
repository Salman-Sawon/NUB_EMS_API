using StudentWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IAllSetupPage
    {
        (int status, string[] message) SaveUptDelAllSetupPage(AllSetupPage allSetupPage);
        List<ComboVM> getComboSerialList(string ORG_CODE, string CAMPUS_CODE);
    }

}
