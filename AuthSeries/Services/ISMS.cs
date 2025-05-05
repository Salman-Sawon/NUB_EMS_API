using StudentWebAPI.Models;
using StudentWebAPI.Models.ViewModel;
using StudentWebAPI.Models.ViewModel.Global;
using StudentWebAPI.Models.ViewModel.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface ISMS
    {
        public List<SMSViewModel> GetUnauthorizedSMSList(string organizationCode, string userCode);
        public (int status, string[] message) SaveSMSAuthData(SMSAuthorization smsData);
        public (int status, string[] message) SaveSMSDueData(DueSms dueData);
        public (int status, string[] message) UnAuthItemDelete(UnAuthItemDlt parameter);
        public (int status, string[] message) UnAuthItemUpdate(UnAuthItemUpdateInfo parameter);
        public List<SMS_AUTH_GRID_VM> GetUnauthorizedSMSGrid(SMS_AUTH_PARAM parameter);

        public (int status, string[] message) SmsAuthInfoSave(SmsAuthIfo parameter);
        public (int status, string[] message) BulkSmsSave(BulkSmsInsert BulkData);
        public List<SmsTypeInfo> GetSmsType(string organizationCode);
        public (int status, string[] message) AllPersonSmsSave(AllPersonSmsInfo parameterData);

        public List<SmsTypeList> GetSmsTypeList();

        public (int status, string[] message) SmsConfigInfoSave(SmsConfigInfo parameter);

        public List<SmsConfigGridList> GetSmsConfigGridList(string ORG_CODE, string CAMPUS_CODE);


        public (int status, string[] message) multipramSmsInfoSave(multipleSmsInfoprams parameter);
        public (int status, string[] message) SmsContentInfoMst(SmsContentInfo parameter);
        public List<SmsContentGridList> GetSmsContentGridList(string ORG_CODE, string CAMPUS_CODE);


        public List<LessonHomeWorkMessage> GetLessonPlanHomeworkList(string ORG_CODE, string CAMPUS_CODE, string HOMEWORK_DATE,string SMS_GATEWAY_CODE);
        public List<ExamRoutineMessage> GetExamRoutineList(string ORG_CODE, string CAMPUS_CODE, string EXAM_DATE,string SMS_GATEWAY_CODE);


        public (int status, string[] message) SmsGatewayConfigInfoSave (SmsGateWayConfigInfo parameter);

        public List<SmsGatewayConfigGridList> GetSmsGateWayConfigGridList(string ORG_CODE, string CAMPUS_CODE);
        public List<SmsGatewayConfigList> GetSmsGateWayConfigListDDL(string ORG_CODE, string CAMPUS_CODE);



    }
}
