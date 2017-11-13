using System.Collections;
using System.Linq;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataShapingController : DemoController {
        public ActionResult TotalSummary() {
            return DemoView("TotalSummary", NorthwindDataProvider.GetFullInvoices());
        }

        public ActionResult TotalSummaryPartial() {
            return PartialView("TotalSummaryPartial", NorthwindDataProvider.GetFullInvoices());
        }
    }
}
