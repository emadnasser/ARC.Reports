using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class WebSpecificFeaturesController: ReportDemoController {
        public ActionResult CustomToolbarReport() {
            var model = ReportDemoHelper.CreateModel("OddEvenStyles", Session, Request);
            model.CurrentViewer = ViewerSelectorState.ClassicViewer;
            return DemoView("CustomToolbarReport", "CustomToolbarViewer", model);
        }

        public ActionResult CustomToolbarViewerPartial(string reportID) {
            return PartialView("CustomToolbarViewerPartial", ReportDemoHelper.CreateModel(reportID, Session, Request));
        }
    }
}
