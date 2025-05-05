using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class OrganizationRepository:IOrganization
    {
        Database_ora _context;
        public List<OrganizationViewModel> GetOrganizationList(string userCode)
        {
            List<OrganizationViewModel> organizationList = new List<OrganizationViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);

            organizationList = _context.GetList<OrganizationViewModel>("DPG_ADMIN_USER_MST_WOADMIN.DPD_ORG_MST_LIST", parameters);

            return organizationList;
            //return organizationList.Select(s=>new OrganizationViewModel {
            //    ORG_CODE = s.ORG_CODE,
            //    ORG_NAME = s.ORG_NAME
            //}).ToList();
        }
        public List<OrganizationViewModel> GetAllOrganizationList()
        {
            List<OrganizationViewModel> organizationList = new List<OrganizationViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            organizationList = _context.GetList<OrganizationViewModel>("DPG_ADMIN_USER_MST_WOADMIN.DPD_ORG_MST_LIST_ALL", parameters);
            return organizationList;
        }
        public List<OrganizationTypeViewModel> OrganizationTypeList()
        {
            List<OrganizationTypeViewModel> organizationTypeList = new List<OrganizationTypeViewModel>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            organizationTypeList = _context.GetList<OrganizationTypeViewModel>("DPG_ORG_TYPE.DPD_ORG_TYPE_GRID", parameters);
            return organizationTypeList;
        }

        public List<OrganizationUserCreationVM> GetOrganizationUser(string userCode)
        {
            List<OrganizationUserCreationVM> organizationUserList = new List<OrganizationUserCreationVM>();
            _context = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = _context.MakeInParameter(userCode, OracleDbType.Varchar2);

            organizationUserList = _context.GetList<OrganizationUserCreationVM>("DPG_ADMIN_USER_MST_WOADMIN.DPD_USER_MASTER_GRID", parameters);

            return organizationUserList;
           
        }

    }
}
