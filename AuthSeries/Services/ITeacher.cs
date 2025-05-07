using StudentWebAPI.Models;
using StudentWebAPI.Models.TeacherFileUpload;
using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface ITeacher
    {
       

        public (int status, string[] message) TeacherEntry(TeacherBulkEntry teacherBulkEntry);

        List<ActiveTeacherData> GetActiveTeacherList(string ORG_CODE);
        public List<RoomInfoVM> getRoomInfo(string ORG_CODE);
       public (int status, string[] message) saveRoomMst(RoomMst roomMst);
        public List<getBuildingList> getBuildingList(string ORG_CODE, string CAMPUS_CODE);
        public List<ResultSubjectListViewModel> GetResultSubjectList(string organizationCode);
        (int status, string[] message) SaveSubjectCreation(SubjectInfoMst subjectInfo);
    }
}
