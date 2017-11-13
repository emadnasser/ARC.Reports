using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class OverviewController: DemoController {
        public override string Name { get { return ""; } }

        public ActionResult Index() {
            return DemoView("Overview");
        }
        public ActionResult OverviewPartial() {
            return PartialView("OverviewPartial");
        }
    }
}
