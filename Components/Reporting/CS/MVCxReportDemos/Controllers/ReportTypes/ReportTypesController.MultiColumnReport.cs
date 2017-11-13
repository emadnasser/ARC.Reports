using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportTypesController: ReportDemoController {
        public ActionResult MultiColumnReport() {
            var model = ReportDemoHelper.CreateModel("MultiColumn", Session, Request);
            return DemoView("MultiColumnReport", "MultiColumn", model);
        }

        public ActionResult MultiColumnViewerPartial(string reportID) {
            return PartialView("MultiColumnViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
