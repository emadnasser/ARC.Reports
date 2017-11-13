using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class WebSpecificFeaturesController: ReportDemoController {
        public ActionResult ReportDesignerReport() {
            var model = ReportDemoHelper.CreateModel("MasterDetail", Session, Request);
            return DemoView("ReportDesignerReport", "ReportDesignerReportViewer", model);
        }

        public ActionResult ReportDesignerReportViewerPartial(string reportID) {
            return PartialView("ReportDesignerReportViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
