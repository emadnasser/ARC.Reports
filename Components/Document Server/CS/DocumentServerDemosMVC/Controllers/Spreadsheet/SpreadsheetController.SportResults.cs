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
using System.Globalization;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetController : DemoController {
        public ActionResult SportResults(SpreadsheetSportResultsModel model) {
            if (model == null)
                model = new SpreadsheetSportResultsModel();
            model.PreviewModel.Workbook = CreateSportResultsWorkbook(model);
            return DemoView("SportResults", model);
        }
        public ActionResult PreviewSportResults(SpreadsheetSportResultsModel model) {
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateSportResultsWorkbook(model);
            return GenerateHtmlPreview(previewModel);
        }
        public ActionResult SportResultsExportTo(SpreadsheetSportResultsModel model) {
            IWorkbook workbook = CreateSportResultsWorkbook(model);
            return GenerateFile(workbook, model);
        }
        IWorkbook CreateSportResultsWorkbook(SpreadsheetSportResultsModel model) {
            SportResultsDocumentGenerator generator = new SportResultsDocumentGenerator(new CultureInfo("en-US"));
            return generator.Generate();
        }
    }
}
