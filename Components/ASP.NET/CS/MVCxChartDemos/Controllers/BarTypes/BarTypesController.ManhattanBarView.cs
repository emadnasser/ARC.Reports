using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult ManhattanBarView() {
            ChartBar3DDemoOptions options = new ChartBar3DDemoOptions();
            options.Transparency = 0;
            options.View = DevExpress.XtraCharts.ViewType.ManhattanBar;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("ManhattanBarView", DevAV.GetSales());
        }
        [HttpPost]
        public ActionResult ManhattanBarView([Bind]ChartBar3DDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.ManhattanBar;
            return DemoView("ManhattanBarView", DevAV.GetSales());
        }
    }
}

