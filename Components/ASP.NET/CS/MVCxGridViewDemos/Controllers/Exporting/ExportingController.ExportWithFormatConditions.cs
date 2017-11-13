using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult ExportWithFormatConditions() {
            return DemoView("ExportWithFormatConditions", NorthwindDataProvider.GetFullInvoices());
        }
        public ActionResult ExportWithFormatConditionsPartial() {
            return PartialView("ExportWithFormatConditionsPartial", NorthwindDataProvider.GetFullInvoices());
        }
        public ActionResult ExportWithFormatConditionsResult() {
            GridViewExportFormat format = GetExportFormat();
            if(GridViewExportDemoHelper.FormatConditionsExportFormatsInfo.ContainsKey(format))
                return GridViewExportDemoHelper.FormatConditionsExportFormatsInfo[format](GridViewExportDemoHelper.FormatConditionsExportGridViewSettings, NorthwindDataProvider.GetFullInvoices());
            return RedirectToAction("ExportWithFormatConditions");
        }
    }
}
