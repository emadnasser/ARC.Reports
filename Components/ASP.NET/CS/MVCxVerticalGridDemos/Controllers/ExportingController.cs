using System.Linq;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public override string Name { get { return "Exporting"; } }

        public ActionResult Index() {
            return RedirectToAction("Exporting");
        }

        public ActionResult Exporting() {
            return DemoView("Exporting", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ExportingPartial() {
            return PartialView("ExportingPartial", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ExportTo() {
            var format = GetExportFormat();
            if(VerticalGridExportDemoHelper.ExportFormatsInfo.ContainsKey(format))
                return VerticalGridExportDemoHelper.ExportFormatsInfo[format](VerticalGridExportDemoHelper.ExportVerticalGridSettings, NorthwindDataProvider.GetProducts());
            return RedirectToAction("Exporting");
        }

        protected VerticalGridExportFormat GetExportFormat() {
            return VerticalGridExportDemoHelper.ExportFormatsInfo.Keys
                .Where(k => Request.Params[k.ToString()] != null)
                .DefaultIfEmpty(VerticalGridExportFormat.None)
                .First();
        }
    }
}
