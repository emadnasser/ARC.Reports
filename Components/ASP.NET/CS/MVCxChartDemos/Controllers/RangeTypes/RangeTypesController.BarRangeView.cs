using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RangeTypesController : DemoController {
        [HttpGet]
        public ActionResult BarRangeView() {
            ChartDemoOptions options = new ChartDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.RangeBar;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("BarRangeView", SourceOfEnergy.GetOilPrices());
        }
        [HttpPost]
        public ActionResult BarRangeView([Bind] ChartDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.RangeBar;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("BarRangeView", SourceOfEnergy.GetOilPrices());
        }
    }
}
