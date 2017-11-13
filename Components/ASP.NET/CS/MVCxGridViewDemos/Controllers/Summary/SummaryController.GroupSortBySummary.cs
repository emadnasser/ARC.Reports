using System.Web.Mvc;
using DevExpress.Data;

namespace DevExpress.Web.Demos {
    public partial class SummaryController: DemoController {
        public ActionResult GroupSortBySummary() {
            ViewBag.SummarySortOrder = ColumnSortOrder.Ascending;
            return DemoView("GroupSortBySummary", NorthwindDataProvider.GetInvoices());
        }
        [HttpPost]
        public ActionResult GroupSortBySummary(ColumnSortOrder summarySortOrder) {
            ViewBag.SummarySortOrder = summarySortOrder;
            return DemoView("GroupSortBySummary", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult GroupSortBySummaryPartial(ColumnSortOrder summarySortOrder) {
            ViewBag.SummarySortOrder = summarySortOrder;
            return PartialView("GroupSortBySummaryPartial", NorthwindDataProvider.GetInvoices());
        }
    }
}
