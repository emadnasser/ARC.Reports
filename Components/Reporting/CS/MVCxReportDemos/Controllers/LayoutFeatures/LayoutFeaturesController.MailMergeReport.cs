using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class LayoutFeaturesController: ReportDemoController {
        public ActionResult MailMergeReport() {
            var model = ReportDemoHelper.CreateModel("MailMerge", Session, Request);
            return DemoView("MailMergeReport", "MailMerge", model);
        }

        public ActionResult MailMergeViewerPartial(string reportID) {
            return PartialView("MailMergeViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
