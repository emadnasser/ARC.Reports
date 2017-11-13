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
        public ActionResult EmployeeInformation() {
            SpreadsheetEmployeeInformationModel model = new SpreadsheetEmployeeInformationModel();
            model.PreviewModel.Workbook = CreateEmployeeInformationWorkbook(model);
            return DemoView("EmployeeInformation", model);
        }
        public ActionResult PreviewEmployeeInformation(SpreadsheetEmployeeInformationModel model) {
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateEmployeeInformationWorkbook(model); ;
            return GenerateHtmlPreview(previewModel);
        }
        public ActionResult EmployeeInformationExportTo(SpreadsheetEmployeeInformationModel model) {
            IWorkbook workbook = CreateEmployeeInformationWorkbook(model);
            return GenerateFile(workbook, model);
        }
        IWorkbook CreateEmployeeInformationWorkbook(SpreadsheetEmployeeInformationModel model) {
            EmployeeInformationDocumentGenerator generator = new EmployeeInformationDocumentGenerator(new CultureInfo("en-US"));
            string path = MapPath("~/App_Data/EmployeeInformation_template.xlsx");
            return generator.Generate(path);
        }
    }
}
