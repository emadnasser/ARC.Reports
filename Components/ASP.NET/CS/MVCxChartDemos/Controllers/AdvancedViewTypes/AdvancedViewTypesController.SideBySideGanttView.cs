using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdvancedViewTypesController : DemoController {
        public ActionResult GanttViewsSideBySidePartial() {
            return PartialView("GanttViewsSideBySidePartial", Session[ChartDemoHelper.ModelKey]);
        }
        public ActionResult CustomActionGanttViewsSideBySidePartial() {
            ViewBag.SeriesName = Request.Params["SeriesName"];
            ViewBag.Argument = Request.Params["Argument"];
            ViewBag.ValueIndex = Convert.ToInt32(Request.Params["ValueIndex"]);
            ViewBag.Date = Convert.ToDateTime(Request.Params["Date"], System.Globalization.CultureInfo.InvariantCulture);
            return PartialView("GanttViewsSideBySidePartial", Session[ChartDemoHelper.ModelKey]);
        }
        [HttpGet]
        public ActionResult SideBySideGanttView() {
            ChartDemoOptions options = new ChartDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.SideBySideGantt;
            Object model = ProjectsProvider.GetProjectsTasks();
            Session[ChartDemoHelper.ModelKey] = model;
            Session[ChartDemoHelper.OptionsKey] = options;
            Session[ChartDemoHelper.CompletedDateKey] = ProjectsProvider.DefaultCompletedDate;
            return DemoView("SideBySideGanttView", model);
        }
    }
}

