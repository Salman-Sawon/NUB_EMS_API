using StudentWebAPI.Models.HTMLReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service.HTMLReport
{
    public interface IStudentTranscriptReport
    {
        List<StudentTranscriptReportViewModel> studentTranscriptReportList(string organizationCode, string studentCode, decimal termId);
    }
}
