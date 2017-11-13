using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedBar3DView() {
            ChartBarFullStacked3DDemoOptions options = new ChartBarFullStacked3DDemoOptions();
            options.ShowLabels = true;
            options.View = DevExpress.XtraCharts.ViewType.FullStackedBar3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedBar3DView", DevAV.GetSalesMixByRegion());
        }
        [HttpPost]
        public ActionResult FullStackedBar3DView([Bind]ChartBarFullStacked3DDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.FullStackedBar3D;
            return DemoView("FullStackedBar3DView", DevAV.GetSalesMixByRegion());
        }
    }
}

