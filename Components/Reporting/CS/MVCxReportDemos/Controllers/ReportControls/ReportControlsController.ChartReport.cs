using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportControlsController: ReportDemoController {
        public ActionResult ChartReport() {
            var model = ReportDemoHelper.CreateModel("Chart", Session, Request);
            return DemoView("ChartReport", "Chart", model);
        }

        public ActionResult ChartViewerPartial(string reportID) {
            return PartialView("ChartViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
