using StudentWebAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Service
{
  public  interface IDocumentType
    {
        List<DocumentTypeVM> GetDocumentType(string ORG_CODE);

    }
}
