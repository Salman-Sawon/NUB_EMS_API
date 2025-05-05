using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Dashboard;
using StudentWebAPI.RepositoryImpl;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static StudentWebAPI.Models.ViewModel.Dashboard.Dashboard;

namespace StudentWebAPI.Controllers
{
   // [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        IDashboard dashboard = new DashboardRepository();

       



        //[HttpGet]
        //[Route("getDashboardClassList")]
        //public IActionResult getDashboardClassList(string ORG_CODE)
        //{
        //    DashboardClassList dashboardList = dashboard.getDashboardClassList(ORG_CODE);
        //    ResponseMessage responseMessage = new ResponseMessage();
        //    responseMessage.StatusCode = 1;
        //    responseMessage.Message = "Dashboard List";
        //    responseMessage.ResponseObj = dashboardList;
        //    return Ok(responseMessage);
        //}


        [HttpGet]
        [Route("getDashboardClassList")]
        public IActionResult getDashboardClassList(string ORG_CODE)
        {

            List<DashboardClassList> designationList = dashboard.getDashboardClassList(ORG_CODE);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = designationList;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("getDashboardBillColGenList")]
        public IActionResult getDashboardBillColGenList(string ORG_CODE, string CAMPUS_CODE)
        {

            List<DashboardBillColGenList> designationList = dashboard.getDashboardBillColGenList(ORG_CODE, CAMPUS_CODE);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = designationList;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("get-Dashboard-data")]
        public IActionResult getDashboardData(string ORG_CODE, string CAMPUS_CODE)
        {

            string dashboardData = dashboard.getDashboardData(ORG_CODE, CAMPUS_CODE);
            return Ok(dashboardData);
        }

        [HttpGet]
        [Route("getDashboardTotalCollGenList")]
        public IActionResult getDashboardTotalCollGenList(string ORG_CODE, string CAMPUS_CODE)
        {

            List<DashboardTotalCollGenList> designationList = dashboard.getDashboardTotalCollGenList(ORG_CODE, CAMPUS_CODE);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = designationList;
            return Ok(responseMessage);
        }




        [HttpGet]
        [Route("getDashboardStudentTotalCollGenList")]
        public IActionResult getDashboardStudentTotalCollGenList(string STUDENT_CODE, string ORG_CODE, string CAMPUS_CODE)
        {

            List<DashboardStudentTotalCollGenList> designationList = dashboard.getDashboardStudentTotalCollGenList(STUDENT_CODE,ORG_CODE, CAMPUS_CODE);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = designationList;
            return Ok(responseMessage);
        }



        [HttpGet]
        [Route("getStudentLastPayment")]
        public IActionResult  getStudentLastPayment(string STUDENT_CODE, string ORG_CODE)
        {

            List<StudentLastPayment> designationList = dashboard.getStudentLastPayment(STUDENT_CODE, ORG_CODE);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = designationList;
            return Ok(responseMessage);
        }

        //[HttpGet]
        //[Route("getDashboardTotalCollGenList")]
        //public IActionResult getDashboardTotalCollGenList(string ORG_CODE, string CAMPUS_CODE)
        //{

        //    List<DashboardTotalCollGenList> designationList = dashboard.getDashboardTotalCollGenList(ORG_CODE, CAMPUS_CODE);

        //    ResponseMessage responseMessage = new ResponseMessage();
        //    responseMessage.StatusCode = 1;
        //    responseMessage.Message = "Designation List";
        //    responseMessage.ResponseObj = designationList;
        //    return Ok(responseMessage);
        //}


        [HttpGet]
        [Route("getDashboardTeacherAttenList")]
        public IActionResult getDashboardTeacherAttenList(string ORG_CODE)
        {

            List<DashboardTeacherAttenList> designationList = dashboard.getDashboardTeacherAttenList(ORG_CODE);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = designationList;
            return Ok(responseMessage);
        }



        [HttpGet]
        [Route("getDashboardNoticeList")]
        public IActionResult getDashboardNoticeList(string ORG_CODE)
        {

            List<DashboardNoticeList> NoticeList = dashboard.getDashboardNoticeList(ORG_CODE);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = NoticeList;
            return Ok(responseMessage);
        }


     


        [HttpGet]
        [Route("getDashboardTermList")]
        public IActionResult getDashboardTermList(string ORG_CODE)
        {

            List<DashboardTermList> DashboardTermList = dashboard.getDashboardTermList(ORG_CODE);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = DashboardTermList;
            return Ok(responseMessage);
        }


        [HttpGet]
        [Route("getTermSubjExmcaptionList")]
        public IActionResult getTermSubjExmcaptionList(string ORG_CODE, string CAMPUS_CODE)
        {

            List<TermSubjExmcaptionListByOrg> DashboardTermList = dashboard.getTermSubjExmcaptionList(ORG_CODE, CAMPUS_CODE);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = DashboardTermList;
            return Ok(responseMessage);
        }


    }
}
