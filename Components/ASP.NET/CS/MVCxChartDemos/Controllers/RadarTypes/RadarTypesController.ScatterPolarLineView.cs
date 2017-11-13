using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult ScatterPolarLineView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartRadarDemoOptions() { View = XtraCharts.ViewType.ScatterPolarLine, ScatterFunction = ScatterRadarFunctions.ArchimedeanSpiral };
            return DemoView("ScatterPolarLineView", MathematicsFunctions.GetDegreeArchimedeanSpiralPoints(ScatterRadarFunctions.ArchimedeanSpiral));
        }
        [HttpPost]
        public ActionResult ScatterPolarLineView([Bind] ChartRadarDemoOptions options) {
            options.View = XtraCharts.ViewType.ScatterPolarLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("ScatterPolarLineView", MathematicsFunctions.GetDegreeArchimedeanSpiralPoints(options.ScatterFunction));
        }
    }
}
