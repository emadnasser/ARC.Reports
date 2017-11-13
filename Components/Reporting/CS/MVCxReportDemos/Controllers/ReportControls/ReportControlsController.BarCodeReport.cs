using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportControlsController: ReportDemoController {
        public ActionResult BarCodeReport() {
            var model = ReportDemoHelper.CreateModel("BarCode", Session, Request);
            return DemoView("BarCodeReport", "BarCode", model);
        }

        public ActionResult BarCodeViewerPartial(string reportID) {
            return PartialView("BarCodeViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
