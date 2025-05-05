using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.User;
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
    public class UserController : ControllerBase
    {
        IUser user = new UserRepository();

        // Teacher Grid View List
        [HttpGet]
        [Route("GetUserList")]
        public IActionResult GetUserList(string userCode)
        {
            UserViewModel userList = user.UserList(userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "User List";
            responseMessage.ResponseObj = userList;
            return Ok(responseMessage.ResponseObj);
        }
    }
}
