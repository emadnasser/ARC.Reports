using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult PolarAreaView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartRadarDemoOptions() { View = XtraCharts.ViewType.PolarArea, PolarFunction = PolarFunctions.Lemniscate, ShowMarkers = true };
            return DemoView("PolarAreaView",MathematicsFunctions.GenerateFunctionPoints(PolarFunctions.Lemniscate));
        }
        [HttpPost]
        public ActionResult PolarAreaView([Bind] ChartRadarDemoOptions options) {
            options.View = XtraCharts.ViewType.PolarArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("PolarAreaView", MathematicsFunctions.GenerateFunctionPoints(options.PolarFunction));
        }
    }
}
