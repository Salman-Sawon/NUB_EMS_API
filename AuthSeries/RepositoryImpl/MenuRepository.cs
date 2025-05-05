using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Helper.Redis;
using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class MenuRepository : IMenu
    {
        Database_ora _context;
        private readonly ICacheService _cacheService = new CacheService();
        //public List<Menu> GetMenuList(string userName, int roleId)
        public MenuViewModel GetMenuList(string userName, int roleId)
        {
            List<Menu> menuList = new List<Menu>();
            _context = new Database_ora();
            OracleParameter[] prmMenu = new OracleParameter[3];
            prmMenu[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            prmMenu[1] = _context.MakeInParameter(userName, OracleDbType.Varchar2);
            prmMenu[2] = _context.MakeInParameter(roleId, OracleDbType.Int16);

            menuList = _context.GetList<Menu>("DPG_ADMIN_LOGIN.DPD_ADMIN_MENU_V3", prmMenu);
          //  menuList = _context.GetList<Menu>("DPG_ADMIN_LOGIN.DPD_ADMIN_MENU", prmMenu);


            MenuViewModel menu = new MenuViewModel();

            var parentMenu = menuList.Where(w => w.PARENT_MENU_ITEM_ID == 0).OrderBy(o => o.SERIAL).ToList();
            menu.items = new List<Item>();
            for (int i = 0; i < parentMenu.Count; i++)
            {
                Item item = new Item();
                item.title = parentMenu[i].MENU_DESCRIPTION;
                item.root = true;
                item.icon = parentMenu[i].ICON;
                item.svg = parentMenu[i].ICON_SVG;//"./assets/media/svg/icons/Design/Layers.svg";
                item.page = "/" + parentMenu[i].MENU_DESCRIPTION.ToLower();
                //item.translate= 'MENU.DASHBOARD';
                item.bullet = "dot";
                if (item.title.ToLower() == "admin")
                    item.section = "ADMIN";
                if (item.title.ToLower() == "reports")
                    item.section = "REPORTS";
                if (item.title.ToLower() == "teacher")
                    item.section = "TEACHERS & STUDENTS";
                if (item.title.ToLower() == "account")
                    item.section = "ACCOUNTS";
                //if (item.title.ToLower() == "fee")
                //    item.section = "FEES";
                //if (item.title.ToLower() == "result")
                //    item.section = "RESULTS";



                item.submenu = new List<Submenu>();
                var childMenu1 = menuList.Where(w => w.PARENT_MENU_ITEM_ID == parentMenu[i].MENU_ITEM_ID).ToList();
                for (int j = 0; j < childMenu1.Count; j++)
                {
                    Submenu submenu = new Submenu();
                    submenu.title = childMenu1[j].MENU_DESCRIPTION;
                    submenu.bullet = "dot";
                    submenu.page = item.page + "/" + childMenu1[j].MENU_DESCRIPTION.Replace(" ", string.Empty).Trim().ToLower() + "/";

                    submenu.submenu = new List<Submenu2>();
                    var childMenu2 = menuList.Where(w => w.PARENT_MENU_ITEM_ID == childMenu1[j].MENU_ITEM_ID).ToList();
                    for (int k = 0; k < childMenu2.Count; k++)
                    {
                        Submenu2 submenu2 = new Submenu2();
                        submenu2.title = childMenu2[k].MENU_DESCRIPTION;
                        submenu2.page = submenu.page + childMenu2[k].MENU_URL.Replace(" ", string.Empty).Trim();//'/material/form-controls/autocomplete';
                        submenu2.permission = "accessToECommerceModule";

                        submenu.submenu.Add(submenu2);
                    }

                    item.submenu.Add(submenu);
                }


                menu.items.Add(item);
            }


            return menu;
        }


        public List<Menu> GetDBMenuList(string userCode, int roleId)
        {
            string redisKey = userCode + "_"+roleId+ "_dBMenuList";
            var cacheData = _cacheService.GetData<IEnumerable<Menu>>(redisKey);
            if (cacheData != null)
            {
                return (List<Menu>)cacheData;
            }
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<Menu> menuList = new List<Menu>();
            _context = new Database_ora();
            OracleParameter[] prmMenu = new OracleParameter[3];
            prmMenu[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            prmMenu[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);
            prmMenu[2] = _context.MakeInParameter(roleId, OracleDbType.Int16);
            menuList = _context.GetList<Menu>("DPG_ADMIN_LOGIN.DPD_ADMIN_MENU_V3", prmMenu);
            Menu menu = new Menu();
            menu.MENU_DESCRIPTION = "ADMIN";
            menu.PARENT_MENU_ITEM_ID = 0;
            menu.IS_MENU = "N";
            menu.SEPARATOR_GROUP_ID = 1;
            menu.SERIAL = 1;
            menuList.Add(menu);
            menu = new Menu();
            menu.MENU_DESCRIPTION = "TEACHERS & STUDENTS";
            menu.PARENT_MENU_ITEM_ID = 0;
            menu.IS_MENU = "N";
            menu.SEPARATOR_GROUP_ID = 2;
            menu.SERIAL = 2;
            menuList.Add(menu);
            menu = new Menu();
            menu.MENU_DESCRIPTION = "RESULTS";
            menu.PARENT_MENU_ITEM_ID = 0;
            menu.IS_MENU = "N";
            menu.SEPARATOR_GROUP_ID = 3;
            menu.SERIAL = 3;
            menuList.Add(menu);
            menuList.Add(menu); 
            menu.MENU_DESCRIPTION = "ACCOUNTS";
            menu.PARENT_MENU_ITEM_ID = 0;
            menu.IS_MENU = "N";
            menu.SEPARATOR_GROUP_ID = 4;
            menu.SERIAL = 4;
            menuList.Add(menu);
            menu = new Menu();
            menu.MENU_DESCRIPTION = "ACCOUNTS";
            menu.PARENT_MENU_ITEM_ID = 0;
            menu.IS_MENU = "N";
            menu.SEPARATOR_GROUP_ID = 5;
            menu.SERIAL = 5;
            menuList.Add(menu);
            menu = new Menu();
            menu.MENU_DESCRIPTION = "SMS & NOTICE";
            menu.PARENT_MENU_ITEM_ID = 0;
            menu.IS_MENU = "N";
            menu.SEPARATOR_GROUP_ID = 6;
            menu.SERIAL = 6;
            menuList.Add(menu);
            menu = new Menu();

            menu.MENU_DESCRIPTION = "SYLLABUS & NOTICE";
            menu.PARENT_MENU_ITEM_ID = 0;
            menu.IS_MENU = "N";
            menu.SEPARATOR_GROUP_ID = 7;
            menu.SERIAL = 7;
            menuList.Add(menu);
            menu = new Menu();

          

            menu.MENU_DESCRIPTION = "REPORTS";
            menu.PARENT_MENU_ITEM_ID = 0;
            menu.IS_MENU = "N";
            menu.SEPARATOR_GROUP_ID = 8;
            menu.SERIAL = 8;
            menuList.Add(menu);
            cacheData = menuList;
            _cacheService.SetData<IEnumerable<Menu>>(redisKey, cacheData, expirationTime);
            return (List<Menu>)cacheData;
        }


        public List<MenuNew> getDBMenuListNew(string userCode, int roleId)
        {
            string redisKey = userCode + "_" + roleId + "_dBMenuListv4";
            var cacheData = _cacheService.GetData<IEnumerable<MenuNew>>(redisKey);
            //if (cacheData != null)
            //{
            //    return (List<MenuNew>)cacheData;
            //}
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            List<MenuNew> menuList = new List<MenuNew>();
            _context = new Database_ora();
            OracleParameter[] prmMenu = new OracleParameter[3];
            prmMenu[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            prmMenu[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);
            prmMenu[2] = _context.MakeInParameter(roleId, OracleDbType.Int16);
            menuList = _context.GetList<MenuNew>("DPG_ADMIN_LOGIN.DPD_ADMIN_MENU_V4", prmMenu);
           
            MenuNew menu = new MenuNew();
            menu.MD = "ADMIN";
            menu.PMIID = 0;
            menu.ISM = "N";
            menu.SGID = 1;
            menu.SL = 1;
            menuList.Add(menu);

            menu = new MenuNew();
            menu.MD = "ADMISSION";
            menu.PMIID = 0;
            menu.ISM = "N";
            menu.SGID = 2;
            menu.SL = 2;
            menuList.Add(menu);

            menu = new MenuNew();
            menu.MD = "TEACHERS & STUDENTS";
            menu.PMIID = 0;
            menu.ISM = "N";
            menu.SGID = 3;
            menu.SL = 3;
            menuList.Add(menu);

            menu = new MenuNew();
            menu.MD = "SMS";
            menu.PMIID = 0;
            menu.ISM = "N";
            menu.SGID = 4;
            menu.SL = 4;
            menuList.Add(menu);


            //menu = new MenuNew();
            //menu.MD = "NOTIFICATION";
            //menu.PMIID = 0;
            //menu.ISM = "N";
            //menu.SGID = 8;
            //menu.SL = 8;
            //menuList.Add(menu);




            menu = new MenuNew();
            menu.MD = "ACCOUNTS";
            menu.PMIID = 0;
            menu.ISM = "N";
            menu.SGID = 5;
            menu.SL = 5;
            menuList.Add(menu);

            
           





            menu = new MenuNew();
            menu.MD = "SYLLABUS & NOTICE";
            menu.PMIID = 0;
            menu.ISM = "N";
            menu.SGID = 6;
            menu.SL = 6;
            menuList.Add(menu);


            menu = new MenuNew();
            menu.MD = "REPORTS";
            menu.PMIID = 0;
            menu.ISM = "N";
            menu.SGID = 7;
            menu.SL = 7;
            menuList.Add(menu);
            cacheData = menuList;
            _cacheService.SetData<IEnumerable<MenuNew>>(redisKey, cacheData, expirationTime);
            return (List<MenuNew>)cacheData;
        }
    }
}
