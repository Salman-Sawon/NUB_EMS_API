using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentWebAPI.Models;
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
    public class AllSetupPageController : ControllerBase
    {
        IAllSetupPage allSetupPage = new AllSetupPageRepository();
        [HttpPost]
        [Route("AllSetupPage")]
        public IActionResult TeacherInfo([FromBody] RequestMessage requestObject)
        {
            AllSetupPage allSetupPageTemplate = new AllSetupPage();
            string jsonResponse = Convert.ToString(requestObject.RequestObject);
            allSetupPageTemplate = JsonConvert.DeserializeObject<AllSetupPage>(jsonResponse);

            // IStudent student = new StudentRepository();
            var statusAndMessage = allSetupPage.SaveUptDelAllSetupPage(allSetupPageTemplate);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            return Ok(responseMessage);
        }


        [HttpGet]
        [Route("GetComboSerialList")]
        public IActionResult GetComboSerialList([FromQuery] string ORG_CODE, string CAMPUS_CODE)
        {

            List<ComboVM> allComboList = allSetupPage.getComboSerialList(ORG_CODE, CAMPUS_CODE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "All Combo List";
            responseMessage.ResponseObj = allComboList;
            return Ok(responseMessage);
        }
    }
}
