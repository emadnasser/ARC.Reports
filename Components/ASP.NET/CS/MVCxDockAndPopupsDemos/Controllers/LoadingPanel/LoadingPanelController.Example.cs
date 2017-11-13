using System.Threading;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class LoadingPanelController : DemoController {
        public ActionResult Example() {
            ViewData["DisplayOverPanel"] = true;
            return DemoView("Example");
        }
        [HttpPost]
        public ActionResult Example(bool displayOverPanel) {
            ViewData["DisplayOverPanel"] = displayOverPanel;
            return DemoView("Example");
        }
        public ActionResult ExamplePartial() {
            if(DevExpressHelper.IsCallback)
                // Intentionally pauses server-side processing,
                // to demonstrate the Loading Panel functionality.
                Thread.Sleep(500);
            return PartialView("ExamplePartial");
        }
    }
}
