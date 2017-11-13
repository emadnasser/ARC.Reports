using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ComplexReportsController: ReportDemoController {
        public ActionResult FallCatalogReport() {
            var model = ReportDemoHelper.CreateModel("FallCatalog", Session, Request);
            return DemoView("FallCatalogReport", "FallCatalog", model);
        }

        public ActionResult FallCatalogViewerPartial(string reportID) {
            return PartialView("FallCatalogViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
