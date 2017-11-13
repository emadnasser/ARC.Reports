using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CalendarFeaturesController: DemoController {
        public override string Name { get { return "CalendarFeatures"; } }

        public ActionResult Index() {
            return RedirectToAction("DateNavigator");
        }
    }
}
