using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models.HTMLReport;
using StudentWebAPI.Service.HTMLReport;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.RepositoryImpl.HTMLReport
{
    public class StudentTranscriptReportRepository : IStudentTranscriptReport
    {
        private readonly Database_ora _context;
        private OracleParameter[] _parameters;

        public StudentTranscriptReportRepository()
        {
            _context = new Database_ora();
        }
        public List<StudentTranscriptReportViewModel> studentTranscriptReportList(string organizationCode, string studentCode, decimal termId)
        {
            List<StudentTranscriptReportViewModel> studentTranscriptReportList = new List<StudentTranscriptReportViewModel>();
             _parameters = new OracleParameter[4];
            _parameters[0] = _context.MakeOutParameter(OracleDbType.RefCursor, ParameterDirection.Output);
            _parameters[1] = _context.MakeInParameter(organizationCode, OracleDbType.Varchar2);
            _parameters[2] = _context.MakeInParameter(studentCode, OracleDbType.Varchar2);
            _parameters[3] = _context.MakeInParameter(termId, OracleDbType.Decimal);

            studentTranscriptReportList = _context.GetList<StudentTranscriptReportViewModel>("DPG_EMS_STUDENT_TRANSCRIPT.STUDENT_RESULTS_TRANSCRIPT", _parameters);

            return studentTranscriptReportList;
        }
    }
}
