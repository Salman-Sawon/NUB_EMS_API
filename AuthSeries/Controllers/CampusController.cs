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
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CampusController : ControllerBase
    {
        ICampus campus = new CampusRepository();

        [HttpGet]
        [Route("GetCampusList")]
        public IActionResult GetCampusList(string organizationCode)
        {
            List<CampusViewModel> list = new List<CampusViewModel>();
            list = campus.GetCampusList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Campus List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetCampusTypeList")]
        public IActionResult GetCampusTypeList()
        {
            List<CampusTypeViewModel> listTypeList = new List<CampusTypeViewModel>();
            listTypeList = campus.GetCampusTypeList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Campus Type List";
            responseMessage.ResponseObj = listTypeList;
            return Ok(responseMessage);
        }
    }
}
