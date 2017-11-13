using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController {
        const string textSearchSessionKey = "TextSearchFile";
        const string textSearchDefaultFile = "~/App_Data/Pdf/TextSearch.pdf";

        public ActionResult TextSearch() {
            return GetDemoView<PdfTextSearchModel>("TextSearch", textSearchSessionKey, textSearchDefaultFile);
        }
        public ActionResult TextSearchUploadFiles() {
            UploadFile(textSearchSessionKey);
            return null;
        }
        public ActionResult TextSearchResult(int wordCount, string findText) {
            model = new PdfTextSearchModel();
            model.LoadDocument((byte[])Session[textSearchSessionKey]);
            ((PdfTextSearchModel)model).Search(wordCount, findText);
            return PartialView("PdfTextSearchResultPartial", model);
        }
    }
}
