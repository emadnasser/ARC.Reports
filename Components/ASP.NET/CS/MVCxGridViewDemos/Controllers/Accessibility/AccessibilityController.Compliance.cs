using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult Compliance() {
            return DemoView("Compliance", NorthwindDataProvider.GetProducts());
        }
        public ActionResult CompliancePartial() {
            return PartialView("CompliancePartial", NorthwindDataProvider.GetProducts());
        }
    }
}
