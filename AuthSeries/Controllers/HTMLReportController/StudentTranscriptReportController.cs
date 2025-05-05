using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models.HTMLReport;
using StudentWebAPI.Service.HTMLReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Controllers.HTMLReportController
{
    [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class StudentTranscriptReportController : ControllerBase
    {
        private readonly IStudentTranscriptReport _studentTranscript;
        public StudentTranscriptReportController(IStudentTranscriptReport studentTranscript)
        {
            _studentTranscript = studentTranscript;
        }
        [HttpGet]
        [Route("StudentTranscriptReportList")]
        public IActionResult GetStudentTranscriptReportLis(string organizationCode, string studentCode, decimal termId)
        {
            List<StudentTranscriptReportViewModel> studentTranscriptReportList = _studentTranscript.studentTranscriptReportList(organizationCode, studentCode, termId);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Account List";
            responseMessage.ResponseObj = studentTranscriptReportList;
            return Ok(responseMessage);
        }
    }
}
