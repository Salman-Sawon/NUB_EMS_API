using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentWebAPI.Models;
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
    public class StudentBulkEntryController : ControllerBase
    {

        [HttpPost]
        [Route("StudentBulkEntry")]
        public IActionResult StudentBulkEntry([FromBody] StudentBulkEntry stdBulkEntry)
        {
            
            //StudentBulkEntry stdBulkEntry = new StudentBulkEntry();
            //string jsonResponse = Convert.ToString(requestObject.RequestObject);
            //stdBulkEntry = JsonConvert.DeserializeObject<StudentBulkEntry>(jsonResponse);
            IStudentBulkEntry studentBulk = new StudentBulkEntryRepository();
            var statusAndMessage = studentBulk.SaveStudentBulkEntry(stdBulkEntry);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            return Ok(responseMessage);
        }

        [HttpPost]
        [Route("dummy-file-upload")]
        public IActionResult DummyFileUpload()
        {
            return Ok("");
        }

    }
}
