using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult StepAreaView() {
            ChartStepAreaDemoOptions options = new ChartStepAreaDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.StepArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StepAreaView", FuelOilPriceProvider.GetFuelOilPrices());
        }
        [HttpPost]
        public ActionResult StepAreaView([Bind] ChartStepAreaDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StepArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StepAreaView", FuelOilPriceProvider.GetFuelOilPrices());
        }
    }
}
