using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RibbonController: DemoController {
        public ActionResult OneLineMode() {
            return DemoView("OneLineMode", new RibbonOneLineModeDemoOptions());
        }
        [HttpPost]
        public ActionResult OneLineMode(RibbonOneLineModeDemoOptions oneLineModeOptions) {
            return DemoView("OneLineMode", oneLineModeOptions);
        }
    }
}
