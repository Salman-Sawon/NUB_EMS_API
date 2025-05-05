using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.WhatsAppMsg
{
    public class WhatsAppMsg
    {
        public List<string> PhoneNumbers { get; set; }
        public List<string> Messages { get; set; }
    }
}
