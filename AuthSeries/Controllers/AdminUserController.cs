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
    public class AdminUserController : ControllerBase
    {

        IAdminUserMst adminUser = new AdminUserMstRepository();

        [HttpGet]
        [Route("GetAdminUserList")]
        public IActionResult GetAdminUserList(string userCode)
        {
            List<AdminUserMstViewModel> adminUserList = adminUser.GetAdminUserList(userCode);
            
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Admin User List";
            responseMessage.ResponseObj = adminUserList;

            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetDCList")]
        public IActionResult GetDCList(string IS_DC)
        {
            List<dcUserViewModel> DCList = adminUser.GetDCList(IS_DC);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Admin User List";
            responseMessage.ResponseObj = DCList;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetAllUserList")]
        public IActionResult GetAllUserList(decimal PAGE_INDEX, decimal PAGE_SIZE)
        {
            List<AllUserMstViewModel> adminUserList = adminUser.GetAllUserList(PAGE_INDEX, PAGE_SIZE);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "User List";
            responseMessage.ResponseObj = adminUserList;

            return Ok(responseMessage);
        }


        [HttpGet]
        [Route("GetAllUserFilterList")]
        public IActionResult GetAllUserFilterList(decimal PAGE_INDEX, decimal PAGE_SIZE, string P_M_WhereString)
        {
            List<AllUserMstViewModel> adminUserList = adminUser.GetAllUserFilterList(PAGE_INDEX, PAGE_SIZE, P_M_WhereString);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "User List";
            responseMessage.ResponseObj = adminUserList;

            return Ok(responseMessage);
        }

        [HttpPost]
        [Route("CreateUser")]
        public IActionResult CreateUser([FromBody] RequestMessage requestObject)
        {
            AdminUserMst user = new AdminUserMst();
            string jsonResponse = Convert.ToString(requestObject.RequestObject);
            user = JsonConvert.DeserializeObject<AdminUserMst>(jsonResponse);

            var statusAndMessage = adminUser.GetUserCreationStatus(user);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            responseMessage.ResponseObj = user;
            return Ok(responseMessage);
        }

        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser([FromBody] RequestMessage requestObject)
        {
            AdminUserMst user = new AdminUserMst();
            string jsonResponse = Convert.ToString(requestObject.RequestObject);
            user = JsonConvert.DeserializeObject<AdminUserMst>(jsonResponse);
            IAdminUserMst adminUserRepository = new AdminUserMstRepository();
            bool status = adminUserRepository.UserUpdateStatus(user);
            ResponseMessage responseMessage = new ResponseMessage();
            if (status)
            {
                responseMessage.StatusCode = 1;
                responseMessage.Message = "User Updated Successfully";
                return Ok(responseMessage);
            }
            else
            {
                responseMessage.StatusCode = 0;
                responseMessage.Message = "User Updated failed";
                return Ok(responseMessage);
            }
        }

        //Change Password
        //[HttpPost]
        //[Route("CreateUserOrganization")]
        //public IActionResult ChangePassword([FromBody] RequestMessage requestObject)
        //{
        //    AdminUserMst user = new AdminUserMst();
        //    string jsonResponse = Convert.ToString(requestObject.RequestObject);
        //    user = JsonConvert.DeserializeObject<AdminUserMst>(jsonResponse);

        //    ILogin changePass = new LoginRepository();

        //    bool status = changePass.ChangePassword(user.USER_CODE, user.USER_PASSWORD, user.USER_PASSWORD, us);

        //    ResponseMessage responseMessage = new ResponseMessage();
        //    if (status)
        //    {
        //        responseMessage.StatusCode = 1;
        //        responseMessage.Message = "Password is changed Successfully";
        //        return Ok(responseMessage);
        //    }
        //    else
        //    {
        //        responseMessage.StatusCode = 0;
        //        responseMessage.Message = "Changing password is failed";
        //        return Ok(responseMessage);
        //    }
        //}

    }
}
