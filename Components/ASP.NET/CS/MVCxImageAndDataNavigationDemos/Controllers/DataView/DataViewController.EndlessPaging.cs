using System.Threading;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataViewController: DemoController {
        public ActionResult EndlessPaging() {
            ViewBag.EndlessPagingMode = DataViewEndlessPagingMode.OnClick;
            return DemoView("EndlessPaging");
        }
        [HttpPost]
        public ActionResult EndlessPaging(DataViewEndlessPagingMode endlessPagingMode) {
            ViewBag.EndlessPagingMode = endlessPagingMode;
            return DemoView("EndlessPaging");
        }
        public ActionResult EndlessPagingPartial(DataViewEndlessPagingMode endlessPagingMode) {
            // Intentionally pauses server-side processing,
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(500);

            ViewBag.EndlessPagingMode = endlessPagingMode;
            return PartialView("EndlessPagingPartial");
        }
    }
}
