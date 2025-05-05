using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.Google;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl.GoogleDrive
{
    public class GoogleDriveCredential
    {
        Database_ora db;
        OracleParameter[] param;
        public GoogleCredentialVM getGoogleCredential()
        {
            var googleCredential = new GoogleCredentialVM();
            db = new Database_ora();
            param = new OracleParameter[1];
            param[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            googleCredential = db.GetModelData<GoogleCredentialVM>("DPG_GOOGLE_DRIVE_CREDENTIAL.DPD_GOOGLE_DRIVE_CREDENTIAL", param);
            return googleCredential;
        }
    }
}
