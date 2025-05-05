using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
    public class RolesController : ControllerBase
    {
        IRole role = new RoleRepository();

        [HttpGet]
        [Route("GetRoleList")]
        public IActionResult GetRoleList()
        {
            
            List<RoleModel> roleList = role.GetRoleList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Role List";
            responseMessage.ResponseObj = roleList;
            return Ok(responseMessage);
        }

        [HttpPost]
        [Route("SaveUserRole")]
        public IActionResult SaveUserRole([FromBody] RequestMessage requestObject)
        {

            AdminRoleSingle userRoleSingle = new AdminRoleSingle();
            string jsonResponse = Convert.ToString(requestObject.RequestObject);
            userRoleSingle = JsonConvert.DeserializeObject<AdminRoleSingle>(jsonResponse);
            

            AdminRoleMst userRole = new AdminRoleMst();

            userRole.ROLE_ID = new List<decimal>();
            userRole.ROLE_ID.Add(userRoleSingle.ROLE_ID);

            userRole.ROLE_DESCR = new List<string>();
            userRole.ROLE_DESCR.Add(userRoleSingle.ROLE_DESCR);

            userRole.RowStatus = new List<decimal>();
            userRole.RowStatus.Add(userRoleSingle.RowStatus);

            userRole.User_Name = userRoleSingle.User_Name;

            var statusAndMessage = role.SaveUserRole(userRole);

            ResponseMessage responseMessage = new ResponseMessage();

            responseMessage.StatusCode = 1;
            responseMessage.Message = "User Role";
            responseMessage.ResponseObj = userRole;
            return Ok(responseMessage);
        }
    
    }
}
