using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult ScatterLineView() {
            ChartScatterDemoOptions options = new ChartScatterDemoOptions();          
            options.View = DevExpress.XtraCharts.ViewType.ScatterLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("ScatterLineView", MathematicsFunctions.GetArchimedeanSpiralPoints());
        }
        [HttpPost]
        public ActionResult ScatterLineView([Bind] ChartScatterDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.ScatterLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            switch (options.Function) {
                case ScatterFunctions.ArchimedeanSpiral:
                    return DemoView("ScatterLineView", MathematicsFunctions.GetArchimedeanSpiralPoints());
                case ScatterFunctions.Cardioid:
                    return DemoView("ScatterLineView", MathematicsFunctions.GetCardioidPoints());
                case ScatterFunctions.CartesianFolium:
                    return DemoView("ScatterLineView", MathematicsFunctions.GetCartesianFoliumPoints());
                default:
                    return DemoView("ScatterLineView", MathematicsFunctions.GetArchimedeanSpiralPoints());
            }          
        }
    }
}
