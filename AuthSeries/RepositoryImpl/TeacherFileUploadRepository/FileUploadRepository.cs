using fileManager.Models;
using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models;
using StudentWebAPI.Models.TeacherFileUpload;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl.TeacherFileUploadRepository
{
    public class FileUploadRepository : ITeacherFileUpload
    {
        Database_ora db;
        public (int status, string[] message) SaveTeacherFile(FileData fileInfo)
        {
            int status = 0;
            string[] message = new String[2];
            db = new Database_ora();

           
            OracleParameter[] Params = new OracleParameter[21];


            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(fileInfo.FILE_ID, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(fileInfo.FILE_NAME, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(fileInfo.FILE_TITLE, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(fileInfo.FILE_DESC, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(fileInfo.FILE_EXTENTION, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(fileInfo.MIM_TYPE, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(fileInfo.FILE_PATH, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(fileInfo.ORG_CODE, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(fileInfo.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(fileInfo.CLASS_CODE, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(fileInfo.SECTION_CODE, OracleDbType.Varchar2);
            Params[12] = db.MakeInParameter(fileInfo.GROUP_CODE, OracleDbType.Varchar2);
            Params[13] = db.MakeInParameter(fileInfo.SESSION_CODE, OracleDbType.Varchar2);
            Params[14] = db.MakeInParameter(fileInfo.VERSION_CODE, OracleDbType.Varchar2);
            Params[15] = db.MakeInParameter(fileInfo.YEAR_CODE, OracleDbType.Varchar2);
            Params[16] = db.MakeInParameter(fileInfo.SEMESTER_CODE, OracleDbType.Varchar2);
            Params[17] = db.MakeInParameter(fileInfo.SHIFT_CODE, OracleDbType.Varchar2);
            Params[18] = db.MakeInParameter(fileInfo.USER_CODE, OracleDbType.Varchar2);
            Params[19] = db.MakeInParameter(fileInfo.FILE_URL, OracleDbType.Varchar2);
            Params[20] = db.MakeInParameter(fileInfo.RowStatus, OracleDbType.Decimal);
             
            //Params[18] = db.MakeInParameter(fileInfo.RowStatus, OracleDbType.Decimal);

            status = db.RunProcedureWithReturnVal("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_CLASS_WISE_FILE_IUD", Params);
            if (status == 1)
            {
                message[0] = "successfully !!";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = "failed. Please try again.";
                message[1] = "#e35b5a";
            }



            return (status, message);

        }

        public (int status, string[] message) DeleteTeacherFile(FileDelete fileDelete)
        {
            int status = 0;
            string[] message = new String[2];
            db = new Database_ora();


            OracleParameter[] Params = new OracleParameter[15];


            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(fileDelete.FILE_ID, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(fileDelete.ORG_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(fileDelete.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(fileDelete.CLASS_CODE, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(fileDelete.SECTION_CODE, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(fileDelete.GROUP_CODE, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(fileDelete.SESSION_CODE, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(fileDelete.VERSION_CODE, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(fileDelete.YEAR_CODE, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(fileDelete.SEMESTER_CODE, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(fileDelete.SHIFT_CODE, OracleDbType.Varchar2);
            Params[12] = db.MakeInParameter(fileDelete.SUBJECT_CODE, OracleDbType.Varchar2);
            Params[13] = db.MakeInParameter(fileDelete.ASSIGNMENT_OR_LECTURE_CODE, OracleDbType.Varchar2);
            Params[14] = db.MakeInParameter(fileDelete.RowStatus, OracleDbType.Decimal);

            //Params[18] = db.MakeInParameter(fileInfo.RowStatus, OracleDbType.Decimal);

            status = db.RunProcedureWithReturnVal("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_FILE_DELETE", Params);
            if (status == 1)
            {
                message[0] = "Delete successfully !!";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = "Delete failed. Please try again.";
                message[1] = "#e35b5a";
            }



            return (status, message);

        }

        public List<FileInfoVM> getFileList(Parameter parameters)
        {
            List<FileInfoVM> fileList = new List<FileInfoVM>();
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[13];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(parameters.ORG_CODE, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(parameters.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(parameters.CLASS_CODE, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(parameters.SECTION_CODE, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(parameters.GROUP_CODE, OracleDbType.Varchar2);
            Params[6] = db.MakeInParameter(parameters.SESSION_CODE, OracleDbType.Varchar2);
            Params[7] = db.MakeInParameter(parameters.VERSION_CODE, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(parameters.YEAR_CODE, OracleDbType.Varchar2);
            Params[9] = db.MakeInParameter(parameters.SEMESTER_CODE, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(parameters.SHIFT_CODE, OracleDbType.Varchar2);
            Params[11] = db.MakeInParameter(parameters.SUBJECT_CODE, OracleDbType.Varchar2);
            Params[12] = db.MakeInParameter(parameters.ASSIGNMENT_OR_LECTURE_CODE, OracleDbType.Varchar2);

            fileList = db.GetList<FileInfoVM>("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_CLASS_WISE_GET_FILE", Params);

            return fileList;
        }

        public List<FileInfoVM> getBatchWiseFileList(StudentAttendanceInfoParam parameters)
        {
            List<FileInfoVM> fileList = new List<FileInfoVM>();
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[5];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(parameters.ORG_CODE, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(parameters.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(parameters.SUB_MAP_ID, OracleDbType.Decimal);
            Params[4] = db.MakeInParameter(parameters.USER_CODE, OracleDbType.Varchar2);

            fileList = db.GetList<FileInfoVM>("DPG_EMS_TEACHER_FILE_MST.DPD_CLASSWISE_FILE", Params);

            return fileList;
        }

        public List<FileInfoVM> BatchWiseGetFileListDtype(GetDTypeWiseFile parameters)
        {
            List<FileInfoVM> fileList = new List<FileInfoVM>();
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[6];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(parameters.ORG_CODE, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(parameters.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(parameters.SUB_MAP_ID, OracleDbType.Decimal);        
            Params[4] = db.MakeInParameter(parameters.USER_CODE, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(parameters.D_TYPE_CODE, OracleDbType.Varchar2);

            fileList = db.GetList<FileInfoVM>("DPG_EMS_TEACHER_FILE_MST.DPD_CLASSWISE_FILE_DTYPE", Params);

            return fileList;
        }

       public List<StdUploadedFilesVM> StudentUploadedFiles(StdUplodedFilesInfo parameters)
        {
            List<StdUploadedFilesVM> fileList = new List<StdUploadedFilesVM>();
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[6];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(parameters.ORG_CODE, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(parameters.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(parameters.SUB_MAP_ID, OracleDbType.Decimal);
            Params[4] = db.MakeInParameter(parameters.USER_CODE, OracleDbType.Varchar2);
            Params[5] = db.MakeInParameter(parameters.PARENT_FILE_ID, OracleDbType.Decimal);

            fileList = db.GetList<StdUploadedFilesVM>("DPG_EMS_TEACHER_FILE_MST.DPD_STD_UPLOADED_FILE", Params);

            return fileList;
        }
        public List<FileInfoVM> getStudentFileList(string ORG_CODE, string USER_CODE)
        {
            List<FileInfoVM> fileList = new List<FileInfoVM>();
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[3];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(USER_CODE, OracleDbType.Varchar2);
            

            fileList = db.GetList<FileInfoVM>("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_STD_WISE_GET_FILE", Params);

            return fileList;
        }

        public List<FileUploadedVM> getStudentUploadedFile(string ORG_CODE, string USER_CODE)
        {
            List<FileUploadedVM> fileList = new List<FileUploadedVM>();
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[3];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(USER_CODE, OracleDbType.Varchar2);


            fileList = db.GetList<FileUploadedVM>("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_STD_ULPOADED_ASSIGN", Params);

            return fileList;
        }

        public List<FileInfoVM> getStudentFileTypeList(string ORG_CODE, string USER_CODE, string D_TYPE_CODE)
        {
            List<FileInfoVM> fileList = new List<FileInfoVM>();
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[4];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(USER_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(D_TYPE_CODE, OracleDbType.Varchar2);


            fileList = db.GetList<FileInfoVM>("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_STD_TYPE_WISE_GET_FILE", Params);

            return fileList;
        }

        public FileInfoVM getFileDownload(decimal FILE_ID, string ORG_CODE)
        {
            FileInfoVM fileList = new FileInfoVM();
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[3];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(FILE_ID, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
           

            fileList = db.GetModelData<FileInfoVM>("DPG_EMS_TEACHER_FILE_MST.DPD_EMS_DOWNLOAD_FILE", Params);

            return fileList;
        }

        public int GetFileId(string userName)
        {
            db = new Database_ora();
            OracleParameter[] parameter = new OracleParameter[2];
            int number;
            parameter[0] = db.MakeReturnValue("ReturnValue", OracleDbType.Int16, 0);
            parameter[1] = db.MakeInParameter(userName, OracleDbType.Varchar2);

            number = db.RunFunction("DPG_EMS_TEACHER_FILE_MST.DPF_EMS_FILE_ID", ref parameter);

            return number;
        }

    
    }
}