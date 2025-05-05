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
    public class UserTypesController : ControllerBase
    {
        IUserType Types = new UserTypeRepository();



        [HttpGet]
        [Route("GetUserTypeList")]
        public IActionResult GetUserTypeList()
        {
            
            List<UserTypeModel> userTypeList = Types.GetUserTypeList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "User Type List";
            responseMessage.ResponseObj = userTypeList;
            return Ok(responseMessage);
        }




        [HttpPost]
        [Route("SaveUserType")]
        public IActionResult SaveUserType([FromBody] RequestMessage requestObject)
        {
            UserTypeSingle userTypeSingle = new UserTypeSingle();
            string jsonResponse = Convert.ToString(requestObject.RequestObject);
            userTypeSingle = JsonConvert.DeserializeObject<UserTypeSingle>(jsonResponse);


            AdminUserType userType = new AdminUserType();

            userType.USER_TYPE_ID = new List<decimal>();
            userType.USER_TYPE_ID.Add(userTypeSingle.USER_TYPE_ID);

            userType.USER_TYPE_DESCR = new List<string>();
            userType.USER_TYPE_DESCR.Add(userTypeSingle.USER_TYPE_DESCR);

            userType.RowStatus = new List<decimal>();
            userType.RowStatus.Add(userTypeSingle.RowStatus);

            userType.User_Name = userTypeSingle.User_Name;

            var statusAndMessage = Types.SaveUserType(userType);
            ResponseMessage responseMessage = new ResponseMessage();

            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            responseMessage.ResponseObj = userType;
            return Ok(responseMessage);
           
        }
    }
}
