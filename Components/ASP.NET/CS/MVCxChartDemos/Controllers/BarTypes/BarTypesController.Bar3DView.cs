using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult Bar3DView() {
            ChartBar3DDemoOptions options = new ChartBar3DDemoOptions();
            options.Transparency = 0;
            options.View = DevExpress.XtraCharts.ViewType.Bar3D;          
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("Bar3DView", DevAV.GetSales());
        }
        [HttpPost]
        public ActionResult Bar3DView([Bind]ChartBar3DDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.Bar3D;
            return DemoView("Bar3DView", DevAV.GetSales());
        }
    }
}

