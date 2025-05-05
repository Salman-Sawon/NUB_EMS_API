using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Controllers
{
    public class ResponseMessage
    {
        public object data { get; set; }
        public object ResponseObj { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }

    }
}
