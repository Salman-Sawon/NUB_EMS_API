using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models;
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
    public class GroupController : ControllerBase
    {
        [HttpGet]
        [Route("GetGroupList")]
        public IActionResult GetGroupList(string organizationCode)
        {
            IGroup group = new GroupRepository();
            List<GroupViewModel> list = group.GetGroupList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Group List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }
    }
}
