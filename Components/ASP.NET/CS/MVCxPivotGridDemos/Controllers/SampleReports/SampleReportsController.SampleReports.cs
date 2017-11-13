using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleReportsController: DemoController {
        public ActionResult SampleReports() {
            Session["ReportOptions"] = PivotGridReportsDemoOptions.Default;
            return DemoView("SampleReports", NorthwindDataProvider.GetCustomerReports());
        }
        public ActionResult SampleReportsPartial() {
            return PartialView("SampleReportsPartial", NorthwindDataProvider.GetCustomerReports());
        }
        public ActionResult CustomActionSampleReportsPartial(PivotGridReportsDemoOptions options) {
            if (options != null) {
                Session["ReportOptions"] = options;
                ViewBag.IsReloadLayout = true;
            }
            return PartialView("SampleReportsPartial", NorthwindDataProvider.GetCustomerReports());
        }
    }
}
