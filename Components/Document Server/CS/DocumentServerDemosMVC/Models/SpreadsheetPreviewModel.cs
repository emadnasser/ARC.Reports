using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Spreadsheet;

namespace DevExpress.Web.Demos {
    public class SpreadsheetPreviewModel {
        public string OwnerPropertyName { get; set; }
        public bool CanShowOnlyFirstWorksheet { get; set; }
        public string PreviewDocumentAction { get; set; }
        public int PreviewSheetIndex { get; set; }
        public IWorkbook Workbook { get; set; }
    }
}
