using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Models.ViewModel
{
    public class DocumentTypeVM
    {
        public decimal DOCUMENT_ID { get; set; }
        public string DOCUMENT_TYPE { get; set; }
        public string IS_ASSIGNMENT { get; set; }
    }
}
