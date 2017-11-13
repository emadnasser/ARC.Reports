using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdvancedViewTypesController : DemoController {
        [HttpGet]
        public ActionResult StockView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartFinacialDemoOptions() { View = DevExpress.XtraCharts.ViewType.Stock };
            return DemoView("StockView", GoogleStockPricesProvider.GetGoogleStockPrices());
        }
        [HttpPost]
        public ActionResult StockView([Bind] ChartFinacialDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.Stock;
            return DemoView("StockView", GoogleStockPricesProvider.GetGoogleStockPrices());
        }
    }
}
