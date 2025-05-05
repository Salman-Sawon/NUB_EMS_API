using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Helper.Redis;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Global;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using SubjectViewModel = StudentWebAPI.Models.ViewModel.Global.SubjectViewModel;

namespace StudentWebAPI.RepositoryImpl
{
    public class GlobalDataByOrgRepository : IGlobalDataByOrg
    {
        Database_ora db;
        private readonly ICacheService _cacheService = new CacheService();
        public GlobalDataByOrgRepository()
        {

        }
        //public GlobalDataByOrgRepository(ICacheService cacheService)
        //{
        //    _cacheService = cacheService;
        //}
        public List<SubjectViewModel> GetSubjectList(string organizationCode)
        {
            List<SubjectViewModel> subjectList = new List<SubjectViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            subjectList = db.GetList<SubjectViewModel>("DPG_RESULT_INFO.DPD_RESULT_SUBJECT_LIST", parameters);

            for(int i = 0; i < subjectList.Count; i++)            
            {
                subjectList[i].SELECT = false; 
            }

            return subjectList;
        }
        public List<BirthPlaceViewModel> GetBirthPlaceList()
        {
            List<BirthPlaceViewModel> birthPlaceList = new List<BirthPlaceViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            birthPlaceList = db.GetList<BirthPlaceViewModel>("DPG_TEACHER_MST.DPD_EMS_DISTRICT_LIST", parameters);

            return birthPlaceList;
        }
        
        public List<DepartmentList> GetDepartmentList()
        {
            List<DepartmentList> department = new List<DepartmentList>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            department = db.GetList<DepartmentList>("DPG_TEACHER_MST.DPD_EMS_DEPARTMENT_LIST", parameters);

            return department;
        }

        public List<DesignationList> GetDesignationList()
        {
            List<DesignationList> designaionList = new List<DesignationList>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            designaionList = db.GetList<DesignationList>("DPG_TEACHER_MST.DPD_EMS_DESIGNATION_LIST", parameters);

            return designaionList;
        }
        public List<NationalityViewModel> GetNationalityList(string organizationCode)
        {
            string redisKey = "nationalityList";
            var cacheData = _cacheService.GetData<IEnumerable<NationalityViewModel>>(redisKey);
            if (cacheData != null)
            {
                return (List<NationalityViewModel>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<NationalityViewModel> nationalityList = new List<NationalityViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            nationalityList = db.GetList<NationalityViewModel>("DPG_TEACHER_MST.DPD_NATIONALITY_LST", parameters);

            cacheData = nationalityList;
            _cacheService.SetData<IEnumerable<NationalityViewModel>>(redisKey, cacheData, expirationTime);
            return (List<NationalityViewModel>)cacheData;
        }
        public List<ReligionViewModel> GetReligionList(string organizationCode)
        {
            string redisKey = "religionList";
            var cacheData = _cacheService.GetData<IEnumerable<ReligionViewModel>>(redisKey);
            if (cacheData != null)
            {
                return (List<ReligionViewModel>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<ReligionViewModel> religionList = new List<ReligionViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            religionList = db.GetList<ReligionViewModel>("DPG_TEACHER_MST.DPD_RELIGION_LST", parameters);

            cacheData = religionList;
            _cacheService.SetData<IEnumerable<ReligionViewModel>>(redisKey, cacheData, expirationTime);
            return (List<ReligionViewModel>)cacheData;
        }
        public List<GenderViewModel> GetGenderList(string organizationCode)
        {
            string redisKey = "genderList";
            var cacheData = _cacheService.GetData<IEnumerable<GenderViewModel>>(redisKey);
            if (cacheData != null)
            {
                return (List<GenderViewModel>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<GenderViewModel> genderList = new List<GenderViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            genderList = db.GetList<GenderViewModel>("DPG_TEACHER_MST.DPD_GENDER_LST", parameters);

            cacheData = genderList;
            _cacheService.SetData<IEnumerable<GenderViewModel>>(redisKey, cacheData, expirationTime);
            return (List<GenderViewModel>)cacheData;
        }
        public List<BloodGroupViewModel> GetBloodGroupList(string organizationCode)
        {
            string redisKey = "bloodGroupList";
            var cacheData = _cacheService.GetData<IEnumerable<BloodGroupViewModel>>(redisKey);
            if (cacheData != null)
            {
                return (List<BloodGroupViewModel>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<BloodGroupViewModel> bloodList = new List<BloodGroupViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            bloodList = db.GetList<BloodGroupViewModel>("DPG_TEACHER_MST.DPD_BLOOD_GROUP_LST", parameters);

            cacheData = bloodList;
            _cacheService.SetData<IEnumerable<BloodGroupViewModel>>(redisKey, cacheData, expirationTime);
            return (List<BloodGroupViewModel>)cacheData;
        }


        public List<OccupationViewModel> GetOccupationList(string organizationCode)
        {
            string redisKey = "occupationList";
            var cacheData = _cacheService.GetData<IEnumerable<OccupationViewModel>>(redisKey);
            if (cacheData != null)
            {
                return (List<OccupationViewModel>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<OccupationViewModel> occupationList = new List<OccupationViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

           occupationList = db.GetList<OccupationViewModel>("DPG_EMS_STUDENT_MST.DPD_OCCUPATION_LST", parameters);

            cacheData = occupationList;
            _cacheService.SetData<IEnumerable<OccupationViewModel>>(redisKey, cacheData, expirationTime);
            return (List<OccupationViewModel>)cacheData;
        }

        public List<DistrictViewModel> GetDistrictList()
        {
            List<DistrictViewModel> districtList = new List<DistrictViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            districtList = db.GetList<DistrictViewModel>("DPG_EMS_STUDENT_MST.DPD_EMS_DISTRICT_LIST", parameters);

            return districtList;
        }

        public List<RelationTypeViewModel> GetRelationTypeList(string organizationCode)
        {
            string redisKey = "relationTypeList";
            var cacheData = _cacheService.GetData<IEnumerable<RelationTypeViewModel>>(redisKey);
            if (cacheData != null)
            {
                return (List<RelationTypeViewModel>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);

            List<RelationTypeViewModel> relationTypeList = new List<RelationTypeViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            relationTypeList = db.GetList<RelationTypeViewModel>("DPG_EMS_STUDENT_MST.DPD_RELATION_TYPE_LST", parameters);

            cacheData = relationTypeList;
            _cacheService.SetData<IEnumerable<RelationTypeViewModel>>(redisKey, cacheData, expirationTime);
            return (List<RelationTypeViewModel>)cacheData;
        }


        // Get Teacher List By Organization 
        public List<TeacherViewModel> GetTeacherList(string organizationCode)
        {
            List<TeacherViewModel> teacherList = new List<TeacherViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            teacherList = db.GetList<TeacherViewModel>("DPG_TEACHER_SINGLE_DATA_INFO.DPD_TEACHER_LST", parameters);

            return teacherList;
        }

        // Get Board or University List by organization
        public List<Board_UniversityViewModel> GetBoardOrUniList(string organizationCode)
        {
            string redisKey = "boardUniList";
            var cacheData = _cacheService.GetData<IEnumerable<Board_UniversityViewModel>>(redisKey);
            if (cacheData != null)
            {
                return (List<Board_UniversityViewModel>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<Board_UniversityViewModel> boardOrUniversityList = new List<Board_UniversityViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            boardOrUniversityList = db.GetList<Board_UniversityViewModel>("DPG_TEACHER_SINGLE_DATA_INFO.DPD_EMS_BOARD_UNIV_LIST", parameters);

            cacheData = boardOrUniversityList;
            _cacheService.SetData<IEnumerable<Board_UniversityViewModel>>(redisKey, cacheData, expirationTime);
            return (List<Board_UniversityViewModel>)cacheData;

        }

       

        // Get Common Table Information List
        public List<CommonTableInfoViewModel> GetCommonTableInfoList(string userCode)
        {
            List<CommonTableInfoViewModel> commonTableInfoList = new List<CommonTableInfoViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(userCode, OracleDbType.Varchar2);

            commonTableInfoList = db.GetList<CommonTableInfoViewModel>("DPG_ALL_COMMON_SETUP.DPD_COMMON_SETUP_TABLE_LST", parameters);

            return commonTableInfoList;
        }

        public List<setUpInfoViewModel> GetCommonTableInfoListNew()
        {
            List<setUpInfoViewModel> commonTableInfoList = new List<setUpInfoViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            commonTableInfoList = db.GetList<setUpInfoViewModel>("DPG_ALL_COMMON_SETUP.DPD_SETUP_LIST", parameters);

            return commonTableInfoList;
        }

        // Country List
        public List<CountryViewModel> CountryList()
        {
            List<CountryViewModel> countryList = new List<CountryViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            countryList = db.GetList<CountryViewModel>("DPG_ORG_MST.DPD_COUNTRY_LIST", parameters);

            return countryList;
        }

        // Devision List

        public List<DevisionViewModel> DevisionList(string devision)
        {
            List<DevisionViewModel> devisionList = new List<DevisionViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(devision, OracleDbType.Varchar2);

            devisionList = db.GetList<DevisionViewModel>("DPG_ORG_MST.DPD_DIVISION_LIST", parameters);

            return devisionList;
        }

        // District List

        public List<DistrictViewModel> DistrictList(string district)
        {
            List<DistrictViewModel> commonTableInfoList = new List<DistrictViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(district, OracleDbType.Varchar2);

            commonTableInfoList = db.GetList<DistrictViewModel>("DPG_ORG_MST.DPD_DISTRICT_LIST", parameters);

            return commonTableInfoList;
        }

        // Thana List

        public List<ThanaViewModel> ThanaList(string thana)
        {
            List<ThanaViewModel> thanaList = new List<ThanaViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(thana, OracleDbType.Varchar2);

            thanaList = db.GetList<ThanaViewModel>("DPG_ORG_MST.DPD_THANA_LIST", parameters);

            return thanaList;
        }

        // Fee Bill Template View Model
        

        public List<Session_Start_End_Month_VuViewModel> sessionSrtEndMonthVoucherList(string sessionCode, string organizationCode, string userCode)
        {
            List<Session_Start_End_Month_VuViewModel> sessionSrtEndMonthVoucherList = new List<Session_Start_End_Month_VuViewModel>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[4];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(sessionCode, OracleDbType.Varchar2);
            parameters[2] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);
            parameters[3] = db.MakeInParameter(userCode, OracleDbType.Varchar2);

            sessionSrtEndMonthVoucherList = db.GetList<Session_Start_End_Month_VuViewModel>("DPG_EMS_BILL_GEN_PROCESS.DPD_SESSION_STRT_END_MON_VU", parameters);

            return sessionSrtEndMonthVoucherList;
        }

        

        public int GetManualNumber(string userName)
        {
            db = new Database_ora();
            OracleParameter[] parameter = new OracleParameter[2];
            int number;
            parameter[0] = db.MakeReturnValue("ReturnValue", OracleDbType.Int16, 0);
            parameter[1] = db.MakeInParameter(userName, OracleDbType.Varchar2);

            number = db.RunFunction("DPG_EMS_BILL_GEN_PROCESS.DPF_EMS_GET_MANUAL_TRAN_ID", ref parameter);

            return number;
        }

        public int GetCollectionId(string userName)
        {
            db = new Database_ora();
            OracleParameter[] parameter = new OracleParameter[2];
            int number;
            parameter[0] = db.MakeReturnValue("ReturnValue", OracleDbType.Int16, 0);
            parameter[1] = db.MakeInParameter(userName, OracleDbType.Varchar2);

            number = db.RunFunction("DPG_EMS_BILL_COLL_PROCESS.DPF_EMS_GET_COLLECTION_ID", ref parameter);

            return number;
        }



        public int GetWorkingdays(string ORG_CODE, string CLASS_CODE, string VERSION_CODE, string GROUP_CODE, string SESSION_CODE, string YEAR_CODE, string SEMESTER_CODE, string SECTION_CODE,decimal TERM_ID )
        {
            db = new Database_ora();
            OracleParameter[] parameter = new OracleParameter[10];
            int number;
            parameter[0] = db.MakeReturnValue("ReturnValue", OracleDbType.Int16, 0);
            parameter[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            parameter[2] = db.MakeInParameter(CLASS_CODE, OracleDbType.Varchar2);
            parameter[3] = db.MakeInParameter(VERSION_CODE, OracleDbType.Varchar2);
            parameter[4] = db.MakeInParameter(GROUP_CODE, OracleDbType.Varchar2);
            parameter[5] = db.MakeInParameter(SESSION_CODE, OracleDbType.Varchar2);
            parameter[6] = db.MakeInParameter(YEAR_CODE, OracleDbType.Varchar2);
            parameter[7] = db.MakeInParameter(SEMESTER_CODE, OracleDbType.Varchar2);
            parameter[8] = db.MakeInParameter(SECTION_CODE, OracleDbType.Varchar2);
            parameter[9] = db.MakeInParameter(TERM_ID, OracleDbType.Decimal);

             number = db.RunFunction("DPG_CALENDAR.DPF_EMS_GET_WORKING_DAYS", ref parameter);

            return number;
        }


        public int GetVoucherNO(string userName)
        {
            db = new Database_ora();
            OracleParameter[] parameter = new OracleParameter[2];
            int number;
            parameter[0] = db.MakeReturnValue("ReturnValue", OracleDbType.Int16, 0);
            parameter[1] = db.MakeInParameter(userName, OracleDbType.Varchar2);

            number = db.RunFunction("DPG_EMS_BILL_COLL_PROCESS.DPF_EMS_GET_VOUCHER_NO", ref parameter);

            return number;
        }

        public int GetVoucherNO_UNIQ(string userName)
        {
            db = new Database_ora();
            OracleParameter[] parameter = new OracleParameter[2];
            int number;
            parameter[0] = db.MakeReturnValue("ReturnValue", OracleDbType.Int16, 0);
            parameter[1] = db.MakeInParameter(userName, OracleDbType.Varchar2);

            number = db.RunFunction("DPG_EMS_BILL_COLL_PROCESS.DPF_EMS_GET_VOUCHER_NO_UNIQ", ref parameter);

            return number;
        }



        public List<ExamBoardInfo> GetBoardExamList(string organizationCode)
        {
            string redisKey = "boardExamList";
            var cacheData = _cacheService.GetData<IEnumerable<ExamBoardInfo>>(redisKey);
            if (cacheData != null)
            {
                return (List<ExamBoardInfo>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<ExamBoardInfo> boardExamList = new List<ExamBoardInfo>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);

            boardExamList = db.GetList<ExamBoardInfo>("DPG_EMS_STD_SINGLE_DATA_INFO.DPD_BOARD_EXAM_LST", parameters);

            cacheData = boardExamList;
            _cacheService.SetData<IEnumerable<ExamBoardInfo>>(redisKey, cacheData, expirationTime);
            return (List<ExamBoardInfo>)cacheData;
        }

    }
}
