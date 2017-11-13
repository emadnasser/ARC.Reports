using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult ExportWithDataCellBands() {
            return DemoView("ExportWithDataCellBands", HomesDataProvider.Homes);
        }
        public ActionResult ExportWithDataCellBandsPartial() {
            return PartialView("ExportWithDataCellBandsPartial", HomesDataProvider.Homes);
        }
        public ActionResult ExportWithDataCellBandsResult() {
            GridViewExportFormat format = GetExportFormat();
            if(GridViewExportDemoHelper.AdvancedBandsExportFormatsInfo.ContainsKey(format))
                return GridViewExportDemoHelper.AdvancedBandsExportFormatsInfo[format](GridViewExportDemoHelper.AdvancedBandsExportGridViewSettings, HomesDataProvider.Homes);
            return RedirectToAction("ExportWithDataCellBands");
        }
    }
}
