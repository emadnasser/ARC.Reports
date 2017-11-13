using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedAreaView() {
            ChartAreaDemoOptions options = new ChartAreaDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.StackedArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedAreaView", DevAV.GetSalesByLast10Years());
        }
        [HttpPost]
        public ActionResult StackedAreaView([Bind] ChartAreaDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StackedArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedAreaView", DevAV.GetSalesByLast10Years());
        }
    }
}
