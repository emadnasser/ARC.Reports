using DevExpress.DXperience.Demos;
using DevExpress.Export.Xl;
using System;
using System.IO;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetController : DemoController {
        const int DefaultXLExportApiSourceCodeId = 0;
        public ActionResult XLExportApi() {
            SpreadsheetXLExportApiModel model = CreateSpreadsheetXLExportApiModel(DefaultXLExportApiSourceCodeId);
            return DemoView("XLExportApi", model);
        }
        SpreadsheetXLExportApiModel CreateSpreadsheetXLExportApiModel(int sourceId) {
            CodeExample example = ObtainXLExportExampleById(sourceId);
            SpreadsheetXLExportApiModel result = new SpreadsheetXLExportApiModel();
            result.CSCode = CodeFormatter.GetFormattedCode(CodeParser.TokenLanguage.CSharp, example.CodeCS, false);
            result.SourceId = sourceId;
            result.SourceName = example.RegionName;
            result.IsXLSButtonEnabled = IsXLSFormatEnabled(example.RegionName);
            result.IsCSVButtonEnabled = IsCSVFormatEnabled(example.RegionName);
            return result;
        }
        bool IsXLSFormatEnabled(string sourceName) {
            return !XLExportForbiddenXLSExamples.Examples.Contains(sourceName);
        }
        bool IsCSVFormatEnabled(string sourceName) {
            return !XLExportForbiddenCSVExamples.Examples.Contains(sourceName);
        }
        public JsonResult XLExportApiChangeCurrentSourceCode(SpreadsheetXLExportApiModel model) {
            SpreadsheetXLExportApiModel newModel = CreateSpreadsheetXLExportApiModel(model.SourceId);
            return Json(newModel, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult XLExportApiExportTo(SpreadsheetXLExportApiModel model) {
            CodeExample example = ObtainXLExportExampleById(model.SourceId);
            return ExportFile(example, GetExportedFormat());
        }
        CodeExample ObtainXLExportExampleById(int exampleId) {
            SpreadsheetXLExportApiModel model = new SpreadsheetXLExportApiModel();
            SourceCodeTreeHelper extender = new SourceCodeTreeHelper(model.SourceCodeTreeModel);
            return extender.GetExampleById(exampleId);
        }
        XlDocumentFormat GetExportedFormat() {
            if (Request.Params["ExportToXLSX"] != null)
                return XlDocumentFormat.Xlsx;
            if (Request.Params["ExportToXLS"] != null)
                return XlDocumentFormat.Xls;
            return XlDocumentFormat.Csv;
        }
        FileStreamResult ExportFile(CodeExample example, XlDocumentFormat format) {
            MemoryStream stream = new MemoryStream();
            RunExample(example.CodeCS, stream, format);

            stream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(stream, ConvertXlDocumentFormatToContentType(format));
        }
        void RunExample(string exampleCode, Stream stream, XlDocumentFormat documentFormat) {
            XLExportExampleCodeEvaluatorBase evaluator = new XLExportCSExampleCodeEvaluator();
            string imagePath = MapPath("~/App_Data/Images");
            CodeEvaluationResult result = evaluator.ExecuteCodeAndGenerateDocument(exampleCode, new object[] { stream, documentFormat, imagePath });
        }
        string ConvertXlDocumentFormatToContentType(XlDocumentFormat format) {
            switch (format) {
                case XlDocumentFormat.Xlsx:
                    return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                case XlDocumentFormat.Xls:
                    return "application/vnd.ms-excel";
                case XlDocumentFormat.Csv:
                    return "text/comma-separated-values";
            }
            return String.Empty;
        }
    }
}
