using DevExpress.CodeParser;
using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class DocumentRepository : IDocumentType
    {
        Database_ora db;
        public List<DocumentTypeVM> GetDocumentType(string ORG_CODE)
        {
            List<DocumentTypeVM> infoList = new List<DocumentTypeVM>();
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[2];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);


            infoList = db.GetList<DocumentTypeVM>("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_DOCUMENT_LIST", Params);

            return infoList;
        }








    }
}
