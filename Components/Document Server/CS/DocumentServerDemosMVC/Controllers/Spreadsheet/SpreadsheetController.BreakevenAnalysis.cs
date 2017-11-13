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
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Services.Implementation;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetController : DemoController {
        public ActionResult BreakevenAnalysis(SpreadsheetBreakevenAnalysisModel model) {
            if (model == null)
                model = new SpreadsheetBreakevenAnalysisModel();
            model.PreviewModel.Workbook = CreateBreakevenAnalysisWorkbook(model);
            return DemoView("BreakevenAnalysis", model);
        }
        public ActionResult PreviewBreakevenAnalysis(SpreadsheetBreakevenAnalysisModel model) {
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateBreakevenAnalysisWorkbook(model); ;
            return GenerateHtmlPreview(previewModel);
        }
        public ActionResult BreakevenAnalysisExportTo(SpreadsheetBreakevenAnalysisModel model) {
            IWorkbook workbook = CreateBreakevenAnalysisWorkbook(model);
            return GenerateFile(workbook, model);
        }
        IWorkbook CreateBreakevenAnalysisWorkbook(SpreadsheetBreakevenAnalysisModel model) {
            IWorkbook workbook = new Workbook();
            workbook.AddService(typeof(IChartControllerFactoryService), new ChartControllerFactoryService());
            workbook.AddService(typeof(IChartImageService), new ChartImageService());
            workbook.LoadDocument(MapPath("~/App_Data/BreakevenAnalysis.xlsx"));
            return workbook;
        }
    }
}
