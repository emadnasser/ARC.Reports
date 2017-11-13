using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineFullStackedArea3DView() {
            ChartAreaFullStcked3DDemoOptions options = new ChartAreaFullStcked3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.FullStackedSplineArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineFullStackedArea3DView", DevAV.GetBranchesSales());
        }
        [HttpPost]
        public ActionResult SplineFullStackedArea3DView([Bind] ChartAreaFullStcked3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.FullStackedSplineArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineFullStackedArea3DView", DevAV.GetBranchesSales());
        }
    }
}
