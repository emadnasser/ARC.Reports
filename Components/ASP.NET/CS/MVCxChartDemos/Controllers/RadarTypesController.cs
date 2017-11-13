using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        public override string Name { get { return "RadarTypes"; } }
        public ActionResult Index() {
            return RedirectToAction("RadarView");
        }
    }
}
