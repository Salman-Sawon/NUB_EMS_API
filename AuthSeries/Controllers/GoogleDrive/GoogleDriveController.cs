using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using StudentWebAPI.Models.Google;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.RepositoryImpl.GoogleDrive;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace StudentWebAPI.Controllers.GoogleDrive
{
    [Authorize]

    [Route("api/[controller]")]
    [ApiController]

    public class GoogleDriveController : ControllerBase
    {
        IGoogle google = new GoogleUtility();
        GoogleDriveCredential googleCredential = new GoogleDriveCredential();
        public GoogleDriveController()
        {
            googleCredential = new GoogleDriveCredential();
        }

        [HttpGet]
        [Route("CheckDrive")]
        public IActionResult GetFileList()
        {
            //GoogleDriveService googleDriveService = new GoogleDriveService();
            var driveService = GoogleDriveService.GetService();

            var fileId = "1Jw1w_lnHqSBfiGBPhO7n-SZ0Am4-F74G";
            // var request = driveService.Files.Export(fileId, "application/pdf");
            var request = driveService.Files.Get(fileId);
            var stream = new System.IO.MemoryStream();
            // Add a handler which will be notified on progress changes.
            // It will notify on each chunk download and when the
            // download is completed or failed.
            request.MediaDownloader.ProgressChanged +=
                    (IDownloadProgress progress) =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };
            request.Download(stream);
            byte[] bytes = stream.ToArray();
            string base64 = Convert.ToBase64String(bytes);
            var driveFolder = new Google.Apis.Drive.v3.Data.File();
            

            return Ok("");
        }

        
        [HttpGet]
        [Route("CreateFolder")]
        public IActionResult CreateFolder(string ORG_CODE,string PARENT_FILE_ID, string USER_CODE)
        {
            var driveService = GoogleDriveService.GetService();
            //var ORG_CODE = "1";
            var CAMPUS_CODE = "2";
            Permission permission = new Permission()
            {
                Type = "anyone",
                Role = "Reader"
            };
            var orgFileList = driveService.Files.List();
            orgFileList.Q = "mimeType='application/vnd.google-apps.folder' and trashed=false and name='"+ ORG_CODE + "'";
            var fileList = orgFileList.Execute();
            
            if (fileList.Files.Count > 0)
            {
                // Folder already exists
                var orgEexistingFolder = fileList.Files.First();
                var campusFileList = driveService.Files.List();
                campusFileList.Q = "mimeType='application/vnd.google-apps.folder' and trashed=false and name='" + CAMPUS_CODE + "'";
                var classFileList = campusFileList.Execute();


                if (classFileList.Files.Count > 0)
                {
                    var existingFodlder = fileList.Files.First();
                }


                else

                {

                    var campusFolder = new Google.Apis.Drive.v3.Data.File();
                    campusFolder.Name = CAMPUS_CODE;
                    campusFolder.MimeType = "application/vnd.google-apps.folder";
                    var request = driveService.Files.Create(campusFolder);
                    campusFolder.Parents = new[] { orgEexistingFolder.Id };
                    request.Fields = "id";
                    var campusFile = request.Execute();
                    driveService.Permissions.Create(permission, campusFile.Id).Execute();
                }
            }
            else
            {

            }

            return Ok("");

           
        }


        [HttpPost]
        [Route("SaveFileDriveDB")]
        public IActionResult SaveFileDriveDB([FromForm] FolderStructureVM folderStructure)
        {

            var statusAndMessage = google.PrepareFolder(folderStructure);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            return Ok(responseMessage);
            

        }


        [HttpPost]
        [Route("TeacherSaveFileDriveDB")]
        public IActionResult TeacherSaveFileDriveDB([FromForm] TeacherFolderStructureVM folderStructure)
        {

            var statusAndMessage = google.TeacherPrepareFolder(folderStructure);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            return Ok(responseMessage);


        }


        [HttpPost]
        [Route("SaveAndroidAssignmentFileId")]
        public IActionResult SaveAndroidFileId([FromBody] FolderStructureSaveDB folderStructure)
        {

            var statusAndMessage = google.SaveFileAndroidDB(folderStructure);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            return Ok(responseMessage);


        }

        [HttpPost]
        [Route("SaveAndroidTeacherFileId")]
        public IActionResult SaveTeacherFileAndroidDB([FromBody] TeacherFolderStructureSaveDB folderStructure)
        {

            var statusAndMessage = google.SaveTeacherFileAndroidDB(folderStructure);
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = statusAndMessage.status;
            responseMessage.Message = statusAndMessage.message[0];
            return Ok(responseMessage);


        }

        

        [HttpPost]
        [Route("CreateFile")]
        public IActionResult CreateFile( IFormFile myFile)
        {

            return Ok("");

        }



        [HttpGet]
        [Route("GetDocumentList")]
        public IActionResult GetDocumentList(string ORG_CODE)
        {
            Serilog.Log.Information("GetDocumentList");
           List<DocumentTypeVM> documentTypeList = google.GetDocumentType(ORG_CODE);
            Serilog.Log.Information("documentTypeList");
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Student Ledger View List";
            responseMessage.ResponseObj = documentTypeList;
            return Ok(responseMessage);
        }




        [HttpGet]
        [Route("CreateFolderOld")]
        public IActionResult CreateFolderOld()
        {
            var driveService = GoogleDriveService.GetService();

            var drivefolder = new Google.Apis.Drive.v3.Data.File();
            drivefolder.Name = "00000144";
            drivefolder.MimeType = "application/vnd.google-apps.folder";
            drivefolder.Parents = new string[] { "1dFfURUwNrrsS6wabmSOe0oYqRTZVFoQz" };
            var request = driveService.Files.Create(drivefolder);
            var file = request.Execute();
            return Ok("");

        }



        [HttpGet]
        [Route("googelCredential")]

        public IActionResult GoogleCredential()
        {
            GoogleCredentialVM googleCredentialVM = new GoogleCredentialVM();
            googleCredentialVM = googleCredential.getGoogleCredential();
            ResponseMessage responseMessage = new ResponseMessage();
            responseMessage.StatusCode = 1;
            responseMessage.Message = "Google Drive Credential";
            responseMessage.ResponseObj = googleCredentialVM;
            return Ok(responseMessage);
        }

    }
}
