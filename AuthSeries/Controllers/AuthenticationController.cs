using StudentWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StudentWebAPI.Service;
using StudentWebAPI.RepositoryImpl;
using StudentWebAPI.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using EMSAPI.Services;

namespace StudentWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ITokenService _tokenService;
        IStudent student = new StudentRepository();
        public AuthenticationController(IConfiguration configuration, ITokenService tokenService)
        {
            _configuration = configuration;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> login([FromBody] User user)
        {
            ILogin loginRepository = new LoginRepository();
           // bool status = loginRepository.CheckValidLogin(user.username, user.password);

            AdminUserMstVM loginData = loginRepository.GetLoggedData(user.username, user.password);
            ResponseMessage responseMessage = new ResponseMessage();
            if (loginData.STATUS!=null)
            {

                loginData.Token = _tokenService.BuildToken(_configuration["Jwt:EMS:Key"], _configuration["Jwt:EMS:ValidIssuer"], user);
                responseMessage.StatusCode = 1;
                responseMessage.Message = "Login Successfully";
                responseMessage.ResponseObj = loginData;
               // return Ok(_tokenService.BuildToken(_configuration["Jwt:EMS:Key"], _configuration["Jwt:EMS:ValidIssuer"], user));
            }
            else
            {
                responseMessage.StatusCode = 0;
                responseMessage.Message = "Invalid Email or Password";
                responseMessage.ResponseObj = "";
            }
           // return Ok("");
            return Ok(responseMessage);
        }


      


        [Authorize]
        [HttpPost]
        [Route("ChangePassword")]
        public IActionResult ChangePassword([FromBody] ChangePasswordViewModel changePass)
        { 
            ILogin loginRepository = new LoginRepository();
            var statusAndMessage = loginRepository.ChangePassword(changePass);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.data = "data";
            responseMessage.ResponseObj = "data";
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            return Ok(responseMessage);
        }






    }
}
