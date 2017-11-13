using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController {
        const string textExtractionSessionKey = "TextExtractionFile";
        const string textExtractionDefaultFile = "~/App_Data/Pdf/TextExtraction.pdf";

        public ActionResult TextExtraction() {
            return GetDemoView<PdfTextExtractionModel>("TextExtraction",textExtractionSessionKey,textExtractionDefaultFile);
        }
        public ActionResult TextExtractionUploadFiles() {
            UploadFile(textExtractionSessionKey);
            return null;
        }
        public ActionResult TextExtractResult() {
            if (Session[textExtractionSessionKey] == null)
                return null;
            model = new PdfTextExtractionModel();
            model.LoadDocument((byte[])Session[textExtractionSessionKey]);
            return PartialView("PdfTextExtractionResultPartial", model);
        }
    }
}
