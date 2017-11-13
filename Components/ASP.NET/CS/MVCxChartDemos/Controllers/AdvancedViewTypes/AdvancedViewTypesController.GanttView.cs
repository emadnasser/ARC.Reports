using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdvancedViewTypesController : DemoController {
        [HttpGet]
        public ActionResult OverlappedGanttView() {
            ChartDemoOptions options = new ChartDemoOptions();
            options.View = DevExpress.XtraCharts.ViewType.Gantt;
            Session[ChartDemoHelper.OptionsKey] = options;
            Session[ChartDemoHelper.CompletedDateKey] = ProjectsProvider.DefaultCompletedDate;
            return DemoView("OverlappedGanttView", ProjectsProvider.GetProjectTasks(ProjectsProvider.DefaultCompletedDate));
        }
        public ActionResult GanttViewsPartial() {
            string datetime = Request.Params["CompletedDate"];
            DateTime completedDate = datetime != "" ? DateTime.Parse(Request.Params["CompletedDate"], System.Globalization.CultureInfo.InvariantCulture) : ProjectsProvider.DefaultCompletedDate;
            Session[ChartDemoHelper.CompletedDateKey] = completedDate;
            return PartialView("GanttViewsPartial", ProjectsProvider.GetProjectTasks(completedDate));
        }
    }
}

