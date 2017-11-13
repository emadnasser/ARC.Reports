using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class OverviewController : DemoController {
        public override string Name { get { return ""; } }

        public ActionResult Index() {
            return DemoView("Overview");
        }
        public ActionResult OverviewPartial() {
            return PartialView("OverviewPartial");
        }
    }
}
