using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController: DemoController {
        public ActionResult ExportDetails() {
            return DemoView("ExportDetails", NorthwindDataProvider.GetCategories());
        }
        public ActionResult ExportDetailsTo(GridViewDetailExportMode? exportMode) {
            GridViewExportFormat format = GetExportFormat();
            if(!GridViewExportDemoHelper.ExportFormatsInfo.ContainsKey(format) || !exportMode.HasValue)
                return RedirectToAction("ExportDetails");

            GridViewSettings masterGridSettings = GridViewExportDemoHelper.CreateGeneralMasterGridSettings(exportMode.Value);
            return GridViewExportDemoHelper.ExportFormatsInfo[format](masterGridSettings, NorthwindDataProvider.GetCategories());
            
        }
        public ActionResult ExportDetailsMasterPartial() {
            return PartialView("ExportDetailsMasterPartial", NorthwindDataProvider.GetCategories());
        }
        public ActionResult ExportDetailsDetailPartial(int categoryID) {
            ViewBag.CategoryID = categoryID;
            return PartialView("ExportDetailsDetailPartial", NorthwindDataProvider.GetProducts(categoryID));
        }
    }
}
