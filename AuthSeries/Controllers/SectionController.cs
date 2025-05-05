using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Global;
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
    public class SectionController : ControllerBase
    {
        [HttpGet]
        [Route("GetSectionList")]
        public IActionResult GetSectionList(string organizationCode,string classCode)
        {
            ISection section = new SectionRepository();
            List<SectionViewModel> list = section.GetSectionList(organizationCode,classCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Section List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetSection")]
        public IActionResult GetSection (string userCode)
        {
            ISection section = new SectionRepository();
            List<SectionModel> list = section.GetSection (userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Section List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }
    }
}
