using Microsoft.AspNetCore.Http;
using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    interface IGoogle
    {
        public (int status, string[] message) PrepareFolder(FolderStructureVM folderStructure);
        public (int status, string[] message) TeacherPrepareFolder(TeacherFolderStructureVM folderStructure);
        public string CheckIfFolderExists(string folderName, string parentFolderId); 
        public string CreateFolder(string folderName, string ParentId);
        public string CreateFile(IFormFile myFile, string folderId);

        public int SaveFileDB(FolderStructureVM folderStructure);


        public List<DocumentTypeVM> GetDocumentType(string ORG_CODE);
        public (int status, string[] message) SaveFileAndroidDB(FolderStructureSaveDB folderStructure);
        public (int status, string[] message) SaveTeacherFileAndroidDB(TeacherFolderStructureSaveDB folderStructure);

    }
}
