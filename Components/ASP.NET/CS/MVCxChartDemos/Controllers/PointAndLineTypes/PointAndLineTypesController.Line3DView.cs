using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult Line3DView() {
            Chart3DDemoOptions options = new Chart3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.Line3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("Line3DView", SourceOfEnergy.GetCoalProduction());
        }
        [HttpPost]
        public ActionResult Line3DView([Bind] Chart3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.Line3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("Line3DView", SourceOfEnergy.GetCoalProduction());
        }
    }
}
