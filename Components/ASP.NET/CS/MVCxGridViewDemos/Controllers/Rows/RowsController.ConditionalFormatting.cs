using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RowsController : DemoController {
        public ActionResult ConditionalFormatting() {
            return DemoView("ConditionalFormatting", NorthwindDataProvider.GetFullInvoices());
        }
        public ActionResult ConditionalFormattingPartial() {
            return PartialView("ConditionalFormattingPartial", NorthwindDataProvider.GetFullInvoices());
        }
    }
}
