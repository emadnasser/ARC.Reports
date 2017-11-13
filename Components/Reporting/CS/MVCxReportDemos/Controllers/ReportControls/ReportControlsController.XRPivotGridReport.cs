using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportControlsController: ReportDemoController {
        public ActionResult XRPivotGridReport() {
            var model = ReportDemoHelper.CreateModel("XRPivotGrid", Session, Request);
            return DemoView("XRPivotGridReport", "PivotGrid", model);
        }

        public ActionResult PivotGridViewerPartial(string reportID) {
            return PartialView("PivotGridViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
