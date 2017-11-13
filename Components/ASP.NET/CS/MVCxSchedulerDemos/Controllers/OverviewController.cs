using System.Web.Mvc;
using System.Collections;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class OverviewController: DemoController {
        public override string Name { get { return ""; } }

        public ActionResult Index() {
            return DemoView("Overview", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult OverviewPartial() {
            return PartialView("OverviewPartial", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult OverviewPartialEditAppointment() {
            SchedulerDataHelper.UpdateEditableDataObject();
            return PartialView("OverviewPartial", SchedulerDataHelper.EditableDataObject);
        }
    }
}
