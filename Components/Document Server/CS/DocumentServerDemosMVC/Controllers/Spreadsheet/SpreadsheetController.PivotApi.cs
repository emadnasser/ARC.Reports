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
        const int DefaultPivotApiSourceCodeId = 0;
        public ActionResult PivotApi() {
            SpreadsheetPivotApiModel model = CreateSpreadsheetPivotApiModel(DefaultPivotApiSourceCodeId);
            return DemoView("PivotApi", model);
        }
        SpreadsheetPivotApiModel CreateSpreadsheetPivotApiModel(int sourceId) {
            CodeExample example = ObtainPivotExampleById(sourceId);
            SpreadsheetPivotApiModel result = new SpreadsheetPivotApiModel();
            result.CSCode = CodeFormatter.GetFormattedCode(CodeParser.TokenLanguage.CSharp, example.CodeCS, false);
            result.SourceId = sourceId;
            result.SourceName = example.RegionName;
            result.PreviewModel.Workbook = CreateWorkbookFromPivotExample(example);
            result.PreviewModel.PreviewSheetIndex = result.PreviewModel.Workbook.Worksheets.ActiveWorksheet.Index;
            return result;
        }
        public ActionResult PreviewPivotApi(SpreadsheetPivotApiModel model) {
            CodeExample example = ObtainPivotExampleById(model.SourceId);
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateWorkbookFromPivotExample(example);
            previewModel.PreviewSheetIndex = previewModel.Workbook.Worksheets.ActiveWorksheet.Index;
            return GenerateHtmlPreview(previewModel);
        }        
        public JsonResult PivotApiChangeCurrentSourceCode(SpreadsheetPivotApiModel model) {
            SpreadsheetPivotApiModel newModel = CreateSpreadsheetPivotApiModel(model.SourceId);
            newModel.PreviewModel.Workbook = null;
            return Json(newModel, JsonRequestBehavior.AllowGet);
        }
        public ActionResult PivotApiExampleTreeListPartial() {
            return PartialView(CreateSpreadsheetPivotApiModel(0).SourceCodeTreeModel);
        }
        [HttpPost]
        public ActionResult PivotApiExportTo(SpreadsheetPivotApiModel model) {
            CodeExample example = ObtainPivotExampleById(model.SourceId);
            IWorkbook workbook = CreateWorkbookFromPivotExample(example);
            return GenerateFile(workbook, model);
        }
        CodeExample ObtainPivotExampleById(int exampleId) {
            SpreadsheetPivotApiModel model = new SpreadsheetPivotApiModel();
            SourceCodeTreeHelper extender = new SourceCodeTreeHelper(model.SourceCodeTreeModel);
            return extender.GetExampleById(exampleId);
        }
        IWorkbook CreateWorkbookFromPivotExample(CodeExample example) {
            ExampleEvaluatorByTimer evaluator = new SpreadsheetExampleEvaluatorNoTimer();
            Workbook workbook = new Workbook();
            workbook.ReplaceService<IUriStreamService>(new ASPxOfficeUriStreamService());
            //workbook.Options.Culture = System.Globalization.CultureInfo.InvariantCulture;
            workbook.LoadDocument(MapPath("~/App_Data/PivotTableTemplate.xlsx"));

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
