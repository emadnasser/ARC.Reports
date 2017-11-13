using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController: DemoController {
        public ActionResult AdaptiveLayout() {
            return DemoView("AdaptiveLayout");
        }
        public ActionResult AdaptiveLayoutPage() {
            return View("AdaptiveLayoutPage", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult AdaptiveLayoutPagePartial() {
            return View("AdaptiveLayoutPagePartial", NorthwindDataProvider.GetEmployees());
        }
    }
}
