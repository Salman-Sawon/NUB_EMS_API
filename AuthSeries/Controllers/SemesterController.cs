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
    [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {


        [HttpGet]
        [Route("GetSemesterList")]
        public IActionResult GetSemesterList(string organizationCode)
        {
            ISemester classRepo = new SemesterRepository();
            List<SemesterListVM> list = classRepo.GetSemesterList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Semester List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }
    }
}
