using System;
using System.IO;
using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Web.Mvc;
using DevExpress.XtraRichEdit;

namespace DevExpress.Web.Demos {
    public partial class RichEditController : DemoController {
        public ActionResult Export() {
            RichEditExportModel model = new RichEditExportModel();
            return DemoView("Export", model);
        }
        public ActionResult ExportExportTo(RichEditExportModel model) {
            RichEditDocumentServer documentServer = CreateDocumentServer();
            string path = System.Uri.UnescapeDataString(model.DocumentUrl);
            string filePath = MapPath(path);
            documentServer.LoadDocument(filePath);

            MemoryStream stream = new MemoryStream();
            DocumentFormat format = ConvertIndexToFormat(model.ExportToDocumentType);
            if (format == DocumentFormat.Undefined)
                documentServer.ExportToPdf(stream);
            else
                documentServer.SaveDocument(stream, format);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            return CreateFileStreamResult(stream, model.ExportToDocumentType, fileNameWithoutExtension);
        }
        public ActionResult ExportDocumentUpload() {
            UploadControlExtension.GetUploadedFiles("uploader", new UploadControlValidationSettings(), UploadComplete);
            return null;
        }
        void UploadComplete(object sender, FileUploadCompleteEventArgs e) {
            const int maxVisibleFileName = 40;
            if (!e.IsValid)
                return;
            UploadedFile uploadedFile = e.UploadedFile;
            string resultFilePath = DocumentServerDemoUtils.UploadDirectory + uploadedFile.FileName;
            FileInfo info = new FileInfo(MapPath(resultFilePath));
            using (FileStream streamToWrite = info.OpenWrite()) {
                uploadedFile.FileContent.CopyTo(streamToWrite);
            }
            IUrlResolutionService urlResolver = sender as IUrlResolutionService;
            string visibleFileName = Path.GetFileName(resultFilePath);
            if (visibleFileName.Length > maxVisibleFileName)
                visibleFileName = String.Format("{0}...", visibleFileName.Substring(0, maxVisibleFileName));
            e.CallbackData = String.Format(@"({{'Url' : '{0}', 'FileName' : '{1}'}})", urlResolver.ResolveClientUrl(resultFilePath), visibleFileName);
        }
    }
}
