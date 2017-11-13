using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController: DemoController {
        public ActionResult ExcelDataAware() {
            ViewBag.ExportSelectedRowsOnly = true;
            return DemoView("ExcelDataAware", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ExcelDataAwareExportTo(GridViewExportedRowType? exportRowType) {
            GridViewExportFormat format = GetExportFormat();
            if(!GridViewExportDemoHelper.DataAwareExportFormatsInfo.ContainsKey(format) || !exportRowType.HasValue)
                return RedirectToAction("ExcelDataAware");

            GridViewExportMethod exportMethod = GridViewExportDemoHelper.DataAwareExportFormatsInfo[format];
            GridViewExportDemoHelper.ExcelDataAwareExportGridViewSettings.SettingsExport.ExportSelectedRowsOnly = exportRowType == GridViewExportedRowType.Selected;
            return exportMethod(GridViewExportDemoHelper.ExcelDataAwareExportGridViewSettings,  NorthwindDataProvider.GetProducts());
        }
        public ActionResult ExcelDataAwarePartial() {
            return PartialView("ExcelDataAwarePartial", NorthwindDataProvider.GetProducts());
        }
    }
}
