using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models
{
    public class Menu
    {
         
        public decimal MENU_ITEM_ID { get; set; }


        
        public decimal PARENT_MENU_ITEM_ID { get; set; }


        
        public string MENU_DESCRIPTION { get; set; }


        
        public string MENU_URL { get; set; }


        
        public string MENU_ICON { get; set; }

        public string MENU_CLASS { get; set; }


        public string ICON_TYPE { get; set; }

        public string ICON { get; set; }
        public string ICON_SVG { get; set; }
        public decimal SERIAL { get; set; }
        public string IS_MENU { get; set; }
        public int SEPARATOR_GROUP_ID { get; set; }



    }

    public class MenuNew
    {
        public decimal MIID { get; set; }
        public decimal PMIID { get; set; }
        public string MD { get; set; }
        public string MURL { get; set; }
        public decimal SL { get; set; }
        public string ISM { get; set; }
        public decimal SGID { get; set; }
        public string ISVG { get; set; }
    }
}
