using StudentWebAPI.Models.Admin.SetUp;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IEMSSession
    {
        List<SessionViewModel> GetSessionList(string organizationCode);
        (int status, string[] message) saveSession(Session session);

        SessionMasterViewModel getSessionGridView(string userCode, decimal sessionCode);

       List<StdWiseSession>  GetStudentWiseSession(string ORG_CODE, string CAMPUS_CODE, string STUDENT_CODE);
    }
}
