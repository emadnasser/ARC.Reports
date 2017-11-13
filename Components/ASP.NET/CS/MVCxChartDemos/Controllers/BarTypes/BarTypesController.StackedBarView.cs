using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedBarView() {
            ChartBarDemoOptions options = new ChartBarDemoOptions();
            options.ShowLabels = true;
            options.View = DevExpress.XtraCharts.ViewType.StackedBar;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedBarView", AgeStructure.GetDataByMaleAge());
        }
        [HttpPost]
        public ActionResult StackedBarView([Bind]ChartBarDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.StackedBar;
            return DemoView("StackedBarView", AgeStructure.GetDataByMaleAge());
        }
    }
}

