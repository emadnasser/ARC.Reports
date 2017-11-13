using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult Export() {
            return DemoView("Export", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ExportPartial() {
            return PartialView("ExportPartial", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ExportTo() {
            var format = GetExportFormat();
            if(CardViewExportDemoHelper.ExportFormatsInfo.ContainsKey(format))
                return CardViewExportDemoHelper.ExportFormatsInfo[format](CardViewExportDemoHelper.ExportCardViewSettings, NorthwindDataProvider.GetProducts());
            return RedirectToAction("Export");
        }
    }
}
