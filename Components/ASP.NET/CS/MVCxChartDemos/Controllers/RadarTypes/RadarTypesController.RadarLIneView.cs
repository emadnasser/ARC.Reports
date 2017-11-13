using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult RadarLineView() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartRadarDemoOptions() { View = XtraCharts.ViewType.RadarLine, ShowMarkers = true };
            return DemoView("RadarLineView", WeatherInLondon.GetTemperatureHistory());
        }
        [HttpPost]
        public ActionResult RadarLineView([Bind] ChartRadarDemoOptions options) {
            options.View = XtraCharts.ViewType.RadarLine;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("RadarLineView", WeatherInLondon.GetTemperatureHistory());
        }
    }
}
