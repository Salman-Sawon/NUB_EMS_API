using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.GoogleDrive;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;


namespace StudentWebAPI.RepositoryImpl.GoogleDrive
{
    
    public class GoogleUtility : IGoogle
    {
        //ICommon common = new CommonRepository();
        DriveService driveService;
        Database_ora db;

        public GoogleUtility()
        {
            driveService = GoogleDriveService.GetService();
        }


        Permission permission = new Permission()
        {
            Type = "anyone",
            Role = "Reader"
        };

        //public string CheckIfFolderExists(string folderName)
        //{
        //    var FileList = driveService.Files.List();
        //    FileList.Q = "mimeType='application/vnd.google-apps.folder' and trashed=false and name='" + folderName + "'";
        //    var fileList = FileList.Execute();
        //    if (fileList.Files.Count > 0)
        //    {
        //        var ExistingFolder = fileList.Files.First();
        //        return ExistingFolder.Id;

        //    }

        //    return string.Empty;
        //}

        public string CreateFile(Stream myFile, string FileName, string ContentType, string folderId)
        {
            //var driveService = _googleService.GetService();
            var driveFile = new Google.Apis.Drive.v3.Data.File();
            driveFile.Name = FileName;
            driveFile.MimeType = ContentType;
            driveFile.Parents = new string[] { folderId };
            var request = driveService.Files.Create(driveFile, myFile, ContentType);
            request.Fields = "id";
            var response = request.Upload();
            if (response.Status != Google.Apis.Upload.UploadStatus.Completed)
                throw response.Exception;
            return request.ResponseBody.Id;

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

        //public (int status, string[] message) PrepareFolder(FolderStructureVM folderStructure)
        //{
        //    int status = 0;
        //    string[] message = new String[2];

        //    string key = ConfigurationManager.AppSetting["DriveFolderKey"];
        //  //  string ReturnKey = common.GetSystemSettingsValueByKey(key, folderStructure.ORG_CODE);
        //    string parentFolderId = string.Empty;
        //    string folderId = string.Empty;

        //    parentFolderId = CheckIfFolderExists(folderStructure.ORG_NAME);
        //    if (parentFolderId.Equals(string.Empty))
        //    {
        //        parentFolderId = CreateFolder(folderStructure.ORG_NAME, "");
        //    }
        //    folderId = CheckIfFolderExists(folderStructure.CLASS_NAME);
        //    if (folderId.Equals(string.Empty))
        //    {
        //        folderId = CreateFolder(folderStructure.CLASS_NAME, parentFolderId);
        //    }
        //    parentFolderId = folderId;
        //    folderId = CheckIfFolderExists(folderStructure.SUBJECT_NAME);
        //    if (folderId.Equals(string.Empty))
        //    {
        //        folderId = CreateFolder(folderStructure.SUBJECT_NAME, parentFolderId);
        //    }
        //    parentFolderId = folderId;
        //    folderId = CheckIfFolderExists(folderStructure.LECTURE_OR_ASSIGNMENT);
        //    if (folderId.Equals(string.Empty))
        //    {
        //        folderId = CreateFolder(folderStructure.LECTURE_OR_ASSIGNMENT, parentFolderId);
        //        var fileId = CreateFile(folderStructure.MyFile, folderId);
        //        folderStructure.GOOGLE_FILE_ID = fileId;
        //        folderStructure.FILE_NAME = folderStructure.MyFile.FileName;
        //        folderStructure.MIM_TYPE = folderStructure.MyFile.ContentType;
        //        folderStructure.FILE_EXTENTION = Path.GetExtension(folderStructure.MyFile.FileName);
        //        folderStructure.FILE_URL = fileId;
        //        status = SaveFileDB(folderStructure);
        //    }
        //    else
        //    {
        //        var fileId = CreateFile(folderStructure.MyFile, folderId);
        //        folderStructure.GOOGLE_FILE_ID = fileId;
        //        folderStructure.FILE_NAME = folderStructure.MyFile.FileName;
        //        folderStructure.MIM_TYPE = folderStructure.MyFile.ContentType;
        //        folderStructure.FILE_EXTENTION = Path.GetExtension(folderStructure.MyFile.FileName);
        //        folderStructure.FILE_URL = fileId;
        //        status = SaveFileDB(folderStructure);
        //    }

        //    if (status == 1)
        //    {
        //        message[0] = "Successfully File Uploaded!!";
        //        message[1] = "#5cb85c";
        //    }
        //    else
        //    {
        //        message[0] = "File Upload failed. Please try again.";
        //        message[1] = "#e35b5a";
        //    }



        //    return (status, message);

        //}

        public (int status, string[] message) PrepareFolder(FolderStructureVM folderStructure)
        {
            int status = 0;
            string[] message = new string[2];

            string key = ConfigurationManager.AppSetting["DriveFolderKey"];
            string parentFolderId = string.Empty;
            string folderId = string.Empty;

        


            parentFolderId = CheckIfFolderExists(folderStructure.ORG_NAME, string.Empty);
            if (parentFolderId.Equals(string.Empty))
            {
                parentFolderId = CreateFolder(folderStructure.ORG_NAME, string.Empty);
            }

            folderId = CheckIfFolderExists(folderStructure.CLASS_NAME, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(folderStructure.CLASS_NAME, parentFolderId);
            }

            parentFolderId = folderId;
            folderId = CheckIfFolderExists(folderStructure.SUBJECT_NAME, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(folderStructure.SUBJECT_NAME, parentFolderId);
            }

            parentFolderId = folderId;
            folderId = CheckIfFolderExists(folderStructure.LECTURE_OR_ASSIGNMENT, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(folderStructure.LECTURE_OR_ASSIGNMENT, parentFolderId);
            }

            // Upload the file to the existing or created folder
            var fileId = CreateFile(folderStructure.MyFile, folderId);
            folderStructure.GOOGLE_FILE_ID = fileId;
            folderStructure.FILE_NAME = folderStructure.MyFile.FileName;
            folderStructure.MIM_TYPE = folderStructure.MyFile.ContentType;
            folderStructure.FILE_EXTENTION = Path.GetExtension(folderStructure.MyFile.FileName);
            folderStructure.FILE_URL = fileId;




            status = SaveFileDB(folderStructure);


            if (status == 1)
            {
                message[0] = "Successfully File Uploaded!!";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = "File Upload failed. Please try again.";
                message[1] = "#e35b5a";
            }

          

            return (status, message);
        }
        public string GetFilesByte(string FileId)
        {
            var request = driveService.Files.Get(FileId);
            var streamDownload = new MemoryStream();
            request.Download(streamDownload);
            // Save the downloaded file to a byte array
            byte[] fileBytes = streamDownload.ToArray();
            // Convert the byte array to a Base64-encoded string
            string base64String = Convert.ToBase64String(fileBytes);
            return base64String;
        }

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
            return  request.ResponseBody.Id;

        }

        public int SaveFileDB(FolderStructureVM folderStructure)
        {
            int status = 0;
            string[] message = new String[2];
            db = new Database_ora();


            OracleParameter[] Params = new OracleParameter[26];

            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(folderStructure.FILE_ID, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(folderStructure.FILE_NAME, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(folderStructure.FILE_TITLE, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(folderStructure.FILE_DESC, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(folderStructure.FILE_EXTENTION, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(folderStructure.MIM_TYPE, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(folderStructure.FILE_URL, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(folderStructure.GOOGLE_FILE_ID, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(folderStructure.ORG_CODE, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(folderStructure.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(folderStructure.CLASS_CODE, OracleDbType.Varchar2);
            Params[12] = db.MakeInParameter(folderStructure.SECTION_CODE, OracleDbType.Varchar2);
            Params[13] = db.MakeInParameter(folderStructure.GROUP_CODE, OracleDbType.Varchar2);
            Params[14] = db.MakeInParameter(folderStructure.SESSION_CODE, OracleDbType.Varchar2);
            Params[15] = db.MakeInParameter(folderStructure.VERSION_CODE, OracleDbType.Varchar2);
            Params[16] = db.MakeInParameter(folderStructure.YEAR_CODE, OracleDbType.Varchar2);
            Params[17] = db.MakeInParameter(folderStructure.SEMESTER_CODE, OracleDbType.Varchar2);
            Params[18] = db.MakeInParameter(folderStructure.SHIFT_CODE, OracleDbType.Varchar2);
            Params[19] = db.MakeInParameter(folderStructure.SUBJECT_CODE, OracleDbType.Varchar2);
            Params[20] = db.MakeInParameter(folderStructure.ASSIGNMENT_OR_LECTURE_CODE, OracleDbType.Varchar2);
            Params[21] = db.MakeInParameter(folderStructure.USER_CODE, OracleDbType.Varchar2);
            Params[22] = db.MakeInParameter(folderStructure.DUE_DATE, OracleDbType.Varchar2);
            Params[23] = db.MakeInParameter(folderStructure.DUE_TIME, OracleDbType.Varchar2);
            Params[24] = db.MakeInParameter(folderStructure.PARENT_FILE_ID, OracleDbType.Decimal);
            Params[25] = db.MakeInParameter(folderStructure.RowStatus, OracleDbType.Decimal);

            //Params[18] = db.MakeInParameter(fileInfo.RowStatus, OracleDbType.Decimal);

            status = db.RunProcedureWithReturnVal("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_CLASS_WISE_FILE_IUD", Params);

            return status;

        }

        public int SaveTeacherFileDB(TeacherFolderStructureVM folderStructure)
        {
            int status = 0;
            string[] message = new String[2];
            db = new Database_ora();


            OracleParameter[] Params = new OracleParameter[18];

            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(folderStructure.FILE_ID, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(folderStructure.FILE_NAME, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(folderStructure.FILE_TITLE, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(folderStructure.FILE_DESC, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(folderStructure.FILE_EXTENTION, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(folderStructure.MIM_TYPE, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(folderStructure.FILE_URL, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(folderStructure.GOOGLE_FILE_ID, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(folderStructure.ORG_CODE, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(folderStructure.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(folderStructure.SUB_MAP_ID, OracleDbType.Decimal);        
            Params[12] = db.MakeInParameter(folderStructure.ASSIGNMENT_OR_LECTURE_CODE, OracleDbType.Varchar2);
            Params[13] = db.MakeInParameter(folderStructure.USER_CODE, OracleDbType.Varchar2);
            Params[14] = db.MakeInParameter(folderStructure.DUE_DATE, OracleDbType.Varchar2);
            Params[15] = db.MakeInParameter(folderStructure.DUE_TIME, OracleDbType.Varchar2);
            Params[16] = db.MakeInParameter(folderStructure.PARENT_FILE_ID, OracleDbType.Decimal);
            Params[17] = db.MakeInParameter(folderStructure.RowStatus, OracleDbType.Decimal);

            //Params[18] = db.MakeInParameter(fileInfo.RowStatus, OracleDbType.Decimal);

            status = db.RunProcedureWithReturnVal("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_TEACHER_CLASS_FILE_IUD", Params);

            return status;

        }


        public (int status, string[] message) SaveFileAndroidDB(FolderStructureSaveDB folderStructure)
        {
            int status = 0;
            string[] message = new String[2];
            db = new Database_ora();


            OracleParameter[] Params = new OracleParameter[26];

            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(folderStructure.FILE_ID, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(folderStructure.FILE_NAME, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(folderStructure.FILE_TITLE, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(folderStructure.FILE_DESC, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(folderStructure.FILE_EXTENTION, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(folderStructure.MIM_TYPE, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(folderStructure.FILE_URL, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(folderStructure.GOOGLE_FILE_ID, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(folderStructure.ORG_CODE, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(folderStructure.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(folderStructure.CLASS_CODE, OracleDbType.Varchar2);
            Params[12] = db.MakeInParameter(folderStructure.SECTION_CODE, OracleDbType.Varchar2);
            Params[13] = db.MakeInParameter(folderStructure.GROUP_CODE, OracleDbType.Varchar2);
            Params[14] = db.MakeInParameter(folderStructure.SESSION_CODE, OracleDbType.Varchar2);
            Params[15] = db.MakeInParameter(folderStructure.VERSION_CODE, OracleDbType.Varchar2);
            Params[16] = db.MakeInParameter(folderStructure.YEAR_CODE, OracleDbType.Varchar2);
            Params[17] = db.MakeInParameter(folderStructure.SEMESTER_CODE, OracleDbType.Varchar2);
            Params[18] = db.MakeInParameter(folderStructure.SHIFT_CODE, OracleDbType.Varchar2);
            Params[19] = db.MakeInParameter(folderStructure.SUBJECT_CODE, OracleDbType.Varchar2);
            Params[20] = db.MakeInParameter(folderStructure.ASSIGNMENT_OR_LECTURE_CODE, OracleDbType.Varchar2);
            Params[21] = db.MakeInParameter(folderStructure.USER_CODE, OracleDbType.Varchar2);
            Params[22] = db.MakeInParameter(folderStructure.DUE_DATE, OracleDbType.Varchar2);
            Params[23] = db.MakeInParameter(folderStructure.DUE_TIME, OracleDbType.Varchar2);
            Params[24] = db.MakeInParameter(folderStructure.PARENT_FILE_ID, OracleDbType.Decimal);
            Params[25] = db.MakeInParameter(folderStructure.RowStatus, OracleDbType.Decimal);

            //Params[18] = db.MakeInParameter(fileInfo.RowStatus, OracleDbType.Decimal);

            status = db.RunProcedureWithReturnVal("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_CLASS_WISE_FILE_IUD", Params);

            if (status == 1)
            {
                message[0] = "Successfully File Uploaded!!";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = "File Upload failed. Please try again.";
                message[1] = "#e35b5a";
            }
            return (status, message);
        }



        public (int status, string[] message) SaveTeacherFileAndroidDB(TeacherFolderStructureSaveDB folderStructure)
        {
            int status = 0;
            string[] message = new String[2];
            db = new Database_ora();


            OracleParameter[] Params = new OracleParameter[18];

            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(folderStructure.FILE_ID, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(folderStructure.FILE_NAME, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(folderStructure.FILE_TITLE, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(folderStructure.FILE_DESC, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(folderStructure.FILE_EXTENTION, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(folderStructure.MIM_TYPE, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(folderStructure.FILE_URL, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(folderStructure.GOOGLE_FILE_ID, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(folderStructure.ORG_CODE, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(folderStructure.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(folderStructure.SUB_MAP_ID, OracleDbType.Decimal);
            Params[12] = db.MakeInParameter(folderStructure.ASSIGNMENT_OR_LECTURE_CODE, OracleDbType.Varchar2);
            Params[13] = db.MakeInParameter(folderStructure.USER_CODE, OracleDbType.Varchar2);
            Params[14] = db.MakeInParameter(folderStructure.DUE_DATE, OracleDbType.Varchar2);
            Params[15] = db.MakeInParameter(folderStructure.DUE_TIME, OracleDbType.Varchar2);
            Params[16] = db.MakeInParameter(folderStructure.PARENT_FILE_ID, OracleDbType.Decimal);
            Params[17] = db.MakeInParameter(folderStructure.RowStatus, OracleDbType.Decimal);
            status = db.RunProcedureWithReturnVal("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_TEACHER_CLASS_FILE_IUD", Params);

            if (status == 1)
            {
                message[0] = "Successfully File Uploaded!!";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = "File Upload failed. Please try again.";
                message[1] = "#e35b5a";
            }
            return (status, message);
        }



        public List<DocumentTypeVM> GetDocumentType(string ORG_CODE)
        {
            List<DocumentTypeVM> documentTypeList = new List<DocumentTypeVM>();

            try {

            //Serilog.Log.Information("GetDocumentType before package call");
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);          
            documentTypeList = db.GetList<DocumentTypeVM>("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_DOCUMENT_LIST", parameters);

            
            }
            catch (Exception ex)
            {
                Serilog.Log.Information(ex.Message.ToString());
            }
            return documentTypeList;
        }

        //public List<DocumentTypeVM> GetDocumentType(string ORG_CODE)
        //{
        //    List<DocumentTypeVM> documentList = new List<DocumentTypeVM>();
        //    db = new Database_ora();
        //    OracleParameter[] Params = new OracleParameter[2];
        //    Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
        //    Params[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);

        //    documentList = db.GetList<DocumentTypeVM>("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_DOCUMENT_LIST", Params);

        //    return documentList;
        //}

        public (int status, string[] message) TeacherPrepareFolder(TeacherFolderStructureVM folderStructure)
        {
            int status = 0;
            string[] message = new string[2];

            string key = ConfigurationManager.AppSetting["DriveFolderKey"];
            string parentFolderId = string.Empty;
            string folderId = string.Empty;


            if (folderStructure.MyFile != null) {



            parentFolderId = CheckIfFolderExists(folderStructure.ORG_NAME, string.Empty);
            if (parentFolderId.Equals(string.Empty))
            {
                parentFolderId = CreateFolder(folderStructure.ORG_NAME, string.Empty);
            }

            folderId = CheckIfFolderExists(folderStructure.CLASS_NAME, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(folderStructure.CLASS_NAME, parentFolderId);
            }

            parentFolderId = folderId;
            folderId = CheckIfFolderExists(folderStructure.SUBJECT_NAME, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(folderStructure.SUBJECT_NAME, parentFolderId);
            }

            parentFolderId = folderId;
            folderId = CheckIfFolderExists(folderStructure.LECTURE_OR_ASSIGNMENT, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(folderStructure.LECTURE_OR_ASSIGNMENT, parentFolderId);
            }

            // Upload the file to the existing or created folder
            var fileId = CreateFile(folderStructure.MyFile, folderId);
            folderStructure.GOOGLE_FILE_ID = fileId;
            folderStructure.FILE_NAME = folderStructure.MyFile.FileName;
            folderStructure.MIM_TYPE = folderStructure.MyFile.ContentType;
            folderStructure.FILE_EXTENTION = Path.GetExtension(folderStructure.MyFile.FileName);
            folderStructure.FILE_URL = fileId;
            }
            status = SaveTeacherFileDB(folderStructure);

            if (status == 1 && folderStructure.RowStatus == 1)
            {
                message[0] = "Successfully File Uploaded Saved!!";
                message[1] = "#5cb85c";
            }
            else if (status == 1 && folderStructure.RowStatus == 2)
            {
                message[0] = "Successfully File Uploaded Update!!";
                message[1] = "#5cb85c";
            }
            else if (status == 1 && folderStructure.RowStatus == 3)
            {
                message[0] = "Successfully File Uploaded deleted!!";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = "File Upload failed. Please try again.";
                message[1] = "#e35b5a";
            }

            return (status, message);
        }




        public string saveImages(ImagesModel imgModel)
        {
            string parentFolderId = string.Empty;
            string folderId = string.Empty;

            parentFolderId = CheckIfFolderExists("EMS", string.Empty);
            if (parentFolderId.Equals(string.Empty))
            {
                parentFolderId = CreateFolder("EMS", string.Empty);
            }

            folderId = CheckIfFolderExists(imgModel.ORG_NAME, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(imgModel.ORG_NAME, parentFolderId);
            }

            parentFolderId = folderId;
            folderId = CheckIfFolderExists(imgModel.CAMPUS_NAME, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(imgModel.CAMPUS_NAME, parentFolderId);
            }

            parentFolderId = folderId;
            folderId = CheckIfFolderExists(imgModel.PARENT_IMAGE, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(imgModel.PARENT_IMAGE, parentFolderId);
            }

            parentFolderId = folderId;
            folderId = CheckIfFolderExists(imgModel.CHILD_IMAGE, parentFolderId);
            if (folderId.Equals(string.Empty))
            {
                folderId = CreateFolder(imgModel.CHILD_IMAGE, parentFolderId);
            }

            // Upload the file to the existing or created folder
            var fileId = CreateFile(imgModel.IMAGE, folderId);
            return fileId;
        }


        public void DownloadFile(string fileId, string saveTo)
        {
            var request = driveService.Files.Get(fileId);
            var stream = new MemoryStream();
            request.MediaDownloader.ProgressChanged += (progress) => {
                if (progress.Status == Google.Apis.Download.DownloadStatus.Completed)
                {
                    SaveStream(stream, saveTo);
                }
            };
            request.Download(stream);
        }


        private void SaveStream(MemoryStream stream, string saveTo)
        {
            using (var fileStream = new FileStream(saveTo, FileMode.Create, FileAccess.Write))
            {
                stream.WriteTo(fileStream);
            }
        }

        public void CreateZip(string directoryPath, string zipPath) { 
            ZipFile.CreateFromDirectory(directoryPath, zipPath); 
        }

    }
}
