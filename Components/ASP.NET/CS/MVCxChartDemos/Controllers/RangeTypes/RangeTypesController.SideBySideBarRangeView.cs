using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RangeTypesController : DemoController {
        [HttpGet]
        public ActionResult SideBySideBarRangeView() {
            ChartRangeDemoOptions options = new ChartRangeDemoOptions(); 
            options.View = DevExpress.XtraCharts.ViewType.SideBySideRangeBar;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SideBySideBarRangeView", SourceOfEnergy.GetOilPrices());
        }
        [HttpPost]
        public ActionResult SideBySideBarRangeView([Bind] ChartRangeDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.SideBySideRangeBar;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SideBySideBarRangeView", SourceOfEnergy.GetOilPrices());
        }
    }
}
