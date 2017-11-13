using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataOutputController: DemoController {
        [HttpGet]
        public ActionResult Export() {
            ViewBag.DemoOptions = ViewBag.DemoOptions ?? new PivotGridExportDemoOptions();
            return DemoView("Export", NorthwindDataProvider.GetCustomerReports());
        }
        [HttpPost]
        public ActionResult Export(PivotGridExportDemoOptions options) {
            if(Request.Params["ExportTo"] == null) { // Theme changing
                ViewBag.DemoOptions = options;
                return DemoView("Export", NorthwindDataProvider.GetCustomerReports());
            }

            return PivotGridDataOutputDemosHelper.GetExportActionResult(options, NorthwindDataProvider.GetCustomerReports());
        }
        public ActionResult ExportPartial() {
            return PartialView("ExportPartial", NorthwindDataProvider.GetCustomerReports());
        }
    }
}
