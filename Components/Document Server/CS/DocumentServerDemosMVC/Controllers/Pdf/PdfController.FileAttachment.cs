using System.IO;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PdfController {
        public ActionResult FileAttachment() {
            return DemoView("FileAttachment", new PdfFileAttachmentModel());
        }
        public ActionResult Attach() {
            using (PdfFileAttachmentModel model = new PdfFileAttachmentModel()) {
                Stream stream = model.CreateDocument(Server.MapPath("~/App_Data/Pdf/FileAttachment.pdf"), Server.MapPath("~/Content/DevExpress.png"));
                return DownloadResult(stream);
            }
        }
    }
}
