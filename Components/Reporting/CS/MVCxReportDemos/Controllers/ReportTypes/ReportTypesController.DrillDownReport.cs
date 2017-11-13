using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportTypesController: ReportDemoController {
        public ActionResult DrillDownReport() {
            var model = ReportDemoHelper.CreateModel("DrillDown", Session, Request);
            return DemoView("DrillDownReport", "DrillDown", model);
        }

        public ActionResult DrillDownViewerPartial(string reportID) {
            return PartialView("DrillDownViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
