using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult DetailsViewMode() {
            Session["Options"] = new FileManagerDetailsViewModeDemoOptions();
            return DemoView("DetailsViewMode", FileManagerDemoHelper.ArtsFileSystemProvider);
        }
        [HttpPost]
        public ActionResult DetailsViewMode(FileManagerDetailsViewModeDemoOptions options) {
            Session["Options"] = options;
            return DemoView("DetailsViewMode", FileManagerDemoHelper.ArtsFileSystemProvider);
        }
        [ValidateInput(false)]
        public ActionResult DetailsViewModePartial() {
            if(Session["Options"] == null)
                Session["Options"] = new FileManagerDetailsViewModeDemoOptions();
            return PartialView("DetailsViewModePartial", FileManagerDemoHelper.ArtsFileSystemProvider);
        }
    }
}
