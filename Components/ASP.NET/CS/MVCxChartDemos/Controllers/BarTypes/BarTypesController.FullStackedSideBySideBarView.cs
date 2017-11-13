using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedSideBySideBarView() {
            ChartSideBySideBarDemoOptions options = new ChartSideBySideBarDemoOptions();
            options.ShowLabels = true;
            options.View = DevExpress.XtraCharts.ViewType.SideBySideFullStackedBar;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("FullStackedSideBySideBarView", AgeStructure.GetDataByAgeAndGender());
        }
        [HttpPost]
        public ActionResult FullStackedSideBySideBarView([Bind]ChartSideBySideBarDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            options.View = DevExpress.XtraCharts.ViewType.SideBySideFullStackedBar;
            return DemoView("FullStackedSideBySideBarView", AgeStructure.GetDataByAgeAndGender());
        }
    }
}
