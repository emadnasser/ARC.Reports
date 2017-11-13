using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PagingAndScrollingController: DemoController {
        [HttpGet]
        public ActionResult Paging() {
            return DemoView("Paging", NorthwindDataProvider.GetCustomerReports());
        }
        [HttpPost]
        public ActionResult Paging(PivotGridPagingDemoOptions options) {
            ViewBag.DemoOptions = options;
            return DemoView("Paging", NorthwindDataProvider.GetCustomerReports());
        }
        public ActionResult PagingPartial(PivotGridPagingDemoOptions options) {
            ViewBag.DemoOptions = options;
            return PartialView("PagingPartial", NorthwindDataProvider.GetCustomerReports());
        }
    }
}
