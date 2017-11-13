using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult BarView() {
            ChartBarDemoOptions options = new ChartBarDemoOptions();
            options.ShowLabels = true;
            options.View = DevExpress.XtraCharts.ViewType.Bar;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("BarView", DevAV.GetSales());
        }
        [HttpPost]
        public ActionResult BarView([Bind]ChartBarDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.Bar;
            return DemoView("BarView", DevAV.GetSales());
        }
    }
}

