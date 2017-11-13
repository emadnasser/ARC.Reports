using DevExpress.XtraCharts;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult StepLineView() {
            ChartStepLineDemoOptions options = new ChartStepLineDemoOptions();
            options.ShowLabels = true;
            options.MarkerSize = 20;
            options.MarkerKindString = MarkerKind.Square.ToString();
            options.View = DevExpress.XtraCharts.ViewType.StepLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StepLineView", FuelOilPriceProvider.GetFuelOilPrices());
        }
        [HttpPost]
        public ActionResult StepLineView([Bind] ChartStepLineDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StepLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StepLineView", FuelOilPriceProvider.GetFuelOilPrices());
        }
    }
}
