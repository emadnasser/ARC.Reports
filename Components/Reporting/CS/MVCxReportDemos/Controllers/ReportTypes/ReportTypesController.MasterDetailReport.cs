using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportTypesController: ReportDemoController {
        public ActionResult MasterDetailReport() {
            var model = ReportDemoHelper.CreateModel("MasterDetail", Session, Request);
            return DemoView("MasterDetailReport", "MasterDetail", model);
        }

        public ActionResult MasterDetailViewerPartial(string reportID) {
            return PartialView("MasterDetailViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
