using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataOutputController: DemoController {
        public override string Name { get { return "DataOutput"; } }

        public ActionResult Index() {
            return RedirectToAction("ChartsIntegration");
        }
    }
}
