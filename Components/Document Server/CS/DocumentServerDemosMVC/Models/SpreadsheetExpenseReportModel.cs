using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetExpenseReportModel : SpreadsheetModelBase {
        public SpreadsheetExpenseReportModel() {
            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewExpenseReport";
        }
    }
}
