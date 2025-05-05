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
    public class AllMenuController : ControllerBase
    {
        IAllMenu allmenu = new AllMenuRepository();
        [HttpGet]
        [Route("GetAllMenuList")]
        public IActionResult GetAllMenuList()
        {
            
            List<AllMenuViewModel> allmenuList = allmenu.GetAllMenuList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "All Menu List";
            responseMessage.ResponseObj = allmenuList;
            return Ok(responseMessage);
        }

        [HttpPost]
        [Route("SaveAllRoleMenu")]
        public IActionResult SaveAllRoleMenu([FromBody] RoleMenuMapViewModel roleMenu)
        {
            //RoleMenuMapViewModel roleMenu = new RoleMenuMapViewModel();
            //string jsonResponse = Convert.ToString(requestObject.RequestObject);
            //roleMenu = JsonConvert.DeserializeObject<RoleMenuMapViewModel>(jsonResponse);
            var statusAndMessage = allmenu.SaveRoleMenu(roleMenu);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.ResponseObj = roleMenu;
            responseMessage.Message = statusAndMessage.message[0];
            return Ok(responseMessage);

        }
    }
}
