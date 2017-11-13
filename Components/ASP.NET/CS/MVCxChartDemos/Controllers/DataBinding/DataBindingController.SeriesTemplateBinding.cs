using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController: DemoController {
        [HttpGet]
        public ActionResult SeriesTemplateBinding() {
            ViewData[ChartDemoHelper.OptionsKey] = new ChartSeriesTemplateBindingDemoOptions();
            return DemoView("SeriesTemplateBinding", GDPofG7.GetData());
        }
        [HttpPost]
        public ActionResult SeriesTemplateBinding([Bind] ChartSeriesTemplateBindingDemoOptions options) {
            ViewData[ChartDemoHelper.OptionsKey] = options;
            return DemoView("SeriesTemplateBinding", GDPofG7.GetData());
        }
    }
}
