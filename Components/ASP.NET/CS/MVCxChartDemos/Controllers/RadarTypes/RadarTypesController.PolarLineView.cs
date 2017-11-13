using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult PolarLineView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartRadarDemoOptions() { View = XtraCharts.ViewType.PolarLine, PolarFunction = PolarFunctions.Lemniscate, ShowMarkers = true };
            return DemoView("PolarLineView", MathematicsFunctions.GenerateFunctionPoints(PolarFunctions.Lemniscate));
        }
        [HttpPost]
        public ActionResult PolarLineView([Bind] ChartRadarDemoOptions options) {
            options.View = XtraCharts.ViewType.PolarLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("PolarLineView", MathematicsFunctions.GenerateFunctionPoints(options.PolarFunction));
        }
    }
}
