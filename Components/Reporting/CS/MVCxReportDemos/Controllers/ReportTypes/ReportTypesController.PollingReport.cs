using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportTypesController : ReportDemoController {
        public ActionResult PollingReport() {
            var model = ReportDemoHelper.CreateModel("PollingReport", Session, Request);
            return DemoView("PollingReport", "PollingReport", model);
        }

        public ActionResult PollingReportViewerPartial(string reportID) {
            return PartialView("PollingReportViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
