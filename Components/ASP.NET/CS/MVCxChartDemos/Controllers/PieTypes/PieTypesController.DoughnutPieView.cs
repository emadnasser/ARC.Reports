using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PieTypesController : DemoController {
        [HttpGet]
        public ActionResult DoughnutPieView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartPieDoughnutDemoOptions() { View = XtraCharts.ViewType.Doughnut, HoleRadiusPercent = 60, ShowLabels = true};            
            return DemoView("DoughnutPieView", CountriesProvider.GetCountries());
        }
        [HttpPost]
        public ActionResult DoughnutPieView([Bind] ChartPieDoughnutDemoOptions options) {
            options.View = XtraCharts.ViewType.Doughnut;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("DoughnutPieView", CountriesProvider.GetCountries());
        }
    }
}
