using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]           
        public ActionResult FullStackedLine3DView() {
            ChartBarFullStacked3DDemoOptions options = new ChartBarFullStacked3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.FullStackedLine3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedLine3DView", DevAV.GetBranchesSales());
        }
        [HttpPost]
        public ActionResult FullStackedLine3DView([Bind] ChartBarFullStacked3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.FullStackedLine3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedLine3DView", DevAV.GetBranchesSales());
        }
    }
}
