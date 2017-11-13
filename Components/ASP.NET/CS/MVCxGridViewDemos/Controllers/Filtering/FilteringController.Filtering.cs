using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController: DemoController {
        public ActionResult Filtering() {
            ViewBag.EnableCheckedListMode = true;
            return DemoView("Filtering", NorthwindDataProvider.GetInvoices());
        }
        [HttpPost]
        public ActionResult Filtering(bool enableCheckedListMode = true) {
            ViewBag.EnableCheckedListMode = enableCheckedListMode;
            return DemoView("Filtering", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult FilteringPartial(bool enableCheckedListMode = true) {
            ViewBag.EnableCheckedListMode = enableCheckedListMode;
            return PartialView("FilteringPartial", NorthwindDataProvider.GetInvoices());
        }
    }
}
