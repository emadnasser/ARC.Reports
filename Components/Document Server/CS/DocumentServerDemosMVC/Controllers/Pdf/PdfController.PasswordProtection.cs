using System.IO;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController {
        const string passwordProtectionSessionKey = "PasswordProtection";
        const string passwordProtectionDefaultFile = "~/App_Data/Pdf/PasswordProtectionDemo.pdf";

        public ActionResult PasswordProtection() {
            return DemoView("PasswordProtection", new PdfPasswordProtectionModel());
        }
        public ActionResult PdfPasswordProtectionPartial() {
            return GetPartialView<PdfModelBase>("PdfFileView", passwordProtectionSessionKey, passwordProtectionDefaultFile);
        }
        public ActionResult Protect(PdfPasswordProtectionModel options) {
            Stream stream = options.PasswordProtect(Server.MapPath(passwordProtectionDefaultFile));
            return DownloadResult(stream);
        }
    }
}
