using StudentWebAPI.Models.ViewModel.Dc_Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Services.DC
{
    interface IDcDashboard
    {

        public List<DcDashboardGrid> getDcDashboardList(string USER_CODE,  string FROM_DATE, string TO_DATE);
        public List<DcOrgList> getDcDashboardOrgList(string USER_CODE);
        public List<DcOrgAttenCountList> getDcOrgAttenCountList(string ORG_CODE, string CAMPUS_CODE, string FROM_DATE, string TO_DATE);
        public List<ClassWiseStduDtlVM> getClassWiseStduDtl(ClassWiseStduDtl param);
        public List<DcOrgClassAttList> getDcOrgClassAttList(string ORG_CODE, string CAMPUS_CODE, string ATT_DATE);
        public List<TeacherTechVM> getteacherTeachProgressMst(string ORG_CODE, string CAMPUS_CODE);
        public List<TeacherTechDtlVM> getteacherTeachProgressDtl(string ORG_CODE, string CAMPUS_CODE, string TEACHER_CODE);
        public List<TeacherTechSubDtlVM> getteacherTeachProgressSubDtl(string ORG_CODE, string CAMPUS_CODE, string TEACHER_CODE, decimal SUB_MAP_ID);







    }
}
