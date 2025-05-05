using StudentWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
    public interface IStudentBulkEntry
    {
        (int status, string[] message) SaveStudentBulkEntry(StudentBulkEntry stdBulkEntry);
    }
}
