using DevExpress.XtraReports.UI;
using StudentWebAPI.Reports.Fee;
using StudentWebAPI.Reports.GLReports;
using StudentWebAPI.Reports.LEDGER;
using StudentWebAPI.Reports.Result;
using StudentWebAPI.Reports.student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Reports
{
    public static class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            ["StudentSubject"] = () => new StudentSubjectMapperReport(),
            ["SubjectMapper"] =()=> new StudentSubjectMapReport(),
            ["TeacherList"] = () => new TeacherListReport(),
            ["TeacherInformation"] = () => new TeacherInfoReport(),
            ["TeacherAttendance"] = () => new TeacherAttendanceReport(),
            ["StudentListReport"] = () => new StudentListReport(),
            ["StudentResultReport"] = () => new StudentResultReport(),
            ["StudentDailyFeeCollectionReport"] = () => new StudentDailyFeeCollectionReport(),
            ["StudentFeePaymentInfo"] = () => new StudentFeePaymentInfoReport(),
            ["StudentWiseFeeInfoReport"] = () => new StudentWiseFeeInformationReport(),
            ["StudentFeeLedger"] = () => new StudentFeeLedgerReport(),
            ["StudentAttendance"] = () => new StudentAttendanceReport(),
            ["StudentGradeWiseReport"] = () => new StudentGradeWiseResultReport(),
            ["SingleStudentTranscriptReport"] = () => new SingleStudentTranscriptReport(),
            ["FeeBillCollectionDTLReport"] = () => new FeeBillCollectionDTLReport(),
            ["StudentBillVoucherCurReport"] = () => new StudentBillVoucherCurReport(),
            ["ClassnSectionWiseDueBillReport"] = () => new ClassnSectionWiseDueBillReport(),
            ["ClassSectionWiseAllReport"] = () => new ClassSectionWiseAllReport(),
            ["DayWiseBillCollectionReport"] = () => new DayWiseBillCollectionReport(),
            ["StudentWiseCollectionReport"] = () => new StudentWiseCollectionReport(),
            ["StudentLedgerViewReport"] = () => new LedgerRepReport(),
            ["StudentInfoReport"] = () => new StudentInfoReport(),
           ["FeeTypeReport"] = () => new FeeTypeReport(),
            ["TranscriptReport"] = () => new TranscriptReport(),
            ["TranscriptReport11"] = () => new TranscriptReport11(),
            ["TranscriptReport12"] = () => new TranscriptReport12(),
            ["TranscriptReport13"] = () => new TranscriptReport13(),
            ["TranscriptReport14"] = () => new TranscriptReport14(),
            ["TranscriptReport15"] = () => new TranscriptReport15(),
            ["TranscriptReport16"] = () => new TranscriptReport16(),
            ["AllStudentTranscriptReport"] = () => new AllStudentTranscriptReport(),
            ["TranscriptReport"] = () => new TranscriptReport(),
            ["StudentWiseDetailsViewBillReport"] = () => new StudentWiseDetailsViewBillReport(),
            ["FailListReport"] = () => new FailListReport(),
            ["PassListReport"] = () => new PassListReport(),
            ["CLASSMERITReport"] = () => new CLASSMERITReport(),
            ["AcademicCalendarReport"] = () => new AcademicCalendarReport(),
            ["ExamRoutineReport"] = () => new ExamRoutineReport(),
           // ["StudentLedgerViewNewReport"] = () => new StudentLedgerViewNewReport(),
            ["StudentWiseDueWithRemarksReport"] = () => new StudentWiseDueWithRemarksReport(),
            ["AllExamRoutineReport"] = () => new AllExamRoutineReport(),
            ["DayWiseFeeTypeDetailsReport"] = () => new DayWiseFeeTypeDetailsReport(),
            ["StudentAdmitCardReport"] = () => new StudentAdmitCardReport(),
            ["StudentFeeCollectionDTLReport"] = () => new StudentFeeCollectionDTLReport(),
            ["ExamRoutineReportNew"] = () => new ExamRoutineReportNew(),
            ["StduCollReport"] = () => new StduCollReport(),
            ["DailyTransCollDeleteReport"] = () => new DailyTransCollDeleteReport(),
            ["DailyTransCollectionGLReportsvsrepx"] = () => new DailyTransCollectionGLReportsvsrepx(),
            ["TransCRCollectionReport"] = () => new TransCRCollectionReport(),
            ["TransDRCollectionDeleteReport"] = () => new TransDRCollectionDeleteReport(),
            ["StudentAdmissionFormReport"] = () => new StudentAdmissionFormReport(),
            ["DaywiseFeeCollectionDetailsReport"] = () => new DaywiseFeeCollectionDetailsReport(),
            ["ClassWiseBillCollectionReport"] = () => new ClassWiseBillCollectionReport(),
            ["CollectionPaySlipReport"] = () => new CollectionPaySlipReport(),
            ["OnlineAdmissionFormReport"] = () => new OnlineAdmissionFormReport()






        };
    }
}