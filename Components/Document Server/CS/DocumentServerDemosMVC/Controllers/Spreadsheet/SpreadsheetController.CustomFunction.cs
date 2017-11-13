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
        public ActionResult CustomFunction(SpreadsheetCustomFunctionModel model) {
            if (model == null)
                model = new SpreadsheetCustomFunctionModel();
            model.PreviewModel.Workbook = CreateCustomFunctionWorkbook(model);
            return DemoView("CustomFunction", model);
        }
        public ActionResult PreviewCustomFunction(SpreadsheetCustomFunctionModel model) {
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateCustomFunctionWorkbook(model); ;
            return GenerateHtmlPreview(previewModel);
        }
        public ActionResult CustomFunctionExportTo(SpreadsheetCustomFunctionModel model) {
            IWorkbook workbook = CreateCustomFunctionWorkbook(model);
            return GenerateFile(workbook, model);
        }
        IWorkbook CreateCustomFunctionWorkbook(SpreadsheetCustomFunctionModel model) {
            CustomFunctionDocumentGenerator generator = new CustomFunctionDocumentGenerator(new CultureInfo("en-US"));
            return generator.Generate();
        }
    }
}
