using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Microsoft.AspNetCore.Http;
using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.Admin.SetUp;
using StudentWebAPI.Models.ViewModel.Admin.SetUp;
using StudentWebAPI.RepositoryImpl.GoogleDrive;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl
{
    public class SetUpRepository : ISetUp
    {
        DriveService driveService;
        Database_ora db = new Database_ora();
       

        public SetUpRepository()
        {
            driveService = GoogleDriveService.GetService();
        }
        Permission permission = new Permission()
        {
            Type = "anyone",
            Role = "Reader"
        };





        public List<OrganizationInfoViewModel> OrganizationInfoList()
        {
            List<OrganizationInfoViewModel> organizationInfoList = new List<OrganizationInfoViewModel>();

            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);

            organizationInfoList = db.GetList<OrganizationInfoViewModel>("DPG_ORG_MST.DPD_ORG_MST_GRID", parameters);

            return organizationInfoList;
        }

        //public string[] CreateFile(IFormFile[] myFile, string folderId)
        //{
        //    string[] fileIdArray = new string[myFile.Length];
        //    var driveService = GoogleDriveService.GetService();
        //    var driveFile = new Google.Apis.Drive.v3.Data.File();
        //    for (int i = 0; i < myFile.Length; i++)
        //    {
        //        driveFile.Name = myFile[i].FileName;
        //        driveFile.MimeType = myFile[i].ContentType;
        //        driveFile.Parents = new string[] { folderId };
        //        using var stream = myFile[i].OpenReadStream();
        //        var request = driveService.Files.Create(driveFile, stream, myFile[i].ContentType);
        //        request.Fields = "id";
        //        var response = request.Upload();
        //        if (response.Status != Google.Apis.Upload.UploadStatus.Completed)
        //            throw response.Exception;
        //        fileIdArray[i] = request.ResponseBody.Id;



        //    }

        //    return fileIdArray;
        // }


        public string CreateFile(IFormFile myFile, string folderId)
        {
            var driveService = GoogleDriveService.GetService();
            var driveFile = new Google.Apis.Drive.v3.Data.File();
            driveFile.Name = myFile.FileName;
            driveFile.MimeType = myFile.ContentType;
            driveFile.Parents = new string[] { folderId };
            using var stream = myFile.OpenReadStream();
            var request = driveService.Files.Create(driveFile, stream, myFile.ContentType);
            request.Fields = "id";
            var response = request.Upload();
            if (response.Status != Google.Apis.Upload.UploadStatus.Completed)
                throw response.Exception;
            return request.ResponseBody.Id;

        }



        public (int status, string[] message) OrganizationInfo(OrganizationInfo organizationInfo)
        {
            int status = 0;
            string[] message = new String[2];


            if (organizationInfo.MyFile !=null) { 

            string key = ConfigurationManager.AppSetting["DriveFolderKey"];
            string parentFolderId = string.Empty;
            string folderId = string.Empty;

            parentFolderId = CheckIfFolderExists(organizationInfo.ORG_NAME, string.Empty);
            if (parentFolderId.Equals(string.Empty))
            {
                parentFolderId = CreateFolder(organizationInfo.ORG_NAME, string.Empty);
            }
            folderId = CheckIfFolderExists(organizationInfo.ORG_NAME, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(organizationInfo.ORG_NAME, parentFolderId);
            }





            var fileId = CreateFile(organizationInfo.MyFile, folderId); 
            //organizationInfo.MyFile = fileId;
            //folderStructure.FILE_NAME = folderStructure.MyFile.FileName;
            //folderStructure.MIM_TYPE = folderStructure.MyFile.ContentType;
            //folderStructure.FILE_EXTENTION = Path.GetExtension(folderStructure.MyFile.FileName);
            organizationInfo.FILE_URL = fileId;
            }


            OracleParameter[] Params = new OracleParameter[28];
            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(organizationInfo.RowStatus, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(organizationInfo.ORG_ID, OracleDbType.Decimal);
            Params[3] = db.MakeInParameter(organizationInfo.ORG_CODE, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(organizationInfo.ORG_NAME, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(organizationInfo.ORG_NAME_BANGLA, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(organizationInfo.ORG_IMAGE, OracleDbType.Clob);
            Params[7] = db.MakeInParameter(organizationInfo.REG_NUM, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(organizationInfo.REG_DATE, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(organizationInfo.ORG_TYPE_ID, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(organizationInfo.MOBILE, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(organizationInfo.CONT_MOBILE1, OracleDbType.Varchar2);
            Params[12] = db.MakeInParameter(organizationInfo.CONT_PERSION1, OracleDbType.Varchar2);
            Params[13] = db.MakeInParameter(organizationInfo.CONT_MOBILE2, OracleDbType.Varchar2);
            Params[14] = db.MakeInParameter(organizationInfo.CONT_PERSION2, OracleDbType.Varchar2);
            Params[15] = db.MakeInParameter(organizationInfo.ADDR1, OracleDbType.Varchar2);
            Params[16] = db.MakeInParameter(organizationInfo.ADDR2, OracleDbType.Varchar2);
            Params[17] = db.MakeInParameter(organizationInfo.COUNTRY_CODE, OracleDbType.Varchar2);
            Params[18] = db.MakeInParameter(organizationInfo.DIV_CODE, OracleDbType.Varchar2);
            Params[19] = db.MakeInParameter(organizationInfo.DIST_CODE, OracleDbType.Varchar2);
            Params[20] = db.MakeInParameter(organizationInfo.THANA_CODE, OracleDbType.Varchar2);
            Params[21] = db.MakeInParameter(organizationInfo.ZIP_CODE, OracleDbType.Varchar2);
            Params[22] = db.MakeInParameter(organizationInfo.EMAIL, OracleDbType.Varchar2);
            Params[23] = db.MakeInParameter(organizationInfo.WEB_ADDR, OracleDbType.Varchar2);
            Params[24] = db.MakeInParameter(organizationInfo.MOBILE_WALLET_NO, OracleDbType.Varchar2);
            Params[25] = db.MakeInParameter(organizationInfo.FILE_URL, OracleDbType.Varchar2);
           // Params[24] = db.MakeCollectionParameter(arryFILE_NAME, OracleDbType.Varchar2, arryFILE_NAME.Length);
            Params[26] = db.MakeInParameter(organizationInfo.USER_NAME, OracleDbType.Varchar2);
            Params[27] = db.MakeInParameter(organizationInfo.SHORT_CODE, OracleDbType.Varchar2);
            status = db.RunProcedureWithReturnVal("DPG_ORG_MST.DPD_ORG_MST", Params);

            if (status == 1 && organizationInfo.RowStatus == 1)
            {
                message[0] = "Organization";
                message[1] = "#5cb85c";
            }
            else if (status == 1 && organizationInfo.RowStatus == 2)
            {
                message[0] = "Organization";
                message[1] = "#5cb85c";
            }
            else if (status == 1 && organizationInfo.RowStatus == 3)
            {
                message[0] = "Organization";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = "Organization";
                message[1] = "#e35b5a";
            }

            return (status,message);
        }



        public string CheckIfFolderExists(string folderName, string parentFolderId)
        {
            var FileList = driveService.Files.List();
            FileList.Q = "mimeType='application/vnd.google-apps.folder' and trashed=false and name='" + folderName + "'";

            if (!string.IsNullOrEmpty(parentFolderId))
            {
                FileList.Q += $" and '{parentFolderId}' in parents";
            }

            var fileList = FileList.Execute();
            if (fileList.Files.Count > 0)
            {
                var existingFolder = fileList.Files.First();
                return existingFolder.Id;
            }

            return string.Empty;
        }


        public string CreateFolder(string folderName, string ParentId)
        {
            if (ParentId.Equals(string.Empty))
            {
                var Folder = new Google.Apis.Drive.v3.Data.File();
                Folder.Name = folderName;
                Folder.MimeType = "application/vnd.google-apps.folder";
                var Request = driveService.Files.Create(Folder);
                Request.Fields = "id";
                var File = Request.Execute();
                driveService.Permissions.Create(permission, File.Id).Execute();
                return File.Id;
            }
            else
            {
                var Folder = new Google.Apis.Drive.v3.Data.File();
                Folder.Name = folderName;
                Folder.MimeType = "application/vnd.google-apps.folder";
                var Request = driveService.Files.Create(Folder);
                Folder.Parents = new[] { ParentId };
                Request.Fields = "id";
                var File = Request.Execute();
                driveService.Permissions.Create(permission, File.Id).Execute();
                return File.Id;
            }

        }













    }
}
