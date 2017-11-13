using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetMailMergeModel : SpreadsheetModelBase {
        public SpreadsheetMailMergeModel() {
            StatementNumber = "No.";
            CustomerId = "ABC12345";
            CustomerName = "Margaret Peacock";
            Street = "NE&nbsp;74th&nbsp;St,&nbsp;Town&nbsp;Center";
            City = "Redmond";
            State = "WA";
            ZIP = "98052";
            Phone = "(206)555-812";
            Email = "mpeacock@example.net";
            
            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewMailMerge";
        }

        public string StatementNumber {get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Path { get; set; }
    }
}
