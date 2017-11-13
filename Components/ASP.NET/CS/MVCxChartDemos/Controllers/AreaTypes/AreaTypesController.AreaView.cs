using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult AreaView() {
            ChartAreaDemoOptions options = new ChartAreaDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.Area;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("AreaView", DevAV.GetOutsideVendorCosts());
        }
        [HttpPost]
        public ActionResult AreaView([Bind] ChartAreaDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.Area;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("AreaView", DevAV.GetOutsideVendorCosts());
        }
    }
}
