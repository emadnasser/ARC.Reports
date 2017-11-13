using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PieTypesController : DemoController {
        [HttpGet]
        public ActionResult NestedDoughnutPieView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartNestedDoughnutDemoOptions() { View = XtraCharts.ViewType.NestedDoughnut, HoleRadiusPercent = 40 };
            return DemoView("NestedDoughnutPieView", AgeStructure.GetPopulationAgeStructure());
        }
        [HttpPost]
        public ActionResult NestedDoughnutPieView([Bind] ChartNestedDoughnutDemoOptions options) {
            options.View = XtraCharts.ViewType.NestedDoughnut;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("NestedDoughnutPieView", AgeStructure.GetPopulationAgeStructure());
        }
    }
}
