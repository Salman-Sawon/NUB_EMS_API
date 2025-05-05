using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentWebAPI.Models;
using StudentWebAPI.Models.Admin.SetUp;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using StudentWebAPI.RepositoryImpl;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Controllers
{
    [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class SetUpController : ControllerBase
    {
        ISetUp setUp = new SetUpRepository();

        // Teacher Grid View List
        [HttpGet]
        [Route("GetOrganizationInfoList")]
        public IActionResult GetOrganizationList()
        {
            List<OrganizationInfoViewModel> organizationList = setUp.OrganizationInfoList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Organization Information List";
            responseMessage.ResponseObj = organizationList;
            return Ok(responseMessage);
        }


        //[HttpPost]
        //[Route("OrganizationInfo")]
        //public IActionResult OrganizationInfo([FromBody] RequestMessage requestObject)
        //{
        //    OrganizationInfo organizationInfo = new OrganizationInfo();
        //    string jsonResponse = Convert.ToString(requestObject.RequestObject);
        //    organizationInfo = JsonConvert.DeserializeObject<OrganizationInfo>(jsonResponse);

        //    // IStudent student = new StudentRepository();
        //    var statusAndMessage = setUp.OrganizationInfo(organizationInfo);

        //    ResponseMessage responseMessage = new ResponseMessage();
        //    responseMessage.StatusCode = statusAndMessage.status;
        //    responseMessage.ResponseObj = organizationInfo;
        //    responseMessage.Message = statusAndMessage.message[0];
        //    return Ok(responseMessage);
        //}



        [HttpPost]
        [Route("OrganizationInfo")]
        public IActionResult OrganizationInfo([FromForm] OrganizationInfo organizationInfo)
        {
            var statusAndMessage = setUp.OrganizationInfo(organizationInfo);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            responseMessage.ResponseObj = statusAndMessage;
            return Ok(responseMessage);
        }










    }
}
