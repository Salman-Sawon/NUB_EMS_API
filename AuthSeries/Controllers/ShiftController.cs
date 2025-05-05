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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftController : ControllerBase
    {
        [HttpGet]
        [Route("GetShiftList")]
        public IActionResult GetShiftList(string organizationCode)
        {
            IShift shift = new ShiftRepository();
            List<ShiftViewModel> list = shift.GetShiftList(organizationCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Shift List";
            responseMessage.ResponseObj = list;
            return Ok(responseMessage);
        }
    }
}
