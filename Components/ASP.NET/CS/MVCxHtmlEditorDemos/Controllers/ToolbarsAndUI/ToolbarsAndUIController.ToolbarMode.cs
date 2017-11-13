using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ToolbarsAndUIController: DemoController {
        public ActionResult ToolbarMode() {
            return DemoView("ToolbarMode", HtmlEditorToolbarMode.Menu);
        }
        [HttpPost]
        public ActionResult ToolbarMode(HtmlEditorToolbarMode toolbarMode) {
            return DemoView("ToolbarMode", toolbarMode);
        }
        public ActionResult ToolbarModePartial(HtmlEditorToolbarMode toolbarMode) {
            return PartialView("ToolbarModePartial", toolbarMode);
        }

        public ActionResult ToolbarModeImageSelectorUpload() {
            HtmlEditorExtension.SaveUploadedImage("heToolbarMode", HtmlEditorFeaturesDemosHelper.ImageSelectorSettings);
            return null;
        }
    }
}
