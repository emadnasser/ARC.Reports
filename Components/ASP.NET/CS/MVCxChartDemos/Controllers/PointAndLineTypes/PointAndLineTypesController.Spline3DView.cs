using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult Spline3DView() {
            Chart3DDemoOptions options = new Chart3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.Spline3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("Spline3DView", SourceOfEnergy.GetCoalProduction());
        }
        [HttpPost]
        public ActionResult Spline3DView([Bind] Chart3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.Spline3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("Spline3DView", SourceOfEnergy.GetCoalProduction());
        }
    }
}
