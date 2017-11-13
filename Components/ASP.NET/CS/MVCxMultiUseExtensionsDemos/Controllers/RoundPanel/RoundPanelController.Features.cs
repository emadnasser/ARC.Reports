using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RoundPanelController: DemoController {
        public ActionResult Features() {
            ViewData["Options"] = new RoundPanelFeaturesDemoOptions();
            return DemoView("Features");
        }
        [HttpPost]
        public ActionResult Features([Bind]RoundPanelFeaturesDemoOptions options) {
            ViewData["Options"] = options;
            return DemoView("Features");
        }
    }
}
