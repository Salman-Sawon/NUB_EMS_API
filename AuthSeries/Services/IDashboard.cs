using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static StudentWebAPI.Models.ViewModel.Dashboard.Dashboard;

namespace StudentWebAPI.Service
{
    public interface IDashboard
    {

        List<DashboardClassList> getDashboardClassList(string ORG_CODE);

        List<DashboardBillColGenList> getDashboardBillColGenList(string ORG_CODE, string CAMPUS_CODE);
        string getDashboardData(string ORG_CODE, string CAMPUS_CODE);


        List<DashboardTotalCollGenList> getDashboardTotalCollGenList(string ORG_CODE, string CAMPUS_CODE);

        List<DashboardStudentTotalCollGenList> getDashboardStudentTotalCollGenList(string STUDENT_CODE, string ORG_CODE, string CAMPUS_CODE);

        List<StudentLastPayment> getStudentLastPayment(string STUDENT_CODE, string ORG_CODE);

        List<DashboardTeacherAttenList> getDashboardTeacherAttenList(string ORG_CODE);

        List<DashboardNoticeList> getDashboardNoticeList(string ORG_CODE);

        List<DashboardTermList> getDashboardTermList(string ORG_CODE);
        List<TermSubjExmcaptionListByOrg> getTermSubjExmcaptionList(string ORG_CODE, string CAMPUS_CODE);



    }
}
