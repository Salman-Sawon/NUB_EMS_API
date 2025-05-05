using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Common;
using StudentWebAPI.RepositoryImpl;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Controllers
{
    //[Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        ICommon common = new CommonRepository();

        [HttpGet]
        [Route("GetAllReferenceDataList")]
        public IActionResult GetAllReferenceDataList(string userCode)
        {

          //  Random generator = new Random();
         //   int r = generator.Next(1, 10000);


            List<ReferenceDataViewModel> list = new List<ReferenceDataViewModel>();
            list = common.GetAllReferenceDataList(userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Reference Data List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetCurSessionList")]
        public IActionResult GetCurSessionList(string userCode)
        {
            List<CurSessionVM> list = new List<CurSessionVM>();
            list = common.GetCurSessionList(userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Cur Session Data List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }



        //[HttpGet]
        //[Route("GetStudentidcardinfoGrid")]
        //public IActionResult  GetStudentidcardinfoGrid(string ORG_CODE, string CAMPUS_CODE, string CLASS_CODE, string GROUP_CODE, string VERSION_CODE, string SESSION_CODE, string SECTION_CODE, string SHIFT_CODE, string YEAR_CODE, string SEMESTER_CODE)
        //{
        //    List<StudentIdCardInfoGrid> list = new List<StudentIdCardInfoGrid>();
        //    list = common.GetStudentidcardinfoGrid(ORG_CODE, CAMPUS_CODE, CLASS_CODE, GROUP_CODE, VERSION_CODE, SESSION_CODE, SECTION_CODE, SHIFT_CODE, YEAR_CODE, SEMESTER_CODE);
        //    ResponseMessage responseMessage = new ResponseMessage();
        //    responseMessage.StatusCode = 1;
        //    responseMessage.Message = "Cur Session Data List";
        //    responseMessage.ResponseObj = list;
        //    return Ok(responseMessage);
        //}






        [HttpGet]
        [Route("GetOrg_image_Url_grid")]
        public IActionResult GetOrg_image_Url_grid(string userCode)
        {
            List<Org_image_Url_grid> list = new List<Org_image_Url_grid>();
            list = common.GetOrg_image_Url_grid(userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Org_image_Url_grid";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }




    }
}
