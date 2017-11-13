using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CalendarFeaturesController: DemoController {
        public ActionResult DateNavigator() {
            return DemoView("DateNavigator", SchedulerDataHelper.DataObject);
        }
        public ActionResult DateNavigatorPartial() {
            return PartialView("DateNavigatorPartial", SchedulerDataHelper.DataObject);
        }
    }
}
