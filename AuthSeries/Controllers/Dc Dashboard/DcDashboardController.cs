using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models.ViewModel.Dc_Dashboard;
using StudentWebAPI.RepositoryImpl.Dc_Dashboard;
using StudentWebAPI.Services.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Controllers.Dc_Dashboard
{
    [Route("api/[controller]")]
    [ApiController]
    public class DcDashboardController : Controller
    {

        IDcDashboard dclist = new DcDashboardRepository();
        private ResponseMessage responseMessage;




        [HttpGet]
        [Route("getDcDashboardList")]
        public IActionResult getDcDashboardList([FromQuery] string USER_CODE, string FROM_DATE, string TO_DATE)
        {


            List<DcDashboardGrid> dataList = dclist.getDcDashboardList(USER_CODE, FROM_DATE, TO_DATE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.data = "dataList";
            responseMessage.Message = "dataList";
            responseMessage.ResponseObj = dataList;
            return Ok(responseMessage);
        }



        [HttpGet]
        [Route("getDcDashboardOrgList")]
        public IActionResult getDcDashboardOrgList([FromQuery] string USER_CODE)
        {


            List<DcOrgList> dataList = dclist.getDcDashboardOrgList(USER_CODE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.data = "dataList";
            responseMessage.Message = "dataList";
            responseMessage.ResponseObj = dataList;
            return Ok(responseMessage);
        }


        [HttpGet]
        [Route("getDcOrgAttenCountList")]
        public IActionResult getDcOrgAttenCountList([FromQuery] string ORG_CODE, string CAMPUS_CODE, string FROM_DATE, string TO_DATE)
        {


            List<DcOrgAttenCountList> dataList = dclist.getDcOrgAttenCountList(ORG_CODE, CAMPUS_CODE, FROM_DATE, TO_DATE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.data = "dataList";
            responseMessage.Message = "dataList";
            responseMessage.ResponseObj = dataList;
            return Ok(responseMessage);
        }

       
          

        [HttpGet]
        [Route("getDcOrgClassAttList")]
        public IActionResult getDcOrgClassAttList([FromQuery] string ORG_CODE, string CAMPUS_CODE, string ATT_DATE)
        {


            List<DcOrgClassAttList> dataList = dclist.getDcOrgClassAttList(ORG_CODE, CAMPUS_CODE, ATT_DATE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.data = "dataList";
            responseMessage.Message = "dataList";
            responseMessage.ResponseObj = dataList;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("ClassWiseStduDtl")]
        public IActionResult getClassWiseStduDtl([FromQuery] ClassWiseStduDtl param)
        {
            List<ClassWiseStduDtlVM> classWiseStduDtlListList = dclist.getClassWiseStduDtl(param);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.data = "classWiseStduDtlListList";
            responseMessage.Message = "classWiseStduDtlListList";
            responseMessage.ResponseObj = classWiseStduDtlListList;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("teacherTeachProgressMst")]
        public IActionResult getteacherTeachProgressMst([FromQuery]  string ORG_CODE, string CAMPUS_CODE )
        {
            List<TeacherTechVM> data = dclist.getteacherTeachProgressMst(ORG_CODE, CAMPUS_CODE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.data = "data";
            responseMessage.Message = "data";
            responseMessage.ResponseObj = data;
            return Ok(responseMessage);
        }


        [HttpGet]
        [Route("teacherTeachProgressDtl")]
        public IActionResult getteacherTeachProgressDtl([FromQuery] string ORG_CODE, string CAMPUS_CODE, string TEACHER_CODE)
        {
            List<TeacherTechDtlVM> data = dclist.getteacherTeachProgressDtl(ORG_CODE, CAMPUS_CODE, TEACHER_CODE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.data = "data";
            responseMessage.Message = "data";
            responseMessage.ResponseObj = data;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("teacherTeachProgressSubDtl")]
        public IActionResult teacherTeachProgressSubDtl([FromQuery] string ORG_CODE, string CAMPUS_CODE, string TEACHER_CODE, decimal SUB_MAP_ID)
        {
            List<TeacherTechSubDtlVM> data = dclist.getteacherTeachProgressSubDtl(ORG_CODE, CAMPUS_CODE, TEACHER_CODE, SUB_MAP_ID);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.data = "data";
            responseMessage.Message = "data";
            responseMessage.ResponseObj = data;
            return Ok(responseMessage);
        }

    }
}
