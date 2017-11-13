using DevExpress.Web;
using DevExpress.Web.Internal;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Net;
using System.IO;
using DevExpress.Docs.Demos;
using DevExpress.Spreadsheet;
using System;
using DevExpress.Web.ASPxTreeList;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using DevExpress.Spreadsheet.Demos;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetController : DemoController {
        public ActionResult ExpenseReport(SpreadsheetExpenseReportModel model) {
            if (model == null)
                model = new SpreadsheetExpenseReportModel();
            model.PreviewModel.Workbook = CreateExpenseReportWorkbook(model);
            return DemoView("ExpenseReport", model);
        }
        public ActionResult PreviewExpenseReport(SpreadsheetExpenseReportModel model) {
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateExpenseReportWorkbook(model); ;
            return GenerateHtmlPreview(previewModel);
        }
        public ActionResult ExpenseReportExportTo(SpreadsheetExpenseReportModel model) {
            IWorkbook workbook = CreateExpenseReportWorkbook(model);
            return GenerateFile(workbook, model);
        }
        IWorkbook CreateExpenseReportWorkbook(SpreadsheetExpenseReportModel model) {
            ExpenseReportDocumentGenerator generator = new ExpenseReportDocumentGenerator();
            return generator.Generate();
        }
    }
}
