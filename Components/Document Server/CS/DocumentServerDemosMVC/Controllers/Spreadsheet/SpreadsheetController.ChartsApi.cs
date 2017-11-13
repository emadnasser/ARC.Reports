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
using DevExpress.DXperience.Demos;
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Services.Implementation;
using DevExpress.Office.Services;
using DevExpress.Web.Office;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetController : DemoController {
        const int DefaultChartsApiSourceCodeId = 0;
        public ActionResult ChartsApi() {
            SpreadsheetChartsApiModel model = CreateSpreadsheetChartsApiModel(DefaultChartsApiSourceCodeId);
            return DemoView("ChartsApi", model);
        }
        SpreadsheetChartsApiModel CreateSpreadsheetChartsApiModel(int sourceId) {
            CodeExample example = ObtainChartsExampleById(sourceId);
            SpreadsheetChartsApiModel result = new SpreadsheetChartsApiModel();
            result.CSCode = CodeFormatter.GetFormattedCode(CodeParser.TokenLanguage.CSharp, example.CodeCS, false);
            result.SourceId = sourceId;
            result.SourceName = example.RegionName;
            result.PreviewModel.Workbook = CreateWorkbookFromChartsExample(example);
            result.PreviewModel.PreviewSheetIndex = result.PreviewModel.Workbook.Worksheets.ActiveWorksheet.Index;
            return result;
        }
        public ActionResult PreviewChartsApi(SpreadsheetChartsApiModel model) {
            CodeExample example = ObtainChartsExampleById(model.SourceId);
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateWorkbookFromChartsExample(example);
            previewModel.PreviewSheetIndex = previewModel.Workbook.Worksheets.ActiveWorksheet.Index;
            return GenerateHtmlPreview(previewModel);
        }        
        public JsonResult ChartsApiChangeCurrentSourceCode(SpreadsheetChartsApiModel model) {
            SpreadsheetChartsApiModel newModel = CreateSpreadsheetChartsApiModel(model.SourceId);
            newModel.PreviewModel.Workbook = null;
            return Json(newModel, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ChartsApiExampleTreeListPartial() {
            return PartialView(CreateSpreadsheetChartsApiModel(0).SourceCodeTreeModel);
        }
        [HttpPost]
        public ActionResult ChartsApiExportTo(SpreadsheetChartsApiModel model) {
            CodeExample example = ObtainChartsExampleById(model.SourceId);
            IWorkbook workbook = CreateWorkbookFromChartsExample(example);
            return GenerateFile(workbook, model);
        }
        CodeExample ObtainChartsExampleById(int exampleId) {
            SpreadsheetChartsApiModel model = new SpreadsheetChartsApiModel();
            SourceCodeTreeHelper extender = new SourceCodeTreeHelper(model.SourceCodeTreeModel);
            return extender.GetExampleById(exampleId);
        }
        IWorkbook CreateWorkbookFromChartsExample(CodeExample example) {
            ExampleEvaluatorByTimer evaluator = new SpreadsheetExampleEvaluatorNoTimer();
            Workbook workbook = new Workbook();
            workbook.ReplaceService<IUriStreamService>(new ASPxOfficeUriStreamService());
            workbook.AddService(typeof(IChartControllerFactoryService), new ChartControllerFactoryService());
            workbook.AddService(typeof(IChartImageService), new ChartImageService());
            //workbook.Options.Culture = System.Globalization.CultureInfo.InvariantCulture;
            workbook.LoadDocument(MapPath("~/App_Data/Document.xlsx"));

            CodeEvaluationEventArgs compileArgs = new CodeEvaluationEventArgs()
            {
                Result = true,
                Code = example.CodeCS,
                Language = ExampleLanguage.Csharp,
                EvaluationParameter = workbook
            };
            evaluator.Evaluate(compileArgs);
            workbook.Worksheets.ActiveWorksheet.Visible = true;
            return workbook;
        }
    }
}
