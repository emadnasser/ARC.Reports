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
        public ActionResult MultiplicationTable(SpreadsheetMultiplicationTableModel model) {
            if (model == null)
                model = new SpreadsheetMultiplicationTableModel();
            model.PreviewModel.Workbook = CreateMultiplicationTableWorkbook(model);
            return DemoView("MultiplicationTable", model);
        }
        public ActionResult PreviewMultiplicationTable(SpreadsheetMultiplicationTableModel model) {
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateMultiplicationTableWorkbook(model); ;
            return GenerateHtmlPreview(previewModel);
        }
        public ActionResult MultiplicationTableExportTo(SpreadsheetMultiplicationTableModel model) {
            IWorkbook workbook = CreateMultiplicationTableWorkbook(model);
            return GenerateFile(workbook, model);
        }
        IWorkbook CreateMultiplicationTableWorkbook(SpreadsheetMultiplicationTableModel model) {
            MultiplicationTableDocumentGenerator generator = new MultiplicationTableDocumentGenerator(new CultureInfo("en-US"));
            generator.Width = model.Width;
            generator.Height = model.Height;
            generator.FitToPage = true;
            generator.CreateInfoCells = model.CreateInfoCells;
            generator.UseSharedFormula = model.UseSharedFormula;
            return generator.Generate();
        }
    }
}
