using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarsAndUIController : DemoController {
        public ActionResult RibbonCustomization() {
            Session["RibbonCustomizationOptions"] = new RibbonCustomizationDemoOptions(); 
            return DemoView("RibbonCustomization");
        }
        [HttpPost]
        public ActionResult RibbonCustomization([Bind] RibbonCustomizationDemoOptions options) {
            Session["RibbonCustomizationOptions"] = options;
            return DemoView("RibbonCustomization");
        }
        public ActionResult RibbonCustomizationPartial() {
            return PartialView("RibbonCustomizationPartial");
        }
    }
}
