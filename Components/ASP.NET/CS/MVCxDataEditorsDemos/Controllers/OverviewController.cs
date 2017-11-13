using System.Web.Mvc;
using System.Collections;
using DevExpress.Web.Mvc;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    [ValidateInput(false)]
    public partial class OverviewController: DemoController {
        public override string Name { get { return ""; } }

        public ActionResult Index() {
            return DemoView("Overview");
        }
        public ActionResult CaptchaPartial() {
            return PartialView("CaptchaPartial");
        }
    }
}
