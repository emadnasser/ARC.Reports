using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AppearanceController: ReportDemoController {
        public ActionResult OddEvenStylesReport() {
            var model = ReportDemoHelper.CreateModel("OddEvenStyles", Session, Request);
            return DemoView("OddEvenStylesReport", "OddEvenStyles", model);
        }

        public ActionResult OddEvenStylesViewerPartial(string reportID) {
            return PartialView("OddEvenStylesViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
