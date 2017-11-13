using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ComplexReportsController: ReportDemoController {
        public ActionResult InvoiceReport() {
            var model = ReportDemoHelper.CreateModel("Invoice", Session, Request);
            return DemoView("InvoiceReport", "Invoice", model);
        }

        public ActionResult InvoiceViewerPartial(string reportID) {
            return PartialView("InvoiceViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
