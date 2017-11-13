using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult ExportSelected() {
            return DemoView("ExportSelected", HomesDataProvider.Homes);
        }
        public ActionResult ExportSelectedPartial() {
            return PartialView("ExportSelectedPartial", HomesDataProvider.Homes);
        }
        public ActionResult ExportSelectedResult() {
            var format = GetExportFormat();
            if(CardViewExportDemoHelper.ExportFormatsInfo.ContainsKey(format)) {
                var settings = CardViewExportDemoHelper.ExportSelectedCardViewSettings;
                CardViewExportDemoHelper.SetImageColumnExportVisibility(settings, format, "PhotoUrl");
                return CardViewExportDemoHelper.ExportSelectedFormatsInfo[format](settings, HomesDataProvider.Homes);
            }
            return RedirectToAction("ExportSelected");
        }
    }
}
