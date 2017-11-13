using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult PolarRangeAreaView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartRadarRangeDemoOptions() { View = XtraCharts.ViewType.PolarRangeArea, PolarFunction = PolarFunctions.Lemniscate, ShowMarkers = true, ShowMarkers2 = false };
            return DemoView("PolarRangeAreaView", MathematicsFunctions.GenerateRangeFunctionPoints(PolarFunctions.Lemniscate));
        }
        [HttpPost]
        public ActionResult PolarRangeAreaView([Bind] ChartRadarRangeDemoOptions options) {
            options.View = XtraCharts.ViewType.PolarRangeArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("PolarRangeAreaView", MathematicsFunctions.GenerateRangeFunctionPoints(options.PolarFunction));
        }
    }
}
