using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineArea3DView() {
            ChartArea3DDemoOptions options = new ChartArea3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.SplineArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineArea3DView", DevAV.GetOutsideVendorCosts());
        }
        [HttpPost]
        public ActionResult SplineArea3DView([Bind] ChartArea3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.SplineArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineArea3DView", DevAV.GetOutsideVendorCosts());
        }
    }
}
