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
        public ActionResult ShiftSchedule(SpreadsheetShiftScheduleModel model) {
            if (model == null)
                model = new SpreadsheetShiftScheduleModel();
            model.PreviewModel.Workbook = CreateShiftScheduleWorkbook(model);
            return DemoView("ShiftSchedule", model);
        }
        public ActionResult PreviewShiftSchedule(SpreadsheetShiftScheduleModel model) {
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateShiftScheduleWorkbook(model); ;
            return GenerateHtmlPreview(previewModel);
        }
        public ActionResult ShiftScheduleExportTo(SpreadsheetShiftScheduleModel model) {
            IWorkbook workbook = CreateShiftScheduleWorkbook(model);
            return GenerateFile(workbook, model);
        }
        IWorkbook CreateShiftScheduleWorkbook(SpreadsheetShiftScheduleModel model) {
            ShiftScheduleGenerator generator = new ShiftScheduleGenerator(new CultureInfo("en-US"));
            return generator.Generate();
        }
    }
}
