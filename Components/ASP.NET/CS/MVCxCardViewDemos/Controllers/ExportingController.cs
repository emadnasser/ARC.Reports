using System.Linq;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public override string Name { get { return "Exporting"; } }

        public ActionResult Index() {
            return RedirectToAction("Export");
        }
        protected CardViewExportFormat GetExportFormat() {
            var result = CardViewExportFormat.None;
            System.Enum.TryParse(Request.Params["ExportFormat"], out result);
            return result;
        }
    }
}
