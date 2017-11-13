using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController {
        const string pageDeleteSessionKey = "DeletePageFile";
        const string pageDeleteDefaultFile = "~/App_Data/Pdf/PageDeletion.pdf";

        public ActionResult PageDeletion() {
            return GetDemoView<PdfPageDeletionModel>("PageDeletion", pageDeleteSessionKey, pageDeleteDefaultFile);
        }
        public ActionResult DeleteCurrentPage(int pageNumber) {
            using (PdfPageDeletionModel model = new PdfPageDeletionModel()) {
                model.LoadDocument((byte[])Session[pageDeleteSessionKey]);
                Session[pageDeleteSessionKey] = model.DeletePage(pageNumber + 1);
                return null;
            }
        }
    }
}
