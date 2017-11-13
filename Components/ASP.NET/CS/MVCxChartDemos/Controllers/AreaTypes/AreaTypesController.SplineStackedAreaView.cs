using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineStackedAreaView() {
            ChartAreaDemoOptions options = new ChartAreaDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.StackedSplineArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineStackedAreaView", DevAV.GetSalesByLast10Years());
        }
        [HttpPost]
        public ActionResult SplineStackedAreaView([Bind] ChartAreaDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StackedSplineArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineStackedAreaView", DevAV.GetSalesByLast10Years());
        }
    }
}
