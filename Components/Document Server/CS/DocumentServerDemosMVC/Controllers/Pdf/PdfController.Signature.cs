using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController {
        const string signSessionKey = "Sign";
        const string signDefaultFile = "~/App_Data/Pdf/SignatureDemo.pdf";

        public ActionResult Signature() {
            return DemoView("Signature", new PdfSignatureModel());
        }
        public ActionResult SignaturePartial() {
            return GetPartialView<PdfModelBase>("PdfFileView", signSessionKey, signDefaultFile);
        }
        public ActionResult Sign(PdfSignatureModel model) {
            return DownloadResult(model.Sign());
        }
    }
}
