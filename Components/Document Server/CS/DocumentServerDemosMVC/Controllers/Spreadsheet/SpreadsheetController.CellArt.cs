using System.Drawing;
using System.IO;
using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Docs.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetController : DemoController {
        public ActionResult CellArt(SpreadsheetCellArtModel model) {
            if (model == null)
                model = new SpreadsheetCellArtModel();
            model.PreviewModel.Workbook = CreateCellArtWorkbook(model);
            return DemoView("CellArt", model);
        }
        public string CallbacksImageUpload() {
            UploadControlExtension.GetUploadedFiles("uploader", new UploadControlValidationSettings(), UploadComplete);
            return null;
        }
        void UploadComplete(object sender, FileUploadCompleteEventArgs e) {
            if (!e.IsValid)
                return;
            UploadedFile uploadedFile = e.UploadedFile;
            string resultFilePath = DocumentServerDemoUtils.UploadDirectory + uploadedFile.FileName;
            FileInfo info = new FileInfo(MapPath(resultFilePath));
            using (FileStream streamToWrite = info.OpenWrite())
                uploadedFile.FileContent.CopyTo(streamToWrite);
            IUrlResolutionService urlResolver = sender as IUrlResolutionService;
            e.CallbackData = urlResolver.ResolveClientUrl(resultFilePath);
        }
        public ActionResult PreviewCellArt(SpreadsheetCellArtModel model) {
            SpreadsheetPreviewModel previewModel = model.PreviewModel;
            previewModel.Workbook = CreateCellArtWorkbook(model); ;
            return GenerateHtmlPreview(previewModel);
        }
        public ActionResult CellArtExportTo(SpreadsheetCellArtModel model) {
            IWorkbook workbook = CreateCellArtWorkbook(model);
            return GenerateFile(workbook, model);
        }
        IWorkbook CreateCellArtWorkbook(SpreadsheetCellArtModel model) {
            Bitmap img = new Bitmap(MapPath(model.GetImageUrl()));
            CellArtDocumentGenerator generator = new CellArtDocumentGenerator(img);
            return generator.Generate();
        }
    }
}
