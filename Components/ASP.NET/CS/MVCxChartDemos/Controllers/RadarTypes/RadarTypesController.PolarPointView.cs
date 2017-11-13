using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult PolarPointView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartRadarDemoOptions() { View = XtraCharts.ViewType.PolarPoint, PolarFunction = PolarFunctions.Lemniscate };
            return DemoView("PolarPointView", MathematicsFunctions.GenerateFunctionPoints(PolarFunctions.Lemniscate));
        }
        [HttpPost]
        public ActionResult PolarPointView([Bind] ChartRadarDemoOptions options) {
            options.View = XtraCharts.ViewType.PolarPoint;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("PolarPointView", MathematicsFunctions.GenerateFunctionPoints(options.PolarFunction));
        }
    }
}
