using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineView() {
            ChartSplineDemoOptions options = new ChartSplineDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.Spline;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineView", PowerConsumptionProvider.GetData());
        }
        [HttpPost]
        public ActionResult SplineView([Bind] ChartSplineDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.Spline;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineView", PowerConsumptionProvider.GetData());
        }
    }
}
