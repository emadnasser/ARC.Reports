using System.IO;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController {
        public ActionResult DocumentCreationAPI() {
            return DemoView("DocumentCreationAPI", null);
        }
        public ActionResult Download() {
            using (PdfDocumentCreationAPIModel model = new PdfDocumentCreationAPIModel()) {
                Stream stream = model.CreateDocument(Server.MapPath("~/App_Data/Pdf/Northwind.png"));
                return DownloadResult(stream);
            }
        }
    }
}
