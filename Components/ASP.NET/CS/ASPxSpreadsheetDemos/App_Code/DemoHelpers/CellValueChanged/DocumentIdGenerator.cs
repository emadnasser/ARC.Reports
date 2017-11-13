using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DevExpress.Spreadsheet;
using DevExpress.Web.Office;
using DevExpress.XtraSpreadsheet;

namespace DevExpress.Web.Demos {
    public static class DocumentIdGenerator {
        public const string CellValueChangedDocumentIdPrefix = "CellValueChangedDemo_";

        public static string GenerateDocumentId() {
            return CellValueChangedDocumentIdPrefix + Guid.NewGuid().ToString();
        }
    }
}
