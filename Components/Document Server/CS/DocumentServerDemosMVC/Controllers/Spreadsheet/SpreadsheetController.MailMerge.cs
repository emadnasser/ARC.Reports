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
using System.Globalization;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetController : DemoController {
        public ActionResult MailMerge() {
            SpreadsheetMailMergeModel model = new SpreadsheetMailMergeModel();
            model.PreviewModel.Workbook = CreateSpreadsheetMailMergeWorkbook(model);
            return DemoView("MailMerge", model);
        }        
        public ActionResult PreviewMailMerge(SpreadsheetMailMergeModel model) {
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateSpreadsheetMailMergeWorkbook(model);
            return GenerateHtmlPreview(previewModel);
        }
        public ActionResult MaileMergeExportTo(SpreadsheetMailMergeModel model) {
            IWorkbook workbook = CreateSpreadsheetMailMergeWorkbook(model);
            return GenerateFile(workbook, model);
        }
        IWorkbook CreateSpreadsheetMailMergeWorkbook(SpreadsheetMailMergeModel model) {
            MailMergeDocumentGenerator generator = new MailMergeDocumentGenerator(new CultureInfo("en-US"));
            generator.City = model.City;
            generator.CustomerId = model.CustomerId;
            generator.CustomerName = model.CustomerName;
            generator.Email = model.Email;
            generator.FitToPage = true;
            generator.Path = MapPath("~/App_Data/Billing_statement.xlsx");
            generator.Phone = model.Phone;
            generator.State = model.State;
            generator.StatementNumber = model.StatementNumber;
            generator.Street = model.Street;
            generator.ZIP = model.ZIP;
            return generator.Generate();
        }
    }
}
