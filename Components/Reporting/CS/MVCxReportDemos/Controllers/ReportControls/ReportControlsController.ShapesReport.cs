using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportControlsController: ReportDemoController {
        public ActionResult ShapesReport() {
            var model = ReportDemoHelper.CreateModel("Shapes", Session, Request);
            return DemoView("ShapesReport", "Shapes", model);
        }

        public ActionResult ShapesViewerPartial(string reportID) {
            return PartialView("ShapesViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
