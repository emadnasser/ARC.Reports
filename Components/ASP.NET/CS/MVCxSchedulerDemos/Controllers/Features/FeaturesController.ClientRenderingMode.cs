using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult ClientRenderingMode() {
            ViewBag.EnableClientRender = true;
            return DemoView("ClientRenderingMode", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult ClientRenderingModePartial(bool enableClientRender = true) {
            ViewBag.EnableClientRender = enableClientRender;
            return PartialView("ClientRenderingModePartial", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult ClientRenderingModePartialEditAppointment(bool enableClientRender = true) {
            ViewBag.EnableClientRender = enableClientRender;
            SchedulerDataHelper.UpdateEditableDataObject();
            return PartialView("ClientRenderingModePartial", SchedulerDataHelper.EditableDataObject);
        }
    }
}
