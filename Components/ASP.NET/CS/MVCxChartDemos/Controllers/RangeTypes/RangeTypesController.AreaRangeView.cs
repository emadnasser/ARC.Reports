using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RangeTypesController : DemoController {
        [HttpGet]
        public ActionResult AreaRangeView() {
            ChartRangeDemoOptions options = new ChartRangeDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.RangeArea;
            options.ShowMarkers = false;
            options.ShowMarkers2 = false;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("AreaRangeView", SourceOfEnergy.GetEuropeBrentPrices());
        }
        [HttpPost]
        public ActionResult AreaRangeView([Bind] ChartRangeDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.RangeArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("AreaRangeView", SourceOfEnergy.GetEuropeBrentPrices());
        }
    }
}
