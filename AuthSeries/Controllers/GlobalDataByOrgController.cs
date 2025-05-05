using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Global;
using StudentWebAPI.RepositoryImpl;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubjectViewModel = StudentWebAPI.Models.ViewModel.Global.SubjectViewModel;

namespace StudentWebAPI.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GlobalDataByOrgController : ControllerBase
    {
        IGlobalDataByOrg globalData = new GlobalDataByOrgRepository();

        //Subject List
        [HttpGet]
        [Route("GetSubjectList")]
        public IActionResult GetSubjectList(string organizationCode)
        {

            List<SubjectViewModel> list = globalData.GetSubjectList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Subject List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        // Blood Group Data
        [HttpGet]
        [Route("GetBloodList")]
        public IActionResult GetBloodList(string organizationCode)
        {

            List<BloodGroupViewModel> list = globalData.GetBloodGroupList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Blood Group List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }


        // Nationality List
        [HttpGet]
        [Route("GetNationalityList")]
        public IActionResult GetNationalityList(string organizationCode)
        {

            List<NationalityViewModel> list = globalData.GetNationalityList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Nationality List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        // Gender List
        [HttpGet]
        [Route("GetGenderList")]
        public IActionResult GetGenderList(string organizationCode)
        {

            List<GenderViewModel> list = globalData.GetGenderList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Gender List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        // Religion List
        [HttpGet]
        [Route("GetReligionList")]
        public IActionResult GetReligionList(string organizationCode)
        {

            List<ReligionViewModel> list = globalData.GetReligionList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Religion List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        // Birth Place List
        [HttpGet]
        [Route("GetBirthPlaceList")]
        public IActionResult GetBirthPlaceList()
        {

            List<BirthPlaceViewModel> list = globalData.GetBirthPlaceList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Blood Group List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        } 

        [HttpGet]
        [Route("GetDesignationList")]
        public IActionResult GetDesignationList()
        {

            List<DesignationList> list = globalData.GetDesignationList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        } 
        
        
        [HttpGet]
        [Route("GetDepartmentList")]
        public IActionResult GetDepartmentList()
        {

            List<DepartmentList> list = globalData.GetDepartmentList ();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Blood Group List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetRelationTypeList")]
        public IActionResult GetRelationTypeList(string organizationCode)
        {
            List<RelationTypeViewModel> list = globalData.GetRelationTypeList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Relation Type List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetDistrictList")]
        public IActionResult GetDistrictList()
        {
            List<DistrictViewModel> list = globalData.GetDistrictList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "District List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetOccupationList")]
        public IActionResult GetOccupationList(string organizationCode)
        {
            List<OccupationViewModel> list = globalData.GetOccupationList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Blood Group List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }


        // Teacher List
        [HttpGet]
        [Route("GetTeacherList")]
        public IActionResult GetTeacherList(string organizationCode)
        {
            List<TeacherViewModel> teacherList = globalData.GetTeacherList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Teacher List";
            responseMessage.ResponseObj = teacherList;
            return Ok(responseMessage);
        }

        // Board Or University List
        [HttpGet]
        [Route("GetBoardOrUniList")]
        public IActionResult GetBoardOrUniList(string organizationCode)
        {
            List<Board_UniversityViewModel> boardorUniList = globalData.GetBoardOrUniList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Board Or University List";
            responseMessage.ResponseObj = boardorUniList;
            return Ok(responseMessage);
        }

      

        // Common Table Information List
        [HttpGet]
        [Route("CommonTableInfoList")]
        public IActionResult CommonTableInfoList(string userCode)
        {
            List<CommonTableInfoViewModel> commonTableInfoList = globalData.GetCommonTableInfoList(userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Common Table Information List";
            responseMessage.ResponseObj = commonTableInfoList;
            return Ok(responseMessage);
        }


        [HttpGet]
        [Route("setUpInfoList")]
        public IActionResult setUpInfoList()
        {
            List<setUpInfoViewModel> commonTableInfoList = globalData.GetCommonTableInfoListNew();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Common Table Information List";
            responseMessage.ResponseObj = commonTableInfoList;
            return Ok(responseMessage);
        }

        // Country List
        [HttpGet]
        [Route("CountryList")]
        public IActionResult CountryList()
        {
            List<CountryViewModel> countryList = globalData.CountryList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Country List";
            responseMessage.ResponseObj = countryList;
            return Ok(responseMessage);
        }

        // Devision List
        [HttpGet]
        [Route("DevisionList")]
        public IActionResult DevisionList(string devision)
        {
            List<DevisionViewModel> devisionList = globalData.DevisionList(devision);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Devision List";
            responseMessage.ResponseObj = devisionList;
            return Ok(responseMessage);
        }

        // District List
        [HttpGet]
        [Route("DistrictList")]
        public IActionResult DistrictList(string district)
        {
            List<DistrictViewModel> districtList = globalData.DistrictList(district);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "District List";
            responseMessage.ResponseObj = districtList;
            return Ok(responseMessage);
        }

        // Thana List
        [HttpGet]
        [Route("ThanaList")]
        public IActionResult ThanaList(string thana)
        {
            List<ThanaViewModel> thanaList = globalData.ThanaList(thana);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Thana List";
            responseMessage.ResponseObj = thanaList;
            return Ok(responseMessage);
        }

      

        // Session Start End Month Voucher List
        [HttpGet]
        [Route("SessionSrtEndMonthVoucherList")]
        public IActionResult SessionSrtEndMonthVoucherList(string sessionCode, string organizationCode, string userCode)
        {
            List<Session_Start_End_Month_VuViewModel> sessionSrtEndMonthVoucherList = globalData.sessionSrtEndMonthVoucherList(sessionCode, organizationCode, userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Session Start End Month Voucher List";
            responseMessage.ResponseObj = sessionSrtEndMonthVoucherList;
            return Ok(responseMessage);
        }

      

        // get manual number
        [HttpGet]
        [Route("GetManualNumber")]
        public IActionResult GetManualNumber(string userName)
        {
            int number = globalData.GetManualNumber(userName);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Manual Number";
            responseMessage.ResponseObj = number;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetCollectionId")]
        public IActionResult GetCollectionId(string userName)
        {
            int number = globalData.GetCollectionId(userName);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Collection Id";
            responseMessage.ResponseObj = number;
            return Ok(responseMessage);
        }


        [HttpGet]
        [Route("GetWorkingdays")]
        public IActionResult GetWorkingdays(string ORG_CODE, string CLASS_CODE, string VERSION_CODE, string GROUP_CODE, string SESSION_CODE, string YEAR_CODE, string SEMESTER_CODE, string SECTION_CODE, decimal TERM_ID)
        {
            int number = globalData.GetWorkingdays( ORG_CODE,CLASS_CODE,VERSION_CODE,GROUP_CODE,SESSION_CODE,YEAR_CODE,SEMESTER_CODE,SECTION_CODE, TERM_ID);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "GetWorkin days ";
            responseMessage.ResponseObj = number;
            return Ok(responseMessage);
        }








        [HttpGet]
        [Route("GetVoucherNo")]
        public IActionResult GetVoucherNo(string userName)
        {
            int number = globalData.GetVoucherNO(userName);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Voucher NO";
            responseMessage.ResponseObj = number;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetVoucherNO_UNIQ")]
        public IActionResult GetVoucherNO_UNIQ(string userName)
        {
            int number = globalData.GetVoucherNO_UNIQ(userName);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Voucher NO";
            responseMessage.ResponseObj = number;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetPrevBoardExamList")]
        public IActionResult GetBoardExamList(string organizationCode)
        {
            List<ExamBoardInfo> boardExamList = globalData.GetBoardExamList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Board Exam List";
            responseMessage.ResponseObj = boardExamList;
            return Ok(responseMessage);
        }

    }
}
