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
        public ActionResult SimplifiedMultiplicationTable(SpreadsheetSimplifiedMultiplicationTableModel model) {
            if (model == null)
                model = new SpreadsheetSimplifiedMultiplicationTableModel();
            model.PreviewModel.Workbook = CreateSimplifiedMultiplicationTableWorkbook(model);
            return DemoView("SimplifiedMultiplicationTable", model);
        }
        public ActionResult PreviewSimplifiedMultiplicationTable(SpreadsheetSimplifiedMultiplicationTableModel model) {
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateSimplifiedMultiplicationTableWorkbook(model); ;
            return GenerateHtmlPreview(previewModel);
        }
        public ActionResult SimplifiedMultiplicationTableExportTo(SpreadsheetSimplifiedMultiplicationTableModel model) {
            IWorkbook workbook = CreateSimplifiedMultiplicationTableWorkbook(model);
            return GenerateFile(workbook, model);
        }
        IWorkbook CreateSimplifiedMultiplicationTableWorkbook(SpreadsheetSimplifiedMultiplicationTableModel model) {
            SimplifiedMultiplicationTableDocumentGenerator generator = new SimplifiedMultiplicationTableDocumentGenerator(new CultureInfo("en-US"));
            generator.ColumnCount = model.ColumnCount;
            generator.TableCount = model.TableCount;
            generator.FitToPage = true;
            return generator.Generate();
        }
    }
}
