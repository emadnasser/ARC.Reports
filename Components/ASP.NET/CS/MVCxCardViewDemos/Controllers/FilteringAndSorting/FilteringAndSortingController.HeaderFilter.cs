using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringAndSortingController: DemoController {
        public ActionResult HeaderFilter() {
            Session["EnableCheckedListMode"] = true;
            return DemoView("HeaderFilter", NorthwindDataProvider.GetInvoices());
        }
        [HttpPost]
        public ActionResult HeaderFilter(bool enableCheckedListMode) {
            Session["EnableCheckedListMode"] = enableCheckedListMode;
            return DemoView("HeaderFilter", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult HeaderFilterPartial() {
            return PartialView("HeaderFilterPartial", NorthwindDataProvider.GetInvoices());
        }
    }
}
