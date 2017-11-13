using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportTypesController: ReportDemoController {
        public ActionResult ReportMerging() {
            var model = ReportDemoHelper.CreateModel("ReportMerging", Session, Request);
            return DemoView("ReportMerging", "ReportMerging", model);
        }

        public ActionResult ReportMergingViewerPartial(string reportID) {
            return PartialView("ReportMergingViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
