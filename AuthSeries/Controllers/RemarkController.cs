using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models.ViewModel;
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
    public class RemarkController : ControllerBase
    {
        [HttpGet]
        [Route("GetRemarkList")]
        public IActionResult GetRemarkList(string organizationCode)
        {
            IRemark remarks = new RemarkRepository();
            List<RemarkViewModel> remarklist = remarks.GetRemarkList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Remark List";
            responseMessage.ResponseObj = remarklist;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetDistributionRemarkList")]
        public IActionResult GetDistributionRemarkList(string organizationCode, string userCode)
        {
            IRemark remarks = new RemarkRepository();
            List<RemarkViewModel> remarklist = remarks.GetDistributionRemarkList(organizationCode, userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Remark List";
            responseMessage.ResponseObj = remarklist;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetResultEntryRemarkList")]
        public IActionResult GetResultEntryRemarkList(string organizationCode, string userCode)
        {
            IRemark remarks = new RemarkRepository();
            List<RemarkViewModel> remarklist = remarks.GetResultEntryRemarkList(organizationCode, userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Remark List";
            responseMessage.ResponseObj = remarklist;
            return Ok(responseMessage);
        }
    }
}
