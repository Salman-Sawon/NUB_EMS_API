using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models;
using StudentWebAPI.Models.Admin.SetUp;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using StudentWebAPI.RepositoryImpl;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationsController : ControllerBase
    {
        IDesignation designation = new DesignationRepository();

        [HttpGet]
        [Route("GetDesignationList")]
        public IActionResult GetDesignationList(string userCode)
        {

            List<DesignationViewModel> designationList = designation.GetDesignationList(userCode);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = designationList;
            return Ok(responseMessage);            
        }

        [HttpGet]
        [Route("GetDesigList")]
        public IActionResult GetDesigList(string organizationCode)
        {

            List<DesignationViewModel> designationList = designation.GetDesigList(organizationCode);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Designation List";
            responseMessage.ResponseObj = designationList;
            return Ok(responseMessage);
        }

        [HttpPost]
        [Route("Designation")]
        public IActionResult Designation([FromBody] RequestMessage requestObject)
        {
            Designation crtDesignation = new Designation();
            string jsonResponse = Convert.ToString(requestObject.RequestObject);
            crtDesignation = JsonConvert.DeserializeObject<Designation>(jsonResponse);

            var statusAndMessage = designation.CrtUptDltDesignation(crtDesignation);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            responseMessage.ResponseObj = crtDesignation;
            return Ok(responseMessage);
        }
    }
}
