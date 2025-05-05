using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Helper.Redis;
using StudentWebAPI.Models;
using StudentWebAPI.Models.Student;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Student;
using StudentWebAPI.RepositoryImpl.GoogleDrive;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using StudentWebAPI.Models.WhatsAppMsg;
using Microsoft.EntityFrameworkCore;

namespace StudentWebAPI.RepositoryImpl
{
    public class StudentRepository : IStudent
    {
        GoogleUtility _googleDriveUtility;
        Database_ora db;

       
        private readonly ICacheService _cacheService = new CacheService();
      
        private GoogleUtility _googleUtility;
        DriveService driveService;
        public StudentRepository()
        {
            _googleDriveUtility = new GoogleUtility();
            driveService = GoogleDriveService.GetService();
            _googleUtility = new GoogleUtility();

        }


        Permission permission = new Permission()
        {
            Type = "anyone",
            Role = "Reader"
        };













        

       

       

       


       

  

      




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

