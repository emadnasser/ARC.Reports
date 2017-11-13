using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedSideBySideBarView() {
            ChartSideBySideBarDemoOptions options = new ChartSideBySideBarDemoOptions();
            options.ShowLabels = false;
            options.View = DevExpress.XtraCharts.ViewType.SideBySideStackedBar;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("StackedSideBySideBarView", AgeStructure.GetDataByAgeAndGender());
        }
        [HttpPost]
        public ActionResult StackedSideBySideBarView([Bind]ChartSideBySideBarDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.SideBySideStackedBar;
            return DemoView("StackedSideBySideBarView", AgeStructure.GetDataByAgeAndGender());
        }
    }
}
