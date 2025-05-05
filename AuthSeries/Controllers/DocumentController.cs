using DevExpress.CodeParser;
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
    public class DocumentController : ControllerBase
    {
        IDocumentType document = new DocumentRepository();


        [HttpGet]
        [Route("DocumentType")]
        public IActionResult DocumentType(string ORG_CODE)
        {
            List<DocumentTypeVM> documentList = document.GetDocumentType(ORG_CODE);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Document List";
            responseMessage.ResponseObj = documentList;
            return Ok(responseMessage);
        }





    }
}
