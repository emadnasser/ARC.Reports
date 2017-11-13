using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FunnelTypesController : DemoController {
        [HttpGet]
        public ActionResult Funnel3DView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartFunnel3DDemoOptions() { View = DevExpress.XtraCharts.ViewType.Funnel3D, HoleRadius = 90, Distance = 10, ShowLabels = true};
            return DemoView("Funnel3DView", WebSiteVisitorsProvider.GetWebSiteVisitors());
        }
        [HttpPost]
        public ActionResult Funnel3DView([Bind] ChartFunnel3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.Funnel3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("Funnel3DView", WebSiteVisitorsProvider.GetWebSiteVisitors());
        }
    }
}
