using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult ExportWithFormatConditions() {
            return DemoView("ExportWithFormatConditions", HomesDataProvider.Homes);
        }
        public ActionResult ExportWithFormatConditionsPartial() {
            return PartialView("ExportWithFormatConditionsPartial", HomesDataProvider.Homes);
        }
        public ActionResult ExportWithFormatConditionsResult() {
            var format = GetExportFormat();
            if(CardViewExportDemoHelper.ExportFormatsInfo.ContainsKey(format)) {
                var settings = CardViewExportDemoHelper.FormatConditionsExportCardViewSettings;
                CardViewExportDemoHelper.SetImageColumnExportVisibility(settings, format, "Photo");
                return CardViewExportDemoHelper.FormatConditionsExportFormatsInfo[format](settings, HomesDataProvider.Homes);
            }
            return RedirectToAction("ExportWithFormatConditions");
        }
    }
}
