using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult ScatterRadarLineView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartRadarDemoOptions() { View = XtraCharts.ViewType.ScatterRadarLine, ScatterFunction = ScatterRadarFunctions.ArchimedeanSpiral };
            return DemoView("ScatterRadarLineView", MathematicsFunctions.GetRadianArchimedeanSpiralPoints(ScatterRadarFunctions.ArchimedeanSpiral));
        }
        [HttpPost]
        public ActionResult ScatterRadarLineView([Bind] ChartRadarDemoOptions options) {
            options.View = XtraCharts.ViewType.ScatterRadarLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("ScatterRadarLineView", MathematicsFunctions.GetRadianArchimedeanSpiralPoints(options.ScatterFunction));
        }
    }
}
