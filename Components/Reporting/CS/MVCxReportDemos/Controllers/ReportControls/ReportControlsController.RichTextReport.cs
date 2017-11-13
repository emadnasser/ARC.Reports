using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportControlsController: ReportDemoController {
        public ActionResult RichTextReport() {
            var model = ReportDemoHelper.CreateModel("RichText", Session, Request);
            return DemoView("RichTextReport", "RichText", model);
        }

        public ActionResult RichTextViewerPartial(string reportID) {
            return PartialView("RichTextViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
