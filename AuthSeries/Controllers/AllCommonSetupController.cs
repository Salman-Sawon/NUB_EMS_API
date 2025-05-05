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
    public class AllCommonSetupController : ControllerBase
    {
        IAllCommonSetup allCommonSetup = new AllCommonSetupRepository();

        // All Common Setup Grid View List
        [HttpGet]
        [Route("GetAllCommonSetupList")]
        public IActionResult GetAllCommonSetupList(string userCode, decimal tableId)
        {
            List<AllCommonSetupViewModel> allCommonSetupList = allCommonSetup.AllCommonSetupList(userCode, tableId);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "All Common Setup List";
            responseMessage.ResponseObj = allCommonSetupList;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetAllCommonSetupListNew")]
        public IActionResult GetAllCommonSetupListNew(string ORG_CODE, decimal SET_UP_ID)
        {
            List<AllCommonSetupViewModelNew> allCommonSetupList = allCommonSetup.AllCommonSetupListNew(ORG_CODE, SET_UP_ID);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "All Common Setup List";
            responseMessage.ResponseObj = allCommonSetupList;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetSystemSettingsGridList")]
        public IActionResult GetSystemSettingsGridList(string ORG_CODE, string User_Id)
        {
            List<SystemSettingsGrid> SystemSettingsGridList = allCommonSetup.SystemSettingsGridList(ORG_CODE,User_Id);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "All Common Setup List";
            responseMessage.ResponseObj = SystemSettingsGridList;
            return Ok(responseMessage);
        }


        [HttpPost]
        [Route("AllCommonSetup")]
        public IActionResult AllCommonSetup([FromBody] RequestMessage requestObject)
        {
            AllCommonSetup allCommonSetupTemplate = new AllCommonSetup();
            string jsonResponse = Convert.ToString(requestObject.RequestObject);
            allCommonSetupTemplate = JsonConvert.DeserializeObject<AllCommonSetup>(jsonResponse);

            // IStudent student = new StudentRepository();
            var statusAndMessage = allCommonSetup.CrtUptDltAllCommonSetup(allCommonSetupTemplate);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.Status;
            responseMessage.Message = statusAndMessage.message[0];
            responseMessage.ResponseObj = allCommonSetup;
            return Ok(responseMessage);
        }



        [HttpPost]
        [Route("AllSetupNew")]
        public IActionResult AllSetupNew([FromBody] AllSetupNew allSetupNew)
        {
            var statusAndMessage = allCommonSetup.CrtUptDltAllSetupNew(allSetupNew);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.Status;
            responseMessage.Message = statusAndMessage.message[0];
            responseMessage.ResponseObj = allCommonSetup;
            return Ok(responseMessage);
        }
    }
}
