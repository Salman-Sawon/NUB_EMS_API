using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.GoogleDrive
{
    public class ImagesModel
    {
        public IFormFile IMAGE { get; set; }
        public string ORG_NAME { get; set; }
        public string CAMPUS_NAME { get; set; }
        public string PARENT_IMAGE { get; set; }
        public string CHILD_IMAGE { get; set; }
   
    }
}
