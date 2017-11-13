using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult BinaryImageAutoUpload() {
            return DemoView("BinaryImageAutoUpload", HtmlEditorBinaryImageAutoUploadOptions.CreateDefault());
        }
        [HttpPost]
        public ActionResult BinaryImageAutoUpload([Bind]HtmlEditorBinaryImageAutoUploadOptions options) {
            return DemoView("BinaryImageAutoUpload", options);
        }
        public ActionResult BinaryImageAutoUploadPartial([Bind]HtmlEditorBinaryImageAutoUploadOptions options) {
            return PartialView("BinaryImageAutoUploadPartial", options);
        }
    }
}
