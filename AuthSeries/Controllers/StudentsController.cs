using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentWebAPI.Models;
using StudentWebAPI.Models.Student;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Student;
using StudentWebAPI.Models.WhatsAppMsg;
using StudentWebAPI.RepositoryImpl;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentWebAPI.Controllers
{
   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IStudent student = new StudentRepository();
      

       

        
       


        









    }
}
