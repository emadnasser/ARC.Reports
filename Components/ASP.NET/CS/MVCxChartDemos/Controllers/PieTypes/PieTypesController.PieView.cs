using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PieTypesController : DemoController {
        [HttpGet]
        public ActionResult PieView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartPieDoughnutDemoOptions() { View = XtraCharts.ViewType.Pie, ShowLabels = true };
            return DemoView("PieView", CountriesProvider.GetCountries());
        }
        [HttpPost]
        public ActionResult PieView([Bind] ChartPieDoughnutDemoOptions options) {
            options.View = XtraCharts.ViewType.Pie;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("PieView", CountriesProvider.GetCountries());
        }
    }
}
