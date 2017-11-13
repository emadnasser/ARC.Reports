using System.Collections.Generic;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PointAndLineTypesController : DemoController {

        [HttpGet]
        public ActionResult PointView() {
            ChartMarkerDemoOptions options = new ChartMarkerDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.Point;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            IList<RealPointSeries> model = MathematicsFunctions.GetRandomData();
            return DemoView("PointView", model);
        }
        [HttpPost]
        public ActionResult PointView([Bind] ChartMarkerDemoOptions options) {
            options.View = DevExpress.XtraCharts.ViewType.Point;
            ViewData[ChartDemoHelper.OptionsKey] = options;
            IList<RealPointSeries> model = MathematicsFunctions.GetRandomData();
            return DemoView("PointView", model);
        }

    }
}
