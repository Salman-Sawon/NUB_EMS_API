using fileManager.Models;
using StudentWebAPI.Models;
using StudentWebAPI.Models.TeacherFileUpload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    interface ITeacherFileUpload
    {
        public (int status, string[] message) SaveTeacherFile(FileData fileInfo);

        public (int status, string[] message) DeleteTeacherFile(FileDelete fileDelete);




        public int GetFileId(string userName);

        List<FileInfoVM> getFileList(Parameter parameters);
        List<FileInfoVM> getBatchWiseFileList(StudentAttendanceInfoParam parameters);
        List<FileInfoVM> BatchWiseGetFileListDtype(GetDTypeWiseFile parameters);
        List<StdUploadedFilesVM> StudentUploadedFiles(StdUplodedFilesInfo parameters);
        public List<FileInfoVM> getStudentFileList(string ORG_CODE, string USER_CODE);
        public List<FileUploadedVM> getStudentUploadedFile(string ORG_CODE, string USER_CODE);
        public List<FileInfoVM> getStudentFileTypeList(string ORG_CODE, string USER_CODE, string D_TYPE_CODE);
        public FileInfoVM getFileDownload(decimal FILE_ID, string ORG_CODE);
    }
}
