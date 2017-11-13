using System.Collections;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using DevExpress.XtraReports.UI;

namespace DevExpress.Web.Demos {
    public partial class ReportControlsController : ReportDemoController {
        public override string Name { get { return "ReportControls"; } }

        public ActionResult Index() {
            return RedirectToAction("ChartReport");
        }
    }

    public static partial class ReportControlsDemosHelper {
        public static IEnumerable GetAppearanceNames(XtraReport report) {
            return GetChartAppearanceNames(report)
                .Select((x, i) => new { Text = x, Value = i });
        }

        public static string GetAppearanceNamesJsonString(XtraReport report) {
            var result = GetChartAppearanceNames(report)
                .Select((x, i) => new { displayValue = x, value = i });
            return new JavaScriptSerializer().Serialize(result);
        }

        static string[] GetChartAppearanceNames(XtraReport report) {
            return ((XtraReportsDemos.Charts.Report)report)
                .xrChart1
                .GetAppearanceNames();
        }
    }
}
