using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using StudentWebAPI.RepositoryImpl;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {

        IOrganization organization = new OrganizationRepository();

        [HttpGet]
        [Route("GetOrganizationList")]
        public IActionResult GetOrganizationList(string userCode)
        {
            List<OrganizationViewModel> organizationList = organization.GetOrganizationList(userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Organization List";
            responseMessage.ResponseObj = organizationList;
            return Ok(responseMessage);
        }
        [HttpGet]
        [Route("getAllOrganizationList")]
        public IActionResult GetAllOrganizationList()
        {
            List<OrganizationViewModel> organizationList = organization.GetAllOrganizationList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Organization List";
            responseMessage.ResponseObj = organizationList;
            return Ok(responseMessage);
        }
        

        [HttpGet]
        [Route("GetOrganizationTypeList")]
        public IActionResult GetOrganizationTypeList()
        {
            List<OrganizationTypeViewModel> organizationTypeList = organization.OrganizationTypeList();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Organization Type List";
            responseMessage.ResponseObj = organizationTypeList;
            return Ok(responseMessage);
        }

        [HttpGet]
        [Route("GetOrgUserCreationList")]
        public IActionResult GetOrganizationUser(string userCode)
        {

            List<OrganizationUserCreationVM> organizationuserList = organization.GetOrganizationUser(userCode);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Organization User Creation List";
            responseMessage.ResponseObj = organizationuserList;
            return Ok(responseMessage);
        }
    }


}
