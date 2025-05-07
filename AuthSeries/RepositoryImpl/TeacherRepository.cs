using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models;
using StudentWebAPI.Models.TeacherFileUpload;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using OfficeOpenXml;
using StudentWebAPI.RepositoryImpl.GoogleDrive;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Microsoft.AspNetCore.Http;
using StudentWebAPI.Models.GoogleDrive;
using static StudentWebAPI.RepositoryImpl.LocationDistance;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentWebAPI.Controllers;

namespace StudentWebAPI.RepositoryImpl
{
    public class TeacherRepository: ITeacher
    {

        Database_ora db;
        LocationDistance locationDistance;
        // Teacher Subject Mapping Grid View
        GoogleUtility _googleDriveUtility;
        private GoogleUtility driveUtility;
     
        public TeacherRepository()
        {
            driveUtility = new GoogleUtility();
            locationDistance = new LocationDistance();
            _googleDriveUtility = new GoogleUtility();

        }


        public List<RoomInfoVM> getRoomInfo(string ORG_CODE)
        {
            List<RoomInfoVM> roomInfo = new List<RoomInfoVM>();

            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];

            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);


            roomInfo = db.GetList<RoomInfoVM>("DPG_ALL_COMMON_SETUP.DPD_ROOM_INFO_GRID", parameters);

            return roomInfo;
        }

        public (int status, string[] message) saveRoomMst(RoomMst roomMst)
        {
            int status = 0;
            string[] message = new string[2];
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[10];
            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(roomMst.ROOM_ID, OracleDbType.Decimal);
            Params[2] = db.MakeInParameter(roomMst.ORG_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeInParameter(roomMst.ROOM_NAME, OracleDbType.Varchar2);
            Params[4] = db.MakeInParameter(roomMst.CAPACITY, OracleDbType.Decimal);
            Params[5] = db.MakeInParameter(roomMst.NUM_OF_ROWS, OracleDbType.Decimal);
            Params[6] = db.MakeInParameter(roomMst.NUM_OF_COLUMNS, OracleDbType.Decimal);
            Params[7] = db.MakeInParameter(roomMst.USER_CODE, OracleDbType.Varchar2);
            Params[8] = db.MakeInParameter(roomMst.BUILDING_ID, OracleDbType.Decimal);
            Params[9] = db.MakeInParameter(roomMst.RowStatus, OracleDbType.Decimal);

            status = db.RunProcedureWithReturnVal("DPG_ALL_COMMON_SETUP.DPD_ROOM_MST", Params);

            if (status == 1 && roomMst.RowStatus == 1)
            {
                message[0] = "Room Entry is saved successfully";
                message[1] = "#5cb85c";
            }
            else if (status == 1 && roomMst.RowStatus == 2)
            {
                message[0] = "Room  is Updated successfully";
                message[1] = "#5cb85c";
            }
            else if (status == 1 && roomMst.RowStatus == 3)
            {
                message[0] = "Room is Deleted successfully";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = "Failed";
                message[1] = "#e35b5a";
            }

            return (status, message);
        }
        public List<getBuildingList> getBuildingList(string ORG_CODE, string CAMPUS_CODE)
        {
            List<getBuildingList> datalist = new List<getBuildingList>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);
            parameters[2] = db.MakeInParameter(CAMPUS_CODE, OracleDbType.Varchar2);

            datalist = db.GetList<getBuildingList>("DPG_ALL_COMMON_SETUP.DPD_BUILDING_LIST", parameters);

            return datalist;
        }

        public List<ActiveTeacherData> GetActiveTeacherList(string ORG_CODE)
        {
            List<ActiveTeacherData> teacherList = new List<ActiveTeacherData>();
            db = new Database_ora();
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            parameters[1] = db.MakeInParameter(ORG_CODE, OracleDbType.Varchar2);

            teacherList = db.GetList<ActiveTeacherData>("DPG_TEACHER_MST.DPD_ACTIVE_TEACHER_LIST", parameters);

            return teacherList;
        }




        public (int status, string[] message) TeacherEntry(TeacherBulkEntry teacherBulkEntry)
        {
            int status = 0;
            string[] message = new string[2];

          

            string[] arryTEACHER_NAME = teacherBulkEntry.TEACHER_NAME.ToArray();
            string[] arryFATHERS_NAME = teacherBulkEntry.FATHERS_NAME.ToArray();
            DateTime[] arryJOINING_DATE = teacherBulkEntry.JOINING_DATE.ToArray();         
            string[] arrySMS_MOBILE_NUM = teacherBulkEntry.SMS_MOBILE_NUM.ToArray();



            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[8];
            Params[0] = db.MakeOutParameter(OracleDbType.Int16, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(teacherBulkEntry.ORG_CODE, OracleDbType.Varchar2);
            Params[2] = db.MakeInParameter(teacherBulkEntry.CAMPUS_CODE, OracleDbType.Varchar2);
            Params[3] = db.MakeCollectionParameter(arryTEACHER_NAME, OracleDbType.Varchar2, arryTEACHER_NAME.Length);
            Params[4] = db.MakeCollectionParameter(arryFATHERS_NAME, OracleDbType.Varchar2, arryFATHERS_NAME.Length);
            Params[5] = db.MakeCollectionParameter(arryJOINING_DATE, OracleDbType.Date, arryJOINING_DATE.Length);
            Params[6] = db.MakeCollectionParameter(arrySMS_MOBILE_NUM, OracleDbType.Varchar2, arrySMS_MOBILE_NUM.Length);
            Params[7] = db.MakeInParameter(teacherBulkEntry.USER_NAME, OracleDbType.Varchar2);

            status = db.RunProcedureWithReturnVal("DPG_TEACHER_MST.DPD_EMS_TEACHER_MST", Params);

            if (status == 1)
            {
                message[0] = "Teacher Entry is saved successfully !!";
                message[1] = "#5cb85c";
            }
            else
            {
                message[0] = "Teacher Entry is saved failed. Please try again.";
                message[1] = "#e35b5a";
            }

            return (status, message);
        }




        public List<ResultSubjectListViewModel> GetResultSubjectList(string organizationCode)
        {
            // SubjectInfoMst resultSubjectInfo = new SubjectInfoMst();
            List<ResultSubjectListViewModel> subjectList = new List<ResultSubjectListViewModel>();
            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[2];
            Params[0] = db.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            Params[1] = db.MakeInParameter(organizationCode, OracleDbType.Varchar2);
            subjectList = db.GetList<ResultSubjectListViewModel>("DPG_ALL_COMMON_SETUP.DPD_RESULT_SUBJECT_GRID", Params);

         

            return subjectList;

        }


        public (int status, string[] message) SaveSubjectCreation(SubjectInfoMst subjectInfo)
        {
            //decimal[] Array_RowStatus = subjectInfo.RowStatus.ToArray();
            // decimal[] Array_SUBJECT_ID = subjectInfo.SUBJECT_ID.ToArray();
            string[] Array_SUBJECT_CODE = subjectInfo.SUBJECT_CODE.ToArray();
            string[] Array_SUBJECT_NAME = subjectInfo.SUBJECT_NAME.ToArray();
            string[] Array_SUBJECT_NAME_BANGLA = subjectInfo.SUBJECT_NAME_BANGLA.ToArray();
            string[] Array_SUBJECT_SHORT_NAME = subjectInfo.SUBJECT_SHORT_NAME.ToArray();
            string[] Array_SUBJECT_PART = subjectInfo.SUBJECT_PART.ToArray();
            string[] Array_SUBJECT_DEFAULT_TYPE = subjectInfo.SUBJECT_DEFAULT_TYPE.ToArray();
            string[] Array_SUJBECT_IS_PRACTICAL = subjectInfo.SUJBECT_IS_PRACTICAL.ToArray();
            decimal[] Array_SUJBECT_SRLNO = subjectInfo.SUJBECT_SRLNO.ToArray();

            int status = 0;
            string[] message = new string[2];

            db = new Database_ora();
            OracleParameter[] Params = new OracleParameter[11];
            Params[0] = db.MakeOutParameter(OracleDbType.Int32, ParameterDirection.Output);
            //Params[1] = db.MakeCollectionParameter(Array_RowStatus, OracleDbType.Decimal, Array_RowStatus.Length);
            //Params[2] = db.MakeCollectionParameter(Array_SUBJECT_ID, OracleDbType.Decimal, Array_SUBJECT_ID.Length);
            Params[1] = db.MakeCollectionParameter(Array_SUBJECT_CODE, OracleDbType.Varchar2, Array_SUBJECT_CODE.Length);
            Params[2] = db.MakeCollectionParameter(Array_SUBJECT_NAME, OracleDbType.Varchar2, Array_SUBJECT_NAME.Length);
            Params[3] = db.MakeCollectionParameter(Array_SUBJECT_NAME_BANGLA, OracleDbType.Varchar2, Array_SUBJECT_NAME_BANGLA.Length);
            Params[4] = db.MakeCollectionParameter(Array_SUBJECT_SHORT_NAME, OracleDbType.Varchar2, Array_SUBJECT_SHORT_NAME.Length);
            Params[5] = db.MakeCollectionParameter(Array_SUBJECT_PART, OracleDbType.Varchar2, Array_SUBJECT_PART.Length);
            Params[6] = db.MakeCollectionParameter(Array_SUBJECT_DEFAULT_TYPE, OracleDbType.Varchar2, Array_SUBJECT_DEFAULT_TYPE.Length);
            Params[7] = db.MakeCollectionParameter(Array_SUJBECT_IS_PRACTICAL, OracleDbType.Varchar2, Array_SUJBECT_IS_PRACTICAL.Length);
            Params[8] = db.MakeCollectionParameter(Array_SUJBECT_SRLNO, OracleDbType.Decimal, Array_SUJBECT_SRLNO.Length);
            Params[9] = db.MakeInParameter(subjectInfo.User_Name, OracleDbType.Varchar2);
            Params[10] = db.MakeInParameter(subjectInfo.ORG_CODE, OracleDbType.Varchar2);
            status = db.RunProcedureWithReturnVal("DPG_ALL_COMMON_SETUP.DPD_RESULT_SUBJECT_IUD", Params);

            if (status == 1)

            {
                message[0] = "Subject(s) are added successfully !!";
                message[1] = "#5cb85c";

            }


            else
            {
                message[0] = "Subject addition is failed. Please try again.";
                message[1] = "#e35b5a";

            }


            return (status, message);
        }


    }
}
