using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubjectViewModel = StudentWebAPI.Models.ViewModel.Global.SubjectViewModel;

namespace StudentWebAPI.Service
{
    public interface IGlobalDataByOrg
    {
        List<SubjectViewModel> GetSubjectList(string organizationCode);
        List<BirthPlaceViewModel> GetBirthPlaceList();
        List<DesignationList> GetDesignationList();
        List<DepartmentList> GetDepartmentList();
        List<NationalityViewModel> GetNationalityList(string organizationCode);
        List<ReligionViewModel> GetReligionList(string organizationCode);
        List<GenderViewModel> GetGenderList(string organizationCode);
        List<BloodGroupViewModel> GetBloodGroupList(string organizationCode);
        List<TeacherViewModel> GetTeacherList(string organizationCode);
        List<Board_UniversityViewModel> GetBoardOrUniList(string organizationCode);
        List<OccupationViewModel> GetOccupationList(string organizationCode);
        List<DistrictViewModel> GetDistrictList();
        List<RelationTypeViewModel> GetRelationTypeList(string organizationCode);


        

        // Common Table Information List
        List<CommonTableInfoViewModel> GetCommonTableInfoList(string userCode);
        List<setUpInfoViewModel> GetCommonTableInfoListNew();

        List<CountryViewModel> CountryList();
        List<DevisionViewModel> DevisionList(string devision);
        List<DistrictViewModel> DistrictList(string district);
        List<ThanaViewModel> ThanaList(string thana);

        // Session Start End Month Voucher List
        List<Session_Start_End_Month_VuViewModel> sessionSrtEndMonthVoucherList(string sessionCode, string organizationCode, string userCode);

        // get manual id number
        int GetManualNumber(string userName);
        int GetCollectionId(string userName);
        int GetWorkingdays(string ORG_CODE, string CLASS_CODE, string VERSION_CODE, string GROUP_CODE, string SESSION_CODE, string YEAR_CODE, string SEMESTER_CODE, string SECTION_CODE, decimal TERM_ID);

        int GetVoucherNO(string userName);
        int GetVoucherNO_UNIQ(string userName);


        public List<ExamBoardInfo> GetBoardExamList(string organizationCode);

    }
}
                                                         