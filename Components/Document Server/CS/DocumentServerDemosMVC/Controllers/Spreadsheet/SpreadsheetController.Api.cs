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
using DevExpress.Office.Services;
using DevExpress.Web.Office;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetController : DemoController {
        const int DefaultSpreadsheetApiSourceCodeId = 0;
        public ActionResult Api() {
            SpreadsheetApiModel model = CreateSpreadsheetApiModel(DefaultSpreadsheetApiSourceCodeId);
            return DemoView("Api", model);
        }
        SpreadsheetApiModel CreateSpreadsheetApiModel(int sourceId) {
            CodeExample example = ObtainExampleById(sourceId);
            SpreadsheetApiModel result = new SpreadsheetApiModel();
            result.CSCode = CodeFormatter.GetFormattedCode(CodeParser.TokenLanguage.CSharp, example.CodeCS, false);
            result.SourceId = sourceId;
            result.SourceName = example.RegionName;
            result.PreviewModel.Workbook = CreateWorkbookFromExample(example);
            return result;
        }
        public ActionResult PreviewApi(SpreadsheetApiModel model) {
            CodeExample example = ObtainExampleById(model.SourceId);
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateWorkbookFromExample(example);
            previewModel.PreviewSheetIndex = previewModel.Workbook.Worksheets.ActiveWorksheet.Index;
            return GenerateHtmlPreview(previewModel);
        }        
        public JsonResult ApiChangeCurrentSourceCode(SpreadsheetApiModel model) {
            SpreadsheetApiModel newModel = CreateSpreadsheetApiModel(model.SourceId);
            newModel.PreviewModel.Workbook = null;
            return Json(newModel, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ApiExampleTreeListPartial() {
            return PartialView(CreateSpreadsheetApiModel(0).SourceCodeTreeModel);
        }
        IWorkbook CreateWorkbookFromExample(CodeExample example) {
            ExampleEvaluatorByTimer evaluator = new SpreadsheetExampleEvaluatorNoTimer();
            Workbook workbook = new Workbook();
            workbook.ReplaceService<IUriStreamService>(new ASPxOfficeUriStreamService());
            //workbook.Options.Culture = System.Globalization.CultureInfo.InvariantCulture;
            workbook.LoadDocument(MapPath("~/App_Data/Document.xlsx"));

            CodeEvaluationEventArgs compileArgs = new CodeEvaluationEventArgs() {
                Result = true,
                Code = example.CodeCS,
                Language = ExampleLanguage.Csharp,
                EvaluationParameter = workbook
            };
            evaluator.Evaluate(compileArgs);
            workbook.Worksheets.ActiveWorksheet.Visible = true;
            return workbook;
        }
        [HttpPost]
        public ActionResult ApiExportTo(SpreadsheetApiModel model) {
            CodeExample example = ObtainExampleById(model.SourceId);
            IWorkbook workbook = CreateWorkbookFromExample(example);
            return GenerateFile(workbook, model);
        }
        CodeExample ObtainExampleById(int exampleId) {
            SpreadsheetApiModel model = new SpreadsheetApiModel();
            SourceCodeTreeHelper extender = new SourceCodeTreeHelper(model.SourceCodeTreeModel);
            return extender.GetExampleById(exampleId);
        }
    }
    #region SpreadsheetExampleEvaluator
    public class SpreadsheetExampleEvaluatorNoTimer : ExampleEvaluatorByTimer {
        public SpreadsheetExampleEvaluatorNoTimer()
            : base(false) {
        }
        protected override ExampleCodeEvaluator GetExampleCodeEvaluator(ExampleLanguage language) {
            if (language == ExampleLanguage.VB)
                return new SpreadsheetVbExampleCodeEvaluator();
            return new SpreadsheetCSExampleCodeEvaluator();
        }
    }
    #endregion
}
