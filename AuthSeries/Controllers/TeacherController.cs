using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.RepositoryImpl;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;
//using Spire.Pdf;
//using Spire.Pdf.Utilities;
//using Spire.Xls;
//using Spire.Pdf.General.Find;
//using Spire.Pdf.Tables;
//using Spire.Pdf.Widget;
using OfficeOpenXml;
using System.IO;
using System.Data;
using StudentWebAPI.Models.TeacherFileUpload;

namespace StudentWebAPI.Controllers
{
   // [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {

        ITeacher teacher = new TeacherRepository();
        LocationDistance locationDistance;
        public TeacherController()
        {
            locationDistance = new LocationDistance();

        }

       



        [HttpPost]
        [Route("TeacherEntry")]
        public IActionResult TeacherEntry([FromBody] TeacherBulkEntry teacherBulkEntry)
        {
            //ITeacher teacher = new TeacherRepository();
            var statusAndMessage = teacher.TeacherEntry(teacherBulkEntry);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            return Ok(responseMessage);
        }


        [HttpGet]
        [Route("GetActiveTeacherList")]
        public IActionResult GetActiveTeacherList(string ORG_CODE)
        {
            List<ActiveTeacherData> teacherList = teacher.GetActiveTeacherList(ORG_CODE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Teacher List";
            responseMessage.ResponseObj = teacherList;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("getRoomInfo")]
        public IActionResult getStudentClassRoutine([FromQuery] string ORG_CODE)
        {

            List<RoomInfoVM> roomInfo = teacher.getRoomInfo(ORG_CODE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.data = "Room Info Data";
            responseMessage.Message = "Room List";
            responseMessage.ResponseObj = roomInfo;
            return Ok(responseMessage);
        }

        [HttpPost]
        [Route("saveRoomMst")]
        public IActionResult saveRoomMst([FromBody] RoomMst roomMst)
        {

            var statusAndMessage = teacher.saveRoomMst(roomMst);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            return Ok(responseMessage);
        }

    }
}
