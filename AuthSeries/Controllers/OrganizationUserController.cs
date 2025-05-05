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
    public class OrganizationUserController : ControllerBase
    {
        IOrganizationUserCreation orgUserRepository = new OrganizationUserCreationRepository();
        //OrganizationUserCreationGRID user = new OrganizationUserCreationGRID();
        //IOrganizationUserCreation organizationUser = new OrganizationUserCreationRepository();

        //[HttpGet]
        //[Route("GetOrganizationUserCreationList")]
        //public IActionResult GetOrganizationUser(string userCode)
        //{
          
        //    List<OrganizationUserCreationGRID> organizationuserList = orgUserRepository.GetOrganizationUser(userCode);
        //    ResponseMessage responseMessage = new ResponseMessage();
        //    responseMessage.StatusCode = 1;
        //    responseMessage.Message = "Organization User Creation List";          
        //    responseMessage.ResponseObj = organizationuserList;
        //    return Ok(responseMessage);
        //}
        //public IActionResult GetOrganizationList(string userCode)
        //{
        //    List<OrganizationViewModel> organizationList = organization.GetOrganizationList(userCode);
        //    ResponseMessage responseMessage = new ResponseMessage();
        //    responseMessage.StatusCode = 1;
        //    responseMessage.Message = "Organization List";
        //    responseMessage.ResponseObj = organizationList;
        //    return Ok(responseMessage);
        //}

        [HttpPost]
        [Route("CreateUserOrganization")]
        public IActionResult AddUserOrganization([FromBody] RequestMessage requestObject)
        {
            OrgUserCreation orgUser = new OrgUserCreation();
            string jsonResponse = Convert.ToString(requestObject.RequestObject);
            orgUser = JsonConvert.DeserializeObject<OrgUserCreation>(jsonResponse);

            var statusAndMessage = orgUserRepository.AddUserOrganizationCreation(orgUser);

            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            responseMessage.ResponseObj = orgUser;
            return Ok(responseMessage);
        }
    }
}
