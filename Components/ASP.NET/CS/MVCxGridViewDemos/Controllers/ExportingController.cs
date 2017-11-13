using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public override string Name { get { return "Exporting"; } }

        public ActionResult Index() {
            return RedirectToAction("Export");
        }
        protected GridViewExportFormat GetExportFormat() {
            var result = GridViewExportFormat.None;
            Enum.TryParse(Request.Params["ExportFormat"], out result);
            return result;
        }
    }
}
