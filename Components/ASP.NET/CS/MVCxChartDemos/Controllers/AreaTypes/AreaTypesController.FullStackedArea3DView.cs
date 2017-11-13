using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedArea3DView() {
            ChartAreaFullStcked3DDemoOptions options = new ChartAreaFullStcked3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.FullStackedArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedArea3DView", DevAV.GetBranchesSales());
        }
        [HttpPost]
        public ActionResult FullStackedArea3DView([Bind] ChartAreaFullStcked3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.FullStackedArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedArea3DView", DevAV.GetBranchesSales());
        }
    }
}
