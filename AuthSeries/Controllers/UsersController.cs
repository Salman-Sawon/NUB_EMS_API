using EMSAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EMSAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly ITokenService tokenService;

        public UsersController(IConfiguration configuration, ITokenService tokenService)
        {
            this.configuration = configuration;
            this.tokenService = tokenService;
        }

        //[HttpPost]
        //[Route("sign-in")]
        //public IActionResult Post(UserModel userModel)
        //{
        //    // return Ok(tokenService.BuildToken(configuration["Jwt:EMS:Key"], configuration["Jwt:EMS:ValidIssuer"], userModel));
        //    return Ok("");
        //}
    }
}
