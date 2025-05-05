using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentWebAPI.Models;
using StudentWebAPI.Models.Admin.SetUp;
using StudentWebAPI.Models.ViewModel;
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
    public class SessionController : ControllerBase
    {
        IEMSSession session = new SessionRepository();

        [HttpGet]
        [Route("GetSessionList")]
        public IActionResult GetSessionList(string organizationCode)
        {
            List<SessionViewModel> list = session.GetSessionList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Session List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetStudentWiseSession")]
        public IActionResult GetStudentWiseSession(string ORG_CODE, string CAMPUS_CODE, string STUDENT_CODE)
        {
            List<StdWiseSession> sessinlist = session.GetStudentWiseSession(ORG_CODE, CAMPUS_CODE, STUDENT_CODE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Session List";
            responseMessage.ResponseObj = sessinlist;
            return Ok(responseMessage);
        }

        [HttpPost]
        [Route("SaveSession")]
        public IActionResult SaveSession([FromBody] RequestMessage requestObject)
        {
            Session saveSession = new Session();
            string jsonResponse = Convert.ToString(requestObject.RequestObject);
            saveSession = JsonConvert.DeserializeObject<Session>(jsonResponse);

            // IStudent student = new StudentRepository();
            var statusAndMessage = session.saveSession(saveSession);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            responseMessage.ResponseObj = saveSession;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetSessionGridView")]
        public IActionResult GetSessionGridView(string userCode, decimal sessionCode)
        {
            SessionMasterViewModel sessionMasterList = session.getSessionGridView(userCode, sessionCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Session Master List";
            responseMessage.ResponseObj = sessionMasterList;
            return Ok(responseMessage);
        }

       

    }
}
