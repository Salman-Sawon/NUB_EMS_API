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
 //   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {

        [HttpGet]
        [Route("GetMenuList")]
        public IActionResult GetMenuList(string userCode, int roleId)
        {
            IMenu menu = new MenuRepository();
            MenuViewModel menuList = menu.GetMenuList(userCode, roleId);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Menu List";
            responseMessage.ResponseObj = menuList;
            return Ok(responseMessage);
        }
        [HttpGet]
        [Route("GetDBMenuList")]
        public IActionResult GetDBMenuList(string userCode, int roleId)
        {
            IMenu menu = new MenuRepository();
            List<Menu> menuList = menu.GetDBMenuList(userCode, roleId);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "DB Menu List";
            responseMessage.ResponseObj = menuList;
            return Ok(responseMessage);
        }
        [HttpGet]
        [Route("getDBMenuListNew")]
        public IActionResult getDBMenuListNew(string userCode, int roleId)
        {
            IMenu menu = new MenuRepository();
            List<MenuNew> menuList = menu.getDBMenuListNew(userCode, roleId);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "DB Menu List";
            responseMessage.ResponseObj = menuList;
            return Ok(responseMessage);
        }
    }
}
