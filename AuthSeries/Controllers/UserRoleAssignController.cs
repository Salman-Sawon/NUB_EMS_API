using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class UserRoleAssignController : ControllerBase
    {
        [HttpGet]
        [Route("GetUserRoleAssignList")]
        public IActionResult GetUserRoleAssignList(int roleId)
        {
            IUserRoleAssign organization = new UserRoleAssignRepository();
            List<UserRoleAssign> user_role_assignList = organization.GetUserRoleAssignList(roleId);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "User Role Assign List";
            responseMessage.ResponseObj = user_role_assignList;
            return Ok(responseMessage);
        }


        [HttpGet]
        [Route("GetUserRoleUnassignList")]
        public IActionResult GetUserRoleUnassignList(int roleId)
        {
            IUserRoleAssign organization = new UserRoleAssignRepository();
            List<UserRoleAssign> user_role_unassignList = organization.GetUserRoleUnassignList(roleId);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "User Role Unassign List";
            responseMessage.ResponseObj = user_role_unassignList;
            return Ok(responseMessage);
        }

    
   }
}
