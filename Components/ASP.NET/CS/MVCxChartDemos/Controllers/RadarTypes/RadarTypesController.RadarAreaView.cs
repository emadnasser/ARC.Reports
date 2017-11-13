using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult RadarAreaView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartRadarDemoOptions() { View = XtraCharts.ViewType.RadarArea };
            return DemoView("RadarAreaView", WeatherInLondon.GetTemperatureHistory());
        }
        [HttpPost]
        public ActionResult RadarAreaView([Bind] ChartRadarDemoOptions options) {
            options.View = XtraCharts.ViewType.RadarArea;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("RadarAreaView", WeatherInLondon.GetTemperatureHistory());
        }
    }
}
