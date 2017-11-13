using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult LineView() {
            ChartMarkerDemoOptions options = new ChartMarkerDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.Line;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("LineView", PopulationProvider.GetPopulationValues());
        }
        [HttpPost]
        public ActionResult LineView([Bind] ChartMarkerDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.Line;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("LineView", PopulationProvider.GetPopulationValues());
        }
    }
}
