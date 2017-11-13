using System.IO;
using System.Web.Mvc;
using DevExpress.Docs.Demos;
using DevExpress.DXperience.Demos;
using DevExpress.XtraRichEdit;
using DevExpress.Office.Services;
using DevExpress.Web.Office;

namespace DevExpress.Web.Demos {
    public partial class RichEditController : DemoController {
        public ActionResult Api() {
            RichEditApiModel model = CreateRichEditApiModel(0);
            return DemoView("Api", model);
        }
        RichEditApiModel CreateRichEditApiModel(int sourceId) {
            CodeExample example = ObtainExampleById(sourceId);
            RichEditApiModel result = new RichEditApiModel();
            result.CSCode = CodeFormatter.GetFormattedCode(CodeParser.TokenLanguage.CSharp, example.CodeCS, false);
            result.SourceId = sourceId;
            result.SourceName = example.RegionName;
            return result;
        }
        public ActionResult PreviewApi(RichEditApiModel model) {
            Stream stream = CreateDocumentStream(DocumentFormat.Html, model.SourceId);
            return CreatePreviewResult(stream); 
        }
        public JsonResult ApiChangeCurrentSourceCode(RichEditApiModel model) {
            RichEditApiModel newModel = CreateRichEditApiModel(model.SourceId);
            return Json(newModel, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ApiExampleTreeListPartial() {
            return PartialView(CreateRichEditApiModel(0).SourceCodeTreeModel);
        }
        [HttpPost]
        public ActionResult ApiExportTo(RichEditApiModel model) {
            DocumentFormat format = ConvertIndexToFormat(model.ExportToDocumentType);
            Stream stream = CreateDocumentStream(format, model.SourceId);
            return CreateFileStreamResult(stream, model.ExportToDocumentType); 
        }
        Stream CreateDocumentStream(DocumentFormat format, int sourceId) {
            CodeExample example = ObtainExampleById(sourceId);
            RichEditDocumentServer documentServer = CreateDocumentServerFromExample(example);
            MemoryStream stream = new MemoryStream();
            if (format == DocumentFormat.Undefined)
                documentServer.ExportToPdf(stream);
            else
                documentServer.SaveDocument(stream, format);
            return stream;
        }
        CodeExample ObtainExampleById(int exampleId) {
            RichEditApiModel model = new RichEditApiModel();
            SourceCodeTreeHelper extender = new SourceCodeTreeHelper(model.SourceCodeTreeModel);
            return extender.GetExampleById(exampleId);
        }
        RichEditDocumentServer CreateDocumentServerFromExample(CodeExample example) {
            ExampleEvaluatorByTimer evaluator = new RichEditExampleEvaluatorNoTimer();
            RichEditDocumentServer documentServer = CreateDocumentServer();
            CodeEvaluationEventArgs compileArgs = new CodeEvaluationEventArgs() {
                Result = true,
                Code = example.CodeCS,
                Language = ExampleLanguage.Csharp,
                EvaluationParameter = documentServer.Document
            };
            evaluator.Evaluate(compileArgs);
            return documentServer;
        }
        RichEditDocumentServer CreateDocumentServer() {
            RichEditDocumentServer documentServer = new RichEditDocumentServer();
            documentServer.ReplaceService<IUriStreamService>(new ASPxOfficeUriStreamService());
            return documentServer;
        }
    }
    #region RichEditExampleEvaluatorNoTimer
    public class RichEditExampleEvaluatorNoTimer : ExampleEvaluatorByTimer {
        public RichEditExampleEvaluatorNoTimer()
            : base(false) {
        }
        protected override ExampleCodeEvaluator GetExampleCodeEvaluator(ExampleLanguage language) {
            if (language == ExampleLanguage.VB)
                return new RichEditVbExampleCodeEvaluator();
            return new RichEditCsExampleCodeEvaluator();
        }
    }
    #endregion
}
