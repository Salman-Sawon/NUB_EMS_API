using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.RepositoryImpl;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class YearController : ControllerBase
    {

        [HttpGet]
        [Route("GetYearList")]
        public IActionResult GetClassList(string organizationCode)
        {
            IYear yearRepo = new YearRepository();
            List<YearListVM> list = yearRepo.GetYearList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Year List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }
    }
}
