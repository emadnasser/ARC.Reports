using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult Export() {
            return DemoView("Export", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult ExportPartial() {
            return PartialView("ExportPartial", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult ExportTo() {
            GridViewExportFormat format = GetExportFormat();
            if(GridViewExportDemoHelper.ExportFormatsInfo.ContainsKey(format))
                return GridViewExportDemoHelper.ExportFormatsInfo[format](GridViewExportDemoHelper.ExportGridViewSettings, NorthwindDataProvider.GetInvoices());
            return RedirectToAction("Export");
        }
    }
}
