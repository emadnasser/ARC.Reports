using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FunnelTypesController : DemoController {
        [HttpGet]
        public ActionResult FunnelView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartFunnel2DDemoOptions() { View = DevExpress.XtraCharts.ViewType.Funnel, HeightToWidthRatioAuto = false, ShowLabels = true };
            return DemoView("FunnelView", WebSiteVisitorsProvider.GetWebSiteVisitors());
        }
        [HttpPost]
        public ActionResult FunnelView([Bind] ChartFunnel2DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.Funnel;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FunnelView", WebSiteVisitorsProvider.GetWebSiteVisitors());
        }
    }
}
