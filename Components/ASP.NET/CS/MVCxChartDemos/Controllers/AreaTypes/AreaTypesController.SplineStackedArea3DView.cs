using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineStackedArea3DView() {
            ChartArea3DDemoOptions options = new ChartArea3DDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.StackedSplineArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineStackedArea3DView", DevAV.GetSalesByLast10Years());
        }
        [HttpPost]
        public ActionResult SplineStackedArea3DView([Bind] ChartArea3DDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.StackedSplineArea3D;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineStackedArea3DView", DevAV.GetSalesByLast10Years());
        }
    }
}
