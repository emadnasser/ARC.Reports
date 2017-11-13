using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineAreaView() {
            ChartAreaDemoOptions options = new ChartAreaDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.SplineArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineAreaView", DevAV.GetOutsideVendorCosts());
        }
        [HttpPost]
        public ActionResult SplineAreaView([Bind] ChartAreaDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.SplineArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SplineAreaView", DevAV.GetOutsideVendorCosts());
        }
    }
}
