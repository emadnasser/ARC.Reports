using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdvancedViewTypesController : DemoController {
        [HttpGet]
        public ActionResult CandleView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartFinacialDemoOptions() { View = DevExpress.XtraCharts.ViewType.CandleStick };
            return DemoView("CandleView", GoogleStockPricesProvider.GetGoogleStockPrices());
        }
        [HttpPost]
        public ActionResult CandleView([Bind] ChartFinacialDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.CandleStick;
            return DemoView("CandleView", GoogleStockPricesProvider.GetGoogleStockPrices());
        }
    }
}
