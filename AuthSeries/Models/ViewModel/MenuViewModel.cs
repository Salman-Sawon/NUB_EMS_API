using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class MenuViewModel
    {
        public List<Item> items { get; set; }
    }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Submenu2
        {
            public string title { get; set; }
            public string page { get; set; }
            public string permission { get; set; }
        }

    public class Submenu
    {
        public string title { get; set; }
        public string page { get; set; }
        public string bullet { get; set; }
        public List<Submenu2> submenu { get; set; }
    }

    public class Item
        {
            public string title { get; set; }
            public bool root { get; set; }
            public string icon { get; set; }
            public string svg { get; set; }
            public string page { get; set; }
            public string translate { get; set; }
            public string bullet { get; set; }
            public string section { get; set; }
            public List<Submenu> submenu { get; set; }
            public string permission { get; set; }
        }

      
}
