using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        public override string Name { get { return "AreaTypes"; } }
        public ActionResult Index() {
            return RedirectToAction("AreaView");
        }
    }
}
